// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The description of the provisioning service.</summary>
    public partial class ProvisioningServiceDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.TrackedResource();

        /// <summary>Allocation policy to be used by this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string AllocationPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).AllocationPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).AllocationPolicy = value ?? null; }

        /// <summary>List of authorization keys for a provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription> AuthorizationPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).AuthorizationPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).AuthorizationPolicy = value ?? null /* arrayOf */; }

        /// <summary>Device endpoint for this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceProvisioningHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceProvisioningHostName; }

        /// <summary>Device Registry Namespace MI authentication type: UserAssigned, SystemAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceRegistryNamespaceAuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespaceAuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespaceAuthenticationType = value ?? null; }

        /// <summary>The ARM resource ID of the Device Registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceRegistryNamespaceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespaceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespaceResourceId = value ?? null; }

        /// <summary>
        /// The selected user-assigned identity resource Id associated with Device Registry namespace. This is required when authenticationType
        /// is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId = value ?? null; }

        /// <summary>
        /// Optional.
        /// Indicates if the DPS instance has Data Residency enabled, removing the cross geo-pair disaster recovery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public bool? EnableDataResidency { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).EnableDataResidency; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).EnableDataResidency = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the
        /// normal ETag convention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; set => this._etag = value; }

        /// <summary>The IP filter rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule> IPFilterRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IPFilterRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IPFilterRule = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Unique identifier of this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string IdScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IdScope; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>List of IoT hubs associated with this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription> IotHub { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IotHub; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IotHub = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Location1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for DeviceProvisioningHostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.DeviceProvisioningHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceProvisioningHostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceProvisioningHostName = value ?? null; }

        /// <summary>Internal Acessors for DeviceRegistryNamespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.DeviceRegistryNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).DeviceRegistryNamespace = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IdScope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.IdScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IdScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).IdScope = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescription()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ServiceOperationsHostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.ServiceOperationsHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).ServiceOperationsHostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).ServiceOperationsHostName = value ?? null; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsSkuInfo()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for SkuTier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal.SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Tier = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Portal endpoint to enable CORS for this provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string PortalOperationsHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).PortalOperationsHostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).PortalOperationsHostName = value ?? null; }

        /// <summary>Private endpoint connections created on this IotHub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).PrivateEndpointConnection = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription _property;

        /// <summary>Service specific properties for a provisioning service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescription()); set => this._property = value; }

        /// <summary>The ARM provisioning state of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Whether requests from Public Network are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Resourcegroup" /> property.</summary>
        private string _resourcegroup;

        /// <summary>The resource group of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Resourcegroup { get => this._resourcegroup; set => this._resourcegroup = value; }

        /// <summary>Service endpoint for provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string ServiceOperationsHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).ServiceOperationsHostName; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo _sku;

        /// <summary>Sku info for a provisioning Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsSkuInfo()); set => this._sku = value; }

        /// <summary>The number of units to provision</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public long? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Capacity = value ?? default(long); }

        /// <summary>Sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Name = value ?? null; }

        /// <summary>Pricing tier name of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal)Sku).Tier; }

        /// <summary>Current state of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)Property).State = value ?? null; }

        /// <summary>Backing field for <see cref="Subscriptionid" /> property.</summary>
        private string _subscriptionid;

        /// <summary>The subscription id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Subscriptionid { get => this._subscriptionid; set => this._subscriptionid = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__trackedResource).Type; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="ProvisioningServiceDescription" /> instance.</summary>
        public ProvisioningServiceDescription()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// The description of the provisioning service.
    public partial interface IProvisioningServiceDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResource
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
        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the
        /// normal ETag convention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get; set; }
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
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
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
        /// <summary>The resource group of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource group of the resource.",
        SerializedName = @"resourcegroup",
        PossibleTypes = new [] { typeof(string) })]
        string Resourcegroup { get; set; }
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
        /// <summary>The number of units to provision</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of units to provision",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(long) })]
        long? SkuCapacity { get; set; }
        /// <summary>Sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("S1")]
        string SkuName { get; set; }
        /// <summary>Pricing tier name of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Pricing tier name of the provisioning service.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get;  }
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
        /// <summary>The subscription id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subscription id of the resource.",
        SerializedName = @"subscriptionid",
        PossibleTypes = new [] { typeof(string) })]
        string Subscriptionid { get; set; }

    }
    /// The description of the provisioning service.
    internal partial interface IProvisioningServiceDescriptionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal
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
        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the
        /// normal ETag convention.
        /// </summary>
        string Etag { get; set; }
        /// <summary>The IP filter rules.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule> IPFilterRule { get; set; }
        /// <summary>Unique identifier of this provisioning service.</summary>
        string IdScope { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>List of IoT hubs associated with this provisioning service.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription> IotHub { get; set; }

        string Location { get; set; }
        /// <summary>Portal endpoint to enable CORS for this provisioning service.</summary>
        string PortalOperationsHostName { get; set; }
        /// <summary>Private endpoint connections created on this IotHub</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>Service specific properties for a provisioning service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription Property { get; set; }
        /// <summary>The ARM provisioning state of the provisioning service.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Whether requests from Public Network are allowed</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>The resource group of the resource.</summary>
        string Resourcegroup { get; set; }
        /// <summary>Service endpoint for provisioning service.</summary>
        string ServiceOperationsHostName { get; set; }
        /// <summary>Sku info for a provisioning Service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo Sku { get; set; }
        /// <summary>The number of units to provision</summary>
        long? SkuCapacity { get; set; }
        /// <summary>Sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("S1")]
        string SkuName { get; set; }
        /// <summary>Pricing tier name of the provisioning service.</summary>
        string SkuTier { get; set; }
        /// <summary>Current state of the provisioning service.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("Activating", "Active", "Deleting", "Deleted", "ActivationFailed", "DeletionFailed", "Transitioning", "Suspending", "Suspended", "Resuming", "FailingOver", "FailoverFailed")]
        string State { get; set; }
        /// <summary>The subscription id of the resource.</summary>
        string Subscriptionid { get; set; }

    }
}