// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure VM workload-specific workload item representing SQL Instance.</summary>
    public partial class AzureVMWorkloadSqlInstanceWorkloadItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadSqlInstanceWorkloadItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadSqlInstanceWorkloadItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItem __azureVMWorkloadItem = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureVMWorkloadItem();

        /// <summary>Type of backup management to backup an item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).BackupManagementType = value ?? null; }

        /// <summary>Backing field for <see cref="DataDirectoryPath" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> _dataDirectoryPath;

        /// <summary>Data Directory Paths for default directories</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> DataDirectoryPath { get => this._dataDirectoryPath; set => this._dataDirectoryPath = value; }

        /// <summary>Friendly name of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).FriendlyName = value ?? null; }

        /// <summary>Indicates if workload item is auto-protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsAutoProtectable { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).IsAutoProtectable; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).IsAutoProtectable = value ?? default(bool); }

        /// <summary>Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ParentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).ParentName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).ParentName = value ?? null; }

        /// <summary>State of the back up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).ProtectionState = value ?? null; }

        /// <summary>Host/Cluster Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ServerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).ServerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).ServerName = value ?? null; }

        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? SubWorkloadItemCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).SubWorkloadItemCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).SubWorkloadItemCount = value ?? default(int); }

        /// <summary>For instance or AG, indicates number of DB's present</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? Subinquireditemcount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).Subinquireditemcount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal)__azureVMWorkloadItem).Subinquireditemcount = value ?? default(int); }

        /// <summary>Type of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "SQLInstance"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).Type = "SQLInstance"; }

        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__azureVMWorkloadItem).WorkloadType = value ?? null; }

        /// <summary>Creates an new <see cref="AzureVMWorkloadSqlInstanceWorkloadItem" /> instance.</summary>
        public AzureVMWorkloadSqlInstanceWorkloadItem()
        {
            this.__azureVMWorkloadItem.Type = "SQLInstance";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureVMWorkloadItem), __azureVMWorkloadItem);
            await eventListener.AssertObjectIsValid(nameof(__azureVMWorkloadItem), __azureVMWorkloadItem);
        }
    }
    /// Azure VM workload-specific workload item representing SQL Instance.
    public partial interface IAzureVMWorkloadSqlInstanceWorkloadItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItem
    {
        /// <summary>Data Directory Paths for default directories</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data Directory Paths for default directories",
        SerializedName = @"dataDirectoryPaths",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> DataDirectoryPath { get; set; }

    }
    /// Azure VM workload-specific workload item representing SQL Instance.
    internal partial interface IAzureVMWorkloadSqlInstanceWorkloadItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal
    {
        /// <summary>Data Directory Paths for default directories</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> DataDirectoryPath { get; set; }

    }
}