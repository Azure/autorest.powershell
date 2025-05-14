// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The type used for update operations of the DataProduct.</summary>
    public partial class DataProductUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateInternal
    {

        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CurrentMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).CurrentMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).CurrentMinorVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4Internal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductUpdateProperties()); set { {_property = value;} } }

        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Owner { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).Owner; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).Owner = value ?? null /* arrayOf */; }

        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PrivateLinksEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).PrivateLinksEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).PrivateLinksEnabled = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductUpdateProperties()); set => this._property = value; }

        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PurviewAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).PurviewAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).PurviewAccount = value ?? null; }

        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string PurviewCollection { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).PurviewCollection; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal)Property).PurviewCollection = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="DataProductUpdate" /> instance.</summary>
        public DataProductUpdate()
        {

        }
    }
    /// The type used for update operations of the DataProduct.
    public partial interface IDataProductUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = false,
        Update = true,
        Description = @"Current configured minor version of the data product resource.",
        SerializedName = @"currentMinorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentMinorVersion { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of name or email associated with data product resource deployment.",
        SerializedName = @"owners",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to enable or disable private link for data product resource.",
        SerializedName = @"privateLinksEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview account url for data product to connect to.",
        SerializedName = @"purviewAccount",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview collection url for data product to connect to.",
        SerializedName = @"purviewCollection",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewCollection { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags Tag { get; set; }

    }
    /// The type used for update operations of the DataProduct.
    internal partial interface IDataProductUpdateInternal

    {
        /// <summary>Current configured minor version of the data product resource.</summary>
        string CurrentMinorVersion { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4 Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateProperties Property { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        string PurviewCollection { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITags Tag { get; set; }

    }
}