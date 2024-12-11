// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Extensions;

    /// <summary>Offer details for the marketplace that is selected by the user</summary>
    public partial class OfferDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOfferDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOfferDetailsInternal
    {

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Backing field for <see cref="PlanName" /> property.</summary>
        private string _planName;

        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string PlanName { get => this._planName; set => this._planName = value; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; set => this._publisherId = value; }

        /// <summary>Backing field for <see cref="TermId" /> property.</summary>
        private string _termId;

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string TermId { get => this._termId; set => this._termId = value; }

        /// <summary>Backing field for <see cref="TermUnit" /> property.</summary>
        private string _termUnit;

        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string TermUnit { get => this._termUnit; set => this._termUnit = value; }

        /// <summary>Creates an new <see cref="OfferDetails" /> instance.</summary>
        public OfferDetails()
        {

        }
    }
    /// Offer details for the marketplace that is selected by the user
    public partial interface IOfferDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.IJsonSerializable
    {
        /// <summary>Offer Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer Id for the marketplace offer",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Id for the marketplace offer",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Name for the marketplace offer",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Publisher Id for the marketplace offer",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termId",
        PossibleTypes = new [] { typeof(string) })]
        string TermId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Display Name for the marketplace offer",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string TermUnit { get; set; }

    }
    /// Offer details for the marketplace that is selected by the user
    internal partial interface IOfferDetailsInternal

    {
        /// <summary>Offer Id for the marketplace offer</summary>
        string OfferId { get; set; }
        /// <summary>Plan Id for the marketplace offer</summary>
        string PlanId { get; set; }
        /// <summary>Plan Name for the marketplace offer</summary>
        string PlanName { get; set; }
        /// <summary>Publisher Id for the marketplace offer</summary>
        string PublisherId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        string TermId { get; set; }
        /// <summary>Plan Display Name for the marketplace offer</summary>
        string TermUnit { get; set; }

    }
}