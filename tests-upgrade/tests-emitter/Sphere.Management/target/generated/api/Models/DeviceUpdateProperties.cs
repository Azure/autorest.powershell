namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The updatable properties of the Device.</summary>
    public partial class DeviceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DeviceGroupId" /> property.</summary>
        private string _deviceGroupId;

        /// <summary>Device group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceGroupId { get => this._deviceGroupId; set => this._deviceGroupId = value; }

        /// <summary>Creates an new <see cref="DeviceUpdateProperties" /> instance.</summary>
        public DeviceUpdateProperties()
        {

        }
    }
    /// The updatable properties of the Device.
    public partial interface IDeviceUpdateProperties :
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
    /// The updatable properties of the Device.
    internal partial interface IDeviceUpdatePropertiesInternal

    {
        /// <summary>Device group id</summary>
        string DeviceGroupId { get; set; }

    }
}