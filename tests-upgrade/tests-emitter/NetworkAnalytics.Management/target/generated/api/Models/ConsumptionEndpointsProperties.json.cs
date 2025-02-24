// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details of Consumption Properties</summary>
    public partial class ConsumptionEndpointsProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject into a new instance of <see cref="ConsumptionEndpointsProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConsumptionEndpointsProperties(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_ingestionUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("ingestionUrl"), out var __jsonIngestionUrl) ? (string)__jsonIngestionUrl : (string)_ingestionUrl;}
            {_ingestionResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("ingestionResourceId"), out var __jsonIngestionResourceId) ? (string)__jsonIngestionResourceId : (string)_ingestionResourceId;}
            {_fileAccessUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("fileAccessUrl"), out var __jsonFileAccessUrl) ? (string)__jsonFileAccessUrl : (string)_fileAccessUrl;}
            {_fileAccessResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("fileAccessResourceId"), out var __jsonFileAccessResourceId) ? (string)__jsonFileAccessResourceId : (string)_fileAccessResourceId;}
            {_queryUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("queryUrl"), out var __jsonQueryUrl) ? (string)__jsonQueryUrl : (string)_queryUrl;}
            {_queryResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("queryResourceId"), out var __jsonQueryResourceId) ? (string)__jsonQueryResourceId : (string)_queryResourceId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json ? new ConsumptionEndpointsProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ConsumptionEndpointsProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConsumptionEndpointsProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._ingestionUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._ingestionUrl.ToString()) : null, "ingestionUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._ingestionResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._ingestionResourceId.ToString()) : null, "ingestionResourceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._fileAccessUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._fileAccessUrl.ToString()) : null, "fileAccessUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._fileAccessResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._fileAccessResourceId.ToString()) : null, "fileAccessResourceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._queryUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._queryUrl.ToString()) : null, "queryUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._queryResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._queryResourceId.ToString()) : null, "queryResourceId" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}