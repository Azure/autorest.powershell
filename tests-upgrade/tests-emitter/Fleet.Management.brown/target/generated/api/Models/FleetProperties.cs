// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>Fleet properties.</summary>
    public partial class FleetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal
    {

        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AgentProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).AgentProfileSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).AgentProfileSubnetId = value ?? null; }

        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AgentProfileVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).AgentProfileVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).AgentProfileVMSize = value ?? null; }

        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? ApiServerAccessProfileEnablePrivateCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfileEnablePrivateCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfileEnablePrivateCluster = value ?? default(bool); }

        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? ApiServerAccessProfileEnableVnetIntegration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfileEnableVnetIntegration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfileEnableVnetIntegration = value ?? default(bool); }

        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ApiServerAccessProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfileSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfileSubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="HubProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile _hubProfile;

        /// <summary>The FleetHubProfile configures the Fleet's hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile HubProfile { get => (this._hubProfile = this._hubProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfile()); set => this._hubProfile = value; }

        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfileDnsPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).DnsPrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).DnsPrefix = value ?? null; }

        /// <summary>The FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfileFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).Fqdn; }

        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfileKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).KubernetesVersion; }

        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfilePortalFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).PortalFqdn; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorAdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorCode; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorDetail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorMessage; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorTarget; }

        /// <summary>Internal Acessors for HubProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.HubProfile { get => (this._hubProfile = this._hubProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfile()); set { {_hubProfile = value;} } }

        /// <summary>Internal Acessors for HubProfileAgentProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.HubProfileAgentProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).AgentProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).AgentProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HubProfileApiServerAccessProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.HubProfileApiServerAccessProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).ApiServerAccessProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HubProfileFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.HubProfileFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).Fqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).Fqdn = value ?? null; }

        /// <summary>Internal Acessors for HubProfileKubernetesVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.HubProfileKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).KubernetesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).KubernetesVersion = value ?? null; }

        /// <summary>Internal Acessors for HubProfilePortalFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.HubProfilePortalFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).PortalFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)HubProfile).PortalFqdn = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorAdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorAdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorCode = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorMessage = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationErrorTarget = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusLastOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.StatusLastOperationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal.StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationId = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus _status;

        /// <summary>Status information for the fleet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetStatus()); }

        /// <summary>The last operation ID for the fleet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatusInternal)Status).LastOperationId; }

        /// <summary>Creates an new <see cref="FleetProperties" /> instance.</summary>
        public FleetProperties()
        {

        }
    }
    /// Fleet properties.
    public partial interface IFleetProperties :
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
        string HubProfileDnsPrefix { get; set; }
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
        string HubProfileFqdn { get;  }
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
        string HubProfileKubernetesVersion { get;  }
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
        string HubProfilePortalFqdn { get;  }
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorTarget { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Updating", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>The last operation ID for the fleet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The last operation ID for the fleet.",
        SerializedName = @"lastOperationId",
        PossibleTypes = new [] { typeof(string) })]
        string StatusLastOperationId { get;  }

    }
    /// Fleet properties.
    internal partial interface IFleetPropertiesInternal

    {
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        string AgentProfileSubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        string AgentProfileVMSize { get; set; }
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        bool? ApiServerAccessProfileEnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        bool? ApiServerAccessProfileEnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        string ApiServerAccessProfileSubnetId { get; set; }
        /// <summary>The FleetHubProfile configures the Fleet's hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile HubProfile { get; set; }
        /// <summary>The agent profile for the Fleet hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile HubProfileAgentProfile { get; set; }
        /// <summary>The access profile for the Fleet hub API server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile HubProfileApiServerAccessProfile { get; set; }
        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        string HubProfileDnsPrefix { get; set; }
        /// <summary>The FQDN of the Fleet hub.</summary>
        string HubProfileFqdn { get; set; }
        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        string HubProfileKubernetesVersion { get; set; }
        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        string HubProfilePortalFqdn { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string LastOperationErrorCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get; set; }
        /// <summary>The error message.</summary>
        string LastOperationErrorMessage { get; set; }
        /// <summary>The error target.</summary>
        string LastOperationErrorTarget { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Updating", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Status information for the fleet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus Status { get; set; }
        /// <summary>The last operation error for the fleet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusLastOperationError { get; set; }
        /// <summary>The last operation ID for the fleet.</summary>
        string StatusLastOperationId { get; set; }

    }
}