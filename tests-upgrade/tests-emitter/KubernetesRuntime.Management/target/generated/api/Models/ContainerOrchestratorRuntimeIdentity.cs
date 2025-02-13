// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    public partial class ContainerOrchestratorRuntimeIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal
    {

        /// <summary>Backing field for <see cref="BgpPeerName" /> property.</summary>
        private string _bgpPeerName;

        /// <summary>The name of the BgpPeer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string BgpPeerName { get => this._bgpPeerName; set => this._bgpPeerName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LoadBalancerName" /> property.</summary>
        private string _loadBalancerName;

        /// <summary>The name of the LoadBalancer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string LoadBalancerName { get => this._loadBalancerName; set => this._loadBalancerName = value; }

        /// <summary>Backing field for <see cref="ResourceUri" /> property.</summary>
        private string _resourceUri;

        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string ResourceUri { get => this._resourceUri; set => this._resourceUri = value; }

        /// <summary>Backing field for <see cref="ServiceName" /> property.</summary>
        private string _serviceName;

        /// <summary>The name of the the service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string ServiceName { get => this._serviceName; set => this._serviceName = value; }

        /// <summary>Backing field for <see cref="StorageClassName" /> property.</summary>
        private string _storageClassName;

        /// <summary>The name of the the storage class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string StorageClassName { get => this._storageClassName; set => this._storageClassName = value; }

        /// <summary>Creates an new <see cref="ContainerOrchestratorRuntimeIdentity" /> instance.</summary>
        public ContainerOrchestratorRuntimeIdentity()
        {

        }
    }
    public partial interface IContainerOrchestratorRuntimeIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable
    {
        /// <summary>The name of the BgpPeer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the BgpPeer",
        SerializedName = @"bgpPeerName",
        PossibleTypes = new [] { typeof(string) })]
        string BgpPeerName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the LoadBalancer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the LoadBalancer",
        SerializedName = @"loadBalancerName",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerName { get; set; }
        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified Azure Resource manager identifier of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceUri { get; set; }
        /// <summary>The name of the the service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the the service",
        SerializedName = @"serviceName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceName { get; set; }
        /// <summary>The name of the the storage class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the the storage class",
        SerializedName = @"storageClassName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageClassName { get; set; }

    }
    internal partial interface IContainerOrchestratorRuntimeIdentityInternal

    {
        /// <summary>The name of the BgpPeer</summary>
        string BgpPeerName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the LoadBalancer</summary>
        string LoadBalancerName { get; set; }
        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        string ResourceUri { get; set; }
        /// <summary>The name of the the service</summary>
        string ServiceName { get; set; }
        /// <summary>The name of the the storage class</summary>
        string StorageClassName { get; set; }

    }
}