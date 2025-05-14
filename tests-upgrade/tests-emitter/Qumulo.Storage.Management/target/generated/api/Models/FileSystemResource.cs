// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    public partial class FileSystemResource :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.TrackedResource();

        /// <summary>Initial administrator password of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string AdminPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).AdminPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).AdminPassword = value ?? null; }

        /// <summary>Availability zone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string AvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).AvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).AvailabilityZone = value ?? null; }

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>File system Id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string ClusterLoginUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).ClusterLoginUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).ClusterLoginUrl = value ?? null; }

        /// <summary>Delegated subnet id for Vnet injection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string DelegatedSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).DelegatedSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).DelegatedSubnetId = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionStatus; }

        /// <summary>Offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailOfferId = value ?? null; }

        /// <summary>Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailPlanId = value ?? null; }

        /// <summary>Publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailPublisherId = value ?? null; }

        /// <summary>Term Unit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailTermUnit = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.MarketplaceDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MarketplaceDetailMarketplaceSubscriptionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.MarketplaceDetailMarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionStatus = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal.UserDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).UserDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).UserDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Private IPs of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PrivateIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).PrivateIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).PrivateIP = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceProperties()); set => this._property = value; }

        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Storage Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).StorageSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).StorageSku = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string UserDetailEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).UserDetailEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)Property).UserDetailEmail = value ?? null; }

        /// <summary>Creates an new <see cref="FileSystemResource" /> instance.</summary>
        public FileSystemResource()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    public partial interface IFileSystemResource :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResource
    {
        /// <summary>Initial administrator password of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Initial administrator password of the resource",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(string) })]
        string AdminPassword { get; set; }
        /// <summary>Availability zone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Availability zone",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>File system Id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"File system Id of the resource",
        SerializedName = @"clusterLoginUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterLoginUrl { get; set; }
        /// <summary>Delegated subnet id for Vnet injection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Delegated subnet id for Vnet injection",
        SerializedName = @"delegatedSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedSubnetId { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Marketplace Subscription Id",
        SerializedName = @"marketplaceSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Marketplace subscription status",
        SerializedName = @"marketplaceSubscriptionStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceDetailMarketplaceSubscriptionStatus { get;  }
        /// <summary>Offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer Id",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailOfferId { get; set; }
        /// <summary>Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Id",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailPlanId { get; set; }
        /// <summary>Publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Publisher Id",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailPublisherId { get; set; }
        /// <summary>Term Unit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Term Unit",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailTermUnit { get; set; }
        /// <summary>Private IPs of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private IPs of the resource",
        SerializedName = @"privateIPs",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> PrivateIP { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State of the resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>Storage Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage Sku",
        SerializedName = @"storageSku",
        PossibleTypes = new [] { typeof(string) })]
        string StorageSku { get; set; }
        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Email",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailEmail { get; set; }

    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    internal partial interface IFileSystemResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal
    {
        /// <summary>Initial administrator password of the resource</summary>
        string AdminPassword { get; set; }
        /// <summary>Availability zone</summary>
        string AvailabilityZone { get; set; }

        string AzureAsyncOperation { get; set; }
        /// <summary>File system Id of the resource</summary>
        string ClusterLoginUrl { get; set; }
        /// <summary>Delegated subnet id for Vnet injection</summary>
        string DelegatedSubnetId { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Marketplace details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails MarketplaceDetail { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceDetailMarketplaceSubscriptionStatus { get; set; }
        /// <summary>Offer Id</summary>
        string MarketplaceDetailOfferId { get; set; }
        /// <summary>Plan Id</summary>
        string MarketplaceDetailPlanId { get; set; }
        /// <summary>Publisher Id</summary>
        string MarketplaceDetailPublisherId { get; set; }
        /// <summary>Term Unit</summary>
        string MarketplaceDetailTermUnit { get; set; }
        /// <summary>Private IPs of the resource</summary>
        System.Collections.Generic.List<string> PrivateIP { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties Property { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Storage Sku</summary>
        string StorageSku { get; set; }
        /// <summary>User Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails UserDetail { get; set; }
        /// <summary>User Email</summary>
        string UserDetailEmail { get; set; }

    }
}