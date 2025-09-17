// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Identities for the virtual machine scale set under the node type.</summary>
    public partial class VMManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentityInternal
    {

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private System.Collections.Generic.List<string> _userAssignedIdentity;

        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UserAssignedIdentity { get => this._userAssignedIdentity; set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="VMManagedIdentity" /> instance.</summary>
        public VMManagedIdentity()
        {

        }
    }
    /// Identities for the virtual machine scale set under the node type.
    public partial interface IVMManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UserAssignedIdentity { get; set; }

    }
    /// Identities for the virtual machine scale set under the node type.
    internal partial interface IVMManagedIdentityInternal

    {
        /// <summary>
        /// The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        System.Collections.Generic.List<string> UserAssignedIdentity { get; set; }

    }
}