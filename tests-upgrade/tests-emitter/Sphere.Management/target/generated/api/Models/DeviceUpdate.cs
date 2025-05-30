// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The type used for update operations of the Device.</summary>
    public partial class DeviceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateInternal
    {

        /// <summary>Device group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string DeviceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdatePropertiesInternal)Property).DeviceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdatePropertiesInternal)Property).DeviceGroupId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateProperties _property;

        /// <summary>The updatable properties of the Device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceUpdateProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="DeviceUpdate" /> instance.</summary>
        public DeviceUpdate()
        {

        }
    }
    /// The type used for update operations of the Device.
    public partial interface IDeviceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Device group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device group id",
        SerializedName = @"deviceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceGroupId { get; set; }

    }
    /// The type used for update operations of the Device.
    internal partial interface IDeviceUpdateInternal

    {
        /// <summary>Device group id</summary>
        string DeviceGroupId { get; set; }
        /// <summary>The updatable properties of the Device.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateProperties Property { get; set; }

    }
}