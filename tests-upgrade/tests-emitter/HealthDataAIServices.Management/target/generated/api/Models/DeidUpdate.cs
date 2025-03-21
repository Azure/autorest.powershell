// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>Patch request body for DeidService</summary>
    public partial class DeidUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidUpdateInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdate _identity;

        /// <summary>Updatable managed service identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdate Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ManagedServiceIdentityUpdate()); set => this._identity = value; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdateInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdateInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdateInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdateInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdate Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ManagedServiceIdentityUpdate()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.DeidPropertiesUpdate()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdate _property;

        /// <summary>RP-specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.DeidPropertiesUpdate()); set => this._property = value; }

        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdateInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdateInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="DeidUpdate" /> instance.</summary>
        public DeidUpdate()
        {

        }
    }
    /// Patch request body for DeidService
    public partial interface IDeidUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
    {
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets allow or disallow public network access to resource",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ITags Tag { get; set; }

    }
    /// Patch request body for DeidService
    internal partial interface IDeidUpdateInternal

    {
        /// <summary>Updatable managed service identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IManagedServiceIdentityUpdate Identity { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>RP-specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdate Property { get; set; }
        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ITags Tag { get; set; }

    }
}