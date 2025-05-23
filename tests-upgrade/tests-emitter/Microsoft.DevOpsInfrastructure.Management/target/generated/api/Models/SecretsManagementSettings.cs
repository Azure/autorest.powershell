// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The secret management settings of the machines in the pool.</summary>
    public partial class SecretsManagementSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettingsInternal
    {

        /// <summary>Backing field for <see cref="CertificateStoreLocation" /> property.</summary>
        private string _certificateStoreLocation;

        /// <summary>Where to store certificates on the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string CertificateStoreLocation { get => this._certificateStoreLocation; set => this._certificateStoreLocation = value; }

        /// <summary>Backing field for <see cref="CertificateStoreName" /> property.</summary>
        private string _certificateStoreName;

        /// <summary>
        /// Name of the certificate store to use on the machine, currently 'My' and 'Root' are supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string CertificateStoreName { get => this._certificateStoreName; set => this._certificateStoreName = value; }

        /// <summary>Backing field for <see cref="KeyExportable" /> property.</summary>
        private bool _keyExportable;

        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public bool KeyExportable { get => this._keyExportable; set => this._keyExportable = value; }

        /// <summary>Backing field for <see cref="ObservedCertificate" /> property.</summary>
        private System.Collections.Generic.List<string> _observedCertificate;

        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ObservedCertificate { get => this._observedCertificate; set => this._observedCertificate = value; }

        /// <summary>Creates an new <see cref="SecretsManagementSettings" /> instance.</summary>
        public SecretsManagementSettings()
        {

        }
    }
    /// The secret management settings of the machines in the pool.
    public partial interface ISecretsManagementSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
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
        string CertificateStoreLocation { get; set; }
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
        string CertificateStoreName { get; set; }
        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines if the key of the certificates should be exportable.",
        SerializedName = @"keyExportable",
        PossibleTypes = new [] { typeof(bool) })]
        bool KeyExportable { get; set; }
        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of certificates to install on all machines in the pool.",
        SerializedName = @"observedCertificates",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ObservedCertificate { get; set; }

    }
    /// The secret management settings of the machines in the pool.
    internal partial interface ISecretsManagementSettingsInternal

    {
        /// <summary>Where to store certificates on the machine.</summary>
        string CertificateStoreLocation { get; set; }
        /// <summary>
        /// Name of the certificate store to use on the machine, currently 'My' and 'Root' are supported.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("My", "Root")]
        string CertificateStoreName { get; set; }
        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        bool KeyExportable { get; set; }
        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        System.Collections.Generic.List<string> ObservedCertificate { get; set; }

    }
}