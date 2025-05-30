// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent a AppComplianceAutomation webhook resource update properties.</summary>
    public partial class WebhookResourcePatch :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatch,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal
    {

        /// <summary>content type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ContentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ContentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ContentType = value ?? null; }

        /// <summary>webhook deliveryStatus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string DeliveryStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).DeliveryStatus; }

        /// <summary>whether to enable ssl verification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string EnableSslVerification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).EnableSslVerification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).EnableSslVerification = value ?? null; }

        /// <summary>under which event notification should be sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Event { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).Event; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).Event = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DeliveryStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal.DeliveryStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).DeliveryStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).DeliveryStatus = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).TenantId = value ?? null; }

        /// <summary>Internal Acessors for WebhookId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal.WebhookId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookId = value ?? null; }

        /// <summary>Internal Acessors for WebhookKeyEnabled</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourcePatchInternal.WebhookKeyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKeyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKeyEnabled = value ?? null; }

        /// <summary>webhook payload url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string PayloadUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).PayloadUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).PayloadUrl = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties _property;

        /// <summary>Webhook property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties()); set => this._property = value; }

        /// <summary>Azure Resource Provisioning State</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ProvisioningState; }

        /// <summary>whether to send notification under any event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string SendAllEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).SendAllEvent; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).SendAllEvent = value ?? null; }

        /// <summary>Webhook status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).TenantId; }

        /// <summary>whether to update webhookKey.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string UpdateWebhookKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).UpdateWebhookKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).UpdateWebhookKey = value ?? null; }

        /// <summary>Webhook id in database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string WebhookId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookId; }

        /// <summary>
        /// webhook secret token. If not set, this field value is null; otherwise, please set a string value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string WebhookKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKey = value ?? null; }

        /// <summary>whether webhookKey is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string WebhookKeyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKeyEnabled; }

        /// <summary>Creates an new <see cref="WebhookResourcePatch" /> instance.</summary>
        public WebhookResourcePatch()
        {

        }
    }
    /// A class represent a AppComplianceAutomation webhook resource update properties.
    public partial interface IWebhookResourcePatch :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>content type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"content type",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("application/json")]
        string ContentType { get; set; }
        /// <summary>webhook deliveryStatus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"webhook deliveryStatus",
        SerializedName = @"deliveryStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "NotStarted")]
        string DeliveryStatus { get;  }
        /// <summary>whether to enable ssl verification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"whether to enable ssl verification",
        SerializedName = @"enableSslVerification",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string EnableSslVerification { get; set; }
        /// <summary>under which event notification should be sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"under which event notification should be sent.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("generate_snapshot_success", "generate_snapshot_failed", "assessment_failure", "report_configuration_changes", "report_deletion")]
        System.Collections.Generic.List<string> Event { get; set; }
        /// <summary>webhook payload url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"webhook payload url",
        SerializedName = @"payloadUrl",
        PossibleTypes = new [] { typeof(string) })]
        string PayloadUrl { get; set; }
        /// <summary>Azure Resource Provisioning State</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure Resource Provisioning State",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>whether to send notification under any event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"whether to send notification under any event.",
        SerializedName = @"sendAllEvents",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string SendAllEvent { get; set; }
        /// <summary>Webhook status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Webhook status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Status { get; set; }
        /// <summary>Tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>whether to update webhookKey.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"whether to update webhookKey.",
        SerializedName = @"updateWebhookKey",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string UpdateWebhookKey { get; set; }
        /// <summary>Webhook id in database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Webhook id in database.",
        SerializedName = @"webhookId",
        PossibleTypes = new [] { typeof(string) })]
        string WebhookId { get;  }
        /// <summary>
        /// webhook secret token. If not set, this field value is null; otherwise, please set a string value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"webhook secret token. If not set, this field value is null; otherwise, please set a string value.",
        SerializedName = @"webhookKey",
        PossibleTypes = new [] { typeof(string) })]
        string WebhookKey { get; set; }
        /// <summary>whether webhookKey is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"whether webhookKey is enabled.",
        SerializedName = @"webhookKeyEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string WebhookKeyEnabled { get;  }

    }
    /// A class represent a AppComplianceAutomation webhook resource update properties.
    internal partial interface IWebhookResourcePatchInternal

    {
        /// <summary>content type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("application/json")]
        string ContentType { get; set; }
        /// <summary>webhook deliveryStatus</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "NotStarted")]
        string DeliveryStatus { get; set; }
        /// <summary>whether to enable ssl verification</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string EnableSslVerification { get; set; }
        /// <summary>under which event notification should be sent.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("generate_snapshot_success", "generate_snapshot_failed", "assessment_failure", "report_configuration_changes", "report_deletion")]
        System.Collections.Generic.List<string> Event { get; set; }
        /// <summary>webhook payload url</summary>
        string PayloadUrl { get; set; }
        /// <summary>Webhook property.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties Property { get; set; }
        /// <summary>Azure Resource Provisioning State</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>whether to send notification under any event.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string SendAllEvent { get; set; }
        /// <summary>Webhook status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Status { get; set; }
        /// <summary>Tenant id.</summary>
        string TenantId { get; set; }
        /// <summary>whether to update webhookKey.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string UpdateWebhookKey { get; set; }
        /// <summary>Webhook id in database.</summary>
        string WebhookId { get; set; }
        /// <summary>
        /// webhook secret token. If not set, this field value is null; otherwise, please set a string value.
        /// </summary>
        string WebhookKey { get; set; }
        /// <summary>whether webhookKey is enabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string WebhookKeyEnabled { get; set; }

    }
}