// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the managed identities for an Azure resource.</summary>
    public partial class ManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The principal id of the managed identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// The tenant id of the managed identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of managed identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities _userAssignedIdentity;

        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities UserAssignedIdentity { get => (this._userAssignedIdentity = this._userAssignedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedIdentityUserAssignedIdentities()); set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="ManagedIdentity" /> instance.</summary>
        public ManagedIdentity()
        {

        }
    }
    /// Describes the managed identities for an Azure resource.
    public partial interface IManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The principal id of the managed identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The principal id of the managed identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>
        /// The tenant id of the managed identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant id of the managed identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>The type of managed identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity for the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string Type { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form:
        '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
    /// Describes the managed identities for an Azure resource.
    internal partial interface IManagedIdentityInternal

    {
        /// <summary>
        /// The principal id of the managed identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>
        /// The tenant id of the managed identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string TenantId { get; set; }
        /// <summary>The type of managed identity for the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string Type { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
}