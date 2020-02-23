﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.WebJobs.Extensions.RabbitMQ
{
    internal class DefaultRabbitMQServiceFactory : IRabbitMQServiceFactory
    {
        public IRabbitMQService CreateService(string connectionString, QueueConfiguration config)
        {
            return new RabbitMQService(connectionString, config);
        }

        public IRabbitMQService CreateService(string connectionString)
        {
            return new RabbitMQService(connectionString);
        }
    }
}