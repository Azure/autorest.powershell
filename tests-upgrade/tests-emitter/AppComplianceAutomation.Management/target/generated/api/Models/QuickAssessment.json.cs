// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the quick assessment.</summary>
    public partial class QuickAssessment
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json ? new QuickAssessment(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject into a new instance of <see cref="QuickAssessment" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal QuickAssessment(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_resourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("resourceId"), out var __jsonResourceId) ? (string)__jsonResourceId : (string)_resourceId;}
            {_responsibilityId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("responsibilityId"), out var __jsonResponsibilityId) ? (string)__jsonResponsibilityId : (string)_responsibilityId;}
            {_timestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("timestamp"), out var __jsonTimestamp) ? global::System.DateTime.TryParse((string)__jsonTimestamp, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonTimestampValue) ? __jsonTimestampValue : _timestamp : _timestamp;}
            {_resourceStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("resourceStatus"), out var __jsonResourceStatus) ? (string)__jsonResourceStatus : (string)_resourceStatus;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)_displayName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_remediationLink = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("remediationLink"), out var __jsonRemediationLink) ? (string)__jsonRemediationLink : (string)_remediationLink;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="QuickAssessment" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="QuickAssessment" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._resourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._resourceId.ToString()) : null, "resourceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._responsibilityId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._responsibilityId.ToString()) : null, "responsibilityId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._timestamp ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._timestamp?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "timestamp" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._resourceStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._resourceStatus.ToString()) : null, "resourceStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._remediationLink)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._remediationLink.ToString()) : null, "remediationLink" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}