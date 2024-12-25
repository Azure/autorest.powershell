// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Pool properties</summary>
    public partial class PoolProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AgentProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile _agentProfile;

        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile AgentProfile { get => (this._agentProfile = this._agentProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfile()); set => this._agentProfile = value; }

        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string AgentProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).Kind = value ; }

        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePrediction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePrediction = value ?? null /* model class */; }

        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile AgentProfileResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="DevCenterProjectResourceId" /> property.</summary>
        private string _devCenterProjectResourceId;

        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string DevCenterProjectResourceId { get => this._devCenterProjectResourceId; set => this._devCenterProjectResourceId = value; }

        /// <summary>Backing field for <see cref="FabricProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile _fabricProfile;

        /// <summary>Defines the type of fabric the agent will run on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get => (this._fabricProfile = this._fabricProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfile()); set => this._fabricProfile = value; }

        /// <summary>Discriminator property for FabricProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string FabricProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal)FabricProfile).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal)FabricProfile).Kind = value ; }

        /// <summary>Backing field for <see cref="MaximumConcurrency" /> property.</summary>
        private int _maximumConcurrency;

        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public int MaximumConcurrency { get => this._maximumConcurrency; set => this._maximumConcurrency = value; }

        /// <summary>Internal Acessors for AgentProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal.AgentProfile { get => (this._agentProfile = this._agentProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfile()); set { {_agentProfile = value;} } }

        /// <summary>Internal Acessors for AgentProfileResourcePredictionsProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal.AgentProfileResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePredictionsProfile = value; }

        /// <summary>Internal Acessors for FabricProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal.FabricProfile { get => (this._fabricProfile = this._fabricProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfile()); set { {_fabricProfile = value;} } }

        /// <summary>Internal Acessors for OrganizationProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal.OrganizationProfile { get => (this._organizationProfile = this._organizationProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfile()); set { {_organizationProfile = value;} } }

        /// <summary>Backing field for <see cref="OrganizationProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile _organizationProfile;

        /// <summary>Defines the organization in which the pool will be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile OrganizationProfile { get => (this._organizationProfile = this._organizationProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfile()); set => this._organizationProfile = value; }

        /// <summary>Discriminator property for OrganizationProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string OrganizationProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfileInternal)OrganizationProfile).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfileInternal)OrganizationProfile).Kind = value ; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ResourcePredictionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePredictionProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)AgentProfile).ResourcePredictionProfileKind = value ?? null; }

        /// <summary>Creates an new <see cref="PoolProperties" /> instance.</summary>
        public PoolProperties()
        {

        }
    }
    /// Pool properties
    public partial interface IPoolProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for AgentProfile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string AgentProfileKind { get; set; }
        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines pool buffer/stand-by agents.",
        SerializedName = @"resourcePredictions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the DevCenter Project the pool belongs to.",
        SerializedName = @"devCenterProjectResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Discriminator property for FabricProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for FabricProfile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string FabricProfileKind { get; set; }
        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines how many resources can there be created at any given time.",
        SerializedName = @"maximumConcurrency",
        PossibleTypes = new [] { typeof(int) })]
        int MaximumConcurrency { get; set; }
        /// <summary>Discriminator property for OrganizationProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for OrganizationProfile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationProfileKind { get; set; }
        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of the current operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines how the stand-by scheme should be provided.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Manual", "Automatic")]
        string ResourcePredictionProfileKind { get; set; }

    }
    /// Pool properties
    internal partial interface IPoolPropertiesInternal

    {
        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile AgentProfile { get; set; }
        /// <summary>Discriminator property for AgentProfile.</summary>
        string AgentProfileKind { get; set; }
        /// <summary>Defines pool buffer/stand-by agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get; set; }
        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile AgentProfileResourcePredictionsProfile { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Defines the type of fabric the agent will run on.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get; set; }
        /// <summary>Discriminator property for FabricProfile.</summary>
        string FabricProfileKind { get; set; }
        /// <summary>Defines how many resources can there be created at any given time.</summary>
        int MaximumConcurrency { get; set; }
        /// <summary>Defines the organization in which the pool will be used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile OrganizationProfile { get; set; }
        /// <summary>Discriminator property for OrganizationProfile.</summary>
        string OrganizationProfileKind { get; set; }
        /// <summary>The status of the current operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Manual", "Automatic")]
        string ResourcePredictionProfileKind { get; set; }

    }
}