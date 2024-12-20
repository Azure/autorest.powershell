// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The agent profile of the machines in the pool.</summary>
    public partial class AgentProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Internal Acessors for ResourcePredictionsProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal.ResourcePredictionsProfile { get => (this._resourcePredictionsProfile = this._resourcePredictionsProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfile()); set { {_resourcePredictionsProfile = value;} } }

        /// <summary>Backing field for <see cref="ResourcePrediction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions _resourcePrediction;

        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions ResourcePrediction { get => (this._resourcePrediction = this._resourcePrediction ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictions()); set => this._resourcePrediction = value; }

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ResourcePredictionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfileInternal)ResourcePredictionsProfile).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfileInternal)ResourcePredictionsProfile).Kind = value ?? null; }

        /// <summary>Backing field for <see cref="ResourcePredictionsProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile _resourcePredictionsProfile;

        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile ResourcePredictionsProfile { get => (this._resourcePredictionsProfile = this._resourcePredictionsProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfile()); set => this._resourcePredictionsProfile = value; }

        /// <summary>Creates an new <see cref="AgentProfile" /> instance.</summary>
        public AgentProfile()
        {

        }
    }
    /// The agent profile of the machines in the pool.
    public partial interface IAgentProfile :
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
        string Kind { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions ResourcePrediction { get; set; }
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
    /// The agent profile of the machines in the pool.
    internal partial interface IAgentProfileInternal

    {
        /// <summary>Discriminator property for AgentProfile.</summary>
        string Kind { get; set; }
        /// <summary>Defines pool buffer/stand-by agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions ResourcePrediction { get; set; }
        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Manual", "Automatic")]
        string ResourcePredictionProfileKind { get; set; }
        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile ResourcePredictionsProfile { get; set; }

    }
}