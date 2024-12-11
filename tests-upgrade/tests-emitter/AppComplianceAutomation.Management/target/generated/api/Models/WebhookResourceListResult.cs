// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The response of a WebhookResource list operation.</summary>
    public partial class WebhookResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResource> _value;

        /// <summary>The WebhookResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="WebhookResourceListResult" /> instance.</summary>
        public WebhookResourceListResult()
        {

        }
    }
    /// The response of a WebhookResource list operation.
    public partial interface IWebhookResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The WebhookResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The WebhookResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResource> Value { get; set; }

    }
    /// The response of a WebhookResource list operation.
    internal partial interface IWebhookResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The WebhookResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IWebhookResource> Value { get; set; }

    }
}