// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Patchable Properties of the Informatica Organization resource</summary>
    public partial class OrganizationPropertiesCustomUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal
    {

        /// <summary>Backing field for <see cref="CompanyDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate _companyDetail;

        /// <summary>Company Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate CompanyDetail { get => (this._companyDetail = this._companyDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsUpdate()); set => this._companyDetail = value; }

        /// <summary>Business phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailBusiness { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).Business; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).Business = value ?? null; }

        /// <summary>company Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).CompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).CompanyName = value ?? null; }

        /// <summary>Country name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).Country = value ?? null; }

        /// <summary>Domain name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).Domain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).Domain = value ?? null; }

        /// <summary>Number Of Employees</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public int? CompanyDetailNumberOfEmployee { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).NumberOfEmployee; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).NumberOfEmployee = value ?? default(int); }

        /// <summary>Office Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string CompanyDetailOfficeAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).OfficeAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdateInternal)CompanyDetail).OfficeAddress = value ?? null; }

        /// <summary>Backing field for <see cref="ExistingResourceId" /> property.</summary>
        private string _existingResourceId;

        /// <summary>Existing Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ExistingResourceId { get => this._existingResourceId; set => this._existingResourceId = value; }

        /// <summary>Backing field for <see cref="InformaticaOrganizationProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate _informaticaOrganizationProperty;

        /// <summary>Informatica Organization properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate InformaticaOrganizationProperty { get => (this._informaticaOrganizationProperty = this._informaticaOrganizationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResourceUpdate()); set => this._informaticaOrganizationProperty = value; }

        /// <summary>Backing field for <see cref="MarketplaceDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate _marketplaceDetail;

        /// <summary>Marketplace details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsUpdate()); set => this._marketplaceDetail = value; }

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).MarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).MarketplaceSubscriptionId = value ?? null; }

        /// <summary>Internal Acessors for CompanyDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal.CompanyDetail { get => (this._companyDetail = this._companyDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsUpdate()); set { {_companyDetail = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal.MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsUpdate()); set { {_marketplaceDetail = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetailOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal.MarketplaceDetailOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal.UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsUpdate()); set { {_userDetail = value;} } }

        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailOfferId = value ?? null; }

        /// <summary>Id of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailPlanId = value ?? null; }

        /// <summary>Name of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailPlanName = value ?? null; }

        /// <summary>Id of the product publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailPublisherId = value ?? null; }

        /// <summary>Offer plan term id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailTermId = value ?? null; }

        /// <summary>Offer plan term unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal)MarketplaceDetail).OfferDetailTermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="UserDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdate _userDetail;

        /// <summary>User details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdate UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsUpdate()); set => this._userDetail = value; }

        /// <summary>User email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).EmailAddress = value ?? null; }

        /// <summary>User first name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).FirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).FirstName = value ?? null; }

        /// <summary>User last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).LastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).LastName = value ?? null; }

        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).PhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).PhoneNumber = value ?? null; }

        /// <summary>UPN of user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string UserDetailUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).Upn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdateInternal)UserDetail).Upn = value ?? null; }

        /// <summary>Creates an new <see cref="OrganizationPropertiesCustomUpdate" /> instance.</summary>
        public OrganizationPropertiesCustomUpdate()
        {

        }
    }
    /// Patchable Properties of the Informatica Organization resource
    public partial interface IOrganizationPropertiesCustomUpdate :
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
        /// <summary>Existing Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Existing Resource Id",
        SerializedName = @"existingResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ExistingResourceId { get; set; }
        /// <summary>Informatica Organization properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Informatica Organization properties",
        SerializedName = @"informaticaOrganizationProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate) })]
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate InformaticaOrganizationProperty { get; set; }
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
    /// Patchable Properties of the Informatica Organization resource
    internal partial interface IOrganizationPropertiesCustomUpdateInternal

    {
        /// <summary>Company Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate CompanyDetail { get; set; }
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
        /// <summary>Existing Resource Id</summary>
        string ExistingResourceId { get; set; }
        /// <summary>Informatica Organization properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate InformaticaOrganizationProperty { get; set; }
        /// <summary>Marketplace details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate MarketplaceDetail { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace offer details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate MarketplaceDetailOfferDetail { get; set; }
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
        /// <summary>User details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdate UserDetail { get; set; }
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