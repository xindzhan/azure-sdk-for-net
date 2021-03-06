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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// The instance view of a virtual machine extension.
    /// </summary>
    public partial class VirtualMachineExtensionInstanceView : ResourceInstanceView
    {
        private string _extensionType;
        
        /// <summary>
        /// Optional. Gets or sets the full type of the extension handler which
        /// includes both publisher and type.
        /// </summary>
        public string ExtensionType
        {
            get { return this._extensionType; }
            set { this._extensionType = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the virtual machine extension name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<InstanceViewStatus> _subStatuses;
        
        /// <summary>
        /// Optional. Gets or sets the resource status information.
        /// </summary>
        public IList<InstanceViewStatus> SubStatuses
        {
            get { return this._subStatuses; }
            set { this._subStatuses = value; }
        }
        
        private string _typeHandlerVersion;
        
        /// <summary>
        /// Optional. Gets or sets the type version of the extension handler.
        /// </summary>
        public string TypeHandlerVersion
        {
            get { return this._typeHandlerVersion; }
            set { this._typeHandlerVersion = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionInstanceView class.
        /// </summary>
        public VirtualMachineExtensionInstanceView()
        {
            this.SubStatuses = new LazyList<InstanceViewStatus>();
        }
    }
}
