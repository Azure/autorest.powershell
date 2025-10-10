// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Description of name availability.</summary>
    public partial class NameAvailabilityInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.INameAvailabilityInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.INameAvailabilityInfoInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>message containing a detailed reason name is unavailable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>specifies if a name is available or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>specifies the reason a name is unavailable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="NameAvailabilityInfo" /> instance.</summary>
        public NameAvailabilityInfo()
        {

        }
    }
    /// Description of name availability.
    public partial interface INameAvailabilityInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>message containing a detailed reason name is unavailable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"message containing a detailed reason name is unavailable",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>specifies if a name is available or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"specifies if a name is available or not",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>specifies the reason a name is unavailable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"specifies the reason a name is unavailable",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
    /// Description of name availability.
    internal partial interface INameAvailabilityInfoInternal

    {
        /// <summary>message containing a detailed reason name is unavailable</summary>
        string Message { get; set; }
        /// <summary>specifies if a name is available or not</summary>
        bool? NameAvailable { get; set; }
        /// <summary>specifies the reason a name is unavailable</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
}