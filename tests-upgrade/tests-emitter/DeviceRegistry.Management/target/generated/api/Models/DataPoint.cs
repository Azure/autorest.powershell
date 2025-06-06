// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the data point properties.</summary>
    public partial class DataPoint :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPoint,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBase __dataPointBase = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.DataPointBase();

        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Configuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal)__dataPointBase).Configuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal)__dataPointBase).Configuration = value ?? null; }

        /// <summary>
        /// The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string DataSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal)__dataPointBase).DataSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal)__dataPointBase).DataSource = value ; }

        /// <summary>The name of the data point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal)__dataPointBase).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal)__dataPointBase).Name = value ; }

        /// <summary>Backing field for <see cref="ObservabilityMode" /> property.</summary>
        private string _observabilityMode;

        /// <summary>An indication of how the data point should be mapped to OpenTelemetry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ObservabilityMode { get => this._observabilityMode; set => this._observabilityMode = value; }

        /// <summary>Creates an new <see cref="DataPoint" /> instance.</summary>
        public DataPoint()
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
            await eventListener.AssertNotNull(nameof(__dataPointBase), __dataPointBase);
            await eventListener.AssertObjectIsValid(nameof(__dataPointBase), __dataPointBase);
        }
    }
    /// Defines the data point properties.
    public partial interface IDataPoint :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBase
    {
        /// <summary>An indication of how the data point should be mapped to OpenTelemetry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An indication of how the data point should be mapped to OpenTelemetry.",
        SerializedName = @"observabilityMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("None", "Counter", "Gauge", "Histogram", "Log")]
        string ObservabilityMode { get; set; }

    }
    /// Defines the data point properties.
    internal partial interface IDataPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal
    {
        /// <summary>An indication of how the data point should be mapped to OpenTelemetry.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("None", "Counter", "Gauge", "Histogram", "Log")]
        string ObservabilityMode { get; set; }

    }
}