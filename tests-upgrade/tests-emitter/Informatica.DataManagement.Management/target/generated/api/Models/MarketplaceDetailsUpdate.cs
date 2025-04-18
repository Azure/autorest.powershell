// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Marketplace details</summary>
    public partial class MarketplaceDetailsUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal
    {

        /// <summary>Backing field for <see cref="MarketplaceSubscriptionId" /> property.</summary>
        private string _marketplaceSubscriptionId;

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string MarketplaceSubscriptionId { get => this._marketplaceSubscriptionId; set => this._marketplaceSubscriptionId = value; }

        /// <summary>Internal Acessors for OfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdateInternal.OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsUpdate()); set { {_offerDetail = value;} } }

        /// <summary>Backing field for <see cref="OfferDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate _offerDetail;

        /// <summary>Marketplace offer details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsUpdate()); set => this._offerDetail = value; }

        /// <summary>Id of the product offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).OfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).OfferId = value ?? null; }

        /// <summary>Id of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).PlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).PlanId = value ?? null; }

        /// <summary>Name of the product offer plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).PlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).PlanName = value ?? null; }

        /// <summary>Id of the product publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).PublisherId = value ?? null; }

        /// <summary>Offer plan term id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).TermId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).TermId = value ?? null; }

        /// <summary>Offer plan term unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).TermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdateInternal)OfferDetail).TermUnit = value ?? null; }

        /// <summary>Creates an new <see cref="MarketplaceDetailsUpdate" /> instance.</summary>
        public MarketplaceDetailsUpdate()
        {

        }
    }
    /// Marketplace details
    public partial interface IMarketplaceDetailsUpdate :
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

    }
    /// Marketplace details
    internal partial interface IMarketplaceDetailsUpdateInternal

    {
        /// <summary>Marketplace Subscription Id</summary>
        string MarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace offer details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate OfferDetail { get; set; }
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