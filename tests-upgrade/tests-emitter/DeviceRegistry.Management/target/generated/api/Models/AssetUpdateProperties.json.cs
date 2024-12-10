// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The updatable properties of the Asset.</summary>
    public partial class AssetUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject into a new instance of <see cref="AssetUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AssetUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_defaultTopic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("defaultTopic"), out var __jsonDefaultTopic) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic.FromJson(__jsonDefaultTopic) : _defaultTopic;}
            {_enabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : _enabled;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)_displayName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_manufacturer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("manufacturer"), out var __jsonManufacturer) ? (string)__jsonManufacturer : (string)_manufacturer;}
            {_manufacturerUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("manufacturerUri"), out var __jsonManufacturerUri) ? (string)__jsonManufacturerUri : (string)_manufacturerUri;}
            {_model = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)_model;}
            {_productCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("productCode"), out var __jsonProductCode) ? (string)__jsonProductCode : (string)_productCode;}
            {_hardwareRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("hardwareRevision"), out var __jsonHardwareRevision) ? (string)__jsonHardwareRevision : (string)_hardwareRevision;}
            {_softwareRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("softwareRevision"), out var __jsonSoftwareRevision) ? (string)__jsonSoftwareRevision : (string)_softwareRevision;}
            {_documentationUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("documentationUri"), out var __jsonDocumentationUri) ? (string)__jsonDocumentationUri : (string)_documentationUri;}
            {_serialNumber = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("serialNumber"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)_serialNumber;}
            {_attribute = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("attributes"), out var __jsonAttributes) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Attributes.FromJson(__jsonAttributes) : _attribute;}
            {_defaultDatasetsConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("defaultDatasetsConfiguration"), out var __jsonDefaultDatasetsConfiguration) ? (string)__jsonDefaultDatasetsConfiguration : (string)_defaultDatasetsConfiguration;}
            {_defaultEventsConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("defaultEventsConfiguration"), out var __jsonDefaultEventsConfiguration) ? (string)__jsonDefaultEventsConfiguration : (string)_defaultEventsConfiguration;}
            {_dataset = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray>("datasets"), out var __jsonDatasets) ? If( __jsonDatasets as Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset) (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Dataset.FromJson(__u) )) ))() : null : _dataset;}
            {_event = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray>("events"), out var __jsonEvents) ? If( __jsonEvents as Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent) (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Event.FromJson(__p) )) ))() : null : _event;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json ? new AssetUpdateProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AssetUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AssetUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._defaultTopic ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) this._defaultTopic.ToJson(null,serializationMode) : null, "defaultTopic" ,container.Add );
            AddIf( null != this._enabled ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._manufacturer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._manufacturer.ToString()) : null, "manufacturer" ,container.Add );
            AddIf( null != (((object)this._manufacturerUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._manufacturerUri.ToString()) : null, "manufacturerUri" ,container.Add );
            AddIf( null != (((object)this._model)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._model.ToString()) : null, "model" ,container.Add );
            AddIf( null != (((object)this._productCode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._productCode.ToString()) : null, "productCode" ,container.Add );
            AddIf( null != (((object)this._hardwareRevision)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._hardwareRevision.ToString()) : null, "hardwareRevision" ,container.Add );
            AddIf( null != (((object)this._softwareRevision)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._softwareRevision.ToString()) : null, "softwareRevision" ,container.Add );
            AddIf( null != (((object)this._documentationUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._documentationUri.ToString()) : null, "documentationUri" ,container.Add );
            AddIf( null != (((object)this._serialNumber)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._serialNumber.ToString()) : null, "serialNumber" ,container.Add );
            AddIf( null != this._attribute ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) this._attribute.ToJson(null,serializationMode) : null, "attributes" ,container.Add );
            AddIf( null != (((object)this._defaultDatasetsConfiguration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._defaultDatasetsConfiguration.ToString()) : null, "defaultDatasetsConfiguration" ,container.Add );
            AddIf( null != (((object)this._defaultEventsConfiguration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._defaultEventsConfiguration.ToString()) : null, "defaultEventsConfiguration" ,container.Add );
            if (null != this._dataset)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.XNodeArray();
                foreach( var __x in this._dataset )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("datasets",__w);
            }
            if (null != this._event)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.XNodeArray();
                foreach( var __s in this._event )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("events",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}