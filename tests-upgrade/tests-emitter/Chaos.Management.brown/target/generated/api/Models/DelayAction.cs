// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a delay action.</summary>
    public partial class DelayAction :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IDelayAction,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IDelayActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction __chaosExperimentAction = new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ChaosExperimentAction();

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private global::System.TimeSpan _duration;

        /// <summary>ISO8601 formatted string that represents a duration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public global::System.TimeSpan Duration { get => this._duration; set => this._duration = value; }

        /// <summary>String that represents a Capability URN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal)__chaosExperimentAction).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal)__chaosExperimentAction).Name = value ; }

        /// <summary>Chaos experiment action discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Type { get => "delay"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal)__chaosExperimentAction).Type = "delay"; }

        /// <summary>Creates an new <see cref="DelayAction" /> instance.</summary>
        public DelayAction()
        {
            this.__chaosExperimentAction.Type = "delay";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__chaosExperimentAction), __chaosExperimentAction);
            await eventListener.AssertObjectIsValid(nameof(__chaosExperimentAction), __chaosExperimentAction);
        }
    }
    /// Model that represents a delay action.
    public partial interface IDelayAction :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction
    {
        /// <summary>ISO8601 formatted string that represents a duration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ISO8601 formatted string that represents a duration.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan Duration { get; set; }

    }
    /// Model that represents a delay action.
    internal partial interface IDelayActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal
    {
        /// <summary>ISO8601 formatted string that represents a duration.</summary>
        global::System.TimeSpan Duration { get; set; }

    }
}