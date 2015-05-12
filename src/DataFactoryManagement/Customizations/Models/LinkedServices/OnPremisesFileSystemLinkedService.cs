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

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// An on-premises file system Linked Service.
    /// </summary>
    public class OnPremisesFileSystemLinkedService : LinkedServiceTypeProperties
    {
        /// <summary>
        /// Optional. Encrypted credential which contains host, userId and
        /// password.
        /// </summary>
        public string EncryptedCredential { get; set; }

        /// <summary>
        /// Required. The on-premises gateway name.
        /// </summary>
        [AdfRequired]
        public string GatewayName { get; set; }

        /// <summary>
        /// Required. Host name of the server.
        /// </summary>
        [AdfRequired]
        public string Host { get; set; }

        /// <summary>
        /// Optional. Password to logon the server.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Optional. UserID to logon the server.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Initializes a new instance of the OnPremisesFileSystemLinkedService
        /// class.
        /// </summary>
        public OnPremisesFileSystemLinkedService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OnPremisesFileSystemLinkedService
        /// class with required arguments.
        /// </summary>
        public OnPremisesFileSystemLinkedService(string host, string gatewayName)
            : this()
        {
            Ensure.IsNotNull(host, "host");
            Ensure.IsNotNull(gatewayName, "gatewayName");

            this.Host = host;
            this.GatewayName = gatewayName;
        }
    }
}
