// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the Asset Endpoint Profile properties.</summary>
    public partial class AssetEndpointProfileProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject into a new instance of <see cref="AssetEndpointProfileProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AssetEndpointProfileProperties(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_authentication = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("authentication"), out var __jsonAuthentication) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Authentication.FromJson(__jsonAuthentication) : _authentication;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject>("status"), out var __jsonStatus) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatus.FromJson(__jsonStatus) : _status;}
            {_uuid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)_uuid;}
            {_targetAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("targetAddress"), out var __jsonTargetAddress) ? (string)__jsonTargetAddress : (string)_targetAddress;}
            {_endpointProfileType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("endpointProfileType"), out var __jsonEndpointProfileType) ? (string)__jsonEndpointProfileType : (string)_endpointProfileType;}
            {_additionalConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("additionalConfiguration"), out var __jsonAdditionalConfiguration) ? (string)__jsonAdditionalConfiguration : (string)_additionalConfiguration;}
            {_discoveredAssetEndpointProfileRef = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("discoveredAssetEndpointProfileRef"), out var __jsonDiscoveredAssetEndpointProfileRef) ? (string)__jsonDiscoveredAssetEndpointProfileRef : (string)_discoveredAssetEndpointProfileRef;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject json ? new AssetEndpointProfileProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AssetEndpointProfileProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AssetEndpointProfileProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._authentication ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) this._authentication.ToJson(null,serializationMode) : null, "authentication" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._status ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) this._status.ToJson(null,serializationMode) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._uuid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._uuid.ToString()) : null, "uuid" ,container.Add );
            }
            AddIf( null != (((object)this._targetAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._targetAddress.ToString()) : null, "targetAddress" ,container.Add );
            AddIf( null != (((object)this._endpointProfileType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._endpointProfileType.ToString()) : null, "endpointProfileType" ,container.Add );
            AddIf( null != (((object)this._additionalConfiguration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._additionalConfiguration.ToString()) : null, "additionalConfiguration" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._discoveredAssetEndpointProfileRef)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonString(this._discoveredAssetEndpointProfileRef.ToString()) : null, "discoveredAssetEndpointProfileRef" ,container.Add );
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