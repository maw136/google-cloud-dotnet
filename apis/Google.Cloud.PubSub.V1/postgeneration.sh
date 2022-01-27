#!/bin/bash

set -e

# Undo the changes in googleapis
git -C $GOOGLEAPIS checkout google/pubsub/v1/pubsub.proto
git -C $GOOGLEAPIS checkout google/pubsub/v1/pubsub_grpc_service_config.json
git -C $GOOGLEAPIS checkout google/pubsub/v1/pubsub_v1.yaml

# Fix up the generated client to use the right gRPC types
sed -i s/PublisherServiceApi.PublisherServiceApiClient/Publisher.PublisherClient/g Google.Cloud.PubSub.V1/PublisherServiceApiClient.g.cs
sed -i s/SubscriberServiceApi.SubscriberServiceApiClient/Subscriber.SubscriberClient/g Google.Cloud.PubSub.V1/SubscriberServiceApiClient.g.cs

# Fix up unit test classes
sed -i s/PublisherServiceApi.PublisherServiceApiClient/Publisher.PublisherClient/g Google.Cloud.PubSub.V1.Tests/PublisherServiceApiClientTest.g.cs
sed -i s/SubscriberServiceApi.SubscriberServiceApiClient/Subscriber.SubscriberClient/g Google.Cloud.PubSub.V1.Tests/SubscriberServiceApiClientTest.g.cs

# Fix up the metadata
sed -i 's/"PublisherServiceApi": {/"Publisher": {/g' gapic_metadata.json
sed -i 's/"SubscriberServiceApi": {/"Subscriber": {/g' gapic_metadata.json
