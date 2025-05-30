// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The updatable properties of the Asset.</summary>
    public partial class AssetUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes _attribute;

        /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Attributes()); set => this._attribute = value; }

        /// <summary>Backing field for <see cref="Dataset" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset> _dataset;

        /// <summary>
        /// Array of datasets that are part of the asset. Each dataset describes the data points that make up the set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset> Dataset { get => this._dataset; set => this._dataset = value; }

        /// <summary>Backing field for <see cref="DefaultDatasetsConfiguration" /> property.</summary>
        private string _defaultDatasetsConfiguration;

        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own
        /// configuration that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string DefaultDatasetsConfiguration { get => this._defaultDatasetsConfiguration; set => this._defaultDatasetsConfiguration = value; }

        /// <summary>Backing field for <see cref="DefaultEventsConfiguration" /> property.</summary>
        private string _defaultEventsConfiguration;

        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration
        /// that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string DefaultEventsConfiguration { get => this._defaultEventsConfiguration; set => this._defaultEventsConfiguration = value; }

        /// <summary>Backing field for <see cref="DefaultTopic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic _defaultTopic;

        /// <summary>Object that describes the default topic information for the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic DefaultTopic { get => (this._defaultTopic = this._defaultTopic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set => this._defaultTopic = value; }

        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultTopicPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)DefaultTopic).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)DefaultTopic).Path = value ?? null; }

        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultTopicRetain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)DefaultTopic).Retain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)DefaultTopic).Retain = value ?? null; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Human-readable description of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Human-readable display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="DocumentationUri" /> property.</summary>
        private string _documentationUri;

        /// <summary>Reference to the documentation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string DocumentationUri { get => this._documentationUri; set => this._documentationUri = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Enabled/Disabled status of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Event" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> _event;

        /// <summary>
        /// Array of events that are part of the asset. Each event can have per-event configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> Event { get => this._event; set => this._event = value; }

        /// <summary>Backing field for <see cref="HardwareRevision" /> property.</summary>
        private string _hardwareRevision;

        /// <summary>Revision number of the hardware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string HardwareRevision { get => this._hardwareRevision; set => this._hardwareRevision = value; }

        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        /// <summary>Asset manufacturer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Manufacturer { get => this._manufacturer; set => this._manufacturer = value; }

        /// <summary>Backing field for <see cref="ManufacturerUri" /> property.</summary>
        private string _manufacturerUri;

        /// <summary>Asset manufacturer URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ManufacturerUri { get => this._manufacturerUri; set => this._manufacturerUri = value; }

        /// <summary>Internal Acessors for DefaultTopic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal.DefaultTopic { get => (this._defaultTopic = this._defaultTopic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set { {_defaultTopic = value;} } }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Asset model name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="ProductCode" /> property.</summary>
        private string _productCode;

        /// <summary>Asset product code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ProductCode { get => this._productCode; set => this._productCode = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Asset serial number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="SoftwareRevision" /> property.</summary>
        private string _softwareRevision;

        /// <summary>Revision number of the software.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string SoftwareRevision { get => this._softwareRevision; set => this._softwareRevision = value; }

        /// <summary>Creates an new <see cref="AssetUpdateProperties" /> instance.</summary>
        public AssetUpdateProperties()
        {

        }
    }
    /// The updatable properties of the Asset.
    public partial interface IAssetUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A set of key-value pairs that contain custom attributes set by the customer.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes Attribute { get; set; }
        /// <summary>
        /// Array of datasets that are part of the asset. Each dataset describes the data points that make up the set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of datasets that are part of the asset. Each dataset describes the data points that make up the set.",
        SerializedName = @"datasets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset> Dataset { get; set; }
        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own
        /// configuration that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here.",
        SerializedName = @"defaultDatasetsConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultDatasetsConfiguration { get; set; }
        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration
        /// that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here.",
        SerializedName = @"defaultEventsConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultEventsConfiguration { get; set; }
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
        string DefaultTopicPath { get; set; }
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
        string DefaultTopicRetain { get; set; }
        /// <summary>Human-readable description of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Human-readable description of the asset.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Human-readable display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Human-readable display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Reference to the documentation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reference to the documentation.",
        SerializedName = @"documentationUri",
        PossibleTypes = new [] { typeof(string) })]
        string DocumentationUri { get; set; }
        /// <summary>Enabled/Disabled status of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enabled/Disabled status of the asset.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// Array of events that are part of the asset. Each event can have per-event configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of events that are part of the asset. Each event can have per-event configuration.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> Event { get; set; }
        /// <summary>Revision number of the hardware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Revision number of the hardware.",
        SerializedName = @"hardwareRevision",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareRevision { get; set; }
        /// <summary>Asset manufacturer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset manufacturer name.",
        SerializedName = @"manufacturer",
        PossibleTypes = new [] { typeof(string) })]
        string Manufacturer { get; set; }
        /// <summary>Asset manufacturer URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset manufacturer URI.",
        SerializedName = @"manufacturerUri",
        PossibleTypes = new [] { typeof(string) })]
        string ManufacturerUri { get; set; }
        /// <summary>Asset model name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset model name.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }
        /// <summary>Asset product code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset product code.",
        SerializedName = @"productCode",
        PossibleTypes = new [] { typeof(string) })]
        string ProductCode { get; set; }
        /// <summary>Asset serial number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset serial number.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>Revision number of the software.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Revision number of the software.",
        SerializedName = @"softwareRevision",
        PossibleTypes = new [] { typeof(string) })]
        string SoftwareRevision { get; set; }

    }
    /// The updatable properties of the Asset.
    internal partial interface IAssetUpdatePropertiesInternal

    {
        /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes Attribute { get; set; }
        /// <summary>
        /// Array of datasets that are part of the asset. Each dataset describes the data points that make up the set.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset> Dataset { get; set; }
        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own
        /// configuration that overrides the default settings here.
        /// </summary>
        string DefaultDatasetsConfiguration { get; set; }
        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration
        /// that overrides the default settings here.
        /// </summary>
        string DefaultEventsConfiguration { get; set; }
        /// <summary>Object that describes the default topic information for the asset.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic DefaultTopic { get; set; }
        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        string DefaultTopicPath { get; set; }
        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Keep", "Never")]
        string DefaultTopicRetain { get; set; }
        /// <summary>Human-readable description of the asset.</summary>
        string Description { get; set; }
        /// <summary>Human-readable display name.</summary>
        string DisplayName { get; set; }
        /// <summary>Reference to the documentation.</summary>
        string DocumentationUri { get; set; }
        /// <summary>Enabled/Disabled status of the asset.</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Array of events that are part of the asset. Each event can have per-event configuration.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> Event { get; set; }
        /// <summary>Revision number of the hardware.</summary>
        string HardwareRevision { get; set; }
        /// <summary>Asset manufacturer name.</summary>
        string Manufacturer { get; set; }
        /// <summary>Asset manufacturer URI.</summary>
        string ManufacturerUri { get; set; }
        /// <summary>Asset model name.</summary>
        string Model { get; set; }
        /// <summary>Asset product code.</summary>
        string ProductCode { get; set; }
        /// <summary>Asset serial number.</summary>
        string SerialNumber { get; set; }
        /// <summary>Revision number of the software.</summary>
        string SoftwareRevision { get; set; }

    }
}