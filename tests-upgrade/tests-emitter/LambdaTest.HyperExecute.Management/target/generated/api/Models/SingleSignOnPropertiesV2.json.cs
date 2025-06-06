// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Extensions;

    /// <summary>Properties specific to Single Sign On Resource</summary>
    public partial class SingleSignOnPropertiesV2
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISingleSignOnPropertiesV2.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISingleSignOnPropertiesV2.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISingleSignOnPropertiesV2 FromJson(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject json ? new SingleSignOnPropertiesV2(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject into a new instance of <see cref="SingleSignOnPropertiesV2" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SingleSignOnPropertiesV2(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)_state;}
            {_enterpriseAppId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString>("enterpriseAppId"), out var __jsonEnterpriseAppId) ? (string)__jsonEnterpriseAppId : (string)_enterpriseAppId;}
            {_url = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString>("url"), out var __jsonUrl) ? (string)__jsonUrl : (string)_url;}
            {_aadDomain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonArray>("aadDomains"), out var __jsonAadDomains) ? If( __jsonAadDomains as Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _aadDomain;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SingleSignOnPropertiesV2" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SingleSignOnPropertiesV2" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._enterpriseAppId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString(this._enterpriseAppId.ToString()) : null, "enterpriseAppId" ,container.Add );
            AddIf( null != (((object)this._url)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString(this._url.ToString()) : null, "url" ,container.Add );
            if (null != this._aadDomain)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.XNodeArray();
                foreach( var __x in this._aadDomain )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("aadDomains",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}