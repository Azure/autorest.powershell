// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>A class represent a AppComplianceAutomation webhook resource update properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(WebhookResourcePatchTypeConverter))]
    public partial class WebhookResourcePatch
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookResourcePatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatch" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatch DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WebhookResourcePatch(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookResourcePatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatch" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatch DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WebhookResourcePatch(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WebhookResourcePatch" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="WebhookResourcePatch" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatch FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookResourcePatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WebhookResourcePatch(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Event"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Event = (System.Collections.Generic.List<string>) content.GetValueForProperty("Event",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Event, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).DeliveryStatus = (string) content.GetValueForProperty("DeliveryStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).DeliveryStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookId = (string) content.GetValueForProperty("WebhookId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("SendAllEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).SendAllEvent = (string) content.GetValueForProperty("SendAllEvent",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).SendAllEvent, global::System.Convert.ToString);
            }
            if (content.Contains("PayloadUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).PayloadUrl = (string) content.GetValueForProperty("PayloadUrl",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).PayloadUrl, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKey = (string) content.GetValueForProperty("WebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateWebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).UpdateWebhookKey = (string) content.GetValueForProperty("UpdateWebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).UpdateWebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKeyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKeyEnabled = (string) content.GetValueForProperty("WebhookKeyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKeyEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("EnableSslVerification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).EnableSslVerification = (string) content.GetValueForProperty("EnableSslVerification",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).EnableSslVerification, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookResourcePatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WebhookResourcePatch(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Event"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Event = (System.Collections.Generic.List<string>) content.GetValueForProperty("Event",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Event, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).DeliveryStatus = (string) content.GetValueForProperty("DeliveryStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).DeliveryStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookId = (string) content.GetValueForProperty("WebhookId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("SendAllEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).SendAllEvent = (string) content.GetValueForProperty("SendAllEvent",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).SendAllEvent, global::System.Convert.ToString);
            }
            if (content.Contains("PayloadUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).PayloadUrl = (string) content.GetValueForProperty("PayloadUrl",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).PayloadUrl, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKey = (string) content.GetValueForProperty("WebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateWebhookKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).UpdateWebhookKey = (string) content.GetValueForProperty("UpdateWebhookKey",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).UpdateWebhookKey, global::System.Convert.ToString);
            }
            if (content.Contains("WebhookKeyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKeyEnabled = (string) content.GetValueForProperty("WebhookKeyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).WebhookKeyEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("EnableSslVerification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).EnableSslVerification = (string) content.GetValueForProperty("EnableSslVerification",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal)this).EnableSslVerification, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// A class represent a AppComplianceAutomation webhook resource update properties.
    [System.ComponentModel.TypeConverter(typeof(WebhookResourcePatchTypeConverter))]
    public partial interface IWebhookResourcePatch

    {

    }
}