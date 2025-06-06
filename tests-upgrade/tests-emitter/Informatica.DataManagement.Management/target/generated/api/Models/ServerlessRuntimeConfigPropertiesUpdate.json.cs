// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>The template for adding optional properties.</summary>
    public partial class ServerlessRuntimeConfigPropertiesUpdate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json ? new ServerlessRuntimeConfigPropertiesUpdate(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject into a new instance of <see cref="ServerlessRuntimeConfigPropertiesUpdate" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServerlessRuntimeConfigPropertiesUpdate(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_cdiConfigProp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray>("cdiConfigProps"), out var __jsonCdiConfigProps) ? If( __jsonCdiConfigProps as Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps) (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigProps.FromJson(__u) )) ))() : null : _cdiConfigProp;}
            {_cdieConfigProp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray>("cdieConfigProps"), out var __jsonCdieConfigProps) ? If( __jsonCdieConfigProps as Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps) (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigProps.FromJson(__p) )) ))() : null : _cdieConfigProp;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServerlessRuntimeConfigPropertiesUpdate" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServerlessRuntimeConfigPropertiesUpdate" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._cdiConfigProp)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.XNodeArray();
                foreach( var __x in this._cdiConfigProp )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("cdiConfigProps",__w);
            }
            if (null != this._cdieConfigProp)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.XNodeArray();
                foreach( var __s in this._cdieConfigProp )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("cdieConfigProps",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}