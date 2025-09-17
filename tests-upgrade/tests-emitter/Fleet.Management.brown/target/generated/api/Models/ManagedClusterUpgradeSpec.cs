// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The upgrade to apply to a ManagedCluster.</summary>
    public partial class ManagedClusterUpgradeSpec :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpecInternal
    {

        /// <summary>Backing field for <see cref="KubernetesVersion" /> property.</summary>
        private string _kubernetesVersion;

        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string KubernetesVersion { get => this._kubernetesVersion; set => this._kubernetesVersion = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ManagedClusterUpgradeSpec" /> instance.</summary>
        public ManagedClusterUpgradeSpec()
        {

        }
    }
    /// The upgrade to apply to a ManagedCluster.
    public partial interface IManagedClusterUpgradeSpec :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
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
        string KubernetesVersion { get; set; }
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
        string Type { get; set; }

    }
    /// The upgrade to apply to a ManagedCluster.
    internal partial interface IManagedClusterUpgradeSpecInternal

    {
        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        string KubernetesVersion { get; set; }
        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Full", "NodeImageOnly", "ControlPlaneOnly")]
        string Type { get; set; }

    }
}