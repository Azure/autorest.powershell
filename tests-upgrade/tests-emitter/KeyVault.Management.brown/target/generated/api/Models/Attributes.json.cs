// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The object attributes managed by the KeyVault service.</summary>
    public partial class Attributes
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject into a new instance of <see cref="Attributes" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Attributes(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_enabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : _enabled;}
            {_notBefore = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber>("nbf"), out var __jsonNbf) ? long.TryParse((string)__jsonNbf, out var __jsonNbfValue) ? new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc).AddSeconds(__jsonNbfValue) : _notBefore : _notBefore;}
            {_expire = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber>("exp"), out var __jsonExp) ? long.TryParse((string)__jsonExp, out var __jsonExpValue) ? new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc).AddSeconds(__jsonExpValue) : _expire : _expire;}
            {_created = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber>("created"), out var __jsonCreated) ? long.TryParse((string)__jsonCreated, out var __jsonCreatedValue) ? new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc).AddSeconds(__jsonCreatedValue) : _created : _created;}
            {_updated = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber>("updated"), out var __jsonUpdated) ? long.TryParse((string)__jsonUpdated, out var __jsonUpdatedValue) ? new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc).AddSeconds(__jsonUpdatedValue) : _updated : _updated;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributes.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributes.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributes FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject json ? new Attributes(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Attributes" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Attributes" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._enabled ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            AddIf( null != this._notBefore ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber(((long?)(this._notBefore?.Subtract(new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds)??0)) : null, "nbf" ,container.Add );
            AddIf( null != this._expire ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber(((long?)(this._expire?.Subtract(new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds)??0)) : null, "exp" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._created ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber(((long?)(this._created?.Subtract(new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds)??0)) : null, "created" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._updated ? (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNumber(((long?)(this._updated?.Subtract(new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds)??0)) : null, "updated" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}