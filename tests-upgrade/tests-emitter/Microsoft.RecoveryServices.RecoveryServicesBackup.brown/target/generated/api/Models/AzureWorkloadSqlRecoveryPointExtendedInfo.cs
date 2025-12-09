// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Extended info class details</summary>
    public partial class AzureWorkloadSqlRecoveryPointExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfoInternal
    {

        /// <summary>Backing field for <see cref="DataDirectoryPath" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> _dataDirectoryPath;

        /// <summary>List of data directory paths during restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> DataDirectoryPath { get => this._dataDirectoryPath; set => this._dataDirectoryPath = value; }

        /// <summary>Backing field for <see cref="DataDirectoryTimeInUtc" /> property.</summary>
        private global::System.DateTime? _dataDirectoryTimeInUtc;

        /// <summary>UTC time at which data directory info was captured</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? DataDirectoryTimeInUtc { get => this._dataDirectoryTimeInUtc; set => this._dataDirectoryTimeInUtc = value; }

        /// <summary>
        /// Creates an new <see cref="AzureWorkloadSqlRecoveryPointExtendedInfo" /> instance.
        /// </summary>
        public AzureWorkloadSqlRecoveryPointExtendedInfo()
        {

        }
    }
    /// Extended info class details
    public partial interface IAzureWorkloadSqlRecoveryPointExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of data directory paths during restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of data directory paths during restore operation.",
        SerializedName = @"dataDirectoryPaths",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> DataDirectoryPath { get; set; }
        /// <summary>UTC time at which data directory info was captured</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UTC time at which data directory info was captured",
        SerializedName = @"dataDirectoryTimeInUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DataDirectoryTimeInUtc { get; set; }

    }
    /// Extended info class details
    internal partial interface IAzureWorkloadSqlRecoveryPointExtendedInfoInternal

    {
        /// <summary>List of data directory paths during restore operation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> DataDirectoryPath { get; set; }
        /// <summary>UTC time at which data directory info was captured</summary>
        global::System.DateTime? DataDirectoryTimeInUtc { get; set; }

    }
}