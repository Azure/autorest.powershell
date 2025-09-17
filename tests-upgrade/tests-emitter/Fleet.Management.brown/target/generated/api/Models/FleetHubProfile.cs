// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The FleetHubProfile configures the fleet hub.</summary>
    public partial class FleetHubProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal
    {

        /// <summary>Backing field for <see cref="AgentProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile _agentProfile;

        /// <summary>The agent profile for the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile AgentProfile { get => (this._agentProfile = this._agentProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfile()); set => this._agentProfile = value; }

        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AgentProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfileInternal)AgentProfile).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfileInternal)AgentProfile).SubnetId = value ?? null; }

        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AgentProfileVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfileInternal)AgentProfile).VMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfileInternal)AgentProfile).VMSize = value ?? null; }

        /// <summary>Backing field for <see cref="ApiServerAccessProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile _apiServerAccessProfile;

        /// <summary>The access profile for the Fleet hub API server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile ApiServerAccessProfile { get => (this._apiServerAccessProfile = this._apiServerAccessProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfile()); set => this._apiServerAccessProfile = value; }

        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? ApiServerAccessProfileEnablePrivateCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal)ApiServerAccessProfile).EnablePrivateCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal)ApiServerAccessProfile).EnablePrivateCluster = value ?? default(bool); }

        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? ApiServerAccessProfileEnableVnetIntegration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal)ApiServerAccessProfile).EnableVnetIntegration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal)ApiServerAccessProfile).EnableVnetIntegration = value ?? default(bool); }

        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ApiServerAccessProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal)ApiServerAccessProfile).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal)ApiServerAccessProfile).SubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="DnsPrefix" /> property.</summary>
        private string _dnsPrefix;

        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string DnsPrefix { get => this._dnsPrefix; set => this._dnsPrefix = value; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>The FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>Backing field for <see cref="KubernetesVersion" /> property.</summary>
        private string _kubernetesVersion;

        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string KubernetesVersion { get => this._kubernetesVersion; }

        /// <summary>Internal Acessors for AgentProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal.AgentProfile { get => (this._agentProfile = this._agentProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfile()); set { {_agentProfile = value;} } }

        /// <summary>Internal Acessors for ApiServerAccessProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal.ApiServerAccessProfile { get => (this._apiServerAccessProfile = this._apiServerAccessProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfile()); set { {_apiServerAccessProfile = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for KubernetesVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal.KubernetesVersion { get => this._kubernetesVersion; set { {_kubernetesVersion = value;} } }

        /// <summary>Internal Acessors for PortalFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal.PortalFqdn { get => this._portalFqdn; set { {_portalFqdn = value;} } }

        /// <summary>Backing field for <see cref="PortalFqdn" /> property.</summary>
        private string _portalFqdn;

        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string PortalFqdn { get => this._portalFqdn; }

        /// <summary>Creates an new <see cref="FleetHubProfile" /> instance.</summary>
        public FleetHubProfile()
        {

        }
    }
    /// The FleetHubProfile configures the fleet hub.
    public partial interface IFleetHubProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be generated and used.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string AgentProfileSubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The virtual machine size of the Fleet hub.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string AgentProfileVMSize { get; set; }
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to create the Fleet hub as a private cluster or not.",
        SerializedName = @"enablePrivateCluster",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApiServerAccessProfileEnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to enable apiserver vnet integration for the Fleet hub or not.",
        SerializedName = @"enableVnetIntegration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApiServerAccessProfileEnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string ApiServerAccessProfileSubnetId { get; set; }
        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"DNS prefix used to create the FQDN for the Fleet hub.",
        SerializedName = @"dnsPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string DnsPrefix { get; set; }
        /// <summary>The FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The FQDN of the Fleet hub.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Kubernetes version of the Fleet hub.",
        SerializedName = @"kubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KubernetesVersion { get;  }
        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Azure Portal FQDN of the Fleet hub.",
        SerializedName = @"portalFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string PortalFqdn { get;  }

    }
    /// The FleetHubProfile configures the fleet hub.
    internal partial interface IFleetHubProfileInternal

    {
        /// <summary>The agent profile for the Fleet hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile AgentProfile { get; set; }
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        string AgentProfileSubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        string AgentProfileVMSize { get; set; }
        /// <summary>The access profile for the Fleet hub API server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile ApiServerAccessProfile { get; set; }
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        bool? ApiServerAccessProfileEnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        bool? ApiServerAccessProfileEnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        string ApiServerAccessProfileSubnetId { get; set; }
        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        string DnsPrefix { get; set; }
        /// <summary>The FQDN of the Fleet hub.</summary>
        string Fqdn { get; set; }
        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        string KubernetesVersion { get; set; }
        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        string PortalFqdn { get; set; }

    }
}