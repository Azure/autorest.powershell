// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Asset definition.</summary>
    public partial class Asset :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAsset,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TrackedResource();

        /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>
        /// Array of datasets that are part of the asset. Each dataset describes the data points that make up the set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset> Dataset { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Dataset; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Dataset = value ?? null /* arrayOf */; }

        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own
        /// configuration that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultDatasetsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultDatasetsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultDatasetsConfiguration = value ?? null; }

        /// <summary>
        /// Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration
        /// that overrides the default settings here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultEventsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultEventsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultEventsConfiguration = value ?? null; }

        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultTopicPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultTopicPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultTopicPath = value ?? null; }

        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DefaultTopicRetain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultTopicRetain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultTopicRetain = value ?? null; }

        /// <summary>Human-readable description of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>
        /// Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered
        /// asset names must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DiscoveredAssetRef { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DiscoveredAssetRef; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DiscoveredAssetRef = value ?? null /* arrayOf */; }

        /// <summary>Human-readable display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Reference to the documentation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string DocumentationUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DocumentationUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DocumentationUri = value ?? null; }

        /// <summary>Enabled/Disabled status of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public bool? Enabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Enabled = value ?? default(bool); }

        /// <summary>
        /// A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides
        /// data points for this asset. Must provide asset endpoint profile name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string EndpointProfileRef { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).AssetEndpointProfileRef; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).AssetEndpointProfileRef = value ?? null; }

        /// <summary>
        /// Array of events that are part of the asset. Each event can have per-event configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> Event { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Event; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Event = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ExtendedLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation _extendedLocation;

        /// <summary>The extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ExtendedLocation()); set => this._extendedLocation = value; }

        /// <summary>The extended location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocationInternal)ExtendedLocation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocationInternal)ExtendedLocation).Name = value ?? null; }

        /// <summary>The extended location type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocationInternal)ExtendedLocation).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocationInternal)ExtendedLocation).Type = value ?? null; }

        /// <summary>Asset id provided by the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ExternalAssetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ExternalAssetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ExternalAssetId = value ?? null; }

        /// <summary>Revision number of the hardware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string HardwareRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).HardwareRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).HardwareRevision = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Asset manufacturer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Manufacturer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Manufacturer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Manufacturer = value ?? null; }

        /// <summary>Asset manufacturer URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ManufacturerUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ManufacturerUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ManufacturerUri = value ?? null; }

        /// <summary>Internal Acessors for DefaultTopic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.DefaultTopic { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultTopic; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).DefaultTopic = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ExtendedLocation()); set { {_extendedLocation = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Status = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusDataset</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.StatusDataset { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusDataset; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusDataset = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusError = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusEvent</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.StatusEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusEvent; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusEvent = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusVersion</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.StatusVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusVersion = value ?? default(long); }

        /// <summary>Internal Acessors for Uuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.Uuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Uuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Uuid = value ?? null; }

        /// <summary>Internal Acessors for Version</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Version = value ?? default(long); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>Asset model name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Model { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Model = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Asset product code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ProductCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ProductCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ProductCode = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Asset serial number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).SerialNumber = value ?? null; }

        /// <summary>Revision number of the software.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string SoftwareRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).SoftwareRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).SoftwareRevision = value ?? null; }

        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> StatusDataset { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusDataset; }

        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusError; }

        /// <summary>Array of event statuses that describe the status of each event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> StatusEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusEvent; }

        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public long? StatusVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).StatusVersion; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string Uuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Uuid; }

        /// <summary>An integer that is incremented each time the resource is modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public long? Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetPropertiesInternal)Property).Version; }

        /// <summary>Creates an new <see cref="Asset" /> instance.</summary>
        public Asset()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Asset definition.
    public partial interface IAsset :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResource
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

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
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
        string EndpointProfileRef { get; set; }
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
        /// <summary>The extended location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The extended location name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationName { get; set; }
        /// <summary>The extended location type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The extended location type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationType { get; set; }
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

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
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
    /// Asset definition.
    internal partial interface IAssetInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal
    {
        /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes Attribute { get; set; }

        string AzureAsyncOperation { get; set; }
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
        /// A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides
        /// data points for this asset. Must provide asset endpoint profile name.
        /// </summary>
        string EndpointProfileRef { get; set; }
        /// <summary>
        /// Array of events that are part of the asset. Each event can have per-event configuration.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent> Event { get; set; }
        /// <summary>The extended location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation ExtendedLocation { get; set; }
        /// <summary>The extended location name.</summary>
        string ExtendedLocationName { get; set; }
        /// <summary>The extended location type.</summary>
        string ExtendedLocationType { get; set; }
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
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