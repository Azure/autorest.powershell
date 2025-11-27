// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The properties of the key.</summary>
    public partial class ManagedHsmKeyProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject json ? new ManagedHsmKeyProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject into a new instance of <see cref="ManagedHsmKeyProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedHsmKeyProperties(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_attribute = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject>("attributes"), out var __jsonAttributes) ? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyAttributes.FromJson(__jsonAttributes) : _attribute;}
            {_rotationPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject>("rotationPolicy"), out var __jsonRotationPolicy) ? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmRotationPolicy.FromJson(__jsonRotationPolicy) : _rotationPolicy;}
            {_releasePolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject>("release_policy"), out var __jsonReleasePolicy) ? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyReleasePolicy.FromJson(__jsonReleasePolicy) : _releasePolicy;}
            {_kty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString>("kty"), out var __jsonKty) ? (string)__jsonKty : (string)_kty;}
            {_keyOp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonArray>("keyOps"), out var __jsonKeyOps) ? If( __jsonKeyOps as Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _keyOp;}
            {_keySize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber>("keySize"), out var __jsonKeySize) ? (int?)__jsonKeySize : _keySize;}
            {_curveName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString>("curveName"), out var __jsonCurveName) ? (string)__jsonCurveName : (string)_curveName;}
            {_keyUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString>("keyUri"), out var __jsonKeyUri) ? (string)__jsonKeyUri : (string)_keyUri;}
            {_keyUriWithVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString>("keyUriWithVersion"), out var __jsonKeyUriWithVersion) ? (string)__jsonKeyUriWithVersion : (string)_keyUriWithVersion;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedHsmKeyProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedHsmKeyProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._attribute ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) this._attribute.ToJson(null,serializationMode) : null, "attributes" ,container.Add );
            AddIf( null != this._rotationPolicy ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) this._rotationPolicy.ToJson(null,serializationMode) : null, "rotationPolicy" ,container.Add );
            AddIf( null != this._releasePolicy ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) this._releasePolicy.ToJson(null,serializationMode) : null, "release_policy" ,container.Add );
            AddIf( null != (((object)this._kty)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString(this._kty.ToString()) : null, "kty" ,container.Add );
            if (null != this._keyOp)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.XNodeArray();
                foreach( var __x in this._keyOp )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("keyOps",__w);
            }
            AddIf( null != this._keySize ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber((int)this._keySize) : null, "keySize" ,container.Add );
            AddIf( null != (((object)this._curveName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString(this._curveName.ToString()) : null, "curveName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._keyUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString(this._keyUri.ToString()) : null, "keyUri" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._keyUriWithVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonString(this._keyUriWithVersion.ToString()) : null, "keyUriWithVersion" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}