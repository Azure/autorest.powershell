// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The current state of a private endpoint connection</summary>
    public partial class PrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateLinkServiceConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateLinkServiceConnectionStateInternal
    {

        /// <summary>Backing field for <see cref="ActionsRequired" /> property.</summary>
        private string _actionsRequired;

        /// <summary>Actions required for a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ActionsRequired { get => this._actionsRequired; set => this._actionsRequired = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description for the current state of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnectionState" /> instance.</summary>
        public PrivateLinkServiceConnectionState()
        {

        }
    }
    /// The current state of a private endpoint connection
    public partial interface IPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>Actions required for a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Actions required for a private endpoint connection",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ActionsRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The description for the current state of a private endpoint connection",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The status of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of a private endpoint connection",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
    /// The current state of a private endpoint connection
    internal partial interface IPrivateLinkServiceConnectionStateInternal

    {
        /// <summary>Actions required for a private endpoint connection</summary>
        string ActionsRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection</summary>
        string Description { get; set; }
        /// <summary>The status of a private endpoint connection</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
}