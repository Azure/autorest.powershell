// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The details of a response from an operation on a resource</summary>
    public partial class ResourceOperationDetails
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json ? new ResourceOperationDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject into a new instance of <see cref="ResourceOperationDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ResourceOperationDetails(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_resourceOperationError = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject>("resourceOperationError"), out var __jsonResourceOperationError) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationError.FromJson(__jsonResourceOperationError) : _resourceOperationError;}
            {_retryPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject>("retryPolicy"), out var __jsonRetryPolicy) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicy.FromJson(__jsonRetryPolicy) : _retryPolicy;}
            {_operationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("operationId"), out var __jsonOperationId) ? (string)__jsonOperationId : (string)_operationId;}
            {_resourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("resourceId"), out var __jsonResourceId) ? (string)__jsonResourceId : (string)_resourceId;}
            {_opType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("opType"), out var __jsonOpType) ? (string)__jsonOpType : (string)_opType;}
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)_subscriptionId;}
            {_deadline = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("deadline"), out var __jsonDeadline) ? global::System.DateTime.TryParse((string)__jsonDeadline, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDeadlineValue) ? __jsonDeadlineValue : _deadline : _deadline;}
            {_deadlineType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("deadlineType"), out var __jsonDeadlineType) ? (string)__jsonDeadlineType : (string)_deadlineType;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)_state;}
            {_timezone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("timezone"), out var __jsonTimezone) ? (string)__jsonTimezone : (string)_timezone;}
            {_timeZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("timeZone"), out var __jsonTimeZone) ? (string)__jsonTimeZone : (string)_timeZone;}
            {_completedAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString>("completedAt"), out var __jsonCompletedAt) ? global::System.DateTime.TryParse((string)__jsonCompletedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCompletedAtValue) ? __jsonCompletedAtValue : _completedAt : _completedAt;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ResourceOperationDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ResourceOperationDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._resourceOperationError ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) this._resourceOperationError.ToJson(null,serializationMode) : null, "resourceOperationError" ,container.Add );
            AddIf( null != this._retryPolicy ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) this._retryPolicy.ToJson(null,serializationMode) : null, "retryPolicy" ,container.Add );
            AddIf( null != (((object)this._operationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._operationId.ToString()) : null, "operationId" ,container.Add );
            AddIf( null != (((object)this._resourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._resourceId.ToString()) : null, "resourceId" ,container.Add );
            AddIf( null != (((object)this._opType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._opType.ToString()) : null, "opType" ,container.Add );
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != this._deadline ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._deadline?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "deadline" ,container.Add );
            AddIf( null != (((object)this._deadlineType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._deadlineType.ToString()) : null, "deadlineType" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._timezone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._timezone.ToString()) : null, "timezone" ,container.Add );
            AddIf( null != (((object)this._timeZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._timeZone.ToString()) : null, "timeZone" ,container.Add );
            AddIf( null != this._completedAt ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonString(this._completedAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "completedAt" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}