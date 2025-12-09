// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>BackupAndExport Response Properties</summary>
    public partial class BackupAndExportResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="BackupMetadata" /> property.</summary>
        private string _backupMetadata;

        /// <summary>
        /// Metadata related to backup to be stored for restoring resource in key-value pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BackupMetadata { get => this._backupMetadata; set => this._backupMetadata = value; }

        /// <summary>Backing field for <see cref="DataTransferredInByte" /> property.</summary>
        private long? _dataTransferredInByte;

        /// <summary>Data transferred in bytes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? DataTransferredInByte { get => this._dataTransferredInByte; set => this._dataTransferredInByte = value; }

        /// <summary>Backing field for <see cref="DatasourceSizeInByte" /> property.</summary>
        private long? _datasourceSizeInByte;

        /// <summary>Size of datasource in bytes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? DatasourceSizeInByte { get => this._datasourceSizeInByte; set => this._datasourceSizeInByte = value; }

        /// <summary>Creates an new <see cref="BackupAndExportResponseProperties" /> instance.</summary>
        public BackupAndExportResponseProperties()
        {

        }
    }
    /// BackupAndExport Response Properties
    public partial interface IBackupAndExportResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Metadata related to backup to be stored for restoring resource in key-value pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Metadata related to backup to be stored for restoring resource in key-value pairs.",
        SerializedName = @"backupMetadata",
        PossibleTypes = new [] { typeof(string) })]
        string BackupMetadata { get; set; }
        /// <summary>Data transferred in bytes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data transferred in bytes",
        SerializedName = @"dataTransferredInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? DataTransferredInByte { get; set; }
        /// <summary>Size of datasource in bytes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Size of datasource in bytes",
        SerializedName = @"datasourceSizeInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? DatasourceSizeInByte { get; set; }

    }
    /// BackupAndExport Response Properties
    internal partial interface IBackupAndExportResponsePropertiesInternal

    {
        /// <summary>
        /// Metadata related to backup to be stored for restoring resource in key-value pairs.
        /// </summary>
        string BackupMetadata { get; set; }
        /// <summary>Data transferred in bytes</summary>
        long? DataTransferredInByte { get; set; }
        /// <summary>Size of datasource in bytes</summary>
        long? DatasourceSizeInByte { get; set; }

    }
}