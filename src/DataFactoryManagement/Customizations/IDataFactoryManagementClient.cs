﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using Microsoft.Azure.Management.DataFactories.Core;

namespace Microsoft.Azure.Management.DataFactories
{
    public interface IDataFactoryManagementClient : IDisposable
    {
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </summary>
        SubscriptionCloudCredentials Credentials { get; set; }

#if ADF_INTERNAL
        /// <summary>
        /// Operations for managing data factory ActivityTypes.
        /// </summary>
        ActivityTypeOperations ActivityTypes { get; }

        /// <summary>
        /// Operations for managing data factory ComputeTypes.
        /// </summary>
        ComputeTypeOperations ComputeTypes { get; }
#endif

        /// <summary>
        /// Operations for managing data factories.
        /// </summary>
        IDataFactoryOperations DataFactories { get; }

        /// <summary>
        /// Operations for managing data slices.
        /// </summary>
        IDataSliceOperations DataSlices { get; }

        /// <summary>
        /// Operations for managing data slice runs.
        /// </summary>
        IDataSliceRunOperations DataSliceRuns { get; }

        /// <summary>
        /// Operations for managing data factory gateways.
        /// </summary>
        IGatewayOperations Gateways { get; }

        /// <summary>
        /// Operations for managing hubs.
        /// </summary>
        IHubOperations Hubs { get; }

        /// <summary>
        /// Operations for managing data factory linkedServices.
        /// </summary>
        LinkedServiceOperations LinkedServices { get; }

        /// <summary>
        /// Operations for managing pipelines.
        /// </summary>
        PipelineOperations Pipelines { get; }

        /// <summary>
        /// Operations for managing pipeline runs.
        /// </summary>
        IPipelineRunOperations PipelineRuns { get; }

        /// <summary>
        /// Operations for managing tables.
        /// </summary>
        TableOperations Tables { get; }
    }
}