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

namespace Microsoft.Azure.Management.DataFactories.Common.Models
{
    /// <summary>
    /// Data element defines the semantics of each column of a table.
    /// </summary>
    public partial class DataElement
    {
        private string _culture;
        
        /// <summary>
        /// Optional. Culture of the data element.
        /// </summary>
        public string Culture
        {
            get { return this._culture; }
            set { this._culture = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Description of the data element.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _format;
        
        /// <summary>
        /// Optional. Format of the data element.
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the data element.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Type of the data element.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataElement class.
        /// </summary>
        public DataElement()
        {
        }
    }
}
