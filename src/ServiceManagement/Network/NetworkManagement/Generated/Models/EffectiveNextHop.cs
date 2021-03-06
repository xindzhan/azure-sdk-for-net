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

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The next hop of this route.
    /// </summary>
    public partial class EffectiveNextHop
    {
        private IList<string> _ipAddresses;
        
        /// <summary>
        /// Required. Gets or sets the effective next hop IP addresses.
        /// </summary>
        public IList<string> IpAddresses
        {
            get { return this._ipAddresses; }
            set { this._ipAddresses = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. Gets or sets the type of the effective next hop.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EffectiveNextHop class.
        /// </summary>
        public EffectiveNextHop()
        {
            this.IpAddresses = new LazyList<string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the EffectiveNextHop class with
        /// required arguments.
        /// </summary>
        public EffectiveNextHop(string type, IList<string> ipAddresses)
            : this()
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (ipAddresses == null)
            {
                throw new ArgumentNullException("ipAddresses");
            }
            this.Type = type;
            this.IpAddresses = ipAddresses;
        }
    }
}
