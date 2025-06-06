// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Properties of a ResourceSku</summary>
    public partial class ResourceSkuProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json ? new ResourceSkuProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject into a new instance of <see cref="ResourceSkuProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ResourceSkuProperties(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_resourceType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("resourceType"), out var __jsonResourceType) ? (string)__jsonResourceType : (string)_resourceType;}
            {_tier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("tier"), out var __jsonTier) ? (string)__jsonTier : (string)_tier;}
            {_size = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("size"), out var __jsonSize) ? (string)__jsonSize : (string)_size;}
            {_family = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("family"), out var __jsonFamily) ? (string)__jsonFamily : (string)_family;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray>("locations"), out var __jsonLocations) ? If( __jsonLocations as Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _location;}
            {_locationInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray>("locationInfo"), out var __jsonLocationInfo) ? If( __jsonLocationInfo as Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuLocationInfo>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuLocationInfo) (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuLocationInfo.FromJson(__p) )) ))() : null : _locationInfo;}
            {_capability = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray>("capabilities"), out var __jsonCapabilities) ? If( __jsonCapabilities as Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities) (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuCapabilities.FromJson(__k) )) ))() : null : _capability;}
            {_restriction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray>("restrictions"), out var __jsonRestrictions) ? If( __jsonRestrictions as Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictions>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictions) (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuRestrictions.FromJson(__f) )) ))() : null : _restriction;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ResourceSkuProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ResourceSkuProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._resourceType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._resourceType.ToString()) : null, "resourceType" ,container.Add );
            AddIf( null != (((object)this._tier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._tier.ToString()) : null, "tier" ,container.Add );
            AddIf( null != (((object)this._size)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._size.ToString()) : null, "size" ,container.Add );
            AddIf( null != (((object)this._family)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._family.ToString()) : null, "family" ,container.Add );
            if (null != this._location)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.XNodeArray();
                foreach( var __x in this._location )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("locations",__w);
            }
            if (null != this._locationInfo)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.XNodeArray();
                foreach( var __s in this._locationInfo )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("locationInfo",__r);
            }
            if (null != this._capability)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.XNodeArray();
                foreach( var __n in this._capability )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("capabilities",__m);
            }
            if (null != this._restriction)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.XNodeArray();
                foreach( var __i in this._restriction )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("restrictions",__h);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}