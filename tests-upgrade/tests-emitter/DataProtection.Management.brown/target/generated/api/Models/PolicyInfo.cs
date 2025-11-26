// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Policy Info in backupInstance</summary>
    public partial class PolicyInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal
    {

        /// <summary>Internal Acessors for PolicyParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal.PolicyParameter { get => (this._policyParameter = this._policyParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParameters()); set { {_policyParameter = value;} } }

        /// <summary>Internal Acessors for PolicyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal.PolicyVersion { get => this._policyVersion; set { {_policyVersion = value;} } }

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private string _policyId;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="PolicyParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters _policyParameter;

        /// <summary>Policy parameters for the backup instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters PolicyParameter { get => (this._policyParameter = this._policyParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParameters()); set => this._policyParameter = value; }

        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParametersInternal)PolicyParameter).BackupDatasourceParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParametersInternal)PolicyParameter).BackupDatasourceParametersList = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the DataStore Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParametersInternal)PolicyParameter).DataStoreParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParametersInternal)PolicyParameter).DataStoreParametersList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="PolicyVersion" /> property.</summary>
        private string _policyVersion;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string PolicyVersion { get => this._policyVersion; }

        /// <summary>Creates an new <see cref="PolicyInfo" /> instance.</summary>
        public PolicyInfo()
        {

        }
    }
    /// Policy Info in backupInstance
    public partial interface IPolicyInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }
        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Backup Data Source Parameters",
        SerializedName = @"backupDatasourceParametersList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get; set; }
        /// <summary>Gets or sets the DataStore Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the DataStore Parameters",
        SerializedName = @"dataStoreParametersList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"policyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyVersion { get;  }

    }
    /// Policy Info in backupInstance
    internal partial interface IPolicyInfoInternal

    {
        string PolicyId { get; set; }
        /// <summary>Policy parameters for the backup instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters PolicyParameter { get; set; }
        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get; set; }
        /// <summary>Gets or sets the DataStore Parameters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get; set; }

        string PolicyVersion { get; set; }

    }
}