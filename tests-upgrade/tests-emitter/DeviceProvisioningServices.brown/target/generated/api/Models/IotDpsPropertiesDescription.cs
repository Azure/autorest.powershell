// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>
    /// the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system
    /// generated properties such as hostname and idScope
    /// </summary>
    public partial class IotDpsPropertiesDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal
    {

        /// <summary>Backing field for <see cref="AllocationPolicy" /> property.</summary>
        private string _allocationPolicy;

        /// <summary>Allocation policy to be used by this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string AllocationPolicy { get => this._allocationPolicy; set => this._allocationPolicy = value; }

        /// <summary>Backing field for <see cref="AuthorizationPolicy" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription> _authorizationPolicy;

        /// <summary>List of authorization keys for a provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription> AuthorizationPolicy { get => this._authorizationPolicy; set => this._authorizationPolicy = value; }

        /// <summary>Backing field for <see cref="DeviceProvisioningHostName" /> property.</summary>
        private string _deviceProvisioningHostName;

        /// <summary>Device endpoint for this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string DeviceProvisioningHostName { get => this._deviceProvisioningHostName; }

        /// <summary>Backing field for <see cref="DeviceRegistryNamespace" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription _deviceRegistryNamespace;

        /// <summary>The Device Registry namespace that is linked to the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription DeviceRegistryNamespace { get => (this._deviceRegistryNamespace = this._deviceRegistryNamespace ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescription()); set => this._deviceRegistryNamespace = value; }

        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceRegistryNamespaceAuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal)DeviceRegistryNamespace).AuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal)DeviceRegistryNamespace).AuthenticationType = value ?? null; }

        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceRegistryNamespaceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal)DeviceRegistryNamespace).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal)DeviceRegistryNamespace).ResourceId = value ?? null; }

        /// <summary>
        /// The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType
        /// is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal)DeviceRegistryNamespace).SelectedUserAssignedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescriptionInternal)DeviceRegistryNamespace).SelectedUserAssignedIdentityResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="EnableDataResidency" /> property.</summary>
        private bool? _enableDataResidency;

        /// <summary>
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public bool? EnableDataResidency { get => this._enableDataResidency; set => this._enableDataResidency = value; }

        /// <summary>Backing field for <see cref="IPFilterRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule> _iPFilterRule;

        /// <summary>The IP filter rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule> IPFilterRule { get => this._iPFilterRule; set => this._iPFilterRule = value; }

        /// <summary>Backing field for <see cref="IdScope" /> property.</summary>
        private string _idScope;

        /// <summary>Unique identifier of this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string IdScope { get => this._idScope; }

        /// <summary>Backing field for <see cref="IotHub" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription> _iotHub;

        /// <summary>List of IoT hubs associated with this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription> IotHub { get => this._iotHub; set => this._iotHub = value; }

        /// <summary>Internal Acessors for DeviceProvisioningHostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal.DeviceProvisioningHostName { get => this._deviceProvisioningHostName; set { {_deviceProvisioningHostName = value;} } }

        /// <summary>Internal Acessors for DeviceRegistryNamespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal.DeviceRegistryNamespace { get => (this._deviceRegistryNamespace = this._deviceRegistryNamespace ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescription()); set { {_deviceRegistryNamespace = value;} } }

        /// <summary>Internal Acessors for IdScope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal.IdScope { get => this._idScope; set { {_idScope = value;} } }

        /// <summary>Internal Acessors for ServiceOperationsHostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal.ServiceOperationsHostName { get => this._serviceOperationsHostName; set { {_serviceOperationsHostName = value;} } }

        /// <summary>Backing field for <see cref="PortalOperationsHostName" /> property.</summary>
        private string _portalOperationsHostName;

        /// <summary>Portal endpoint to enable CORS for this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string PortalOperationsHostName { get => this._portalOperationsHostName; set => this._portalOperationsHostName = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection> _privateEndpointConnection;

        /// <summary>Private endpoint connections created on this IotHub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => this._privateEndpointConnection; set => this._privateEndpointConnection = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The ARM provisioning state of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>Whether requests from Public Network are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="ServiceOperationsHostName" /> property.</summary>
        private string _serviceOperationsHostName;

        /// <summary>Service endpoint for provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ServiceOperationsHostName { get => this._serviceOperationsHostName; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Current state of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="IotDpsPropertiesDescription" /> instance.</summary>
        public IotDpsPropertiesDescription()
        {

        }
    }
    /// the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system
    /// generated properties such as hostname and idScope
    public partial interface IIotDpsPropertiesDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>Allocation policy to be used by this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Allocation policy to be used by this provisioning service.",
        SerializedName = @"allocationPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Hashed", "GeoLatency", "Static")]
        string AllocationPolicy { get; set; }
        /// <summary>List of authorization keys for a provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of authorization keys for a provisioning service.",
        SerializedName = @"authorizationPolicies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription> AuthorizationPolicy { get; set; }
        /// <summary>Device endpoint for this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Device endpoint for this provisioning service.",
        SerializedName = @"deviceProvisioningHostName",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceProvisioningHostName { get;  }
        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.",
        SerializedName = @"authenticationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("UserAssigned", "SystemAssigned")]
        string DeviceRegistryNamespaceAuthenticationType { get; set; }
        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM resource ID of the Device Registry namespace.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceRegistryNamespaceResourceId { get; set; }
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
        string DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId { get; set; }
        /// <summary>
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional.
        Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.",
        SerializedName = @"enableDataResidency",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDataResidency { get; set; }
        /// <summary>The IP filter rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The IP filter rules.",
        SerializedName = @"ipFilterRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule> IPFilterRule { get; set; }
        /// <summary>Unique identifier of this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique identifier of this provisioning service.",
        SerializedName = @"idScope",
        PossibleTypes = new [] { typeof(string) })]
        string IdScope { get;  }
        /// <summary>List of IoT hubs associated with this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of IoT hubs associated with this provisioning service.",
        SerializedName = @"iotHubs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription> IotHub { get; set; }
        /// <summary>Portal endpoint to enable CORS for this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Portal endpoint to enable CORS for this provisioning service.",
        SerializedName = @"portalOperationsHostName",
        PossibleTypes = new [] { typeof(string) })]
        string PortalOperationsHostName { get; set; }
        /// <summary>Private endpoint connections created on this IotHub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private endpoint connections created on this IotHub",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>The ARM provisioning state of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM provisioning state of the provisioning service.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get; set; }
        /// <summary>Whether requests from Public Network are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether requests from Public Network are allowed",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Service endpoint for provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Service endpoint for provisioning service.",
        SerializedName = @"serviceOperationsHostName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceOperationsHostName { get;  }
        /// <summary>Current state of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current state of the provisioning service.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Activating", "Active", "Deleting", "Deleted", "ActivationFailed", "DeletionFailed", "Transitioning", "Suspending", "Suspended", "Resuming", "FailingOver", "FailoverFailed")]
        string State { get; set; }

    }
    /// the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system
    /// generated properties such as hostname and idScope
    internal partial interface IIotDpsPropertiesDescriptionInternal

    {
        /// <summary>Allocation policy to be used by this provisioning service.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Hashed", "GeoLatency", "Static")]
        string AllocationPolicy { get; set; }
        /// <summary>List of authorization keys for a provisioning service.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription> AuthorizationPolicy { get; set; }
        /// <summary>Device endpoint for this provisioning service.</summary>
        string DeviceProvisioningHostName { get; set; }
        /// <summary>The Device Registry namespace that is linked to the provisioning service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription DeviceRegistryNamespace { get; set; }
        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("UserAssigned", "SystemAssigned")]
        string DeviceRegistryNamespaceAuthenticationType { get; set; }
        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        string DeviceRegistryNamespaceResourceId { get; set; }
        /// <summary>
        /// The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType
        /// is UserAssigned.
        /// </summary>
        string DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId { get; set; }
        /// <summary>
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </summary>
        bool? EnableDataResidency { get; set; }
        /// <summary>The IP filter rules.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule> IPFilterRule { get; set; }
        /// <summary>Unique identifier of this provisioning service.</summary>
        string IdScope { get; set; }
        /// <summary>List of IoT hubs associated with this provisioning service.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription> IotHub { get; set; }
        /// <summary>Portal endpoint to enable CORS for this provisioning service.</summary>
        string PortalOperationsHostName { get; set; }
        /// <summary>Private endpoint connections created on this IotHub</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>The ARM provisioning state of the provisioning service.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Whether requests from Public Network are allowed</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Service endpoint for provisioning service.</summary>
        string ServiceOperationsHostName { get; set; }
        /// <summary>Current state of the provisioning service.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Activating", "Active", "Deleting", "Deleted", "ActivationFailed", "DeletionFailed", "Transitioning", "Suspending", "Suspended", "Resuming", "FailingOver", "FailoverFailed")]
        string State { get; set; }

    }
}