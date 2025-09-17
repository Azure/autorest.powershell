// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The node image upgrade to be applied to the target nodes in update run.</summary>
    public partial class NodeImageSelection :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionInternal
    {

        /// <summary>Backing field for <see cref="CustomNodeImageVersion" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> _customNodeImageVersion;

        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> CustomNodeImageVersion { get => this._customNodeImageVersion; set => this._customNodeImageVersion = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="NodeImageSelection" /> instance.</summary>
        public NodeImageSelection()
        {

        }
    }
    /// The node image upgrade to be applied to the target nodes in update run.
    public partial interface INodeImageSelection :
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
        Update = true,
        Description = @"Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise, it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.",
        SerializedName = @"customNodeImageVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> CustomNodeImageVersion { get; set; }
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
        string Type { get; set; }

    }
    /// The node image upgrade to be applied to the target nodes in update run.
    internal partial interface INodeImageSelectionInternal

    {
        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> CustomNodeImageVersion { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent", "Custom")]
        string Type { get; set; }

    }
}