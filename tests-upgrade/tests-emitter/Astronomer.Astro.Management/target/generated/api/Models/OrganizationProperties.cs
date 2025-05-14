// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Extensions;

    /// <summary>Properties specific to Data Organization resource</summary>
    public partial class OrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Marketplace" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetails _marketplace;

        /// <summary>Marketplace details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetails Marketplace { get => (this._marketplace = this._marketplace ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.MarketplaceDetails()); set => this._marketplace = value; }

        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string MarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string MarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).SubscriptionStatus = value ?? null; }

        /// <summary>Internal Acessors for Marketplace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.Marketplace { get => (this._marketplace = this._marketplace ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.MarketplaceDetails()); set { {_marketplace = value;} } }

        /// <summary>Internal Acessors for MarketplaceOfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.MarketplaceOfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for OfferDetailEndDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.OfferDetailEndDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailEndDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailEndDate = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for PartnerOrganizationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.PartnerOrganizationProperty { get => (this._partnerOrganizationProperty = this._partnerOrganizationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.PartnerOrganizationProperties()); set { {_partnerOrganizationProperty = value;} } }

        /// <summary>Internal Acessors for PartnerOrganizationPropertySingleSignOnProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.PartnerOrganizationPropertySingleSignOnProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for SingleSignOnPropertyProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.SingleSignOnPropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for User</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationPropertiesInternal.User { get => (this._user = this._user ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.UserDetails()); set { {_user = value;} } }

        /// <summary>Current subscription end date and time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public global::System.DateTime? OfferDetailEndDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailEndDate; }

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailOfferId = value ; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanId = value ; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPlanName = value ?? null; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailPublisherId = value ; }

        /// <summary>Subscription renewal mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailRenewalMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailRenewalMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailRenewalMode = value ?? null; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermId = value ?? null; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetailsInternal)Marketplace).OfferDetailTermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="PartnerOrganizationProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties _partnerOrganizationProperty;

        /// <summary>Organization properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties PartnerOrganizationProperty { get => (this._partnerOrganizationProperty = this._partnerOrganizationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.PartnerOrganizationProperties()); set => this._partnerOrganizationProperty = value; }

        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyOrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationId = value ?? null; }

        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyOrganizationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).OrganizationName = value ?? null; }

        /// <summary>Workspace Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).WorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).WorkspaceId = value ?? null; }

        /// <summary>Workspace name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string PartnerOrganizationPropertyWorkspaceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).WorkspaceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).WorkspaceName = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyAadDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyAadDomain = value ?? null /* arrayOf */; }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyEnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyEnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyEnterpriseAppId = value ?? null; }

        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertyProvisioningState; }

        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnState = value ?? null; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal)PartnerOrganizationProperty).SingleSignOnPropertySingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetails _user;

        /// <summary>Details of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetails User { get => (this._user = this._user ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.UserDetails()); set => this._user = value; }

        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string UserEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).EmailAddress = value ; }

        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string UserFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).FirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).FirstName = value ; }

        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string UserLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).LastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).LastName = value ; }

        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string UserPhoneNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).PhoneNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).PhoneNumber = value ?? null; }

        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string UserUpn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).Upn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetailsInternal)User).Upn = value ?? null; }

        /// <summary>Creates an new <see cref="OrganizationProperties" /> instance.</summary>
        public OrganizationProperties()
        {

        }
    }
    /// Properties specific to Data Organization resource
    public partial interface IOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.IJsonSerializable
    {
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Marketplace subscription status",
        SerializedName = @"subscriptionStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceSubscriptionStatus { get; set; }
        /// <summary>Current subscription end date and time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Current subscription end date and time",
        SerializedName = @"endDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? OfferDetailEndDate { get;  }
        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Publisher Id for the marketplace offer",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPublisherId { get; set; }
        /// <summary>Subscription renewal mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subscription renewal mode",
        SerializedName = @"renewalMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Auto", "Manual")]
        string OfferDetailRenewalMode { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailTermUnit { get; set; }
        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization name in partner's system",
        SerializedName = @"organizationName",
        PossibleTypes = new [] { typeof(string) })]
        string PartnerOrganizationPropertyOrganizationName { get; set; }
        /// <summary>Workspace Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workspace Id in partner's system",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string PartnerOrganizationPropertyWorkspaceId { get; set; }
        /// <summary>Workspace name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workspace name in partner's system",
        SerializedName = @"workspaceName",
        PossibleTypes = new [] { typeof(string) })]
        string PartnerOrganizationPropertyWorkspaceName { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State of the resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string SingleSignOnPropertyProvisioningState { get;  }
        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the Single Sign On for the organization",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
    /// Properties specific to Data Organization resource
    internal partial interface IOrganizationPropertiesInternal

    {
        /// <summary>Marketplace details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetails Marketplace { get; set; }
        /// <summary>Offer details for the marketplace that is selected by the user</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails MarketplaceOfferDetail { get; set; }
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceSubscriptionStatus { get; set; }
        /// <summary>Current subscription end date and time</summary>
        global::System.DateTime? OfferDetailEndDate { get; set; }
        /// <summary>Offer Id for the marketplace offer</summary>
        string OfferDetailOfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        string OfferDetailPlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        string OfferDetailPlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        string OfferDetailPublisherId { get; set; }
        /// <summary>Subscription renewal mode</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Auto", "Manual")]
        string OfferDetailRenewalMode { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        string OfferDetailTermId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        string OfferDetailTermUnit { get; set; }
        /// <summary>Organization properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties PartnerOrganizationProperty { get; set; }
        /// <summary>Organization Id in partner's system</summary>
        string PartnerOrganizationPropertyOrganizationId { get; set; }
        /// <summary>Organization name in partner's system</summary>
        string PartnerOrganizationPropertyOrganizationName { get; set; }
        /// <summary>Single Sign On properties for the organization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties PartnerOrganizationPropertySingleSignOnProperty { get; set; }
        /// <summary>Workspace Id in partner's system</summary>
        string PartnerOrganizationPropertyWorkspaceId { get; set; }
        /// <summary>Workspace name in partner's system</summary>
        string PartnerOrganizationPropertyWorkspaceName { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string SingleSignOnPropertyProvisioningState { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>Details of the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetails User { get; set; }
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