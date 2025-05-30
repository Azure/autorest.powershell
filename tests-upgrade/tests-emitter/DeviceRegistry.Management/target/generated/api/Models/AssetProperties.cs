// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the asset properties.</summary>
    public partial class AssetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AssetEndpointProfileRef" /> property.</summary>
        private string _assetEndpointProfileRef;

        /// <summary>
        /// A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides
        /// data points for this asset. Must provide asset endpoint profile name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string AssetEndpointProfileRef { get => this._assetEndpointProfileRef; set => this._assetEndpointProfileRef = value; }

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

        /// <summary>Backing field for <see cref="DiscoveredAssetRef" /> property.</summary>
        private System.Collections.Generic.List<string> _discoveredAssetRef;

        /// <summary>
        /// Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered
        /// asset names must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DiscoveredAssetRef { get => this._discoveredAssetRef; set => this._discoveredAssetRef = value; }

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

        /// <summary>Backing field for <see cref="ExternalAssetId" /> property.</summary>
        private string _externalAssetId;

        /// <summary>Asset id provided by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ExternalAssetId { get => this._externalAssetId; set => this._externalAssetId = value; }

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
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.DefaultTopic { get => (this._defaultTopic = this._defaultTopic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set { {_defaultTopic = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusDataset</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.StatusDataset { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Dataset; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Dataset = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Error = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusEvent</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.StatusEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Event; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Event = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusVersion</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.StatusVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Version = value ?? default(long); }

        /// <summary>Internal Acessors for Uuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.Uuid { get => this._uuid; set { {_uuid = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal.Version { get => this._version; set { {_version = value;} } }

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

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

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

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus _status;

        /// <summary>
        /// Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatus()); }

        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> StatusDataset { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Dataset; }

        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Error; }

        /// <summary>Array of event statuses that describe the status of each event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> StatusEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Event; }

        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public long? StatusVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal)Status).Version; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private long? _version;

        /// <summary>An integer that is incremented each time the resource is modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public long? Version { get => this._version; }

        /// <summary>Creates an new <see cref="AssetProperties" /> instance.</summary>
        public AssetProperties()
        {

        }
    }
    /// Defines the asset properties.
    public partial interface IAssetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides
        /// data points for this asset. Must provide asset endpoint profile name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides data points for this asset. Must provide asset endpoint profile name.",
        SerializedName = @"assetEndpointProfileRef",
        PossibleTypes = new [] { typeof(string) })]
        string AssetEndpointProfileRef { get; set; }
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
        /// <summary>
        /// Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered
        /// asset names must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered asset names must be provided.",
        SerializedName = @"discoveredAssetRefs",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DiscoveredAssetRef { get; set; }
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
        /// <summary>Asset id provided by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Asset id provided by the customer.",
        SerializedName = @"externalAssetId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalAssetId { get; set; }
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
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get;  }
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
        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of dataset statuses that describe the status of each dataset.",
        SerializedName = @"datasets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> StatusDataset { get;  }
        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array object to transfer and persist errors that originate from the Edge.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> StatusError { get;  }
        /// <summary>Array of event statuses that describe the status of each event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of event statuses that describe the status of each event.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> StatusEvent { get;  }
        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A read only incremental counter indicating the number of times the configuration has been modified from the perspective of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to the cloud. In steady state, this should equal version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(long) })]
        long? StatusVersion { get;  }
        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Globally unique, immutable, non-reusable id.",
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get;  }
        /// <summary>An integer that is incremented each time the resource is modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"An integer that is incremented each time the resource is modified.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(long) })]
        long? Version { get;  }

    }
    /// Defines the asset properties.
    internal partial interface IAssetPropertiesInternal

    {
        /// <summary>
        /// A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides
        /// data points for this asset. Must provide asset endpoint profile name.
        /// </summary>
        string AssetEndpointProfileRef { get; set; }
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
        /// <summary>
        /// Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered
        /// asset names must be provided.
        /// </summary>
        System.Collections.Generic.List<string> DiscoveredAssetRef { get; set; }
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
        /// <summary>Asset id provided by the customer.</summary>
        string ExternalAssetId { get; set; }
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
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Asset serial number.</summary>
        string SerialNumber { get; set; }
        /// <summary>Revision number of the software.</summary>
        string SoftwareRevision { get; set; }
        /// <summary>
        /// Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus Status { get; set; }
        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> StatusDataset { get; set; }
        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> StatusError { get; set; }
        /// <summary>Array of event statuses that describe the status of each event.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> StatusEvent { get; set; }
        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        long? StatusVersion { get; set; }
        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        string Uuid { get; set; }
        /// <summary>An integer that is incremented each time the resource is modified.</summary>
        long? Version { get; set; }

    }
}