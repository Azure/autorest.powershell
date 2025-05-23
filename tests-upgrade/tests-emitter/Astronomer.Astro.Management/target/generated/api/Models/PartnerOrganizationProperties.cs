// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Extensions;

    /// <summary>Properties specific to Partner's organization</summary>
    public partial class PartnerOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal
    {

        /// <summary>Internal Acessors for SingleSignOnProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal.SingleSignOnProperty { get => (this._singleSignOnProperty = this._singleSignOnProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.SingleSignOnProperties()); set { {_singleSignOnProperty = value;} } }

        /// <summary>Internal Acessors for SingleSignOnPropertyProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationPropertiesInternal.SingleSignOnPropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).ProvisioningState = value ?? null; }

        /// <summary>Backing field for <see cref="OrganizationId" /> property.</summary>
        private string _organizationId;

        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string OrganizationId { get => this._organizationId; set => this._organizationId = value; }

        /// <summary>Backing field for <see cref="OrganizationName" /> property.</summary>
        private string _organizationName;

        /// <summary>Organization name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string OrganizationName { get => this._organizationName; set => this._organizationName = value; }

        /// <summary>Backing field for <see cref="SingleSignOnProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties _singleSignOnProperty;

        /// <summary>Single Sign On properties for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties SingleSignOnProperty { get => (this._singleSignOnProperty = this._singleSignOnProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.SingleSignOnProperties()); set => this._singleSignOnProperty = value; }

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).AadDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).AadDomain = value ?? null /* arrayOf */; }

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyEnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).EnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).EnterpriseAppId = value ?? null; }

        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).ProvisioningState; }

        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnState = value ?? null; }

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="WorkspaceId" /> property.</summary>
        private string _workspaceId;

        /// <summary>Workspace Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string WorkspaceId { get => this._workspaceId; set => this._workspaceId = value; }

        /// <summary>Backing field for <see cref="WorkspaceName" /> property.</summary>
        private string _workspaceName;

        /// <summary>Workspace name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string WorkspaceName { get => this._workspaceName; set => this._workspaceName = value; }

        /// <summary>Creates an new <see cref="PartnerOrganizationProperties" /> instance.</summary>
        public PartnerOrganizationProperties()
        {

        }
    }
    /// Properties specific to Partner's organization
    public partial interface IPartnerOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.IJsonSerializable
    {
        /// <summary>Organization Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State of the resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string SingleSignOnPropertyProvisioningState { get;  }
        /// <summary>State of the Single Sign On for the organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the Single Sign On for the organization",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URL for SSO to be used by the partner to redirect the user to their system",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>Workspace Id in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workspace Id in partner's system",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceId { get; set; }
        /// <summary>Workspace name in partner's system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workspace name in partner's system",
        SerializedName = @"workspaceName",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceName { get; set; }

    }
    /// Properties specific to Partner's organization
    internal partial interface IPartnerOrganizationPropertiesInternal

    {
        /// <summary>Organization Id in partner's system</summary>
        string OrganizationId { get; set; }
        /// <summary>Organization name in partner's system</summary>
        string OrganizationName { get; set; }
        /// <summary>Single Sign On properties for the organization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties SingleSignOnProperty { get; set; }
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        System.Collections.Generic.List<string> SingleSignOnPropertyAadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string SingleSignOnPropertyProvisioningState { get; set; }
        /// <summary>State of the Single Sign On for the organization</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Astro.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>Workspace Id in partner's system</summary>
        string WorkspaceId { get; set; }
        /// <summary>Workspace name in partner's system</summary>
        string WorkspaceName { get; set; }

    }
}