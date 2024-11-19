// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Organization Resource by Neon</summary>
    public partial class OrganizationResource :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.TrackedResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>Business phone number of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailBusinessPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailBusinessPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailBusinessPhone = value ?? null; }

        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCompanyName = value ?? null; }

        /// <summary>Country name of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCountry; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCountry = value ?? null; }

        /// <summary>Domain of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailDomain = value ?? null; }

        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public long? CompanyDetailNumberOfEmployee { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailNumberOfEmployee; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailNumberOfEmployee = value ?? default(long); }

        /// <summary>Office address of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailOfficeAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailOfficeAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetailOfficeAddress = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>SaaS subscription id for the the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string MarketplaceDetailSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailSubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string MarketplaceDetailSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailSubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailSubscriptionStatus = value ?? null; }

        /// <summary>Internal Acessors for CompanyDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.CompanyDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).CompanyDetail = value; }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.MarketplaceDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetail = value; }

        /// <summary>Internal Acessors for MarketplaceDetailOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.MarketplaceDetailOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailOfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailOfferDetail = value; }

        /// <summary>Internal Acessors for PartnerOrganizationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.PartnerOrganizationProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationProperty = value; }

        /// <summary>Internal Acessors for PartnerOrganizationPropertySingleSignOnProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.PartnerOrganizationPropertySingleSignOnProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationPropertySingleSignOnProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationPropertySingleSignOnProperty = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal.UserDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetail = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailOfferId = value ?? null; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanId = value ?? null; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanName = value ?? null; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailPublisherId = value ?? null; }

        /// <summary>Term Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermId = value ?? null; }

        /// <summary>Term Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermUnit = value ?? null; }

        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyOrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationPropertyOrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationPropertyOrganizationId = value ?? null; }

        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyOrganizationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationPropertyOrganizationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).PartnerOrganizationPropertyOrganizationName = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertyAadDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertyAadDomain = value ?? null /* arrayOf */; }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyEnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertyEnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertyEnterpriseAppId = value ?? null; }

        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertySingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertySingleSignOnState = value ?? null; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertySingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).SingleSignOnPropertySingleSignOnUrl = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailEmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailEmailAddress = value ?? null; }

        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailFirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailFirstName = value ?? null; }

        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailLastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailLastName = value ?? null; }

        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailPhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailPhoneNumber = value ?? null; }

        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailUpn; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal)Property).UserDetailUpn = value ?? null; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Creates an new <see cref="OrganizationResource" /> instance.</summary>
        public OrganizationResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Organization Resource by Neon
    public partial interface IOrganizationResource :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>Business phone number of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Business phone number of the company",
        SerializedName = @"businessPhone",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailBusinessPhone { get; set; }
        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Company name",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailCompanyName { get; set; }
        /// <summary>Country name of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Country name of the company",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailCountry { get; set; }
        /// <summary>Domain of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Domain of the user",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailDomain { get; set; }
        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of employees in the company",
        SerializedName = @"numberOfEmployees",
        PossibleTypes = new [] { typeof(long) })]
        long? CompanyDetailNumberOfEmployee { get; set; }
        /// <summary>Office address of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Office address of the company",
        SerializedName = @"officeAddress",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailOfficeAddress { get; set; }
        /// <summary>SaaS subscription id for the the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"SaaS subscription id for the the marketplace offer",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Marketplace subscription status",
        SerializedName = @"subscriptionStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceDetailSubscriptionStatus { get; set; }
        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Offer Id for the marketplace offer",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailOfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Plan Id for the marketplace offer",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Plan Name for the marketplace offer",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Publisher Id for the marketplace offer",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPublisherId { get; set; }
        /// <summary>Term Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Term Id for the marketplace offer",
        SerializedName = @"termId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermId { get; set; }
        /// <summary>Term Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Term Name for the marketplace offer",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermUnit { get; set; }
        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization Id in partner's system",
        SerializedName = @"organizationId",
        PossibleTypes = new [] { typeof(string) })]
        string PartnerOrganizationPropertyOrganizationId { get; set; }
        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization name in partner's system",
        SerializedName = @"organizationName",
        PossibleTypes = new [] { typeof(string) })]
        string PartnerOrganizationPropertyOrganizationName { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of AAD domains fetched from Microsoft Graph for user.",
        SerializedName = @"aadDomains",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the Single Sign On for the organization",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URL for SSO to be used by the partner to redirect the user to their system",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Email address of the user",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailEmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"First name of the user",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailFirstName { get; set; }
        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last name of the user",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailLastName { get; set; }
        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User's phone number",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailPhoneNumber { get; set; }
        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User's principal name",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailUpn { get; set; }

    }
    /// Organization Resource by Neon
    internal partial interface IOrganizationResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>Details of the company.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails CompanyDetail { get; set; }
        /// <summary>Business phone number of the company</summary>
        string CompanyDetailBusinessPhone { get; set; }
        /// <summary>Company name</summary>
        string CompanyDetailCompanyName { get; set; }
        /// <summary>Country name of the company</summary>
        string CompanyDetailCountry { get; set; }
        /// <summary>Domain of the user</summary>
        string CompanyDetailDomain { get; set; }
        /// <summary>Number of employees in the company</summary>
        long? CompanyDetailNumberOfEmployee { get; set; }
        /// <summary>Office address of the company</summary>
        string CompanyDetailOfficeAddress { get; set; }
        /// <summary>Marketplace details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails MarketplaceDetail { get; set; }
        /// <summary>Offer details for the marketplace that is selected by the user</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOfferDetails MarketplaceDetailOfferDetail { get; set; }
        /// <summary>SaaS subscription id for the the marketplace offer</summary>
        string MarketplaceDetailSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceDetailSubscriptionStatus { get; set; }
        /// <summary>Offer Id for the marketplace offer</summary>
        string OfferDetailOfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        string OfferDetailPlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        string OfferDetailPlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        string OfferDetailPublisherId { get; set; }
        /// <summary>Term Id for the marketplace offer</summary>
        string OfferDetailTermId { get; set; }
        /// <summary>Term Name for the marketplace offer</summary>
        string OfferDetailTermUnit { get; set; }
        /// <summary>Organization properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties PartnerOrganizationProperty { get; set; }
        /// <summary>Organization Id in partner's system</summary>
        string PartnerOrganizationPropertyOrganizationId { get; set; }
        /// <summary>Organization name in partner's system</summary>
        string PartnerOrganizationPropertyOrganizationName { get; set; }
        /// <summary>Single Sign On properties for the organization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties PartnerOrganizationPropertySingleSignOnProperty { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>Details of the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails UserDetail { get; set; }
        /// <summary>Email address of the user</summary>
        string UserDetailEmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        string UserDetailFirstName { get; set; }
        /// <summary>Last name of the user</summary>
        string UserDetailLastName { get; set; }
        /// <summary>User's phone number</summary>
        string UserDetailPhoneNumber { get; set; }
        /// <summary>User's principal name</summary>
        string UserDetailUpn { get; set; }

    }
}