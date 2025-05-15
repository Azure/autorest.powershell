// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>The updatable properties of the FileSystemResource.</summary>
    public partial class FileSystemResourceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DelegatedSubnetId" /> property.</summary>
        private string _delegatedSubnetId;

        /// <summary>Delegated subnet id for Vnet injection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string DelegatedSubnetId { get => this._delegatedSubnetId; set => this._delegatedSubnetId = value; }

        /// <summary>Backing field for <see cref="MarketplaceDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails _marketplaceDetail;

        /// <summary>Marketplace details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetails()); set => this._marketplaceDetail = value; }

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionStatus; }

        /// <summary>Offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).OfferId = value ?? null; }

        /// <summary>Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).PlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).PlanId = value ?? null; }

        /// <summary>Publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).PublisherId = value ?? null; }

        /// <summary>Term Unit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).TermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).TermUnit = value ?? null; }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal.MarketplaceDetail { get => (this._marketplaceDetail = this._marketplaceDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetails()); set { {_marketplaceDetail = value;} } }

        /// <summary>Internal Acessors for MarketplaceDetailMarketplaceSubscriptionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal.MarketplaceDetailMarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetailsInternal)MarketplaceDetail).MarketplaceSubscriptionStatus = value ?? null; }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal.UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetails()); set { {_userDetail = value;} } }

        /// <summary>Backing field for <see cref="UserDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails _userDetail;

        /// <summary>User Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails UserDetail { get => (this._userDetail = this._userDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetails()); set => this._userDetail = value; }

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string UserDetailEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetailsInternal)UserDetail).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetailsInternal)UserDetail).Email = value ?? null; }

        /// <summary>Creates an new <see cref="FileSystemResourceUpdateProperties" /> instance.</summary>
        public FileSystemResourceUpdateProperties()
        {

        }
    }
    /// The updatable properties of the FileSystemResource.
    public partial interface IFileSystemResourceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IJsonSerializable
    {
        /// <summary>Delegated subnet id for Vnet injection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Delegated subnet id for Vnet injection",
        SerializedName = @"delegatedSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedSubnetId { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Marketplace Subscription Id",
        SerializedName = @"marketplaceSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Marketplace subscription status",
        SerializedName = @"marketplaceSubscriptionStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceDetailMarketplaceSubscriptionStatus { get;  }
        /// <summary>Offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offer Id",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailOfferId { get; set; }
        /// <summary>Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Plan Id",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailPlanId { get; set; }
        /// <summary>Publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Publisher Id",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailPublisherId { get; set; }
        /// <summary>Term Unit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Term Unit",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceDetailTermUnit { get; set; }
        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Email",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string UserDetailEmail { get; set; }

    }
    /// The updatable properties of the FileSystemResource.
    internal partial interface IFileSystemResourceUpdatePropertiesInternal

    {
        /// <summary>Delegated subnet id for Vnet injection</summary>
        string DelegatedSubnetId { get; set; }
        /// <summary>Marketplace details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails MarketplaceDetail { get; set; }
        /// <summary>Marketplace Subscription Id</summary>
        string MarketplaceDetailMarketplaceSubscriptionId { get; set; }
        /// <summary>Marketplace subscription status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("PendingFulfillmentStart", "Subscribed", "Suspended", "Unsubscribed")]
        string MarketplaceDetailMarketplaceSubscriptionStatus { get; set; }
        /// <summary>Offer Id</summary>
        string MarketplaceDetailOfferId { get; set; }
        /// <summary>Plan Id</summary>
        string MarketplaceDetailPlanId { get; set; }
        /// <summary>Publisher Id</summary>
        string MarketplaceDetailPublisherId { get; set; }
        /// <summary>Term Unit</summary>
        string MarketplaceDetailTermUnit { get; set; }
        /// <summary>User Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails UserDetail { get; set; }
        /// <summary>User Email</summary>
        string UserDetailEmail { get; set; }

    }
}