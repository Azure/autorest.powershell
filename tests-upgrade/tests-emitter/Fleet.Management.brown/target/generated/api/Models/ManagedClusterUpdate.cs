// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The update to be applied to the ManagedClusters.</summary>
    public partial class ManagedClusterUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal
    {

        /// <summary>Internal Acessors for NodeImageSelection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal.NodeImageSelection { get => (this._nodeImageSelection = this._nodeImageSelection ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.NodeImageSelection()); set { {_nodeImageSelection = value;} } }

        /// <summary>Internal Acessors for Upgrade</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal.Upgrade { get => (this._upgrade = this._upgrade ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec()); set { {_upgrade = value;} } }

        /// <summary>Backing field for <see cref="NodeImageSelection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection _nodeImageSelection;

        /// <summary>The node image upgrade to be applied to the target nodes in update run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection NodeImageSelection { get => (this._nodeImageSelection = this._nodeImageSelection ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.NodeImageSelection()); set => this._nodeImageSelection = value; }

        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionCustomNodeImageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionInternal)NodeImageSelection).CustomNodeImageVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionInternal)NodeImageSelection).CustomNodeImageVersion = value ?? null /* arrayOf */; }

        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string NodeImageSelectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionInternal)NodeImageSelection).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionInternal)NodeImageSelection).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Upgrade" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec _upgrade;

        /// <summary>The upgrade to apply to the ManagedClusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec Upgrade { get => (this._upgrade = this._upgrade ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedClusterUpgradeSpec()); set => this._upgrade = value; }

        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpgradeKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpecInternal)Upgrade).KubernetesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpecInternal)Upgrade).KubernetesVersion = value ?? null; }

        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpgradeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpecInternal)Upgrade).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpecInternal)Upgrade).Type = value ; }

        /// <summary>Creates an new <see cref="ManagedClusterUpdate" /> instance.</summary>
        public ManagedClusterUpdate()
        {

        }
    }
    /// The update to be applied to the ManagedClusters.
    public partial interface IManagedClusterUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise, it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.",
        SerializedName = @"customNodeImageVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionCustomNodeImageVersion { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The node image upgrade type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent", "Custom")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Kubernetes version to upgrade the member clusters to.",
        SerializedName = @"kubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeKubernetesVersion { get; set; }
        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ManagedClusterUpgradeType is the type of upgrade to be applied.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Full", "NodeImageOnly", "ControlPlaneOnly")]
        string UpgradeType { get; set; }

    }
    /// The update to be applied to the ManagedClusters.
    internal partial interface IManagedClusterUpdateInternal

    {
        /// <summary>The node image upgrade to be applied to the target nodes in update run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection NodeImageSelection { get; set; }
        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionCustomNodeImageVersion { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent", "Custom")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The upgrade to apply to the ManagedClusters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec Upgrade { get; set; }
        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        string UpgradeKubernetesVersion { get; set; }
        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Full", "NodeImageOnly", "ControlPlaneOnly")]
        string UpgradeType { get; set; }

    }
}