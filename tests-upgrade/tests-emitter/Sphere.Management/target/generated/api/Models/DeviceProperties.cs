// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of device</summary>
    public partial class DeviceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ChipSku" /> property.</summary>
        private string _chipSku;

        /// <summary>SKU of the chip</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ChipSku { get => this._chipSku; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        /// <summary>Device ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="LastAvailableOSVersion" /> property.</summary>
        private string _lastAvailableOSVersion;

        /// <summary>OS version available for installation when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string LastAvailableOSVersion { get => this._lastAvailableOSVersion; }

        /// <summary>Backing field for <see cref="LastInstalledOSVersion" /> property.</summary>
        private string _lastInstalledOSVersion;

        /// <summary>OS version running on device when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string LastInstalledOSVersion { get => this._lastInstalledOSVersion; }

        /// <summary>Backing field for <see cref="LastOSUpdateUtc" /> property.</summary>
        private global::System.DateTime? _lastOSUpdateUtc;

        /// <summary>Time when update requested and new OS version available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? LastOSUpdateUtc { get => this._lastOSUpdateUtc; }

        /// <summary>Backing field for <see cref="LastUpdateRequestUtc" /> property.</summary>
        private global::System.DateTime? _lastUpdateRequestUtc;

        /// <summary>Time when update was last requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdateRequestUtc { get => this._lastUpdateRequestUtc; }

        /// <summary>Internal Acessors for ChipSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal.ChipSku { get => this._chipSku; set { {_chipSku = value;} } }

        /// <summary>Internal Acessors for LastAvailableOSVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal.LastAvailableOSVersion { get => this._lastAvailableOSVersion; set { {_lastAvailableOSVersion = value;} } }

        /// <summary>Internal Acessors for LastInstalledOSVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal.LastInstalledOSVersion { get => this._lastInstalledOSVersion; set { {_lastInstalledOSVersion = value;} } }

        /// <summary>Internal Acessors for LastOSUpdateUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal.LastOSUpdateUtc { get => this._lastOSUpdateUtc; set { {_lastOSUpdateUtc = value;} } }

        /// <summary>Internal Acessors for LastUpdateRequestUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal.LastUpdateRequestUtc { get => this._lastUpdateRequestUtc; set { {_lastUpdateRequestUtc = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="DeviceProperties" /> instance.</summary>
        public DeviceProperties()
        {

        }
    }
    /// The properties of device
    public partial interface IDeviceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>SKU of the chip</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"SKU of the chip",
        SerializedName = @"chipSku",
        PossibleTypes = new [] { typeof(string) })]
        string ChipSku { get;  }
        /// <summary>Device ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Device ID",
        SerializedName = @"deviceId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceId { get; set; }
        /// <summary>OS version available for installation when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"OS version available for installation when update requested",
        SerializedName = @"lastAvailableOsVersion",
        PossibleTypes = new [] { typeof(string) })]
        string LastAvailableOSVersion { get;  }
        /// <summary>OS version running on device when update requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"OS version running on device when update requested",
        SerializedName = @"lastInstalledOsVersion",
        PossibleTypes = new [] { typeof(string) })]
        string LastInstalledOSVersion { get;  }
        /// <summary>Time when update requested and new OS version available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time when update requested and new OS version available",
        SerializedName = @"lastOsUpdateUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastOSUpdateUtc { get;  }
        /// <summary>Time when update was last requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time when update was last requested",
        SerializedName = @"lastUpdateRequestUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdateRequestUtc { get;  }
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

    }
    /// The properties of device
    internal partial interface IDevicePropertiesInternal

    {
        /// <summary>SKU of the chip</summary>
        string ChipSku { get; set; }
        /// <summary>Device ID</summary>
        string DeviceId { get; set; }
        /// <summary>OS version available for installation when update requested</summary>
        string LastAvailableOSVersion { get; set; }
        /// <summary>OS version running on device when update requested</summary>
        string LastInstalledOSVersion { get; set; }
        /// <summary>Time when update requested and new OS version available</summary>
        global::System.DateTime? LastOSUpdateUtc { get; set; }
        /// <summary>Time when update was last requested</summary>
        global::System.DateTime? LastUpdateRequestUtc { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

    }
}