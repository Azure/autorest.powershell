// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the event properties.</summary>
    public partial class Event :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase __eventBase = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventBase();

        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the event. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Configuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Configuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Configuration = value ?? null; }

        /// <summary>Internal Acessors for Topic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal.Topic { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Topic; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Topic = value ?? null /* model class */; }

        /// <summary>The name of the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Name = value ; }

        /// <summary>
        /// The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Notifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Notifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Notifier = value ; }

        /// <summary>Backing field for <see cref="ObservabilityMode" /> property.</summary>
        private string _observabilityMode;

        /// <summary>An indication of how the event should be mapped to OpenTelemetry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ObservabilityMode { get => this._observabilityMode; set => this._observabilityMode = value; }

        /// <summary>Object that describes the topic information for the specific event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Topic { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Topic; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).Topic = value ?? null /* model class */; }

        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string TopicPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).TopicPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).TopicPath = value ?? null; }

        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string TopicRetain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).TopicRetain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)__eventBase).TopicRetain = value ?? null; }

        /// <summary>Creates an new <see cref="Event" /> instance.</summary>
        public Event()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__eventBase), __eventBase);
            await eventListener.AssertObjectIsValid(nameof(__eventBase), __eventBase);
        }
    }
    /// Defines the event properties.
    public partial interface IEvent :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase
    {
        /// <summary>An indication of how the event should be mapped to OpenTelemetry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An indication of how the event should be mapped to OpenTelemetry.",
        SerializedName = @"observabilityMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("None", "Log")]
        string ObservabilityMode { get; set; }

    }
    /// Defines the event properties.
    internal partial interface IEventInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal
    {
        /// <summary>An indication of how the event should be mapped to OpenTelemetry.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("None", "Log")]
        string ObservabilityMode { get; set; }

    }
}