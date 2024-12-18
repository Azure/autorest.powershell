// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the asset properties.</summary>
    public partial class AssetProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject into a new instance of <see cref="AssetProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AssetProperties(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_defaultTopic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("defaultTopic"), out var __jsonDefaultTopic) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic.FromJson(__jsonDefaultTopic) : _defaultTopic;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("status"), out var __jsonStatus) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetStatus.FromJson(__jsonStatus) : _status;}
            {_uuid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)_uuid;}
            {_enabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : _enabled;}
            {_externalAssetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("externalAssetId"), out var __jsonExternalAssetId) ? (string)__jsonExternalAssetId : (string)_externalAssetId;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)_displayName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_assetEndpointProfileRef = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("assetEndpointProfileRef"), out var __jsonAssetEndpointProfileRef) ? (string)__jsonAssetEndpointProfileRef : (string)_assetEndpointProfileRef;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNumber>("version"), out var __jsonVersion) ? (long?)__jsonVersion : _version;}
            {_manufacturer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("manufacturer"), out var __jsonManufacturer) ? (string)__jsonManufacturer : (string)_manufacturer;}
            {_manufacturerUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("manufacturerUri"), out var __jsonManufacturerUri) ? (string)__jsonManufacturerUri : (string)_manufacturerUri;}
            {_model = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)_model;}
            {_productCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("productCode"), out var __jsonProductCode) ? (string)__jsonProductCode : (string)_productCode;}
            {_hardwareRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("hardwareRevision"), out var __jsonHardwareRevision) ? (string)__jsonHardwareRevision : (string)_hardwareRevision;}
            {_softwareRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("softwareRevision"), out var __jsonSoftwareRevision) ? (string)__jsonSoftwareRevision : (string)_softwareRevision;}
            {_documentationUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("documentationUri"), out var __jsonDocumentationUri) ? (string)__jsonDocumentationUri : (string)_documentationUri;}
            {_serialNumber = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("serialNumber"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)_serialNumber;}
            {_attribute = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("attributes"), out var __jsonAttributes) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Attributes.FromJson(__jsonAttributes) : _attribute;}
            {_discoveredAssetRef = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray>("discoveredAssetRefs"), out var __jsonDiscoveredAssetRefs) ? If( __jsonDiscoveredAssetRefs as Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _discoveredAssetRef;}
            {_defaultDatasetsConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("defaultDatasetsConfiguration"), out var __jsonDefaultDatasetsConfiguration) ? (string)__jsonDefaultDatasetsConfiguration : (string)_defaultDatasetsConfiguration;}
            {_defaultEventsConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("defaultEventsConfiguration"), out var __jsonDefaultEventsConfiguration) ? (string)__jsonDefaultEventsConfiguration : (string)_defaultEventsConfiguration;}
            {_dataset = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray>("datasets"), out var __jsonDatasets) ? If( __jsonDatasets as Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataset) (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Dataset.FromJson(__p) )) ))() : null : _dataset;}
            {_event = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray>("events"), out var __jsonEvents) ? If( __jsonEvents as Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEvent) (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Event.FromJson(__k) )) ))() : null : _event;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json ? new AssetProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AssetProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AssetProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._status ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) this._status.ToJson(null,serializationMode) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._uuid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._uuid.ToString()) : null, "uuid" ,container.Add );
            }
            AddIf( null != this._enabled ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._externalAssetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._externalAssetId.ToString()) : null, "externalAssetId" ,container.Add );
            }
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._assetEndpointProfileRef)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._assetEndpointProfileRef.ToString()) : null, "assetEndpointProfileRef" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._version ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNumber((long)this._version) : null, "version" ,container.Add );
            }
            AddIf( null != (((object)this._manufacturer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._manufacturer.ToString()) : null, "manufacturer" ,container.Add );
            AddIf( null != (((object)this._manufacturerUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._manufacturerUri.ToString()) : null, "manufacturerUri" ,container.Add );
            AddIf( null != (((object)this._model)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._model.ToString()) : null, "model" ,container.Add );
            AddIf( null != (((object)this._productCode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._productCode.ToString()) : null, "productCode" ,container.Add );
            AddIf( null != (((object)this._hardwareRevision)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._hardwareRevision.ToString()) : null, "hardwareRevision" ,container.Add );
            AddIf( null != (((object)this._softwareRevision)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._softwareRevision.ToString()) : null, "softwareRevision" ,container.Add );
            AddIf( null != (((object)this._documentationUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._documentationUri.ToString()) : null, "documentationUri" ,container.Add );
            AddIf( null != (((object)this._serialNumber)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._serialNumber.ToString()) : null, "serialNumber" ,container.Add );
            AddIf( null != this._attribute ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) this._attribute.ToJson(null,serializationMode) : null, "attributes" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeCreate))
            {
                if (null != this._discoveredAssetRef)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.XNodeArray();
                    foreach( var __x in this._discoveredAssetRef )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("discoveredAssetRefs",__w);
                }
            }
            AddIf( null != (((object)this._defaultDatasetsConfiguration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._defaultDatasetsConfiguration.ToString()) : null, "defaultDatasetsConfiguration" ,container.Add );
            AddIf( null != (((object)this._defaultEventsConfiguration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._defaultEventsConfiguration.ToString()) : null, "defaultEventsConfiguration" ,container.Add );
            if (null != this._dataset)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.XNodeArray();
                foreach( var __s in this._dataset )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("datasets",__r);
            }
            if (null != this._event)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.XNodeArray();
                foreach( var __n in this._event )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("events",__m);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}