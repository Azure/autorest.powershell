// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>
    /// Informatica runtime resource metadata as received via the informatica fetch all runtime environments API
    /// </summary>
    public partial class InfaRuntimeResourceFetchMetaData
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json ? new InfaRuntimeResourceFetchMetaData(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject into a new instance of <see cref="InfaRuntimeResourceFetchMetaData" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InfaRuntimeResourceFetchMetaData(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_serverlessConfigProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject>("serverlessConfigProperties"), out var __jsonServerlessConfigProperties) ? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties.FromJson(__jsonServerlessConfigProperties) : _serverlessConfigProperty;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)_name;}
            {_createdTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("createdTime"), out var __jsonCreatedTime) ? (string)__jsonCreatedTime : (string)_createdTime;}
            {_updatedTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("updatedTime"), out var __jsonUpdatedTime) ? (string)__jsonUpdatedTime : (string)_updatedTime;}
            {_createdBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("createdBy"), out var __jsonCreatedBy) ? (string)__jsonCreatedBy : (string)_createdBy;}
            {_updatedBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("updatedBy"), out var __jsonUpdatedBy) ? (string)__jsonUpdatedBy : (string)_updatedBy;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_statusLocalized = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("statusLocalized"), out var __jsonStatusLocalized) ? (string)__jsonStatusLocalized : (string)_statusLocalized;}
            {_statusMessage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("statusMessage"), out var __jsonStatusMessage) ? (string)__jsonStatusMessage : (string)_statusMessage;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InfaRuntimeResourceFetchMetaData" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InfaRuntimeResourceFetchMetaData" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._serverlessConfigProperty ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) this._serverlessConfigProperty.ToJson(null,serializationMode) : null, "serverlessConfigProperties" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._createdTime)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._createdTime.ToString()) : null, "createdTime" ,container.Add );
            AddIf( null != (((object)this._updatedTime)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._updatedTime.ToString()) : null, "updatedTime" ,container.Add );
            AddIf( null != (((object)this._createdBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._createdBy.ToString()) : null, "createdBy" ,container.Add );
            AddIf( null != (((object)this._updatedBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._updatedBy.ToString()) : null, "updatedBy" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._statusLocalized)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._statusLocalized.ToString()) : null, "statusLocalized" ,container.Add );
            AddIf( null != (((object)this._statusMessage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._statusMessage.ToString()) : null, "statusMessage" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}