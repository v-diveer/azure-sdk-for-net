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

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class RegionalQuotaCapability
    {
        private long _coresAvailable;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public long CoresAvailable
        {
            get { return this._coresAvailable; }
            set { this._coresAvailable = value; }
        }
        
        private long _coresUsed;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public long CoresUsed
        {
            get { return this._coresUsed; }
            set { this._coresUsed = value; }
        }
        
        private string _regionName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RegionalQuotaCapability class.
        /// </summary>
        public RegionalQuotaCapability()
        {
        }
    }
}
