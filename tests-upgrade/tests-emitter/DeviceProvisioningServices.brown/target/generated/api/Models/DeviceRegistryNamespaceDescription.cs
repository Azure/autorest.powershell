// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>
    /// Description of the Device Registry namespace that is linked to the provisioning service.
    /// </summary>
    public partial class DeviceRegistryNamespaceDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal
    {

        /// <summary>Backing field for <see cref="AuthenticationType" /> property.</summary>
        private string _authenticationType;

        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string AuthenticationType { get => this._authenticationType; set => this._authenticationType = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>
        /// Backing field for <see cref="SelectedUserAssignedIdentityResourceId" /> property.
        /// </summary>
        private string _selectedUserAssignedIdentityResourceId;

        /// <summary>
        /// The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType
        /// is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string SelectedUserAssignedIdentityResourceId { get => this._selectedUserAssignedIdentityResourceId; set => this._selectedUserAssignedIdentityResourceId = value; }

        /// <summary>Creates an new <see cref="DeviceRegistryNamespaceDescription" /> instance.</summary>
        public DeviceRegistryNamespaceDescription()
        {

        }
    }
    /// Description of the Device Registry namespace that is linked to the provisioning service.
    public partial interface IDeviceRegistryNamespaceDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.",
        SerializedName = @"authenticationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("UserAssigned", "SystemAssigned")]
        string AuthenticationType { get; set; }
        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM resource ID of the Device Registry namespace.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>
        /// The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType
        /// is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType is UserAssigned.",
        SerializedName = @"selectedUserAssignedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SelectedUserAssignedIdentityResourceId { get; set; }

    }
    /// Description of the Device Registry namespace that is linked to the provisioning service.
    internal partial interface IDeviceRegistryNamespaceDescriptionInternal

    {
        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("UserAssigned", "SystemAssigned")]
        string AuthenticationType { get; set; }
        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        string ResourceId { get; set; }
        /// <summary>
        /// The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType
        /// is UserAssigned.
        /// </summary>
        string SelectedUserAssignedIdentityResourceId { get; set; }

    }
}