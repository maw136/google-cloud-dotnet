#!/bin/bash
# Copyright 2021 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# Run this script from the root directory of the repository, like this:
#    $ ./owlbot-post-processor/main.sh

# This script does two things:
# 1. Based on the presence or absence of pregeneration.sh or
#    midmicrogeneration.sh in the API directory:
#    - Regenerate using generateapis.sh if either file is present.
#    - Copy files from the /owl-bot-staging directory otherwise.
# 2. Invokes ../generate-projects.sh to generate .csproj files.

set -ex

TMP=$(mktemp -d)

# Copies one api from the /owl-bot-staging directory into the the /apis dir.
copy_one_api() {
  PACKAGE=$1
  STAGING_DIR=owl-bot-staging/$1
  PACKAGE_DIR=apis/$1

  # Determine the commit for googleapis to use based on the Source-Link in
  # the comment from the last commit in the local directory.
  GOOGLEAPIS_COMMIT=$(git show --format=%B -s \
     | grep "^Source-Link: https://github.com/googleapis/googleapis/commit/" \
     | sed 's/.*\/commit\///g')
    
  # We don't expect googleapis-gen to contain the right (or potentially
  # even valid) code for APIs which have pre/mid-generation tweak scripts,
  # or custom resource configurations - or a few other corner cases.
  # Some APIs may not even be fully generated in googleapis-gen.
  # We can still use OwlBot to notice that something has changed,
  # and simply running our local generation script against the right commit
  # for googleapis/googleapis. The project generator determines whether any
  # given API requires regeneration here, and creates a marker .OwlBot-ForceRegeneration.txt
  # file if so.
  if [[ -f $PACKAGE_DIR/.OwlBot-ForceRegeneration.txt ]]
  then
    if [[ $GOOGLEAPIS_COMMIT == "" ]]
    then
      echo "No googleapis commit to generate $PACKAGE from"
      exit 1
    fi
    
    # Clone googleapis into the staging directory, as a suitable temporary directory
    git clone https://github.com/googleapis/googleapis $STAGING_DIR/googleapis
    
    # Check out the commit
    git -C $STAGING_DIR/googleapis checkout $GOOGLEAPIS_COMMIT
    
    # The generation script uses the GOOGLEAPIS_DIR environment variable:
    # if the variable is present, it's expected to be googleapis/googleapis at
    # the appropriate commit (which is exactly what we've got)
    GOOGLEAPIS_DIR=$PWD/$STAGING_DIR/googleapis ./generateapis.sh $PACKAGE
    
    # If that worked, we can remove the staging directory for this API completely;
    # we're done (but there may be other APIs).
    rm -rf $STAGING_DIR
    return
  fi

  # We generate our own project files
  rm -f $(find "$STAGING_DIR" -name '*.csproj')

  # Files generated by microgenerator are mysteriously marked as executable.
  # They shouldn't be.
  chmod a-x $(find "$STAGING_DIR" -name '*.cs')

  # Wipe out all the existing source files we're about to replace.
  # This will clear out source files that are no longer generated.
  rm -f $(find "$PACKAGE_DIR" -name '*.g.cs')

  # Copy the files out of the staging directory into the package directory.
  mkdir -p "$PACKAGE_DIR"
  cp -rf $STAGING_DIR/* "$PACKAGE_DIR"

  # Copy the GAPIC metadata file if there is one
  if [[ -f $STAGING_DIR/gapic_metadata.json ]]
  then
    cp $STAGING_DIR/gapic_metadata.json $PACKAGE_DIR
  fi

  # Clean out the staging directory.
  rm -rf "$STAGING_DIR"

  # The following code was copied from generate_api().
  if [[ -f $PACKAGE_DIR/postgeneration.sh ]]
  then    
    echo "Running post-generation script for $PACKAGE"
    (cd $PACKAGE_DIR; ./postgeneration.sh)
  fi

  if [[ $(grep -E "^namespace" apis/$1/$1/*.cs | grep -v "namespace Microsoft.Extensions.DependencyInjection" | grep -Ev "namespace ${1}[[:space:]{]*;?\$") ]]
  then
    # We know Google.LongRunning contains a proto in Google.Cloud.
    if [[ $1 == "Google.LongRunning" ]]; then
      echo "Ignoring broken namespaces in $1"
    else
      echo "API $1 has broken namespace declarations"
      exit 1
    fi
  fi

  # Check for any updated mixins in the API.
  # We use the HEAD API index rather than $GOOGLEAPIS_COMMIT
  # as the latter is the commit at which the *API* changed,
  # and the API *index* changes shortly afterwards.
  ./prepare-release.sh update-mixins $PACKAGE HEAD
}

# List the SDKs available, for diagnostic purposes
echo ".NET SDKs:"
dotnet --list-sdks

# Avoid .NET complaining about submodules being missing
git config --global --add safe.directory /repo
git submodule update --init --recursive

# Iterate over all the apis in the /owl-bot-staging directory, and copy
# the files into the /apis directory.
if [[ -d owl-bot-staging ]]
then
  for package in $(ls -1 owl-bot-staging)
  do
    copy_one_api "$package"
  done
  rm -rf owl-bot-staging
fi

# Update dependencies if we're releasing anything.
# (This is for release-please integration.)
dotnet run --project tools/Google.Cloud.Tools.ReleaseManager -- update-dependencies --owlbot

# Generate .csproj files in all the /apis directories.
./generateprojects.sh
