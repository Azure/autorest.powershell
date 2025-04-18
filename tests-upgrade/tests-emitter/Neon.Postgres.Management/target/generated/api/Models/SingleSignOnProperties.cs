// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Single Sign On Resource</summary>
    public partial class SingleSignOnProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AadDomain" /> property.</summary>
        private System.Collections.Generic.List<string> _aadDomain;

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AadDomain { get => this._aadDomain; set => this._aadDomain = value; }

        /// <summary>Backing field for <see cref="EnterpriseAppId" /> property.</summary>
        private string _enterpriseAppId;

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string EnterpriseAppId { get => this._enterpriseAppId; set => this._enterpriseAppId = value; }

        /// <summary>Backing field for <see cref="SingleSignOnState" /> property.</summary>
        private string _singleSignOnState;

        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string SingleSignOnState { get => this._singleSignOnState; set => this._singleSignOnState = value; }

        /// <summary>Backing field for <see cref="SingleSignOnUrl" /> property.</summary>
        private string _singleSignOnUrl;

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string SingleSignOnUrl { get => this._singleSignOnUrl; set => this._singleSignOnUrl = value; }

        /// <summary>Creates an new <see cref="SingleSignOnProperties" /> instance.</summary>
        public SingleSignOnProperties()
        {

        }
    }
    /// Properties specific to Single Sign On Resource
    public partial interface ISingleSignOnProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of AAD domains fetched from Microsoft Graph for user.",
        SerializedName = @"aadDomains",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string EnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the Single Sign On for the organization",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URL for SSO to be used by the partner to redirect the user to their system",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnUrl { get; set; }

    }
    /// Properties specific to Single Sign On Resource
    internal partial interface ISingleSignOnPropertiesInternal

    {
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        System.Collections.Generic.List<string> AadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        string EnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        string SingleSignOnUrl { get; set; }

    }
}