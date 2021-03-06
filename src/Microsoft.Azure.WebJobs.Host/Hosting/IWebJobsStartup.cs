﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;

namespace Microsoft.Azure.WebJobs.Hosting
{
    public interface IWebJobsStartup
    {
        void Configure(IHostBuilder builder);
    }
}
