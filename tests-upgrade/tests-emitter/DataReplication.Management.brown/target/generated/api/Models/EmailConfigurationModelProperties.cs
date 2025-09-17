// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Email configuration model properties.</summary>
    public partial class EmailConfigurationModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IEmailConfigurationModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IEmailConfigurationModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CustomEmailAddress" /> property.</summary>
        private System.Collections.Generic.List<string> _customEmailAddress;

        /// <summary>Gets or sets the custom email address for sending emails.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> CustomEmailAddress { get => this._customEmailAddress; set => this._customEmailAddress = value; }

        /// <summary>Backing field for <see cref="Locale" /> property.</summary>
        private string _locale;

        /// <summary>Gets or sets the locale for the email notification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Locale { get => this._locale; set => this._locale = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IEmailConfigurationModelPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets or sets the provisioning state of the email configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SendToOwner" /> property.</summary>
        private bool _sendToOwner;

        /// <summary>
        /// Gets or sets a value indicating whether to send email to subscription administrator.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool SendToOwner { get => this._sendToOwner; set => this._sendToOwner = value; }

        /// <summary>Creates an new <see cref="EmailConfigurationModelProperties" /> instance.</summary>
        public EmailConfigurationModelProperties()
        {

        }
    }
    /// Email configuration model properties.
    public partial interface IEmailConfigurationModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the custom email address for sending emails.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the custom email address for sending emails.",
        SerializedName = @"customEmailAddresses",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> CustomEmailAddress { get; set; }
        /// <summary>Gets or sets the locale for the email notification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the locale for the email notification.",
        SerializedName = @"locale",
        PossibleTypes = new [] { typeof(string) })]
        string Locale { get; set; }
        /// <summary>Gets or sets the provisioning state of the email configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the email configuration.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>
        /// Gets or sets a value indicating whether to send email to subscription administrator.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets a value indicating whether to send email to subscription administrator.",
        SerializedName = @"sendToOwners",
        PossibleTypes = new [] { typeof(bool) })]
        bool SendToOwner { get; set; }

    }
    /// Email configuration model properties.
    internal partial interface IEmailConfigurationModelPropertiesInternal

    {
        /// <summary>Gets or sets the custom email address for sending emails.</summary>
        System.Collections.Generic.List<string> CustomEmailAddress { get; set; }
        /// <summary>Gets or sets the locale for the email notification.</summary>
        string Locale { get; set; }
        /// <summary>Gets or sets the provisioning state of the email configuration.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to send email to subscription administrator.
        /// </summary>
        bool SendToOwner { get; set; }

    }
}