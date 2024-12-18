// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Webhook properties.</summary>
    public partial class WebhookProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>content type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Backing field for <see cref="DeliveryStatus" /> property.</summary>
        private string _deliveryStatus;

        /// <summary>webhook deliveryStatus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string DeliveryStatus { get => this._deliveryStatus; }

        /// <summary>Backing field for <see cref="EnableSslVerification" /> property.</summary>
        private string _enableSslVerification;

        /// <summary>whether to enable ssl verification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string EnableSslVerification { get => this._enableSslVerification; set => this._enableSslVerification = value; }

        /// <summary>Backing field for <see cref="Event" /> property.</summary>
        private System.Collections.Generic.List<string> _event;

        /// <summary>under which event notification should be sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Event { get => this._event; set => this._event = value; }

        /// <summary>Internal Acessors for DeliveryStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal.DeliveryStatus { get => this._deliveryStatus; set { {_deliveryStatus = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Internal Acessors for WebhookId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal.WebhookId { get => this._webhookId; set { {_webhookId = value;} } }

        /// <summary>Internal Acessors for WebhookKeyEnabled</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal.WebhookKeyEnabled { get => this._webhookKeyEnabled; set { {_webhookKeyEnabled = value;} } }

        /// <summary>Backing field for <see cref="PayloadUrl" /> property.</summary>
        private string _payloadUrl;

        /// <summary>webhook payload url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string PayloadUrl { get => this._payloadUrl; set => this._payloadUrl = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Azure Resource Provisioning State</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SendAllEvent" /> property.</summary>
        private string _sendAllEvent;

        /// <summary>whether to send notification under any event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string SendAllEvent { get => this._sendAllEvent; set => this._sendAllEvent = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Webhook status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="UpdateWebhookKey" /> property.</summary>
        private string _updateWebhookKey;

        /// <summary>whether to update webhookKey.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string UpdateWebhookKey { get => this._updateWebhookKey; set => this._updateWebhookKey = value; }

        /// <summary>Backing field for <see cref="WebhookId" /> property.</summary>
        private string _webhookId;

        /// <summary>Webhook id in database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string WebhookId { get => this._webhookId; }

        /// <summary>Backing field for <see cref="WebhookKey" /> property.</summary>
        private string _webhookKey;

        /// <summary>
        /// webhook secret token. If not set, this field value is null; otherwise, please set a string value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string WebhookKey { get => this._webhookKey; set => this._webhookKey = value; }

        /// <summary>Backing field for <see cref="WebhookKeyEnabled" /> property.</summary>
        private string _webhookKeyEnabled;

        /// <summary>whether webhookKey is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string WebhookKeyEnabled { get => this._webhookKeyEnabled; }

        /// <summary>Creates an new <see cref="WebhookProperties" /> instance.</summary>
        public WebhookProperties()
        {

        }
    }
    /// Webhook properties.
    public partial interface IWebhookProperties :
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
    /// Webhook properties.
    internal partial interface IWebhookPropertiesInternal

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