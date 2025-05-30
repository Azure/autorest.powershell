// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The updatable properties of the DeviceGroup.</summary>
    public partial class DeviceGroupUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal
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

        /// <summary>Backing field for <see cref="OSFeedType" /> property.</summary>
        private string _oSFeedType;

        /// <summary>Operating system feed type of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string OSFeedType { get => this._oSFeedType; set => this._oSFeedType = value; }

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

        /// <summary>Creates an new <see cref="DeviceGroupUpdateProperties" /> instance.</summary>
        public DeviceGroupUpdateProperties()
        {

        }
    }
    /// The updatable properties of the DeviceGroup.
    public partial interface IDeviceGroupUpdateProperties :
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
    /// The updatable properties of the DeviceGroup.
    internal partial interface IDeviceGroupUpdatePropertiesInternal

    {
        /// <summary>Flag to define if the user allows for crash dump collection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AllowCrashDumpsCollection { get; set; }
        /// <summary>Description of the device group.</summary>
        string Description { get; set; }
        /// <summary>Operating system feed type of the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Retail", "RetailEval")]
        string OSFeedType { get; set; }
        /// <summary>Regional data boundary for the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }
        /// <summary>Update policy of the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("UpdateAll", "No3rdPartyAppUpdates")]
        string UpdatePolicy { get; set; }

    }
}