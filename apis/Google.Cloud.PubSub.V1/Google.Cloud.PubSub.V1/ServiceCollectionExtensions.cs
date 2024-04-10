// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.PubSub.V1;
using System;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods to configure dependency injection with PubSub.
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds a singleton <see cref="PublisherClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="action">
    /// An action delegate to invoke on the <see cref="PublisherClientBuilder"/> for configuring the <see cref="PublisherClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="PublisherClientBuilder.TopicName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddPublisherClient(this IServiceCollection services, Action<PublisherClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddPublisherClient((_, builder) => action(builder));
    }

    /// <summary>
    /// Adds a singleton <see cref="PublisherClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="action">
    /// An action delegate to invoke on the <see cref="PublisherClientBuilder"/> for configuring the <see cref="PublisherClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="PublisherClientBuilder.TopicName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddPublisherClient(this IServiceCollection services, Action<IServiceProvider, PublisherClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddSingleton(provider =>
        {
            var builder = new PublisherClientBuilder();
            action.Invoke(provider, builder);
            return builder.Build(provider);
        });
    }

    /// <summary>
    /// Adds a singleton <see cref="PublisherClient"/> associated with the specified <see cref="TopicName"/>, using default settings to the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="topicName">The <see cref="TopicName"/> to publish messages to. Must not be null.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddPublisherClient(this IServiceCollection services, TopicName topicName)
    {
        GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
        return services.AddPublisherClient((_, builder) => builder.TopicName = topicName);
    }

    /// <summary>
    /// Adds a singleton <see cref="SubscriberClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="action">
    /// An action to invoke on the <see cref="SubscriberClientBuilder"/> for configuring the <see cref="SubscriberClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="SubscriberClientBuilder.SubscriptionName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddSubscriberClient(this IServiceCollection services, Action<SubscriberClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddSubscriberClient((_, builder) => action(builder));
    }

    /// <summary>
    /// Adds a singleton <see cref="SubscriberClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="action">
    /// An action to invoke on the <see cref="SubscriberClientBuilder"/> for configuring the <see cref="SubscriberClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="SubscriberClientBuilder.SubscriptionName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddSubscriberClient(this IServiceCollection services, Action<IServiceProvider, SubscriberClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddSingleton(provider =>
        {
            var builder = new SubscriberClientBuilder();
            action.Invoke(provider, builder);
            return builder.Build(provider);
        });
    }

    /// <summary>
    /// Adds a singleton <see cref="SubscriberClient"/> associated with the specified <see cref="SubscriptionName"/>, using default settings to the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from. Must not be null.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddSubscriberClient(this IServiceCollection services, SubscriptionName subscriptionName)
    {
        GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
        return services.AddSubscriberClient((_, builder) => builder.SubscriptionName = subscriptionName);
    }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Adds a singleton <see cref="PublisherClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="serviceKey">The <see cref="ServiceDescriptor.ServiceKey"/> of the service.</param>
    /// <param name="action">
    /// An action delegate to invoke on the <see cref="PublisherClientBuilder"/> for configuring the <see cref="PublisherClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="PublisherClientBuilder.TopicName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddKeyedPublisherClient(this IServiceCollection services, object serviceKey, Action<object, PublisherClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddKeyedPublisherClient(serviceKey, (_, key, builder) => action(key, builder));
    }

    /// <summary>
    /// Adds a singleton <see cref="PublisherClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="serviceKey">The <see cref="ServiceDescriptor.ServiceKey"/> of the service.</param>
    /// <param name="action">
    /// An action delegate to invoke on the <see cref="PublisherClientBuilder"/> for configuring the <see cref="PublisherClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="PublisherClientBuilder.TopicName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddKeyedPublisherClient(this IServiceCollection services, object serviceKey, Action<IServiceProvider, object, PublisherClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddKeyedSingleton(serviceKey, (provider, key) =>
        {
            var builder = new PublisherClientBuilder();
            action.Invoke(provider, key, builder);
            return builder.Build(provider);
        });
    }

    /// <summary>
    /// Adds a singleton <see cref="PublisherClient"/> associated with the specified <see cref="TopicName"/>, using default settings to the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="serviceKey">The <see cref="ServiceDescriptor.ServiceKey"/> of the service.</param>
    /// <param name="topicName">The <see cref="TopicName"/> to publish messages to. Must not be null.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddKeyedPublisherClient(this IServiceCollection services, object serviceKey, TopicName topicName)
    {
        GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
        return services.AddKeyedPublisherClient(serviceKey, (_, _, builder) => builder.TopicName = topicName);
    }

    /// <summary>
    /// Adds a singleton <see cref="SubscriberClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="serviceKey">The <see cref="ServiceDescriptor.ServiceKey"/> of the service.</param>
    /// <param name="action">
    /// An action to invoke on the <see cref="SubscriberClientBuilder"/> for configuring the <see cref="SubscriberClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="SubscriberClientBuilder.SubscriptionName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddKeyedSubscriberClient(this IServiceCollection services, object serviceKey, Action<object, SubscriberClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddKeyedSubscriberClient(serviceKey, (_, key, builder) => action(key, builder));
    }

    /// <summary>
    /// Adds a singleton <see cref="SubscriberClient"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="serviceKey">The <see cref="ServiceDescriptor.ServiceKey"/> of the service.</param>
    /// <param name="action">
    /// An action to invoke on the <see cref="SubscriberClientBuilder"/> for configuring the <see cref="SubscriberClient"/>. This is invoked before <paramref name="services"/> are used.
    /// Must not be null and at-least <see cref="SubscriberClientBuilder.SubscriptionName"/> must be set.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddKeyedSubscriberClient(this IServiceCollection services, object serviceKey, Action<IServiceProvider, object, SubscriberClientBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddKeyedSingleton(serviceKey, (provider, key) =>
        {
            var builder = new SubscriberClientBuilder();
            action.Invoke(provider, key, builder);
            return builder.Build(provider);
        });
    }

    /// <summary>
    /// Adds a singleton <see cref="SubscriberClient"/> associated with the specified <see cref="SubscriptionName"/>, using default settings to the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to add the singleton client to.
    /// </param>
    /// <param name="serviceKey">The <see cref="ServiceDescriptor.ServiceKey"/> of the service.</param>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from. Must not be null.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddKeyedSubscriberClient(this IServiceCollection services, object serviceKey, SubscriptionName subscriptionName)
    {
        GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
        return services.AddKeyedSubscriberClient(serviceKey, (_, _, builder) => builder.SubscriptionName = subscriptionName);
    }
#endif
}
