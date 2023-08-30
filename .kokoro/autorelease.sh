#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR

# Make sure secrets are loaded in a well known localtion before running releasetool
source ./populatesecrets.sh
populate_all_secrets

source ../tools/Google.Cloud.Tools.ReleaseProgressReporter/publish_reporter.sh

# Secrets are already populated, let's not do that again
./release.sh --skippopulatesecrets
