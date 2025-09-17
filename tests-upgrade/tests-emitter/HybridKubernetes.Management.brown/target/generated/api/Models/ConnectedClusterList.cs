// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Extensions;

    /// <summary>The paginated list of connected Clusters</summary>
    public partial class ConnectedClusterList :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterList,
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster> _value;

        /// <summary>The ConnectedCluster items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ConnectedClusterList" /> instance.</summary>
        public ConnectedClusterList()
        {

        }
    }
    /// The paginated list of connected Clusters
    public partial interface IConnectedClusterList :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ConnectedCluster items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ConnectedCluster items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster> Value { get; set; }

    }
    /// The paginated list of connected Clusters
    internal partial interface IConnectedClusterListInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ConnectedCluster items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster> Value { get; set; }

    }
}