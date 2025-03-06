// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Extensions;

    /// <summary>Properties specific to Organization</summary>
    public partial class OrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Marketplace" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails _marketplace;

        /// <summary>Marketplace details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails Marketplace { get => (this._marketplace = this._marketplace ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.MarketplaceDetails()); set => this._marketplace = value; }

        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string MarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionId = value ; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string MarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionStatus; }

        /// <summary>Internal Acessors for Marketplace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal.Marketplace { get => (this._marketplace = this._marketplace ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.MarketplaceDetails()); set { {_marketplace = value;} } }

        /// <summary>Internal Acessors for MarketplaceOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal.MarketplaceOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetail = value; }

        /// <summary>Internal Acessors for MarketplaceSubscriptionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal.MarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionStatus = value; }

        /// <summary>Internal Acessors for PartnerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal.PartnerProperty { get => (this._partnerProperty = this._partnerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.PartnerProperties()); set { {_partnerProperty = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for User</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal.User { get => (this._user = this._user ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserDetails()); set { {_user = value;} } }

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailOfferId = value ; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanId = value ; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanName = value ?? null; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPublisherId = value ; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermId = value ?? null; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="PartnerProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties _partnerProperty;

        /// <summary>partner properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties PartnerProperty { get => (this._partnerProperty = this._partnerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.PartnerProperties()); set => this._partnerProperty = value; }

        /// <summary>The number of licenses subscribed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public int? PartnerPropertyLicensesSubscribed { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerPropertiesInternal)PartnerProperty).LicensesSubscribed; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerPropertiesInternal)PartnerProperty).LicensesSubscribed = value ?? default(int); }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails _user;

        /// <summary>Details of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails User { get => (this._user = this._user ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserDetails()); set => this._user = value; }

        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string UserEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).EmailAddress = value ; }

        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string UserFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).FirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).FirstName = value ; }

        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string UserLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).LastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).LastName = value ; }

        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string UserPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).PhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).PhoneNumber = value ?? null; }

        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Inlined)]
        public string UserUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).Upn; set => ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal)User).Upn = value ?? null; }

        /// <summary>Creates an new <see cref="OrganizationProperties" /> instance.</summary>
        public OrganizationProperties()
        {

        }
    }
    /// Properties specific to Organization
    public partial interface IOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.IJsonSerializable
    {
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure subscription id for the the marketplace offer is purchased from",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Marketplace subscription status",
        SerializedName = @"subscriptionStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceSubscriptionStatus { get;  }
        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer Id for the marketplace offer",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailOfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Id for the marketplace offer",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Publisher Id for the marketplace offer",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPublisherId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermUnit { get; set; }
        /// <summary>The number of licenses subscribed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of licenses subscribed",
        SerializedName = @"licensesSubscribed",
        PossibleTypes = new [] { typeof(int) })]
        int? PartnerPropertyLicensesSubscribed { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Email address of the user",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string UserEmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"First name of the user",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string UserFirstName { get; set; }
        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last name of the user",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string UserLastName { get; set; }
        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
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
    /// Properties specific to Organization
    internal partial interface IOrganizationPropertiesInternal

    {
        /// <summary>Marketplace details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails Marketplace { get; set; }
        /// <summary>Offer details for the marketplace that is selected by the user</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOfferDetails MarketplaceOfferDetail { get; set; }
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
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
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties PartnerProperty { get; set; }
        /// <summary>The number of licenses subscribed</summary>
        int? PartnerPropertyLicensesSubscribed { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Details of the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails User { get; set; }
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