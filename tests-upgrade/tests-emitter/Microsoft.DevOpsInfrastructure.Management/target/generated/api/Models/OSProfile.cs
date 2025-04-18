// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The OS profile of the machines in the pool.</summary>
    public partial class OSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal
    {

        /// <summary>Backing field for <see cref="LogonType" /> property.</summary>
        private string _logonType;

        /// <summary>
        /// Determines how the service should be run. By default, this will be set to Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string LogonType { get => this._logonType; set => this._logonType = value; }

        /// <summary>Internal Acessors for SecretsManagementSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal.SecretsManagementSetting { get => (this._secretsManagementSetting = this._secretsManagementSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.SecretsManagementSettings()); set { {_secretsManagementSetting = value;} } }

        /// <summary>Where to store certificates on the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string SecretManagementSettingCertificateStoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).CertificateStoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).CertificateStoreLocation = value ?? null; }

        /// <summary>
        /// Name of the certificate store to use on the machine, currently 'My' and 'Root' are supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string SecretManagementSettingCertificateStoreName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).CertificateStoreName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).CertificateStoreName = value ?? null; }

        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public bool? SecretManagementSettingKeyExportable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).KeyExportable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).KeyExportable = value ?? default(bool); }

        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SecretManagementSettingObservedCertificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).ObservedCertificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal)SecretsManagementSetting).ObservedCertificate = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="SecretsManagementSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings _secretsManagementSetting;

        /// <summary>The secret management settings of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings SecretsManagementSetting { get => (this._secretsManagementSetting = this._secretsManagementSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.SecretsManagementSettings()); set => this._secretsManagementSetting = value; }

        /// <summary>Creates an new <see cref="OSProfile" /> instance.</summary>
        public OSProfile()
        {

        }
    }
    /// The OS profile of the machines in the pool.
    public partial interface IOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Determines how the service should be run. By default, this will be set to Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines how the service should be run. By default, this will be set to Service.",
        SerializedName = @"logonType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Service", "Interactive")]
        string LogonType { get; set; }
        /// <summary>Where to store certificates on the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Where to store certificates on the machine.",
        SerializedName = @"certificateStoreLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SecretManagementSettingCertificateStoreLocation { get; set; }
        /// <summary>
        /// Name of the certificate store to use on the machine, currently 'My' and 'Root' are supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the certificate store to use on the machine, currently 'My' and 'Root' are supported.",
        SerializedName = @"certificateStoreName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("My", "Root")]
        string SecretManagementSettingCertificateStoreName { get; set; }
        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines if the key of the certificates should be exportable.",
        SerializedName = @"keyExportable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecretManagementSettingKeyExportable { get; set; }
        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of certificates to install on all machines in the pool.",
        SerializedName = @"observedCertificates",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SecretManagementSettingObservedCertificate { get; set; }

    }
    /// The OS profile of the machines in the pool.
    internal partial interface IOSProfileInternal

    {
        /// <summary>
        /// Determines how the service should be run. By default, this will be set to Service.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Service", "Interactive")]
        string LogonType { get; set; }
        /// <summary>Where to store certificates on the machine.</summary>
        string SecretManagementSettingCertificateStoreLocation { get; set; }
        /// <summary>
        /// Name of the certificate store to use on the machine, currently 'My' and 'Root' are supported.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("My", "Root")]
        string SecretManagementSettingCertificateStoreName { get; set; }
        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        bool? SecretManagementSettingKeyExportable { get; set; }
        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        System.Collections.Generic.List<string> SecretManagementSettingObservedCertificate { get; set; }
        /// <summary>The secret management settings of the machines in the pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings SecretsManagementSetting { get; set; }

    }
}