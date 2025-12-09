// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>BackupAndExport Response Properties</summary>
    public partial class BackupAndExportResponseType :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportResponseType,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportResponseTypeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType __operationProgressResponseType = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.OperationProgressResponseType();

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

        /// <summary>Identifies the type of source operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string ObjectType { get => "BackupAndExportResponse"; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal)__operationProgressResponseType).ObjectType = "BackupAndExportResponse"; }

        /// <summary>Creates an new <see cref="BackupAndExportResponseType" /> instance.</summary>
        public BackupAndExportResponseType()
        {
            this.__operationProgressResponseType.ObjectType = "BackupAndExportResponse";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__operationProgressResponseType), __operationProgressResponseType);
            await eventListener.AssertObjectIsValid(nameof(__operationProgressResponseType), __operationProgressResponseType);
        }
    }
    /// BackupAndExport Response Properties
    public partial interface IBackupAndExportResponseType :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType
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
    internal partial interface IBackupAndExportResponseTypeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal
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