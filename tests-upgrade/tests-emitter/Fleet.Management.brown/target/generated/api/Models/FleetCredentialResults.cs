// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The Credential results response.</summary>
    public partial class FleetCredentialResults :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResults,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResultsInternal
    {

        /// <summary>Backing field for <see cref="Kubeconfig" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResult> _kubeconfig;

        /// <summary>Array of base64-encoded Kubernetes configuration files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResult> Kubeconfig { get => this._kubeconfig; }

        /// <summary>Internal Acessors for Kubeconfig</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResult> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResultsInternal.Kubeconfig { get => this._kubeconfig; set { {_kubeconfig = value;} } }

        /// <summary>Creates an new <see cref="FleetCredentialResults" /> instance.</summary>
        public FleetCredentialResults()
        {

        }
    }
    /// The Credential results response.
    public partial interface IFleetCredentialResults :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>Array of base64-encoded Kubernetes configuration files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of base64-encoded Kubernetes configuration files.",
        SerializedName = @"kubeconfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResult> Kubeconfig { get;  }

    }
    /// The Credential results response.
    internal partial interface IFleetCredentialResultsInternal

    {
        /// <summary>Array of base64-encoded Kubernetes configuration files.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetCredentialResult> Kubeconfig { get; set; }

    }
}