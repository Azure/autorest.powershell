// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>Webhook properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesTypeConverter))]
    public partial class WebhookProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WebhookProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WebhookProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WebhookProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="WebhookProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WebhookProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("WebhookId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookId = (string) content.GetValueForProperty("WebhookId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("SendAllEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).SendAllEvent = (string) content.GetValueForProperty("SendAllEvent",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).SendAllEvent, global::System.Convert.ToString);
            }
            if (content.Contains("Event"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Event = (System.Collections.Generic.List<string>) content.GetValueForProperty("Event",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Event, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PayloadUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).PayloadUrl = (string) content.GetValueForProperty("PayloadUrl",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).PayloadUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKey = (string) content.GetValueForProperty("WebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateWebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).UpdateWebhookKey = (string) content.GetValueForProperty("UpdateWebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).UpdateWebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKeyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKeyEnabled = (string) content.GetValueForProperty("WebhookKeyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKeyEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("EnableSslVerification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).EnableSslVerification = (string) content.GetValueForProperty("EnableSslVerification",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).EnableSslVerification, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).DeliveryStatus = (string) content.GetValueForProperty("DeliveryStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).DeliveryStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WebhookProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("WebhookId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookId = (string) content.GetValueForProperty("WebhookId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("SendAllEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).SendAllEvent = (string) content.GetValueForProperty("SendAllEvent",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).SendAllEvent, global::System.Convert.ToString);
            }
            if (content.Contains("Event"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Event = (System.Collections.Generic.List<string>) content.GetValueForProperty("Event",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).Event, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PayloadUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).PayloadUrl = (string) content.GetValueForProperty("PayloadUrl",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).PayloadUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKey = (string) content.GetValueForProperty("WebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateWebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).UpdateWebhookKey = (string) content.GetValueForProperty("UpdateWebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).UpdateWebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKeyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKeyEnabled = (string) content.GetValueForProperty("WebhookKeyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).WebhookKeyEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("EnableSslVerification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).EnableSslVerification = (string) content.GetValueForProperty("EnableSslVerification",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).EnableSslVerification, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).DeliveryStatus = (string) content.GetValueForProperty("DeliveryStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).DeliveryStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Webhook properties.
    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesTypeConverter))]
    public partial interface IWebhookProperties

    {

    }
}