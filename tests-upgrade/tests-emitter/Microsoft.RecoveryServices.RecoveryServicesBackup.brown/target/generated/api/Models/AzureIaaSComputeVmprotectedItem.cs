// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// IaaS VM workload-specific backup item representing the Azure Resource Manager VM.
    /// </summary>
    public partial class AzureIaaSComputeVmprotectedItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSComputeVmprotectedItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSComputeVmprotectedItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItem __azureIaaSvmProtectedItem = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmProtectedItem();

        /// <summary>Type of backup management for the backed up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).BackupManagementType; }

        /// <summary>Name of the backup set the backup item belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).BackupSetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).BackupSetName = value ?? null; }

        /// <summary>Unique name of container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ContainerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).ContainerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).ContainerName = value ?? null; }

        /// <summary>
        /// Create mode to indicate recovery of existing soft deleted data source or creation of new data source.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string CreateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).CreateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).CreateMode = value ?? null; }

        /// <summary>Time for deferred deletion in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? DeferredDeleteTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).DeferredDeleteTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).DeferredDeleteTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Time remaining before the DS marked for deferred delete is permanently deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string DeferredDeleteTimeRemaining { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).DeferredDeleteTimeRemaining; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).DeferredDeleteTimeRemaining = value ?? null; }

        /// <summary>List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<int> DiskExclusionPropertyDiskLunList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).DiskExclusionPropertyDiskLunList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).DiskExclusionPropertyDiskLunList = value ?? null /* arrayOf */; }

        /// <summary>Flag to indicate whether DiskLunList is to be included/ excluded from backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? DiskExclusionPropertyIsInclusionList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).DiskExclusionPropertyIsInclusionList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).DiskExclusionPropertyIsInclusionList = value ?? default(bool); }

        /// <summary>Additional information for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemExtendedInfo ExtendedInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfo = value ?? null /* model class */; }

        /// <summary>The latest backup copy available for this backup item in archive tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? ExtendedInfoNewestRecoveryPointInArchive { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoNewestRecoveryPointInArchive; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoNewestRecoveryPointInArchive = value ?? default(global::System.DateTime); }

        /// <summary>The oldest backup copy available for this backup item across all tiers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? ExtendedInfoOldestRecoveryPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoOldestRecoveryPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoOldestRecoveryPoint = value ?? default(global::System.DateTime); }

        /// <summary>The oldest backup copy available for this backup item in archive tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? ExtendedInfoOldestRecoveryPointInArchive { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoOldestRecoveryPointInArchive; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoOldestRecoveryPointInArchive = value ?? default(global::System.DateTime); }

        /// <summary>The oldest backup copy available for this backup item in vault tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? ExtendedInfoOldestRecoveryPointInVault { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoOldestRecoveryPointInVault; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoOldestRecoveryPointInVault = value ?? default(global::System.DateTime); }

        /// <summary>Specifies if backup policy associated with the backup item is inconsistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? ExtendedInfoPolicyInconsistent { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoPolicyInconsistent; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoPolicyInconsistent = value ?? default(bool); }

        /// <summary>Number of backup copies available for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? ExtendedInfoRecoveryPointCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoRecoveryPointCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfoRecoveryPointCount = value ?? default(int); }

        /// <summary>Extended Properties for Azure IaasVM Backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedProperties ExtendedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedProperty = value ?? null /* model class */; }

        /// <summary>Extended Properties for Disk Exclusion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties ExtendedPropertyDiskExclusionProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedPropertyDiskExclusionProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedPropertyDiskExclusionProperty = value ?? null /* model class */; }

        /// <summary>Linux VM name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ExtendedPropertyLinuxVMApplicationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedPropertyLinuxVMApplicationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedPropertyLinuxVMApplicationName = value ?? null; }

        /// <summary>Friendly name of the VM represented by this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).FriendlyName; }

        /// <summary>Health details on this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmHealthDetails> HealthDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).HealthDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).HealthDetail = value ?? null /* arrayOf */; }

        /// <summary>Health status of protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).HealthStatus; }

        /// <summary>Flag to identify whether datasource is protected in archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsArchiveEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsArchiveEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsArchiveEnabled = value ?? default(bool); }

        /// <summary>Flag to identify whether the deferred deleted DS is to be purged soon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsDeferredDeleteScheduleUpcoming { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsDeferredDeleteScheduleUpcoming; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsDeferredDeleteScheduleUpcoming = value ?? default(bool); }

        /// <summary>Flag to identify that deferred deleted DS is to be moved into Pause state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsRehydrate { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsRehydrate; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsRehydrate = value ?? default(bool); }

        /// <summary>Flag to identify whether the DS is scheduled for deferred delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsScheduledForDeferredDelete { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsScheduledForDeferredDelete; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).IsScheduledForDeferredDelete = value ?? default(bool); }

        /// <summary>Health details of different KPIs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemKpisHealths KpisHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).KpisHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).KpisHealth = value ?? null /* model class */; }

        /// <summary>Last backup operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string LastBackupStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).LastBackupStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).LastBackupStatus = value ?? null; }

        /// <summary>Timestamp of the last backup operation on this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).LastBackupTime; }

        /// <summary>Timestamp when the last (latest) backup copy was created for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastRecoveryPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).LastRecoveryPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).LastRecoveryPoint = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.ExtendedInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.ExtendedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedPropertyDiskExclusionProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.ExtendedPropertyDiskExclusionProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedPropertyDiskExclusionProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ExtendedPropertyDiskExclusionProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).FriendlyName = value ?? null; }

        /// <summary>Internal Acessors for HealthStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).HealthStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).HealthStatus = value ?? null; }

        /// <summary>Internal Acessors for LastBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.LastBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).LastBackupTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).LastBackupTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for PolicyType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.PolicyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyType = value ?? null; }

        /// <summary>Internal Acessors for ProtectedItemDataId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.ProtectedItemDataId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectedItemDataId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectedItemDataId = value ?? null; }

        /// <summary>Internal Acessors for VirtualMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal.VirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).VirtualMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).VirtualMachineId = value ?? null; }

        /// <summary>Internal Acessors for BackupManagementType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal.BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).BackupManagementType = value ?? null; }

        /// <summary>Internal Acessors for VaultId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal.VaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).VaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).VaultId = value ?? null; }

        /// <summary>Internal Acessors for WorkloadType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal.WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).WorkloadType = value ?? null; }

        /// <summary>ID of the backup policy with which this item is backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyId = value ?? null; }

        /// <summary>Name of the policy used for protection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyName = value ?? null; }

        /// <summary>Type of the policy used for protection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).PolicyType; }

        /// <summary>Data ID of the protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectedItemDataId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectedItemDataId; }

        /// <summary>Backup state of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectionState = value ?? null; }

        /// <summary>Backup status of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).ProtectionStatus = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? SoftDeleteRetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).SoftDeleteRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).SoftDeleteRetentionPeriodInDay = value ?? default(int); }

        /// <summary>ARM ID of the resource to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).SourceResourceId = value ?? null; }

        /// <summary>backup item type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "Microsoft.Compute/virtualMachines"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).Type = "Microsoft.Compute/virtualMachines"; }

        /// <summary>ID of the vault which protects this item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string VaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).VaultId; }

        /// <summary>Fully qualified ARM ID of the virtual machine represented by this item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string VirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal)__azureIaaSvmProtectedItem).VirtualMachineId; }

        /// <summary>Type of workload this item represents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__azureIaaSvmProtectedItem).WorkloadType; }

        /// <summary>Creates an new <see cref="AzureIaaSComputeVmprotectedItem" /> instance.</summary>
        public AzureIaaSComputeVmprotectedItem()
        {
            this.__azureIaaSvmProtectedItem.Type = "Microsoft.Compute/virtualMachines";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureIaaSvmProtectedItem), __azureIaaSvmProtectedItem);
            await eventListener.AssertObjectIsValid(nameof(__azureIaaSvmProtectedItem), __azureIaaSvmProtectedItem);
        }
    }
    /// IaaS VM workload-specific backup item representing the Azure Resource Manager VM.
    public partial interface IAzureIaaSComputeVmprotectedItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItem
    {

    }
    /// IaaS VM workload-specific backup item representing the Azure Resource Manager VM.
    internal partial interface IAzureIaaSComputeVmprotectedItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectedItemInternal
    {

    }
}