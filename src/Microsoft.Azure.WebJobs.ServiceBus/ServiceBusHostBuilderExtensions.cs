﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.Hosting
{
    public static class ServiceBusHostBuilderExtensions
    {
        public static IHostBuilder AddServiceBus(this IHostBuilder builder)
        {
            return builder.AddExtension<ServiceBusExtensionConfig>()
                .ConfigureServices(services =>
                {
                    services.AddOptions<ServiceBusOptions>()
                            .Configure<IConnectionStringProvider>((o, p) =>
                            {
                                o.ConnectionString = p.GetConnectionString(ConnectionStringNames.ServiceBus);
                            });

                    services.TryAddSingleton<MessagingProvider>();
                });
        }
    }
}
