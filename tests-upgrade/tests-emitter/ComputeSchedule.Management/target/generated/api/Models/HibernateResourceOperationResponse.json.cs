// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The response from a Hibernate request</summary>
    public partial class HibernateResourceOperationResponse
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IHibernateResourceOperationResponse FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json ? new HibernateResourceOperationResponse(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject into a new instance of <see cref="HibernateResourceOperationResponse" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal HibernateResourceOperationResponse(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)_location;}
            {_result = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonArray>("results"), out var __jsonResults) ? If( __jsonResults as Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation) (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperation.FromJson(__u) )) ))() : null : _result;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="HibernateResourceOperationResponse" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="HibernateResourceOperationResponse" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            }
            if (null != this._result)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.XNodeArray();
                foreach( var __x in this._result )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("results",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}