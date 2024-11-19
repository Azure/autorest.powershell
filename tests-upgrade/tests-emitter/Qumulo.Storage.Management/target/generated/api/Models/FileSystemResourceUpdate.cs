// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>The type used for update operations of the FileSystemResource.</summary>
    public partial class FileSystemResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal
    {

        /// <summary>Delegated subnet id for Vnet injection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string DelegatedSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).DelegatedSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).DelegatedSubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Marketplace Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionId = value ?? null; }

        /// <summary>Marketplace subscription status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailMarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionStatus; }

        /// <summary>Offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailOfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailOfferId = value ?? null; }

        /// <summary>Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailPlanId = value ?? null; }

        /// <summary>Publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailPublisherId = value ?? null; }

        /// <summary>Term Unit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string MarketplaceDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailTermUnit = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for MarketplaceDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.MarketplaceDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetail = value; }

        /// <summary>Internal Acessors for MarketplaceDetailMarketplaceSubscriptionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.MarketplaceDetailMarketplaceSubscriptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).MarketplaceDetailMarketplaceSubscriptionStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for UserDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal.UserDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).UserDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).UserDetail = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties _property;

        /// <summary>The updatable properties of the FileSystemResource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdateProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.Tags()); set => this._tag = value; }

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Inlined)]
        public string UserDetailEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).UserDetailEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdatePropertiesInternal)Property).UserDetailEmail = value ?? null; }

        /// <summary>Creates an new <see cref="FileSystemResourceUpdate" /> instance.</summary>
        public FileSystemResourceUpdate()
        {

        }
    }
    /// The type used for update operations of the FileSystemResource.
    public partial interface IFileSystemResourceUpdate :
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
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags Tag { get; set; }
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
    /// The type used for update operations of the FileSystemResource.
    internal partial interface IFileSystemResourceUpdateInternal

    {
        /// <summary>Delegated subnet id for Vnet injection</summary>
        string DelegatedSubnetId { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>The updatable properties of the FileSystemResource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties Property { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags Tag { get; set; }
        /// <summary>User Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails UserDetail { get; set; }
        /// <summary>User Email</summary>
        string UserDetailEmail { get; set; }

    }
}