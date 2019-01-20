// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// The deployment debug setting.
    /// </summary>
    public partial class DeploymentDebugSetting
    {
        private string _deploymentDebugDetailLevel;
        
        /// <summary>
        /// Required. Deployment debug detail level. Any combination of None,
        /// RequestContent and ResponseContent
        /// </summary>
        public string DeploymentDebugDetailLevel
        {
            get { return this._deploymentDebugDetailLevel; }
            set { this._deploymentDebugDetailLevel = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentDebugSetting class.
        /// </summary>
        public DeploymentDebugSetting()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentDebugSetting class with
        /// required arguments.
        /// </summary>
        public DeploymentDebugSetting(string deploymentDebugDetailLevel)
            : this()
        {
            if (deploymentDebugDetailLevel == null)
            {
                throw new ArgumentNullException("deploymentDebugDetailLevel");
            }
            this.DeploymentDebugDetailLevel = deploymentDebugDetailLevel;
        }
    }
}