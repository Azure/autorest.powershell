// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The type used for update operations of the DeviceGroup.</summary>
    public partial class DeviceGroupUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateInternal
    {

        /// <summary>Flag to define if the user allows for crash dump collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string AllowCrashDumpsCollection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).AllowCrashDumpsCollection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).AllowCrashDumpsCollection = value ?? null; }

        /// <summary>Description of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceGroupUpdateProperties()); set { {_property = value;} } }

        /// <summary>Operating system feed type of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string OSFeedType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).OSFeedType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).OSFeedType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties _property;

        /// <summary>The updatable properties of the DeviceGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceGroupUpdateProperties()); set => this._property = value; }

        /// <summary>Regional data boundary for the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string RegionalDataBoundary { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).RegionalDataBoundary; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).RegionalDataBoundary = value ?? null; }

        /// <summary>Update policy of the device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string UpdatePolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).UpdatePolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdatePropertiesInternal)Property).UpdatePolicy = value ?? null; }

        /// <summary>Creates an new <see cref="DeviceGroupUpdate" /> instance.</summary>
        public DeviceGroupUpdate()
        {

        }
    }
    /// The type used for update operations of the DeviceGroup.
    public partial interface IDeviceGroupUpdate :
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
    /// The type used for update operations of the DeviceGroup.
    internal partial interface IDeviceGroupUpdateInternal

    {
        /// <summary>Flag to define if the user allows for crash dump collection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AllowCrashDumpsCollection { get; set; }
        /// <summary>Description of the device group.</summary>
        string Description { get; set; }
        /// <summary>Operating system feed type of the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Retail", "RetailEval")]
        string OSFeedType { get; set; }
        /// <summary>The updatable properties of the DeviceGroup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties Property { get; set; }
        /// <summary>Regional data boundary for the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }
        /// <summary>Update policy of the device group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("UpdateAll", "No3rdPartyAppUpdates")]
        string UpdatePolicy { get; set; }

    }
}