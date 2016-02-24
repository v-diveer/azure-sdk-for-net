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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Model class for task specific details based on the task type.
    /// </summary>
    public partial class TaskTypeDetails
    {
        private string _type;
        
        /// <summary>
        /// Required. The task type. Overriden in derived classes.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TaskTypeDetails class.
        /// </summary>
        public TaskTypeDetails()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the TaskTypeDetails class with
        /// required arguments.
        /// </summary>
        public TaskTypeDetails(string type)
            : this()
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.Type = type;
        }
    }
}