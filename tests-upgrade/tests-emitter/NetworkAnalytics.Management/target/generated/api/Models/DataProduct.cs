// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The data product resource.</summary>
    public partial class DataProduct :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.TrackedResource();

        /// <summary>List of available minor versions of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AvailableMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).AvailableMinorVersion; }

        /// <summary>Resource Id of file access endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointFileAccessResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointFileAccessResourceId; }

        /// <summary>Url to consume file type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointFileAccessUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointFileAccessUrl; }

        /// <summary>Resource Id of ingestion endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointIngestionResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointIngestionResourceId; }

        /// <summary>Ingestion url to upload the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointIngestionUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointIngestionUrl; }

        /// <summary>Resource Id of query endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointQueryResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointQueryResourceId; }

        /// <summary>Url to consume the processed data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointQueryUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointQueryUrl; }

        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CurrentMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CurrentMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CurrentMinorVersion = value ?? null; }

        /// <summary>The name of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerEncryptionKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKeyName = value ?? null; }

        /// <summary>The Uri of the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerEncryptionKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKeyVaultUri = value ?? null; }

        /// <summary>The version of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerEncryptionKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKeyVersion = value ?? null; }

        /// <summary>Flag to enable customer managed key encryption for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerManagedKeyEncryptionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerManagedKeyEncryptionEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerManagedKeyEncryptionEnabled = value ?? null; }

        /// <summary>Documentation link for the data product based on definition file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string Documentation { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Documentation; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Key vault url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string KeyVaultUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).KeyVaultUrl; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Major version of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string MajorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).MajorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).MajorVersion = value ?? null; }

        /// <summary>Managed Resource Group location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupConfigurationLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ManagedResourceGroupConfigurationLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ManagedResourceGroupConfigurationLocation = value ?? null; }

        /// <summary>Name of managed resource group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ManagedResourceGroupConfigurationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ManagedResourceGroupConfigurationName = value ?? null; }

        /// <summary>Internal Acessors for AvailableMinorVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.AvailableMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).AvailableMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).AvailableMinorVersion = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ConsumptionEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpoint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ConsumptionEndpointFileAccessResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpointFileAccessResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointFileAccessResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointFileAccessResourceId = value ?? null; }

        /// <summary>Internal Acessors for ConsumptionEndpointFileAccessUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpointFileAccessUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointFileAccessUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointFileAccessUrl = value ?? null; }

        /// <summary>Internal Acessors for ConsumptionEndpointIngestionResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpointIngestionResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointIngestionResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointIngestionResourceId = value ?? null; }

        /// <summary>Internal Acessors for ConsumptionEndpointIngestionUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpointIngestionUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointIngestionUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointIngestionUrl = value ?? null; }

        /// <summary>Internal Acessors for ConsumptionEndpointQueryResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpointQueryResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointQueryResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointQueryResourceId = value ?? null; }

        /// <summary>Internal Acessors for ConsumptionEndpointQueryUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ConsumptionEndpointQueryUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointQueryUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ConsumptionEndpointQueryUrl = value ?? null; }

        /// <summary>Internal Acessors for CustomerEncryptionKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.CustomerEncryptionKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).CustomerEncryptionKey = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Documentation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.Documentation { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Documentation; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Documentation = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for KeyVaultUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.KeyVaultUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).KeyVaultUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).KeyVaultUrl = value ?? null; }

        /// <summary>Internal Acessors for ManagedResourceGroupConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ManagedResourceGroupConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ManagedResourceGroupConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ManagedResourceGroupConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Networkacl</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.Networkacl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Networkacl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Networkacl = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal.ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ResourceGuid = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> NetworkaclAllowedQueryIPRangeList { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclAllowedQueryIPRangeList; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclAllowedQueryIPRangeList = value ?? null /* arrayOf */; }

        /// <summary>Default Action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string NetworkaclDefaultAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclDefaultAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclDefaultAction = value ?? null; }

        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> NetworkaclIPRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclIPRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclIPRule = value ?? null /* arrayOf */; }

        /// <summary>Virtual Network Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> NetworkaclVirtualNetworkRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclVirtualNetworkRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).NetworkaclVirtualNetworkRule = value ?? null /* arrayOf */; }

        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Owner { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Owner; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Owner = value ?? null /* arrayOf */; }

        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PrivateLinksEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PrivateLinksEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PrivateLinksEnabled = value ?? null; }

        /// <summary>Product name of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string Product { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Product; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Product = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductProperties()); set => this._property = value; }

        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Flag to enable or disable public access of data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>Data product publisher name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Publisher = value ?? null; }

        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PurviewAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PurviewAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PurviewAccount = value ?? null; }

        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PurviewCollection { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PurviewCollection; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).PurviewCollection = value ?? null; }

        /// <summary>Flag to enable or disable redundancy for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string Redundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Redundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).Redundancy = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The resource GUID property of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)Property).ResourceGuid; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="DataProduct" /> instance.</summary>
        public DataProduct()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// The data product resource.
    public partial interface IDataProduct :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResource
    {
        /// <summary>List of available minor versions of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of available minor versions of the data product resource.",
        SerializedName = @"availableMinorVersions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AvailableMinorVersion { get;  }
        /// <summary>Resource Id of file access endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of file access endpoint.",
        SerializedName = @"fileAccessResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointFileAccessResourceId { get;  }
        /// <summary>Url to consume file type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to consume file type.",
        SerializedName = @"fileAccessUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointFileAccessUrl { get;  }
        /// <summary>Resource Id of ingestion endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of ingestion endpoint.",
        SerializedName = @"ingestionResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointIngestionResourceId { get;  }
        /// <summary>Ingestion url to upload the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Ingestion url to upload the data.",
        SerializedName = @"ingestionUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointIngestionUrl { get;  }
        /// <summary>Resource Id of query endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of query endpoint.",
        SerializedName = @"queryResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointQueryResourceId { get;  }
        /// <summary>Url to consume the processed data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to consume the processed data.",
        SerializedName = @"queryUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointQueryUrl { get;  }
        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = false,
        Update = true,
        Description = @"Current configured minor version of the data product resource.",
        SerializedName = @"currentMinorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentMinorVersion { get; set; }
        /// <summary>The name of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The name of the key vault key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerEncryptionKeyName { get; set; }
        /// <summary>The Uri of the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The Uri of the key vault.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerEncryptionKeyVaultUri { get; set; }
        /// <summary>The version of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The version of the key vault key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerEncryptionKeyVersion { get; set; }
        /// <summary>Flag to enable customer managed key encryption for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Flag to enable customer managed key encryption for data product.",
        SerializedName = @"customerManagedKeyEncryptionEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string CustomerManagedKeyEncryptionEnabled { get; set; }
        /// <summary>Documentation link for the data product based on definition file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Documentation link for the data product based on definition file.",
        SerializedName = @"documentation",
        PossibleTypes = new [] { typeof(string) })]
        string Documentation { get;  }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Key vault url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Key vault url.",
        SerializedName = @"keyVaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultUrl { get;  }
        /// <summary>Major version of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Major version of data product.",
        SerializedName = @"majorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MajorVersion { get; set; }
        /// <summary>Managed Resource Group location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Managed Resource Group location",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupConfigurationLocation { get; set; }
        /// <summary>Name of managed resource group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Name of managed resource group",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupConfigurationName { get; set; }
        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.",
        SerializedName = @"allowedQueryIpRangeList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> NetworkaclAllowedQueryIPRangeList { get; set; }
        /// <summary>Default Action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Default Action",
        SerializedName = @"defaultAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Allow", "Deny")]
        string NetworkaclDefaultAction { get; set; }
        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"IP rule with specific IP or IP range in CIDR format.",
        SerializedName = @"ipRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> NetworkaclIPRule { get; set; }
        /// <summary>Virtual Network Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Virtual Network Rule",
        SerializedName = @"virtualNetworkRule",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> NetworkaclVirtualNetworkRule { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of name or email associated with data product resource deployment.",
        SerializedName = @"owners",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to enable or disable private link for data product resource.",
        SerializedName = @"privateLinksEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Product name of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Product name of data product.",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string Product { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Latest provisioning state  of data product.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Flag to enable or disable public access of data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Flag to enable or disable public access of data product resource.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Data product publisher name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Data product publisher name.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview account url for data product to connect to.",
        SerializedName = @"purviewAccount",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview collection url for data product to connect to.",
        SerializedName = @"purviewCollection",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewCollection { get; set; }
        /// <summary>Flag to enable or disable redundancy for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Flag to enable or disable redundancy for data product.",
        SerializedName = @"redundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Redundancy { get; set; }
        /// <summary>The resource GUID property of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource GUID property of the data product resource.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

    }
    /// The data product resource.
    internal partial interface IDataProductInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal
    {
        /// <summary>List of available minor versions of the data product resource.</summary>
        System.Collections.Generic.List<string> AvailableMinorVersion { get; set; }
        /// <summary>Resource links which exposed to the customer to query the data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties ConsumptionEndpoint { get; set; }
        /// <summary>Resource Id of file access endpoint.</summary>
        string ConsumptionEndpointFileAccessResourceId { get; set; }
        /// <summary>Url to consume file type.</summary>
        string ConsumptionEndpointFileAccessUrl { get; set; }
        /// <summary>Resource Id of ingestion endpoint.</summary>
        string ConsumptionEndpointIngestionResourceId { get; set; }
        /// <summary>Ingestion url to upload the data.</summary>
        string ConsumptionEndpointIngestionUrl { get; set; }
        /// <summary>Resource Id of query endpoint.</summary>
        string ConsumptionEndpointQueryResourceId { get; set; }
        /// <summary>Url to consume the processed data.</summary>
        string ConsumptionEndpointQueryUrl { get; set; }
        /// <summary>Current configured minor version of the data product resource.</summary>
        string CurrentMinorVersion { get; set; }
        /// <summary>Customer managed encryption key details for data product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails CustomerEncryptionKey { get; set; }
        /// <summary>The name of the key vault key.</summary>
        string CustomerEncryptionKeyName { get; set; }
        /// <summary>The Uri of the key vault.</summary>
        string CustomerEncryptionKeyVaultUri { get; set; }
        /// <summary>The version of the key vault key.</summary>
        string CustomerEncryptionKeyVersion { get; set; }
        /// <summary>Flag to enable customer managed key encryption for data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string CustomerManagedKeyEncryptionEnabled { get; set; }
        /// <summary>Documentation link for the data product based on definition file.</summary>
        string Documentation { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Key vault url.</summary>
        string KeyVaultUrl { get; set; }
        /// <summary>Major version of data product.</summary>
        string MajorVersion { get; set; }
        /// <summary>Managed resource group configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary>Managed Resource Group location</summary>
        string ManagedResourceGroupConfigurationLocation { get; set; }
        /// <summary>Name of managed resource group</summary>
        string ManagedResourceGroupConfigurationName { get; set; }
        /// <summary>Network rule set for data product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls Networkacl { get; set; }
        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        System.Collections.Generic.List<string> NetworkaclAllowedQueryIPRangeList { get; set; }
        /// <summary>Default Action</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Allow", "Deny")]
        string NetworkaclDefaultAction { get; set; }
        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> NetworkaclIPRule { get; set; }
        /// <summary>Virtual Network Rule</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> NetworkaclVirtualNetworkRule { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Product name of data product.</summary>
        string Product { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties Property { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Flag to enable or disable public access of data product resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Data product publisher name.</summary>
        string Publisher { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        string PurviewCollection { get; set; }
        /// <summary>Flag to enable or disable redundancy for data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Redundancy { get; set; }
        /// <summary>The resource GUID property of the data product resource.</summary>
        string ResourceGuid { get; set; }

        int? RetryAfter { get; set; }

    }
}