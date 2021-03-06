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
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects
    /// </summary>
    public static partial class StorSimpleManagementClientExtensions
    {
        /// <summary>
        /// The Get Task Status returns the status of the specified task id.
        /// After calling an asynchronous task, you can call Get Task Status
        /// to determine whether the task has succeeded, failed, or is still
        /// in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IStorSimpleManagementClient.
        /// </param>
        /// <param name='taskId'>
        /// Required. The task Id for the request you wish to track.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo GetOperationStatus(this IStorSimpleManagementClient operations, string taskId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorSimpleManagementClient)s).GetOperationStatusAsync(taskId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Task Status returns the status of the specified task id.
        /// After calling an asynchronous task, you can call Get Task Status
        /// to determine whether the task has succeeded, failed, or is still
        /// in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IStorSimpleManagementClient.
        /// </param>
        /// <param name='taskId'>
        /// Required. The task Id for the request you wish to track.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> GetOperationStatusAsync(this IStorSimpleManagementClient operations, string taskId)
        {
            return operations.GetOperationStatusAsync(taskId, CancellationToken.None);
        }
    }
}
