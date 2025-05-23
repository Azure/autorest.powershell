// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Properties specific to the Informatica DataManagement Organization resource.</summary>
    public partial class OrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CompanyDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails _companyDetail;

        /// <summary>Company details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails CompanyDetail { get => (this._companyDetail = this._companyDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetails()); set => this._companyDetail = value; }

        /// <summary>Business phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailBusiness { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).Business; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).Business = value ?? null; }

        /// <summary>company Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).CompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).CompanyName = value ?? null; }

        /// <summary>Country name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).Country = value ?? null; }

        /// <summary>Domain name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).Domain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).Domain = value ?? null; }

        /// <summary>Number Of Employees</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public int? CompanyDetailNumberOfEmployee { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).NumberOfEmployee; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).NumberOfEmployee = value ?? default(int); }

        /// <summary>Office Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailOfficeAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).OfficeAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal)CompanyDetail).OfficeAddress = value ?? null; }

        /// <summary>Backing field for <see cref="InformaticaProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties _informaticaProperty;

        /// <summary>Informatica Organization properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties InformaticaProperty { get => (this._informaticaProperty = this._informaticaProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaProperties()); set => this._informaticaProperty = value; }

        /// <summary>Informatica organization region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertyInformaticaRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).InformaticaRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).InformaticaRegion = value ?? null; }

        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertyOrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).OrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).OrganizationId = value ?? null; }

        /// <summary>Organization name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertyOrganizationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).OrganizationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).OrganizationName = value ?? null; }

        /// <summary>Single sing on URL for informatica organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string InformaticaPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).SingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal)InformaticaProperty).SingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="LinkOrganization" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization _linkOrganization;

        /// <summary>Link Organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization LinkOrganization { get => (this._linkOrganization = this._linkOrganization ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.LinkOrganization()); set => this._linkOrganization = value; }

        /// <summary>Link organization token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string LinkOrganizationToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganizationInternal)LinkOrganization).Token; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganizationInternal)LinkOrganization).Token = value ?? null; }

        /// <summary>Backing field for <see cref="MarketplaceDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails _marketplaceDetail;

        /// <summary>Marketplace details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetails()); set => this._marketplaceDetail = value; }

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionId = value ?? null; }

        /// <summary>Internal Acessors for CompanyDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.CompanyDetail { get => (this._companyDetail = this._companyDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetails()); set { {_companyDetail = value;} } }

        /// <summary>Internal Acessors for InformaticaProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.InformaticaProperty { get => (this._informaticaProperty = this._informaticaProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaProperties()); set { {_informaticaProperty = value;} } }

        /// <summary>Internal Acessors for LinkOrganization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.LinkOrganization { get => (this._linkOrganization = this._linkOrganization ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.LinkOrganization()); set { {_linkOrganization = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetails()); set { {_marketplaceDetail = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetailOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.MarketplaceDetailOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal.UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetails()); set { {_userDetail = value;} } }

        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailOfferId = value ?? null; }

        /// <summary>Id of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanId = value ?? null; }

        /// <summary>Name of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPlanName = value ?? null; }

        /// <summary>Id of the product publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailPublisherId = value ?? null; }

        /// <summary>Offer plan term id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermId = value ?? null; }

        /// <summary>Offer plan term unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferDetailTermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="UserDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails _userDetail;

        /// <summary>User details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetails()); set => this._userDetail = value; }

        /// <summary>User email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).EmailAddress = value ?? null; }

        /// <summary>User first name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).FirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).FirstName = value ?? null; }

        /// <summary>User last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).LastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).LastName = value ?? null; }

        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).PhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).PhoneNumber = value ?? null; }

        /// <summary>UPN of user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).Upn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal)UserDetail).Upn = value ?? null; }

        /// <summary>Creates an new <see cref="OrganizationProperties" /> instance.</summary>
        public OrganizationProperties()
        {

        }
    }
    /// Properties specific to the Informatica DataManagement Organization resource.
    public partial interface IOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
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
    /// Properties specific to the Informatica DataManagement Organization resource.
    internal partial interface IOrganizationPropertiesInternal

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
        /// <summary>Provisioning State of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }
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