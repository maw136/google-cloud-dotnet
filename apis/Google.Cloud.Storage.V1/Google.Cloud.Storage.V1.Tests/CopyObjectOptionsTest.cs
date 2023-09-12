// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;
using static Google.Apis.Storage.v1.ObjectsResource;

namespace Google.Cloud.Storage.V1.Tests
{
    public class CopyObjectOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new RewriteRequest(null, null, "sourceBucket", "sourceObject", "destBucket", "destObject");
            var options = new CopyObjectOptions();
            options.ModifyRequest(request);
            Assert.Null(request.DestinationKmsKeyName);
            Assert.Null(request.DestinationPredefinedAcl);
            Assert.Null(request.IfGenerationMatch);
            Assert.Null(request.IfGenerationNotMatch);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Null(request.IfSourceGenerationMatch);
            Assert.Null(request.IfSourceGenerationNotMatch);
            Assert.Null(request.IfSourceMetagenerationMatch);
            Assert.Null(request.IfSourceMetagenerationNotMatch);
            Assert.Null(request.Projection);
            Assert.Null(request.SourceGeneration);
            Assert.Null(request.UserProject);
        }

        [Fact]
        public void ModifyRequest_AllOptions_PositiveMatch()
        {
            var request = new RewriteRequest(null, null, "sourceBucket", "sourceObject", "destBucket", "destObject");
            var options = new CopyObjectOptions
            {
                DestinationPredefinedAcl = PredefinedObjectAcl.Private,
                IfGenerationMatch = 1L,
                IfMetagenerationMatch = 2L,
                IfSourceGenerationMatch = 3L,
                IfSourceMetagenerationMatch = 4L,
                KmsKeyName = "key",
                Projection = Projection.Full,
                SourceGeneration = 5L,
                UserProject = "proj"
            };
            options.ModifyRequest(request);
            Assert.Equal("key", request.DestinationKmsKeyName);
            Assert.Equal(RewriteRequest.DestinationPredefinedAclEnum.Private__, request.DestinationPredefinedAcl);
            Assert.Equal(1L, request.IfGenerationMatch);
            Assert.Null(request.IfGenerationNotMatch);
            Assert.Equal(2L, request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Equal(3L, request.IfSourceGenerationMatch);
            Assert.Null(request.IfSourceGenerationNotMatch);
            Assert.Equal(4L, request.IfSourceMetagenerationMatch);
            Assert.Null(request.IfSourceMetagenerationNotMatch);
            Assert.Equal(5L, request.SourceGeneration);
            Assert.Equal("proj", request.UserProject);
        }

        [Fact]
        public void ModifyRequest_AllOptions_NegativeMatch()
        {
            var request = new RewriteRequest(null, null, "sourceBucket", "sourceObject", "destBucket", "destObject");
            var options = new CopyObjectOptions
            {
                DestinationPredefinedAcl = PredefinedObjectAcl.Private,
                IfGenerationNotMatch = 1L,
                IfMetagenerationNotMatch = 2L,
                IfSourceGenerationNotMatch = 3L,
                IfSourceMetagenerationNotMatch = 4L,
                Projection = Projection.Full,
                SourceGeneration = 5L
            };
            options.ModifyRequest(request);
            Assert.Equal(RewriteRequest.DestinationPredefinedAclEnum.Private__, request.DestinationPredefinedAcl);
            Assert.Null(request.IfGenerationMatch);
            Assert.Equal(1L, request.IfGenerationNotMatch);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Equal(2L, request.IfMetagenerationNotMatch);
            Assert.Null(request.IfSourceGenerationMatch);
            Assert.Equal(3L, request.IfSourceGenerationNotMatch);
            Assert.Null(request.IfSourceMetagenerationMatch);
            Assert.Equal(4L, request.IfSourceMetagenerationNotMatch);
            Assert.Equal(5L, request.SourceGeneration);
        }

        [Fact]
        public void ModifyRequest_MatchNotMatchConflicts()
        {
            var request = new RewriteRequest(null, null, "sourceBucket", "sourceObject", "destBucket", "destObject");
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new CopyObjectOptions { IfGenerationMatch = 1L, IfGenerationNotMatch = 2L };
                options.ModifyRequest(request);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new CopyObjectOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
                options.ModifyRequest(request);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new CopyObjectOptions { IfSourceGenerationMatch = 1L, IfSourceGenerationNotMatch = 2L };
                options.ModifyRequest(request);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new CopyObjectOptions { IfSourceMetagenerationMatch = 1L, IfSourceMetagenerationNotMatch = 2L };
                options.ModifyRequest(request);
            });
        }
    }
}
