// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>
    /// Stateful profile meaning that the machines will be returned to the pool after running a job.
    /// </summary>
    public partial class Stateful :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStateful,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile __agentProfile = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfile();

        /// <summary>Backing field for <see cref="GracePeriodTimeSpan" /> property.</summary>
        private string _gracePeriodTimeSpan;

        /// <summary>
        /// How long should the machine be kept around after it ran a workload when there are no stand-by agents. The maximum is one
        /// week.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string GracePeriodTimeSpan { get => this._gracePeriodTimeSpan; set => this._gracePeriodTimeSpan = value; }

        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Kind { get => "Stateful"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).Kind = "Stateful"; }

        /// <summary>Backing field for <see cref="MaxAgentLifetime" /> property.</summary>
        private string _maxAgentLifetime;

        /// <summary>How long should stateful machines be kept around. The maximum is one week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string MaxAgentLifetime { get => this._maxAgentLifetime; set => this._maxAgentLifetime = value; }

        /// <summary>Internal Acessors for ResourcePredictionsProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal.ResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions ResourcePrediction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePrediction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePrediction = value ?? null /* model class */; }

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string ResourcePredictionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionProfileKind = value ?? null; }

        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile ResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)__agentProfile).ResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="Stateful" /> instance.</summary>
        public Stateful()
        {
            this.__agentProfile.Kind = "Stateful";
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
    /// Stateful profile meaning that the machines will be returned to the pool after running a job.
    public partial interface IStateful :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile
    {
        /// <summary>
        /// How long should the machine be kept around after it ran a workload when there are no stand-by agents. The maximum is one
        /// week.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How long should the machine be kept around after it ran a workload when there are no stand-by agents. The maximum is one week.",
        SerializedName = @"gracePeriodTimeSpan",
        PossibleTypes = new [] { typeof(string) })]
        string GracePeriodTimeSpan { get; set; }
        /// <summary>How long should stateful machines be kept around. The maximum is one week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How long should stateful machines be kept around. The maximum is one week.",
        SerializedName = @"maxAgentLifetime",
        PossibleTypes = new [] { typeof(string) })]
        string MaxAgentLifetime { get; set; }

    }
    /// Stateful profile meaning that the machines will be returned to the pool after running a job.
    internal partial interface IStatefulInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal
    {
        /// <summary>
        /// How long should the machine be kept around after it ran a workload when there are no stand-by agents. The maximum is one
        /// week.
        /// </summary>
        string GracePeriodTimeSpan { get; set; }
        /// <summary>How long should stateful machines be kept around. The maximum is one week.</summary>
        string MaxAgentLifetime { get; set; }

    }
}