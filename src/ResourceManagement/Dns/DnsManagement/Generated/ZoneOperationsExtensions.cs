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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Dns;
using Microsoft.Azure.Management.Dns.Models;

namespace Microsoft.Azure.Management.Dns
{
    /// <summary>
    /// Client for managing DNS zones and record.
    /// </summary>
    public static partial class ZoneOperationsExtensions
    {
        /// <summary>
        /// Creates a DNS zone within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// Required. The name of the zone without a terminating dot.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <returns>
        /// The response to a Zone CreateOrUpdate operation.
        /// </returns>
        public static ZoneCreateOrUpdateResponse CreateOrUpdate(this IZoneOperations operations, string resourceGroupName, string zoneName, ZoneCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IZoneOperations)s).CreateOrUpdateAsync(resourceGroupName, zoneName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a DNS zone within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// Required. The name of the zone without a terminating dot.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <returns>
        /// The response to a Zone CreateOrUpdate operation.
        /// </returns>
        public static Task<ZoneCreateOrUpdateResponse> CreateOrUpdateAsync(this IZoneOperations operations, string resourceGroupName, string zoneName, ZoneCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, zoneName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Removes a DNS zone from a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// Required. The name of the zone without a terminating dot.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to delete a zone
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IZoneOperations operations, string resourceGroupName, string zoneName, ZoneDeleteParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IZoneOperations)s).DeleteAsync(resourceGroupName, zoneName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Removes a DNS zone from a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// Required. The name of the zone without a terminating dot.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to delete a zone
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IZoneOperations operations, string resourceGroupName, string zoneName, ZoneDeleteParameters parameters)
        {
            return operations.DeleteAsync(resourceGroupName, zoneName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a DNS zone.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// Required. The name of the zone without a terminating dot.
        /// </param>
        /// <returns>
        /// The response to a Zone Get operation.
        /// </returns>
        public static ZoneGetResponse Get(this IZoneOperations operations, string resourceGroupName, string zoneName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IZoneOperations)s).GetAsync(resourceGroupName, zoneName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a DNS zone.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// Required. The name of the zone without a terminating dot.
        /// </param>
        /// <returns>
        /// The response to a Zone Get operation.
        /// </returns>
        public static Task<ZoneGetResponse> GetAsync(this IZoneOperations operations, string resourceGroupName, string zoneName)
        {
            return operations.GetAsync(resourceGroupName, zoneName, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the DNS zones within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns the default
        /// number of zones.
        /// </param>
        /// <returns>
        /// The response to a Zone List or ListAll operation.
        /// </returns>
        public static ZoneListResponse List(this IZoneOperations operations, string resourceGroupName, ZoneListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IZoneOperations)s).ListAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the DNS zones within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns the default
        /// number of zones.
        /// </param>
        /// <returns>
        /// The response to a Zone List or ListAll operation.
        /// </returns>
        public static Task<ZoneListResponse> ListAsync(this IZoneOperations operations, string resourceGroupName, ZoneListParameters parameters)
        {
            return operations.ListAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the DNS zones within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// The response to a Zone List or ListAll operation.
        /// </returns>
        public static ZoneListResponse ListNext(this IZoneOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IZoneOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the DNS zones within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Dns.IZoneOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// The response to a Zone List or ListAll operation.
        /// </returns>
        public static Task<ZoneListResponse> ListNextAsync(this IZoneOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
