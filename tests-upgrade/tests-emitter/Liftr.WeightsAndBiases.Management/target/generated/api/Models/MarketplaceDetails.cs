// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;

    /// <summary>Marketplace details for an organization</summary>
    public partial class MarketplaceDetails :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetailsInternal
    {

        /// <summary>Internal Acessors for OfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetailsInternal.OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.OfferDetails()); set { {_offerDetail = value;} } }

        /// <summary>Internal Acessors for SubscriptionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetailsInternal.SubscriptionStatus { get => this._subscriptionStatus; set { {_subscriptionStatus = value;} } }

        /// <summary>Backing field for <see cref="OfferDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails _offerDetail;

        /// <summary>Offer details for the marketplace that is selected by the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.OfferDetails()); set => this._offerDetail = value; }

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).OfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).OfferId = value ; }

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).PlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).PlanId = value ; }

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).PlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).PlanName = value ?? null; }

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).PublisherId = value ; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).TermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).TermId = value ?? null; }

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).TermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetailsInternal)OfferDetail).TermUnit = value ?? null; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="SubscriptionStatus" /> property.</summary>
        private string _subscriptionStatus;

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string SubscriptionStatus { get => this._subscriptionStatus; }

        /// <summary>Creates an new <see cref="MarketplaceDetails" /> instance.</summary>
        public MarketplaceDetails()
        {

        }
    }
    /// Marketplace details for an organization
    public partial interface IMarketplaceDetails :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IJsonSerializable
    {
        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
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
        string SubscriptionId { get; set; }
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
        string SubscriptionStatus { get;  }

    }
    /// Marketplace details for an organization
    internal partial interface IMarketplaceDetailsInternal

    {
        /// <summary>Offer details for the marketplace that is selected by the user</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails OfferDetail { get; set; }
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
        /// <summary>Azure subscription id for the the marketplace offer is purchased from</summary>
        string SubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string SubscriptionStatus { get; set; }

    }
}