// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the dataset properties.</summary>
    public partial class Dataset :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDatasetInternal
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private string _configuration;

        /// <summary>
        /// Stringified JSON that contains connector-specific JSON string that describes configuration for the specific dataset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Configuration { get => this._configuration; set => this._configuration = value; }

        /// <summary>Backing field for <see cref="DataPoint" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPoint> _dataPoint;

        /// <summary>
        /// Array of data points that are part of the dataset. Each data point can have per-data point configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPoint> DataPoint { get => this._dataPoint; set => this._dataPoint = value; }

        /// <summary>Internal Acessors for Topic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDatasetInternal.Topic { get => (this._topic = this._topic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set { {_topic = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Topic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic _topic;

        /// <summary>Object that describes the topic information for the specific dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Topic { get => (this._topic = this._topic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set => this._topic = value; }

        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string TopicPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Path = value ?? null; }

        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string TopicRetain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Retain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Retain = value ?? null; }

        /// <summary>Creates an new <see cref="Dataset" /> instance.</summary>
        public Dataset()
        {

        }
    }
    /// Defines the dataset properties.
    public partial interface IDataset :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Stringified JSON that contains connector-specific JSON string that describes configuration for the specific dataset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Stringified JSON that contains connector-specific JSON string that describes configuration for the specific dataset.",
        SerializedName = @"datasetConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string Configuration { get; set; }
        /// <summary>
        /// Array of data points that are part of the dataset. Each data point can have per-data point configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of data points that are part of the dataset. Each data point can have per-data point configuration.",
        SerializedName = @"dataPoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPoint) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPoint> DataPoint { get; set; }
        /// <summary>Name of the dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the dataset.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The topic path for messages published to an MQTT broker.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string TopicPath { get; set; }
        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.",
        SerializedName = @"retain",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Keep", "Never")]
        string TopicRetain { get; set; }

    }
    /// Defines the dataset properties.
    internal partial interface IDatasetInternal

    {
        /// <summary>
        /// Stringified JSON that contains connector-specific JSON string that describes configuration for the specific dataset.
        /// </summary>
        string Configuration { get; set; }
        /// <summary>
        /// Array of data points that are part of the dataset. Each data point can have per-data point configuration.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPoint> DataPoint { get; set; }
        /// <summary>Name of the dataset.</summary>
        string Name { get; set; }
        /// <summary>Object that describes the topic information for the specific dataset.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Topic { get; set; }
        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        string TopicPath { get; set; }
        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Keep", "Never")]
        string TopicRetain { get; set; }

    }
}