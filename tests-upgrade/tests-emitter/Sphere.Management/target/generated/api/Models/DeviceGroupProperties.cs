// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of deviceGroup</summary>
    public partial class DeviceGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowCrashDumpsCollection" /> property.</summary>
        private string _allowCrashDumpsCollection;

        /// <summary>Flag to define if the user allows for crash dump collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string AllowCrashDumpsCollection { get => this._allowCrashDumpsCollection; set => this._allowCrashDumpsCollection = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="HasDeployment" /> property.</summary>
        private bool? _hasDeployment;

        /// <summary>Deployment status for the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public bool? HasDeployment { get => this._hasDeployment; }

        /// <summary>Internal Acessors for HasDeployment</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupPropertiesInternal.HasDeployment { get => this._hasDeployment; set { {_hasDeployment = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="OSFeedType" /> property.</summary>
        private string _oSFeedType;

        /// <summary>Operating system feed type of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string OSFeedType { get => this._oSFeedType; set => this._oSFeedType = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RegionalDataBoundary" /> property.</summary>
        private string _regionalDataBoundary;

        /// <summary>Regional data boundary for the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string RegionalDataBoundary { get => this._regionalDataBoundary; set => this._regionalDataBoundary = value; }

        /// <summary>Backing field for <see cref="UpdatePolicy" /> property.</summary>
        private string _updatePolicy;

        /// <summary>Update policy of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string UpdatePolicy { get => this._updatePolicy; set => this._updatePolicy = value; }

        /// <summary>Creates an new <see cref="DeviceGroupProperties" /> instance.</summary>
        public DeviceGroupProperties()
        {

        }
    }
    /// The properties of deviceGroup
    public partial interface IDeviceGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Flag to define if the user allows for crash dump collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to define if the user allows for crash dump collection.",
        SerializedName = @"allowCrashDumpsCollection",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AllowCrashDumpsCollection { get; set; }
        /// <summary>Description of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the device group.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Deployment status for the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Deployment status for the device group.",
        SerializedName = @"hasDeployment",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HasDeployment { get;  }
        /// <summary>Operating system feed type of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operating system feed type of the device group.",
        SerializedName = @"osFeedType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Retail", "RetailEval")]
        string OSFeedType { get; set; }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Regional data boundary for the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Regional data boundary for the device group.",
        SerializedName = @"regionalDataBoundary",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }
        /// <summary>Update policy of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Update policy of the device group.",
        SerializedName = @"updatePolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("UpdateAll", "No3rdPartyAppUpdates")]
        string UpdatePolicy { get; set; }

    }
    /// The properties of deviceGroup
    internal partial interface IDeviceGroupPropertiesInternal

    {
        /// <summary>Flag to define if the user allows for crash dump collection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AllowCrashDumpsCollection { get; set; }
        /// <summary>Description of the device group.</summary>
        string Description { get; set; }
        /// <summary>Deployment status for the device group.</summary>
        bool? HasDeployment { get; set; }
        /// <summary>Operating system feed type of the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Retail", "RetailEval")]
        string OSFeedType { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Regional data boundary for the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }
        /// <summary>Update policy of the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("UpdateAll", "No3rdPartyAppUpdates")]
        string UpdatePolicy { get; set; }

    }
}