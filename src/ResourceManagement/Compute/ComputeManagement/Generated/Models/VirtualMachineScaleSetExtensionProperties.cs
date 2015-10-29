// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes the properties of a Virtual Machine Scale Set Extension.
    /// </summary>
    public partial class VirtualMachineScaleSetExtensionProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionProperties class.
        /// </summary>
        public VirtualMachineScaleSetExtensionProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionProperties class.
        /// </summary>
        public VirtualMachineScaleSetExtensionProperties(string publisher = default(string), string type = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string))
        {
            Publisher = publisher;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the type of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets whether the extension handler should be automatically
        /// upgraded across minor versions.
        /// </summary>
        [JsonProperty(PropertyName = "autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets Json formatted public settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets Json formatted protected settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state, which only appears in the
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
