// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.PowerShell;

    /// <summary>Asset definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(AssetTypeConverter))]
    public partial class Asset
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Asset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Asset(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Version = (long?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Version, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Dataset"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Dataset = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset>) content.GetValueForProperty("Dataset",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Dataset, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.DatasetTypeConverter.ConvertFrom));
            }
            if (content.Contains("Event"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Event = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent>) content.GetValueForProperty("Event",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Event, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTopic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopic = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic) content.GetValueForProperty("DefaultTopic",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopic, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TopicTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Uuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Uuid, global::System.Convert.ToString);
            }
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExternalAssetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExternalAssetId = (string) content.GetValueForProperty("ExternalAssetId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExternalAssetId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointProfileRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).EndpointProfileRef = (string) content.GetValueForProperty("EndpointProfileRef",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).EndpointProfileRef, global::System.Convert.ToString);
            }
            if (content.Contains("Manufacturer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Manufacturer, global::System.Convert.ToString);
            }
            if (content.Contains("ManufacturerUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ManufacturerUri = (string) content.GetValueForProperty("ManufacturerUri",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ManufacturerUri, global::System.Convert.ToString);
            }
            if (content.Contains("Model"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Model = (string) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Model, global::System.Convert.ToString);
            }
            if (content.Contains("ProductCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProductCode = (string) content.GetValueForProperty("ProductCode",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProductCode, global::System.Convert.ToString);
            }
            if (content.Contains("HardwareRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).HardwareRevision = (string) content.GetValueForProperty("HardwareRevision",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).HardwareRevision, global::System.Convert.ToString);
            }
            if (content.Contains("SoftwareRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SoftwareRevision = (string) content.GetValueForProperty("SoftwareRevision",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SoftwareRevision, global::System.Convert.ToString);
            }
            if (content.Contains("DocumentationUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DocumentationUri = (string) content.GetValueForProperty("DocumentationUri",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DocumentationUri, global::System.Convert.ToString);
            }
            if (content.Contains("SerialNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SerialNumber, global::System.Convert.ToString);
            }
            if (content.Contains("DiscoveredAssetRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DiscoveredAssetRef = (System.Collections.Generic.List<string>) content.GetValueForProperty("DiscoveredAssetRef",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DiscoveredAssetRef, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DefaultDatasetsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultDatasetsConfiguration = (string) content.GetValueForProperty("DefaultDatasetsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultDatasetsConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultEventsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultEventsConfiguration = (string) content.GetValueForProperty("DefaultEventsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultEventsConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError>) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("StatusVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusVersion = (long?) content.GetValueForProperty("StatusVersion",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusVersion, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StatusDataset"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusDataset = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset>) content.GetValueForProperty("StatusDataset",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusDataset, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusDatasetTypeConverter.ConvertFrom));
            }
            if (content.Contains("StatusEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusEvent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent>) content.GetValueForProperty("StatusEvent",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusEvent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusEventTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTopicPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicPath = (string) content.GetValueForProperty("DefaultTopicPath",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicPath, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTopicRetain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicRetain = (string) content.GetValueForProperty("DefaultTopicRetain",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicRetain, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Asset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Asset(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Version = (long?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Version, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Dataset"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Dataset = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset>) content.GetValueForProperty("Dataset",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Dataset, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.DatasetTypeConverter.ConvertFrom));
            }
            if (content.Contains("Event"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Event = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent>) content.GetValueForProperty("Event",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Event, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTopic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopic = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic) content.GetValueForProperty("DefaultTopic",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopic, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TopicTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Uuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Uuid, global::System.Convert.ToString);
            }
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExternalAssetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExternalAssetId = (string) content.GetValueForProperty("ExternalAssetId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExternalAssetId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointProfileRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).EndpointProfileRef = (string) content.GetValueForProperty("EndpointProfileRef",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).EndpointProfileRef, global::System.Convert.ToString);
            }
            if (content.Contains("Manufacturer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Manufacturer, global::System.Convert.ToString);
            }
            if (content.Contains("ManufacturerUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ManufacturerUri = (string) content.GetValueForProperty("ManufacturerUri",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ManufacturerUri, global::System.Convert.ToString);
            }
            if (content.Contains("Model"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Model = (string) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).Model, global::System.Convert.ToString);
            }
            if (content.Contains("ProductCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProductCode = (string) content.GetValueForProperty("ProductCode",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ProductCode, global::System.Convert.ToString);
            }
            if (content.Contains("HardwareRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).HardwareRevision = (string) content.GetValueForProperty("HardwareRevision",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).HardwareRevision, global::System.Convert.ToString);
            }
            if (content.Contains("SoftwareRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SoftwareRevision = (string) content.GetValueForProperty("SoftwareRevision",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SoftwareRevision, global::System.Convert.ToString);
            }
            if (content.Contains("DocumentationUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DocumentationUri = (string) content.GetValueForProperty("DocumentationUri",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DocumentationUri, global::System.Convert.ToString);
            }
            if (content.Contains("SerialNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).SerialNumber, global::System.Convert.ToString);
            }
            if (content.Contains("DiscoveredAssetRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DiscoveredAssetRef = (System.Collections.Generic.List<string>) content.GetValueForProperty("DiscoveredAssetRef",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DiscoveredAssetRef, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DefaultDatasetsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultDatasetsConfiguration = (string) content.GetValueForProperty("DefaultDatasetsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultDatasetsConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultEventsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultEventsConfiguration = (string) content.GetValueForProperty("DefaultEventsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultEventsConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError>) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("StatusVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusVersion = (long?) content.GetValueForProperty("StatusVersion",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusVersion, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StatusDataset"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusDataset = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset>) content.GetValueForProperty("StatusDataset",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusDataset, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusDatasetTypeConverter.ConvertFrom));
            }
            if (content.Contains("StatusEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusEvent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent>) content.GetValueForProperty("StatusEvent",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).StatusEvent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatusEventTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTopicPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicPath = (string) content.GetValueForProperty("DefaultTopicPath",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicPath, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTopicRetain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicRetain = (string) content.GetValueForProperty("DefaultTopicRetain",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetInternal)this).DefaultTopicRetain, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Asset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAsset" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAsset DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Asset(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Asset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAsset" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAsset DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Asset(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Asset" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Asset" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAsset FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Asset definition.
    [System.ComponentModel.TypeConverter(typeof(AssetTypeConverter))]
    public partial interface IAsset

    {

    }
}