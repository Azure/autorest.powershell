// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Webhook properties.</summary>
    public partial class WebhookProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json ? new WebhookProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="WebhookProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="WebhookProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" />.
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
                AddIf( null != (((object)this._webhookId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._webhookId.ToString()) : null, "webhookId" ,container.Add );
            }
            AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._tenantId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._tenantId.ToString()) : null, "tenantId" ,container.Add );
            }
            AddIf( null != (((object)this._sendAllEvent)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._sendAllEvent.ToString()) : null, "sendAllEvents" ,container.Add );
            if (null != this._event)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.XNodeArray();
                foreach( var __x in this._event )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("events",__w);
            }
            AddIf( null != (((object)this._payloadUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._payloadUrl.ToString()) : null, "payloadUrl" ,container.Add );
            AddIf( null != (((object)this._contentType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._contentType.ToString()) : null, "contentType" ,container.Add );
            AddIf( null != (((object)this._webhookKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._webhookKey.ToString()) : null, "webhookKey" ,container.Add );
            AddIf( null != (((object)this._updateWebhookKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._updateWebhookKey.ToString()) : null, "updateWebhookKey" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._webhookKeyEnabled)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._webhookKeyEnabled.ToString()) : null, "webhookKeyEnabled" ,container.Add );
            }
            AddIf( null != (((object)this._enableSslVerification)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._enableSslVerification.ToString()) : null, "enableSslVerification" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._deliveryStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._deliveryStatus.ToString()) : null, "deliveryStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject into a new instance of <see cref="WebhookProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal WebhookProperties(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_webhookId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("webhookId"), out var __jsonWebhookId) ? (string)__jsonWebhookId : (string)_webhookId;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_tenantId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("tenantId"), out var __jsonTenantId) ? (string)__jsonTenantId : (string)_tenantId;}
            {_sendAllEvent = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("sendAllEvents"), out var __jsonSendAllEvents) ? (string)__jsonSendAllEvents : (string)_sendAllEvent;}
            {_event = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonArray>("events"), out var __jsonEvents) ? If( __jsonEvents as Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _event;}
            {_payloadUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("payloadUrl"), out var __jsonPayloadUrl) ? (string)__jsonPayloadUrl : (string)_payloadUrl;}
            {_contentType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("contentType"), out var __jsonContentType) ? (string)__jsonContentType : (string)_contentType;}
            {_webhookKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("webhookKey"), out var __jsonWebhookKey) ? (string)__jsonWebhookKey : (string)_webhookKey;}
            {_updateWebhookKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("updateWebhookKey"), out var __jsonUpdateWebhookKey) ? (string)__jsonUpdateWebhookKey : (string)_updateWebhookKey;}
            {_webhookKeyEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("webhookKeyEnabled"), out var __jsonWebhookKeyEnabled) ? (string)__jsonWebhookKeyEnabled : (string)_webhookKeyEnabled;}
            {_enableSslVerification = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("enableSslVerification"), out var __jsonEnableSslVerification) ? (string)__jsonEnableSslVerification : (string)_enableSslVerification;}
            {_deliveryStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("deliveryStatus"), out var __jsonDeliveryStatus) ? (string)__jsonDeliveryStatus : (string)_deliveryStatus;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }
    }
}