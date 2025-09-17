// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a continuous action.</summary>
    public partial class ContinuousAction :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IContinuousAction,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IContinuousActionInternal,
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

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IKeyValuePair> _parameter;

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IKeyValuePair> Parameter { get => this._parameter; set => this._parameter = value; }

        /// <summary>Backing field for <see cref="SelectorId" /> property.</summary>
        private string _selectorId;

        /// <summary>String that represents a selector.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string SelectorId { get => this._selectorId; set => this._selectorId = value; }

        /// <summary>Chaos experiment action discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Type { get => "continuous"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal)__chaosExperimentAction).Type = "continuous"; }

        /// <summary>Creates an new <see cref="ContinuousAction" /> instance.</summary>
        public ContinuousAction()
        {
            this.__chaosExperimentAction.Type = "continuous";
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
    /// Model that represents a continuous action.
    public partial interface IContinuousAction :
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
        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of key value pairs.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IKeyValuePair) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IKeyValuePair> Parameter { get; set; }
        /// <summary>String that represents a selector.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a selector.",
        SerializedName = @"selectorId",
        PossibleTypes = new [] { typeof(string) })]
        string SelectorId { get; set; }

    }
    /// Model that represents a continuous action.
    internal partial interface IContinuousActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal
    {
        /// <summary>ISO8601 formatted string that represents a duration.</summary>
        global::System.TimeSpan Duration { get; set; }
        /// <summary>List of key value pairs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IKeyValuePair> Parameter { get; set; }
        /// <summary>String that represents a selector.</summary>
        string SelectorId { get; set; }

    }
}