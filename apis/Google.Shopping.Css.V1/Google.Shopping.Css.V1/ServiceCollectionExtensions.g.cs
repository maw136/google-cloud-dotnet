// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using gscv = Google.Shopping.Css.V1;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gscv::AccountLabelsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountLabelsServiceClient(this IServiceCollection services, sys::Action<gscv::AccountLabelsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gscv::AccountLabelsServiceClientBuilder builder = new gscv::AccountLabelsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gscv::AccountsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountsServiceClient(this IServiceCollection services, sys::Action<gscv::AccountsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gscv::AccountsServiceClientBuilder builder = new gscv::AccountsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gscv::CssProductInputsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCssProductInputsServiceClient(this IServiceCollection services, sys::Action<gscv::CssProductInputsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gscv::CssProductInputsServiceClientBuilder builder = new gscv::CssProductInputsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gscv::CssProductsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCssProductsServiceClient(this IServiceCollection services, sys::Action<gscv::CssProductsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gscv::CssProductsServiceClientBuilder builder = new gscv::CssProductsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
