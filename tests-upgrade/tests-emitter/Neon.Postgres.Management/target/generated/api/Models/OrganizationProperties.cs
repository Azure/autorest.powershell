// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Data Organization resource</summary>
    public partial class OrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CompanyDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails _companyDetail;

        /// <summary>Details of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails CompanyDetail { get => (this._companyDetail = this._companyDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.CompanyDetails()); set => this._companyDetail = value; }

        /// <summary>Business phone number of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailBusinessPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).BusinessPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).BusinessPhone = value ?? null; }

        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).CompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).CompanyName = value ?? null; }

        /// <summary>Country name of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).Country = value ?? null; }

        /// <summary>Domain of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).Domain; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).Domain = value ?? null; }

        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public long? CompanyDetailNumberOfEmployee { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).NumberOfEmployee; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).NumberOfEmployee = value ?? default(long); }

        /// <summary>Office address of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CompanyDetailOfficeAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).OfficeAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal)CompanyDetail).OfficeAddress = value ?? null; }

        /// <summary>Backing field for <see cref="MarketplaceDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails _marketplaceDetail;

        /// <summary>Marketplace details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.MarketplaceDetails()); set => this._marketplaceDetail = value; }

        /// <summary>SaaS subscription id for the the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string MarketplaceDetailSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).SubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string MarketplaceDetailSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).SubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).SubscriptionStatus = value ?? null; }

        /// <summary>Internal Acessors for CompanyDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.CompanyDetail { get => (this._companyDetail = this._companyDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.CompanyDetails()); set { {_companyDetail = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.MarketplaceDetails()); set { {_marketplaceDetail = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetailOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.MarketplaceDetailOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetail = value; }

        /// <summary>Internal Acessors for PartnerOrganizationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.PartnerOrganizationProperty { get => (this._partnerOrganizationProperty = this._partnerOrganizationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.PartnerOrganizationProperties()); set { {_partnerOrganizationProperty = value;} } }

        /// <summary>Internal Acessors for PartnerOrganizationPropertySingleSignOnProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.PartnerOrganizationPropertySingleSignOnProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnProperty = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationPropertiesInternal.UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.UserDetails()); set { {_userDetail = value;} } }

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailOfferId = value ?? null; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanId = value ?? null; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanName = value ?? null; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPublisherId = value ?? null; }

        /// <summary>Term Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermId = value ?? null; }

        /// <summary>Term Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="PartnerOrganizationProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties _partnerOrganizationProperty;

        /// <summary>Organization properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties PartnerOrganizationProperty { get => (this._partnerOrganizationProperty = this._partnerOrganizationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.PartnerOrganizationProperties()); set => this._partnerOrganizationProperty = value; }

        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyOrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationId = value ?? null; }

        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyOrganizationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationName = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyAadDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyAadDomain = value ?? null /* arrayOf */; }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyEnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyEnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyEnterpriseAppId = value ?? null; }

        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnState = value ?? null; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="UserDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails _userDetail;

        /// <summary>Details of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.UserDetails()); set => this._userDetail = value; }

        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).EmailAddress = value ?? null; }

        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).FirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).FirstName = value ?? null; }

        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).LastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).LastName = value ?? null; }

        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).PhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).PhoneNumber = value ?? null; }

        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string UserDetailUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).Upn; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetailsInternal)UserDetail).Upn = value ?? null; }

        /// <summary>Creates an new <see cref="OrganizationProperties" /> instance.</summary>
        public OrganizationProperties()
        {

        }
    }
    /// Properties specific to Data Organization resource
    public partial interface IOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
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
        Required = true,
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
        Required = true,
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
        Required = true,
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
    /// Properties specific to Data Organization resource
    internal partial interface IOrganizationPropertiesInternal

    {
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
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
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