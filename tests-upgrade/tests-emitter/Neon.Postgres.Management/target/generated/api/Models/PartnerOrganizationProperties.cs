// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Partner's organization</summary>
    public partial class PartnerOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal
    {

        /// <summary>Internal Acessors for SingleSignOnProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationPropertiesInternal.SingleSignOnProperty { get => (this._singleSignOnProperty = this._singleSignOnProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.SingleSignOnProperties()); set { {_singleSignOnProperty = value;} } }

        /// <summary>Backing field for <see cref="OrganizationId" /> property.</summary>
        private string _organizationId;

        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string OrganizationId { get => this._organizationId; set => this._organizationId = value; }

        /// <summary>Backing field for <see cref="OrganizationName" /> property.</summary>
        private string _organizationName;

        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string OrganizationName { get => this._organizationName; set => this._organizationName = value; }

        /// <summary>Backing field for <see cref="SingleSignOnProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties _singleSignOnProperty;

        /// <summary>Single Sign On properties for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties SingleSignOnProperty { get => (this._singleSignOnProperty = this._singleSignOnProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.SingleSignOnProperties()); set => this._singleSignOnProperty = value; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).AadDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).AadDomain = value ?? null /* arrayOf */; }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyEnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).EnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).EnterpriseAppId = value ?? null; }

        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnState = value ?? null; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnUrl = value ?? null; }

        /// <summary>Creates an new <see cref="PartnerOrganizationProperties" /> instance.</summary>
        public PartnerOrganizationProperties()
        {

        }
    }
    /// Properties specific to Partner's organization
    public partial interface IPartnerOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization Id in partner's system",
        SerializedName = @"organizationId",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationId { get; set; }
        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization name in partner's system",
        SerializedName = @"organizationName",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationName { get; set; }
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
        System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get; set; }
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
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
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
        string SingleSignOnPropertySingleSignOnState { get; set; }
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
        string SingleSignOnPropertySingleSignOnUrl { get; set; }

    }
    /// Properties specific to Partner's organization
    internal partial interface IPartnerOrganizationPropertiesInternal

    {
        /// <summary>Organization Id in partner's system</summary>
        string OrganizationId { get; set; }
        /// <summary>Organization name in partner's system</summary>
        string OrganizationName { get; set; }
        /// <summary>Single Sign On properties for the organization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties SingleSignOnProperty { get; set; }
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        string SingleSignOnPropertySingleSignOnUrl { get; set; }

    }
}