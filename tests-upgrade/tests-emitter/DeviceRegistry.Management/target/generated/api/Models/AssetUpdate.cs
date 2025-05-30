// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The type used for update operations of the Asset.</summary>
    public partial class AssetUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateInternal
    {

        /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>
        /// Array of datasets that are part of the asset. Each dataset describes the data points that make up the set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset> Dataset { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Dataset; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Dataset = value ?? null /* arrayOf */; }

        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own
        /// configuration that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultDatasetsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultDatasetsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultDatasetsConfiguration = value ?? null; }

        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration
        /// that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultEventsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultEventsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultEventsConfiguration = value ?? null; }

        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultTopicPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultTopicPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultTopicPath = value ?? null; }

        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultTopicRetain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultTopicRetain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultTopicRetain = value ?? null; }

        /// <summary>Human-readable description of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Human-readable display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Reference to the documentation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DocumentationUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DocumentationUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DocumentationUri = value ?? null; }

        /// <summary>Enabled/Disabled status of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public bool? Enabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Enabled = value ?? default(bool); }

        /// <summary>
        /// Array of events that are part of the asset. Each event can have per-event configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> Event { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Event; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Event = value ?? null /* arrayOf */; }

        /// <summary>Revision number of the hardware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string HardwareRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).HardwareRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).HardwareRevision = value ?? null; }

        /// <summary>Asset manufacturer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Manufacturer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Manufacturer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Manufacturer = value ?? null; }

        /// <summary>Asset manufacturer URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ManufacturerUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).ManufacturerUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).ManufacturerUri = value ?? null; }

        /// <summary>Internal Acessors for DefaultTopic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateInternal.DefaultTopic { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultTopic; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).DefaultTopic = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetUpdateProperties()); set { {_property = value;} } }

        /// <summary>Asset model name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Model { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).Model = value ?? null; }

        /// <summary>Asset product code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ProductCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).ProductCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).ProductCode = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetUpdateProperties()); set => this._property = value; }

        /// <summary>Asset serial number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).SerialNumber = value ?? null; }

        /// <summary>Revision number of the software.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string SoftwareRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).SoftwareRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdatePropertiesInternal)Property).SoftwareRevision = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="AssetUpdate" /> instance.</summary>
        public AssetUpdate()
        {

        }
    }
    /// The type used for update operations of the Asset.
    public partial interface IAssetUpdate :
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
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get; set; }

    }
    /// The type used for update operations of the Asset.
    internal partial interface IAssetUpdateInternal

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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties Property { get; set; }
        /// <summary>Asset serial number.</summary>
        string SerialNumber { get; set; }
        /// <summary>Revision number of the software.</summary>
        string SoftwareRevision { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get; set; }

    }
}