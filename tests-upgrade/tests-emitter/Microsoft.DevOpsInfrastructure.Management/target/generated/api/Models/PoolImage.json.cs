// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The VM image of the machines in the pool.</summary>
    public partial class PoolImage
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json ? new PoolImage(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject into a new instance of <see cref="PoolImage" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PoolImage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_resourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("resourceId"), out var __jsonResourceId) ? (string)__jsonResourceId : (string)_resourceId;}
            {_wellKnownImageName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("wellKnownImageName"), out var __jsonWellKnownImageName) ? (string)__jsonWellKnownImageName : (string)_wellKnownImageName;}
            {_alias = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray>("aliases"), out var __jsonAliases) ? If( __jsonAliases as Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _alias;}
            {_buffer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("buffer"), out var __jsonBuffer) ? (string)__jsonBuffer : (string)_buffer;}
            {_ephemeralType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("ephemeralType"), out var __jsonEphemeralType) ? (string)__jsonEphemeralType : (string)_ephemeralType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PoolImage" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PoolImage" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._resourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._resourceId.ToString()) : null, "resourceId" ,container.Add );
            AddIf( null != (((object)this._wellKnownImageName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._wellKnownImageName.ToString()) : null, "wellKnownImageName" ,container.Add );
            if (null != this._alias)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.XNodeArray();
                foreach( var __x in this._alias )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("aliases",__w);
            }
            AddIf( null != (((object)this._buffer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._buffer.ToString()) : null, "buffer" ,container.Add );
            AddIf( null != (((object)this._ephemeralType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString(this._ephemeralType.ToString()) : null, "ephemeralType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}