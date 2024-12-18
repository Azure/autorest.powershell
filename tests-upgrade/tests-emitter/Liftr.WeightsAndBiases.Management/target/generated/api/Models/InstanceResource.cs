// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    public partial class InstanceResource :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.TrackedResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string MarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceSubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string MarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceSubscriptionStatus; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Marketplace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.Marketplace { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).Marketplace; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).Marketplace = value; }

        /// <summary>Internal Acessors for MarketplaceOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.MarketplaceOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceOfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceOfferDetail = value; }

        /// <summary>Internal Acessors for MarketplaceSubscriptionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.MarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceSubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).MarketplaceSubscriptionStatus = value; }

        /// <summary>Internal Acessors for PartnerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.PartnerProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).PartnerProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).PartnerProperty = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for User</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal.User { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).User; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).User = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailOfferId = value ?? null; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailPlanId = value ?? null; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailPlanName = value ?? null; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailPublisherId = value ?? null; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailTermId = value ?? null; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).OfferDetailTermUnit = value ?? null; }

        /// <summary>The region of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string PartnerPropertyRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).PartnerPropertyRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).PartnerPropertyRegion = value ?? null; }

        /// <summary>The subdomain of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string PartnerPropertySubdomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).PartnerPropertySubdomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).PartnerPropertySubdomain = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string UserEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserEmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserEmailAddress = value ?? null; }

        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string UserFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserFirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserFirstName = value ?? null; }

        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string UserLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserLastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserLastName = value ?? null; }

        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string UserPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserPhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserPhoneNumber = value ?? null; }

        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string UserUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserUpn; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)Property).UserUpn = value ?? null; }

        /// <summary>Creates an new <see cref="InstanceResource" /> instance.</summary>
        public InstanceResource()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    public partial interface IInstanceResource :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure subscription id for the the marketplace offer is purchased from",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Marketplace subscription status",
        SerializedName = @"subscriptionStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceSubscriptionStatus { get;  }
        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer Id for the marketplace offer",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailOfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Id for the marketplace offer",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Name for the marketplace offer",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Publisher Id for the marketplace offer",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPublisherId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermUnit { get; set; }
        /// <summary>The region of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The region of the instance",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("eastus", "centralus", "westus", "westeurope", "japaneast", "koreacentral")]
        string PartnerPropertyRegion { get; set; }
        /// <summary>The subdomain of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subdomain of the instance",
        SerializedName = @"subdomain",
        PossibleTypes = new [] { typeof(string) })]
        string PartnerPropertySubdomain { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Email address of the user",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string UserEmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"First name of the user",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string UserFirstName { get; set; }
        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last name of the user",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string UserLastName { get; set; }
        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User's phone number",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        string UserPhoneNumber { get; set; }
        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User's principal name",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        string UserUpn { get; set; }

    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    internal partial interface IInstanceResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Marketplace details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails Marketplace { get; set; }
        /// <summary>Offer details for the marketplace that is selected by the user</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails MarketplaceOfferDetail { get; set; }
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceSubscriptionStatus { get; set; }
        /// <summary>Offer Id for the marketplace offer</summary>
        string OfferDetailOfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        string OfferDetailPlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        string OfferDetailPlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        string OfferDetailPublisherId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        string OfferDetailTermId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        string OfferDetailTermUnit { get; set; }
        /// <summary>partner properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties PartnerProperty { get; set; }
        /// <summary>The region of the instance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("eastus", "centralus", "westus", "westeurope", "japaneast", "koreacentral")]
        string PartnerPropertyRegion { get; set; }
        /// <summary>The subdomain of the instance</summary>
        string PartnerPropertySubdomain { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Details of the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserDetails User { get; set; }
        /// <summary>Email address of the user</summary>
        string UserEmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        string UserFirstName { get; set; }
        /// <summary>Last name of the user</summary>
        string UserLastName { get; set; }
        /// <summary>User's phone number</summary>
        string UserPhoneNumber { get; set; }
        /// <summary>User's principal name</summary>
        string UserUpn { get; set; }

    }
}