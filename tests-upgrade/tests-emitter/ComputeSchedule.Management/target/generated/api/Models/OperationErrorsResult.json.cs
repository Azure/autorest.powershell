// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>
    /// This is the first level of operation errors from the request when clients get errors per vm operation
    /// </summary>
    public partial class OperationErrorsResult
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json ? new OperationErrorsResult(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject into a new instance of <see cref="OperationErrorsResult" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OperationErrorsResult(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_operationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("operationId"), out var __jsonOperationId) ? (string)__jsonOperationId : (string)_operationId;}
            {_creationTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("creationTime"), out var __jsonCreationTime) ? global::System.DateTime.TryParse((string)__jsonCreationTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreationTimeValue) ? __jsonCreationTimeValue : _creationTime : _creationTime;}
            {_activationTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("activationTime"), out var __jsonActivationTime) ? global::System.DateTime.TryParse((string)__jsonActivationTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonActivationTimeValue) ? __jsonActivationTimeValue : _activationTime : _activationTime;}
            {_completedAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("completedAt"), out var __jsonCompletedAt) ? global::System.DateTime.TryParse((string)__jsonCompletedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCompletedAtValue) ? __jsonCompletedAtValue : _completedAt : _completedAt;}
            {_operationError = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonArray>("operationErrors"), out var __jsonOperationErrors) ? If( __jsonOperationErrors as Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails) (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorDetails.FromJson(__u) )) ))() : null : _operationError;}
            {_requestErrorCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("requestErrorCode"), out var __jsonRequestErrorCode) ? (string)__jsonRequestErrorCode : (string)_requestErrorCode;}
            {_requestErrorDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("requestErrorDetails"), out var __jsonRequestErrorDetails) ? (string)__jsonRequestErrorDetails : (string)_requestErrorDetail;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OperationErrorsResult" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OperationErrorsResult" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._operationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._operationId.ToString()) : null, "operationId" ,container.Add );
            AddIf( null != this._creationTime ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._creationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "creationTime" ,container.Add );
            AddIf( null != this._activationTime ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._activationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "activationTime" ,container.Add );
            AddIf( null != this._completedAt ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._completedAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "completedAt" ,container.Add );
            if (null != this._operationError)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.XNodeArray();
                foreach( var __x in this._operationError )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("operationErrors",__w);
            }
            AddIf( null != (((object)this._requestErrorCode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._requestErrorCode.ToString()) : null, "requestErrorCode" ,container.Add );
            AddIf( null != (((object)this._requestErrorDetail)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._requestErrorDetail.ToString()) : null, "requestErrorDetails" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}