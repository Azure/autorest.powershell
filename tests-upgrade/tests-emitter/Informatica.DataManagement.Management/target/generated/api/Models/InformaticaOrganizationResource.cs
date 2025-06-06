// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>An Organization Resource by Informatica.</summary>
    public partial class InformaticaOrganizationResource :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResource,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.TrackedResource();

        /// <summary>Business phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailBusiness { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailBusiness; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailBusiness = value ?? null; }

        /// <summary>company Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCompanyName = value ?? null; }

        /// <summary>Country name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCountry; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailCountry = value ?? null; }

        /// <summary>Domain name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailDomain = value ?? null; }

        /// <summary>Number Of Employees</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public int? CompanyDetailNumberOfEmployee { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailNumberOfEmployee; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailNumberOfEmployee = value ?? default(int); }

        /// <summary>Office Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailOfficeAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailOfficeAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetailOfficeAddress = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Informatica organization region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertyInformaticaRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertyInformaticaRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertyInformaticaRegion = value ?? null; }

        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertyOrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertyOrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertyOrganizationId = value ?? null; }

        /// <summary>Organization name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertyOrganizationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertyOrganizationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertyOrganizationName = value ?? null; }

        /// <summary>Single sing on URL for informatica organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertySingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaPropertySingleSignOnUrl = value ?? null; }

        /// <summary>Link organization token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string LinkOrganizationToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).LinkOrganizationToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).LinkOrganizationToken = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionId = value ?? null; }

        /// <summary>Internal Acessors for CompanyDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.CompanyDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).CompanyDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for InformaticaProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.InformaticaProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).InformaticaProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LinkOrganization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.LinkOrganization { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).LinkOrganization; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).LinkOrganization = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.MarketplaceDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MarketplaceDetailOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.MarketplaceDetailOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailOfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).MarketplaceDetailOfferDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal.UserDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailOfferId = value ?? null; }

        /// <summary>Id of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanId = value ?? null; }

        /// <summary>Name of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailPlanName = value ?? null; }

        /// <summary>Id of the product publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailPublisherId = value ?? null; }

        /// <summary>Offer plan term id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermId = value ?? null; }

        /// <summary>Offer plan term unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).OfferDetailTermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationProperties()); set => this._property = value; }

        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>User email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailEmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailEmailAddress = value ?? null; }

        /// <summary>User first name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailFirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailFirstName = value ?? null; }

        /// <summary>User last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailLastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailLastName = value ?? null; }

        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailPhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailPhoneNumber = value ?? null; }

        /// <summary>UPN of user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailUpn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)Property).UserDetailUpn = value ?? null; }

        /// <summary>Creates an new <see cref="InformaticaOrganizationResource" /> instance.</summary>
        public InformaticaOrganizationResource()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// An Organization Resource by Informatica.
    public partial interface IInformaticaOrganizationResource :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResource
    {
        /// <summary>Business phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Business phone number",
        SerializedName = @"business",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailBusiness { get; set; }
        /// <summary>company Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"company Name",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailCompanyName { get; set; }
        /// <summary>Country name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Country name",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailCountry { get; set; }
        /// <summary>Domain name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Domain name",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailDomain { get; set; }
        /// <summary>Number Of Employees</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number Of Employees",
        SerializedName = @"numberOfEmployees",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyDetailNumberOfEmployee { get; set; }
        /// <summary>Office Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Office Address",
        SerializedName = @"officeAddress",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyDetailOfficeAddress { get; set; }
        /// <summary>Informatica organization region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Informatica organization region",
        SerializedName = @"informaticaRegion",
        PossibleTypes = new [] { typeof(string) })]
        string InformaticaPropertyInformaticaRegion { get; set; }
        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization id",
        SerializedName = @"organizationId",
        PossibleTypes = new [] { typeof(string) })]
        string InformaticaPropertyOrganizationId { get; set; }
        /// <summary>Organization name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization name",
        SerializedName = @"organizationName",
        PossibleTypes = new [] { typeof(string) })]
        string InformaticaPropertyOrganizationName { get; set; }
        /// <summary>Single sing on URL for informatica organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Single sing on URL for informatica organization",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string InformaticaPropertySingleSignOnUrl { get; set; }
        /// <summary>Link organization token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Link organization token",
        SerializedName = @"token",
        PossibleTypes = new [] { typeof(string) })]
        string LinkOrganizationToken { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Marketplace Subscription Id",
        SerializedName = @"marketplaceSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Id of the product offering.",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailOfferId { get; set; }
        /// <summary>Id of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Id of the product offer plan.",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanId { get; set; }
        /// <summary>Name of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the product offer plan.",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanName { get; set; }
        /// <summary>Id of the product publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Id of the product publisher.",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPublisherId { get; set; }
        /// <summary>Offer plan term id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer plan term id.",
        SerializedName = @"termId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermId { get; set; }
        /// <summary>Offer plan term unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer plan term unit.",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermUnit { get; set; }
        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>User email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User email address.",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailEmailAddress { get; set; }
        /// <summary>User first name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User first name.",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailFirstName { get; set; }
        /// <summary>User last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User last name.",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailLastName { get; set; }
        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Phone number of the user used by for contacting them if needed",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailPhoneNumber { get; set; }
        /// <summary>UPN of user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UPN of user",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailUpn { get; set; }

    }
    /// An Organization Resource by Informatica.
    internal partial interface IInformaticaOrganizationResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal
    {
        /// <summary>Company details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails CompanyDetail { get; set; }
        /// <summary>Business phone number</summary>
        string CompanyDetailBusiness { get; set; }
        /// <summary>company Name</summary>
        string CompanyDetailCompanyName { get; set; }
        /// <summary>Country name</summary>
        string CompanyDetailCountry { get; set; }
        /// <summary>Domain name</summary>
        string CompanyDetailDomain { get; set; }
        /// <summary>Number Of Employees</summary>
        int? CompanyDetailNumberOfEmployee { get; set; }
        /// <summary>Office Address</summary>
        string CompanyDetailOfficeAddress { get; set; }
        /// <summary>Informatica Organization properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties InformaticaProperty { get; set; }
        /// <summary>Informatica organization region</summary>
        string InformaticaPropertyInformaticaRegion { get; set; }
        /// <summary>Organization id</summary>
        string InformaticaPropertyOrganizationId { get; set; }
        /// <summary>Organization name</summary>
        string InformaticaPropertyOrganizationName { get; set; }
        /// <summary>Single sing on URL for informatica organization</summary>
        string InformaticaPropertySingleSignOnUrl { get; set; }
        /// <summary>Link Organization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization LinkOrganization { get; set; }
        /// <summary>Link organization token</summary>
        string LinkOrganizationToken { get; set; }
        /// <summary>Marketplace details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails MarketplaceDetail { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace offer details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails MarketplaceDetailOfferDetail { get; set; }
        /// <summary>Id of the product offering.</summary>
        string OfferDetailOfferId { get; set; }
        /// <summary>Id of the product offer plan.</summary>
        string OfferDetailPlanId { get; set; }
        /// <summary>Name of the product offer plan.</summary>
        string OfferDetailPlanName { get; set; }
        /// <summary>Id of the product publisher.</summary>
        string OfferDetailPublisherId { get; set; }
        /// <summary>Offer plan term id.</summary>
        string OfferDetailTermId { get; set; }
        /// <summary>Offer plan term unit.</summary>
        string OfferDetailTermUnit { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties Property { get; set; }
        /// <summary>Provisioning State of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>User details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails UserDetail { get; set; }
        /// <summary>User email address.</summary>
        string UserDetailEmailAddress { get; set; }
        /// <summary>User first name.</summary>
        string UserDetailFirstName { get; set; }
        /// <summary>User last name.</summary>
        string UserDetailLastName { get; set; }
        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        string UserDetailPhoneNumber { get; set; }
        /// <summary>UPN of user</summary>
        string UserDetailUpn { get; set; }

    }
}