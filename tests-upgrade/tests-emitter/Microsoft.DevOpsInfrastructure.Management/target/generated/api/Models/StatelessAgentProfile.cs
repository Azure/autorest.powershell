// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>
    /// Stateless profile meaning that the machines will be cleaned up after running a job.
    /// </summary>
    public partial class StatelessAgentProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatelessAgentProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatelessAgentProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile __agentProfile = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfile();

        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Kind { get => "Stateless"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).Kind = "Stateless"; }

        /// <summary>Internal Acessors for ResourcePredictionsProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal.ResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile = value; }

        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions ResourcePrediction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePrediction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePrediction = value ?? null /* model class */; }

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string ResourcePredictionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionProfileKind = value ?? null; }

        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile ResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="StatelessAgentProfile" /> instance.</summary>
        public StatelessAgentProfile()
        {
            this.__agentProfile.Kind = "Stateless";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__agentProfile), __agentProfile);
            await eventListener.AssertObjectIsValid(nameof(__agentProfile), __agentProfile);
        }
    }
    /// Stateless profile meaning that the machines will be cleaned up after running a job.
    public partial interface IStatelessAgentProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile
    {

    }
    /// Stateless profile meaning that the machines will be cleaned up after running a job.
    internal partial interface IStatelessAgentProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal
    {

    }
}