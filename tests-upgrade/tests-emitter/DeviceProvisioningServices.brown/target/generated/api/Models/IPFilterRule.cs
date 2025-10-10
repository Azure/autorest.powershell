// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The IP filter rules for a provisioning Service.</summary>
    public partial class IPFilterRule :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRuleInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>The desired action for requests captured by this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="FilterName" /> property.</summary>
        private string _filterName;

        /// <summary>The name of the IP filter rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string FilterName { get => this._filterName; set => this._filterName = value; }

        /// <summary>Backing field for <see cref="IPMask" /> property.</summary>
        private string _iPMask;

        /// <summary>A string that contains the IP address range in CIDR notation for the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string IPMask { get => this._iPMask; set => this._iPMask = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>Target for requests captured by this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="IPFilterRule" /> instance.</summary>
        public IPFilterRule()
        {

        }
    }
    /// The IP filter rules for a provisioning Service.
    public partial interface IIPFilterRule :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>The desired action for requests captured by this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The desired action for requests captured by this rule.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Accept", "Reject")]
        string Action { get; set; }
        /// <summary>The name of the IP filter rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the IP filter rule.",
        SerializedName = @"filterName",
        PossibleTypes = new [] { typeof(string) })]
        string FilterName { get; set; }
        /// <summary>A string that contains the IP address range in CIDR notation for the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string that contains the IP address range in CIDR notation for the rule.",
        SerializedName = @"ipMask",
        PossibleTypes = new [] { typeof(string) })]
        string IPMask { get; set; }
        /// <summary>Target for requests captured by this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target for requests captured by this rule.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("all", "serviceApi", "deviceApi")]
        string Target { get; set; }

    }
    /// The IP filter rules for a provisioning Service.
    internal partial interface IIPFilterRuleInternal

    {
        /// <summary>The desired action for requests captured by this rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Accept", "Reject")]
        string Action { get; set; }
        /// <summary>The name of the IP filter rule.</summary>
        string FilterName { get; set; }
        /// <summary>A string that contains the IP address range in CIDR notation for the rule.</summary>
        string IPMask { get; set; }
        /// <summary>Target for requests captured by this rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("all", "serviceApi", "deviceApi")]
        string Target { get; set; }

    }
}