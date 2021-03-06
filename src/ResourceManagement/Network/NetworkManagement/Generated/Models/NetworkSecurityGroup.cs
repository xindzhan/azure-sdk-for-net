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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// NetworkSecurityGroup resource
    /// </summary>
    public partial class NetworkSecurityGroup : TopLevelResource
    {
        private IList<SecurityRule> _defaultSecurityRules;
        
        /// <summary>
        /// Optional. Gets or sets Default security rules of network security
        /// group
        /// </summary>
        public IList<SecurityRule> DefaultSecurityRules
        {
            get { return this._defaultSecurityRules; }
            set { this._defaultSecurityRules = value; }
        }
        
        private IList<ResourceId> _networkInterfaces;
        
        /// <summary>
        /// Optional. Gets collection of references to Network Interfaces
        /// </summary>
        public IList<ResourceId> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private IList<SecurityRule> _securityRules;
        
        /// <summary>
        /// Optional. Gets or sets Security rules of network security group
        /// </summary>
        public IList<SecurityRule> SecurityRules
        {
            get { return this._securityRules; }
            set { this._securityRules = value; }
        }
        
        private IList<ResourceId> _subnets;
        
        /// <summary>
        /// Optional. Gets collection of references to subnets
        /// </summary>
        public IList<ResourceId> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroup class.
        /// </summary>
        public NetworkSecurityGroup()
        {
            this.DefaultSecurityRules = new LazyList<SecurityRule>();
            this.NetworkInterfaces = new LazyList<ResourceId>();
            this.SecurityRules = new LazyList<SecurityRule>();
            this.Subnets = new LazyList<ResourceId>();
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroup class with
        /// required arguments.
        /// </summary>
        public NetworkSecurityGroup(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
