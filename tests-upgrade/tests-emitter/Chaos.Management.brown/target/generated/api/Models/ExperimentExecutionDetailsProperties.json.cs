// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents the extended properties of an experiment execution.</summary>
    public partial class ExperimentExecutionDetailsProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject into a new instance of <see cref="ExperimentExecutionDetailsProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExperimentExecutionDetailsProperties(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_runInformation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject>("runInformation"), out var __jsonRunInformation) ? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ExperimentExecutionDetailsPropertiesRunInformation.FromJson(__jsonRunInformation) : _runInformation;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_startedAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString>("startedAt"), out var __jsonStartedAt) ? global::System.DateTime.TryParse((string)__jsonStartedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartedAtValue) ? __jsonStartedAtValue : _startedAt : _startedAt;}
            {_stoppedAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString>("stoppedAt"), out var __jsonStoppedAt) ? global::System.DateTime.TryParse((string)__jsonStoppedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStoppedAtValue) ? __jsonStoppedAtValue : _stoppedAt : _stoppedAt;}
            {_failureReason = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString>("failureReason"), out var __jsonFailureReason) ? (string)__jsonFailureReason : (string)_failureReason;}
            {_lastActionAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString>("lastActionAt"), out var __jsonLastActionAt) ? global::System.DateTime.TryParse((string)__jsonLastActionAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastActionAtValue) ? __jsonLastActionAtValue : _lastActionAt : _lastActionAt;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject json ? new ExperimentExecutionDetailsProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExperimentExecutionDetailsProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExperimentExecutionDetailsProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._runInformation ? (Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode) this._runInformation.ToJson(null,serializationMode) : null, "runInformation" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._startedAt ? (Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString(this._startedAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startedAt" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._stoppedAt ? (Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString(this._stoppedAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "stoppedAt" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._failureReason)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString(this._failureReason.ToString()) : null, "failureReason" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastActionAt ? (Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Json.JsonString(this._lastActionAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastActionAt" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}