// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Marketplace details.</summary>
    public partial class MarketplaceDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal
    {

        /// <summary>Backing field for <see cref="MarketplaceSubscriptionId" /> property.</summary>
        private string _marketplaceSubscriptionId;

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string MarketplaceSubscriptionId { get => this._marketplaceSubscriptionId; set => this._marketplaceSubscriptionId = value; }

        /// <summary>Internal Acessors for OfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsInternal.OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetails()); set { {_offerDetail = value;} } }

        /// <summary>Backing field for <see cref="OfferDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails _offerDetail;

        /// <summary>Marketplace offer details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetails()); set => this._offerDetail = value; }

        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).OfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).OfferId = value ; }

        /// <summary>Id of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).PlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).PlanId = value ; }

        /// <summary>Name of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).PlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).PlanName = value ; }

        /// <summary>Id of the product publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).PublisherId = value ; }

        /// <summary>Offer plan term id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).TermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).TermId = value ; }

        /// <summary>Offer plan term unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).TermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsInternal)OfferDetail).TermUnit = value ?? null; }

        /// <summary>Creates an new <see cref="MarketplaceDetails" /> instance.</summary>
        public MarketplaceDetails()
        {

        }
    }
    /// Marketplace details.
    public partial interface IMarketplaceDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
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
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
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
        Required = true,
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
        Required = true,
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
        Required = true,
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
        Required = true,
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

    }
    /// Marketplace details.
    internal partial interface IMarketplaceDetailsInternal

    {
        /// <summary>Marketplace Subscription Id</summary>
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace offer details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails OfferDetail { get; set; }
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

    }
}