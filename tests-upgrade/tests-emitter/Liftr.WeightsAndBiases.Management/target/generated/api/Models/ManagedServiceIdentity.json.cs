// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;

    /// <summary>Managed service identity (system assigned and/or user assigned identities)</summary>
    public partial class ManagedServiceIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject json ? new ManagedServiceIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject into a new instance of <see cref="ManagedServiceIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedServiceIdentity(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_principalId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonString>("principalId"), out var __jsonPrincipalId) ? (string)__jsonPrincipalId : (string)_principalId;}
            {_tenantId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonString>("tenantId"), out var __jsonTenantId) ? (string)__jsonTenantId : (string)_tenantId;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_userAssignedIdentity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject>("userAssignedIdentities"), out var __jsonUserAssignedIdentities) ? Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserAssignedIdentities.FromJson(__jsonUserAssignedIdentities) : _userAssignedIdentity;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedServiceIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedServiceIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._principalId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonString(this._principalId.ToString()) : null, "principalId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._tenantId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonString(this._tenantId.ToString()) : null, "tenantId" ,container.Add );
            }
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != this._userAssignedIdentity ? (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode) this._userAssignedIdentity.ToJson(null,serializationMode) : null, "userAssignedIdentities" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}