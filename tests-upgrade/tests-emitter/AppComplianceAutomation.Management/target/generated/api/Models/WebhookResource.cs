// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent an AppComplianceAutomation webhook resource.</summary>
    public partial class WebhookResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ProxyResource();

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

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>Internal Acessors for DeliveryStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal.DeliveryStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).DeliveryStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).DeliveryStatus = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookProperties Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.WebhookProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).TenantId = value ?? null; }

        /// <summary>Internal Acessors for WebhookId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal.WebhookId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookId = value ?? null; }

        /// <summary>Internal Acessors for WebhookKeyEnabled</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceInternal.WebhookKeyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKeyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).WebhookKeyEnabled = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Name; }

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

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>whether to send notification under any event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string SendAllEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).SendAllEvent; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).SendAllEvent = value ?? null; }

        /// <summary>Webhook status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>Tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookPropertiesInternal)Property).TenantId; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Type; }

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

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }

        /// <summary>Creates an new <see cref="WebhookResource" /> instance.</summary>
        public WebhookResource()
        {

        }
    }
    /// A class represent an AppComplianceAutomation webhook resource.
    public partial interface IWebhookResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResource
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
    /// A class represent an AppComplianceAutomation webhook resource.
    internal partial interface IWebhookResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResourceInternal
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