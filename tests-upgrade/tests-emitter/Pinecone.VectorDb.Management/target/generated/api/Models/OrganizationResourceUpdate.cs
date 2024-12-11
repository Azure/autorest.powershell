// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Extensions;

    /// <summary>The type used for update operations of the Organization Resource.</summary>
    public partial class OrganizationResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOrganizationResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOrganizationResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOrganizationResourceUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOrganizationResourceUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IOrganizationResourceUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="OrganizationResourceUpdate" /> instance.</summary>
        public OrganizationResourceUpdate()
        {

        }
    }
    /// The type used for update operations of the Organization Resource.
    public partial interface IOrganizationResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ITags Tag { get; set; }

    }
    /// The type used for update operations of the Organization Resource.
    internal partial interface IOrganizationResourceUpdateInternal

    {
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ITags Tag { get; set; }

    }
}