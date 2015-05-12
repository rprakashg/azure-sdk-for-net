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

using System.Collections.Generic;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Pig activity which runs on HDInsight.
    /// </summary>
    public class HDInsightPigActivity : HDInsightActivityBase
    {
        /// <summary>
        /// Hive script.
        /// </summary>
        public string Script { get; set; }

        /// <summary>
        /// Path to the script in blob storage.
        /// </summary>
        public string ScriptPath { get; set; }

        /// <summary>
        /// Storage linked service where the script file is located. 
        /// </summary>
        public string ScriptLinkedService { get; set; }


        /// <summary>
        /// User specified property bag used in Pig scripts. There is no restriction on the
        /// keys or values that can be used. User needs to consume and interpret the content accordingly in
        /// their customized Pig script.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties { get; set; }
    }
}
