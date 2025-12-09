// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure VM workload-specific protected item.</summary>
    public partial class AzureVMWorkloadProtectedItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItem __protectedItem = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ProtectedItem();

        /// <summary>Type of backup management for the backed up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).BackupManagementType; }

        /// <summary>Name of the backup set the backup item belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).BackupSetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).BackupSetName = value ?? null; }

        /// <summary>Unique name of container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ContainerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).ContainerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).ContainerName = value ?? null; }

        /// <summary>
        /// Create mode to indicate recovery of existing soft deleted data source or creation of new data source.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string CreateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).CreateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).CreateMode = value ?? null; }

        /// <summary>Time for deferred deletion in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? DeferredDeleteTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).DeferredDeleteTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).DeferredDeleteTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Time remaining before the DS marked for deferred delete is permanently deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string DeferredDeleteTimeRemaining { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).DeferredDeleteTimeRemaining; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).DeferredDeleteTimeRemaining = value ?? null; }

        /// <summary>Backing field for <see cref="ExtendedInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfo _extendedInfo;

        /// <summary>Additional information for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfo ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureVMWorkloadProtectedItemExtendedInfo()); set => this._extendedInfo = value; }

        /// <summary>The latest backup copy available for this backup item in archive tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExtendedInfoNewestRecoveryPointInArchive { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).NewestRecoveryPointInArchive; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).NewestRecoveryPointInArchive = value ?? default(global::System.DateTime); }

        /// <summary>The oldest backup copy available for this backup item across all tiers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExtendedInfoOldestRecoveryPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).OldestRecoveryPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).OldestRecoveryPoint = value ?? default(global::System.DateTime); }

        /// <summary>The oldest backup copy available for this backup item in archive tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExtendedInfoOldestRecoveryPointInArchive { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).OldestRecoveryPointInArchive; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).OldestRecoveryPointInArchive = value ?? default(global::System.DateTime); }

        /// <summary>The oldest backup copy available for this backup item in vault tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExtendedInfoOldestRecoveryPointInVault { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).OldestRecoveryPointInVault; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).OldestRecoveryPointInVault = value ?? default(global::System.DateTime); }

        /// <summary>Indicates consistency of policy object and policy applied to this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoPolicyState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).PolicyState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).PolicyState = value ?? null; }

        /// <summary>Indicates consistency of policy object and policy applied to this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoRecoveryModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).RecoveryModel; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).RecoveryModel = value ?? null; }

        /// <summary>Number of backup copies available for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? ExtendedInfoRecoveryPointCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).RecoveryPointCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfoInternal)ExtendedInfo).RecoveryPointCount = value ?? default(int); }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of the DB represented by this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; }

        /// <summary>Flag to identify whether datasource is protected in archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsArchiveEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsArchiveEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsArchiveEnabled = value ?? default(bool); }

        /// <summary>Flag to identify whether the deferred deleted DS is to be purged soon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsDeferredDeleteScheduleUpcoming { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsDeferredDeleteScheduleUpcoming; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsDeferredDeleteScheduleUpcoming = value ?? default(bool); }

        /// <summary>Flag to identify that deferred deleted DS is to be moved into Pause state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsRehydrate { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsRehydrate; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsRehydrate = value ?? default(bool); }

        /// <summary>Flag to identify whether the DS is scheduled for deferred delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsScheduledForDeferredDelete { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsScheduledForDeferredDelete; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).IsScheduledForDeferredDelete = value ?? default(bool); }

        /// <summary>Backing field for <see cref="KpisHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealths _kpisHealth;

        /// <summary>Health details of different KPIs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealths KpisHealth { get => (this._kpisHealth = this._kpisHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureVMWorkloadProtectedItemKpisHealths()); set => this._kpisHealth = value; }

        /// <summary>Backing field for <see cref="LastBackupErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 _lastBackupErrorDetail;

        /// <summary>Error details in last backup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 LastBackupErrorDetail { get => (this._lastBackupErrorDetail = this._lastBackupErrorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ErrorDetail1()); set => this._lastBackupErrorDetail = value; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string LastBackupErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Code; }

        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string LastBackupErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Message; }

        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> LastBackupErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Recommendation; }

        /// <summary>Backing field for <see cref="LastBackupStatus" /> property.</summary>
        private string _lastBackupStatus;

        /// <summary>Last backup operation status. Possible values: Healthy, Unhealthy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string LastBackupStatus { get => this._lastBackupStatus; set => this._lastBackupStatus = value; }

        /// <summary>Backing field for <see cref="LastBackupTime" /> property.</summary>
        private global::System.DateTime? _lastBackupTime;

        /// <summary>Timestamp of the last backup operation on this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? LastBackupTime { get => this._lastBackupTime; set => this._lastBackupTime = value; }

        /// <summary>Timestamp when the last (latest) backup copy was created for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastRecoveryPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).LastRecoveryPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).LastRecoveryPoint = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureVMWorkloadProtectedItemExtendedInfo()); set { {_extendedInfo = value;} } }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.FriendlyName { get => this._friendlyName; set { {_friendlyName = value;} } }

        /// <summary>Internal Acessors for LastBackupErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.LastBackupErrorDetail { get => (this._lastBackupErrorDetail = this._lastBackupErrorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ErrorDetail1()); set { {_lastBackupErrorDetail = value;} } }

        /// <summary>Internal Acessors for LastBackupErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.LastBackupErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Code = value ?? null; }

        /// <summary>Internal Acessors for LastBackupErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.LastBackupErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Message = value ?? null; }

        /// <summary>Internal Acessors for LastBackupErrorDetailRecommendation</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.LastBackupErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Recommendation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1Internal)LastBackupErrorDetail).Recommendation = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemInternal.ProtectionStatus { get => this._protectionStatus; set { {_protectionStatus = value;} } }

        /// <summary>Internal Acessors for BackupManagementType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal.BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).BackupManagementType = value ?? null; }

        /// <summary>Internal Acessors for VaultId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal.VaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).VaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).VaultId = value ?? null; }

        /// <summary>Internal Acessors for WorkloadType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal.WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).WorkloadType = value ?? null; }

        /// <summary>Backing field for <see cref="NodesList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> _nodesList;

        /// <summary>List of the nodes in case of distributed container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> NodesList { get => this._nodesList; set => this._nodesList = value; }

        /// <summary>Backing field for <see cref="ParentName" /> property.</summary>
        private string _parentName;

        /// <summary>Parent name of the DB such as Instance or Availability Group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ParentName { get => this._parentName; set => this._parentName = value; }

        /// <summary>Backing field for <see cref="ParentType" /> property.</summary>
        private string _parentType;

        /// <summary>
        /// Parent type of protected item, example: for a DB, standalone server or distributed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ParentType { get => this._parentType; set => this._parentType = value; }

        /// <summary>ID of the backup policy with which this item is backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).PolicyId = value ?? null; }

        /// <summary>Name of the policy used for protection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).PolicyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).PolicyName = value ?? null; }

        /// <summary>Backing field for <see cref="ProtectedItemDataSourceId" /> property.</summary>
        private string _protectedItemDataSourceId;

        /// <summary>Data ID of the protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ProtectedItemDataSourceId { get => this._protectedItemDataSourceId; set => this._protectedItemDataSourceId = value; }

        /// <summary>Backing field for <see cref="ProtectedItemHealthStatus" /> property.</summary>
        private string _protectedItemHealthStatus;

        /// <summary>Health status of the backup item, evaluated based on last heartbeat received</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ProtectedItemHealthStatus { get => this._protectedItemHealthStatus; set => this._protectedItemHealthStatus = value; }

        /// <summary>Backing field for <see cref="ProtectionState" /> property.</summary>
        private string _protectionState;

        /// <summary>Backup state of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ProtectionState { get => this._protectionState; set => this._protectionState = value; }

        /// <summary>Backing field for <see cref="ProtectionStatus" /> property.</summary>
        private string _protectionStatus;

        /// <summary>Backup status of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ProtectionStatus { get => this._protectionStatus; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServerName" /> property.</summary>
        private string _serverName;

        /// <summary>Host/Cluster Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ServerName { get => this._serverName; set => this._serverName = value; }

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? SoftDeleteRetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).SoftDeleteRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).SoftDeleteRetentionPeriodInDay = value ?? default(int); }

        /// <summary>ARM ID of the resource to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).SourceResourceId = value ?? null; }

        /// <summary>backup item type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "AzureVmWorkloadProtectedItem"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).Type = "AzureVmWorkloadProtectedItem"; }

        /// <summary>ID of the vault which protects this item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string VaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).VaultId; }

        /// <summary>Type of workload this item represents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)__protectedItem).WorkloadType; }

        /// <summary>Creates an new <see cref="AzureVMWorkloadProtectedItem" /> instance.</summary>
        public AzureVMWorkloadProtectedItem()
        {
            this.__protectedItem.Type = "AzureVmWorkloadProtectedItem";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectedItem), __protectedItem);
            await eventListener.AssertObjectIsValid(nameof(__protectedItem), __protectedItem);
        }
    }
    /// Azure VM workload-specific protected item.
    public partial interface IAzureVMWorkloadProtectedItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItem
    {
        /// <summary>The latest backup copy available for this backup item in archive tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The latest backup copy available for this backup item in archive tier",
        SerializedName = @"newestRecoveryPointInArchive",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExtendedInfoNewestRecoveryPointInArchive { get; set; }
        /// <summary>The oldest backup copy available for this backup item across all tiers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The oldest backup copy available for this backup item across all tiers.",
        SerializedName = @"oldestRecoveryPoint",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExtendedInfoOldestRecoveryPoint { get; set; }
        /// <summary>The oldest backup copy available for this backup item in archive tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The oldest backup copy available for this backup item in archive tier",
        SerializedName = @"oldestRecoveryPointInArchive",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExtendedInfoOldestRecoveryPointInArchive { get; set; }
        /// <summary>The oldest backup copy available for this backup item in vault tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The oldest backup copy available for this backup item in vault tier",
        SerializedName = @"oldestRecoveryPointInVault",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExtendedInfoOldestRecoveryPointInVault { get; set; }
        /// <summary>Indicates consistency of policy object and policy applied to this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates consistency of policy object and policy applied to this backup item.",
        SerializedName = @"policyState",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoPolicyState { get; set; }
        /// <summary>Indicates consistency of policy object and policy applied to this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates consistency of policy object and policy applied to this backup item.",
        SerializedName = @"recoveryModel",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoRecoveryModel { get; set; }
        /// <summary>Number of backup copies available for this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of backup copies available for this backup item.",
        SerializedName = @"recoveryPointCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ExtendedInfoRecoveryPointCount { get; set; }
        /// <summary>Friendly name of the DB represented by this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Friendly name of the DB represented by this backup item.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get;  }
        /// <summary>Health details of different KPIs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Health details of different KPIs",
        SerializedName = @"kpisHealths",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealths) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealths KpisHealth { get; set; }
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupErrorDetailCode { get;  }
        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error Message related to the Code.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupErrorDetailMessage { get;  }
        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of recommendation strings.",
        SerializedName = @"recommendations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> LastBackupErrorDetailRecommendation { get;  }
        /// <summary>Last backup operation status. Possible values: Healthy, Unhealthy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last backup operation status. Possible values: Healthy, Unhealthy.",
        SerializedName = @"lastBackupStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Healthy", "Unhealthy", "IRPending")]
        string LastBackupStatus { get; set; }
        /// <summary>Timestamp of the last backup operation on this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Timestamp of the last backup operation on this backup item.",
        SerializedName = @"lastBackupTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastBackupTime { get; set; }
        /// <summary>List of the nodes in case of distributed container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of the nodes in case of distributed container.",
        SerializedName = @"nodesList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> NodesList { get; set; }
        /// <summary>Parent name of the DB such as Instance or Availability Group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Parent name of the DB such as Instance or Availability Group.",
        SerializedName = @"parentName",
        PossibleTypes = new [] { typeof(string) })]
        string ParentName { get; set; }
        /// <summary>
        /// Parent type of protected item, example: for a DB, standalone server or distributed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Parent type of protected item, example: for a DB, standalone server or distributed",
        SerializedName = @"parentType",
        PossibleTypes = new [] { typeof(string) })]
        string ParentType { get; set; }
        /// <summary>Data ID of the protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data ID of the protected item.",
        SerializedName = @"protectedItemDataSourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectedItemDataSourceId { get; set; }
        /// <summary>Health status of the backup item, evaluated based on last heartbeat received</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Health status of the backup item, evaluated based on last heartbeat received",
        SerializedName = @"protectedItemHealthStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Healthy", "Unhealthy", "NotReachable", "IRPending")]
        string ProtectedItemHealthStatus { get; set; }
        /// <summary>Backup state of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup state of this backup item.",
        SerializedName = @"protectionState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "IRPending", "Protected", "ProtectionError", "ProtectionStopped", "ProtectionPaused", "BackupsSuspended")]
        string ProtectionState { get; set; }
        /// <summary>Backup status of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Backup status of this backup item.",
        SerializedName = @"protectionStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionStatus { get;  }
        /// <summary>Host/Cluster Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Host/Cluster Name for instance or AG",
        SerializedName = @"serverName",
        PossibleTypes = new [] { typeof(string) })]
        string ServerName { get; set; }

    }
    /// Azure VM workload-specific protected item.
    internal partial interface IAzureVMWorkloadProtectedItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal
    {
        /// <summary>Additional information for this backup item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemExtendedInfo ExtendedInfo { get; set; }
        /// <summary>The latest backup copy available for this backup item in archive tier</summary>
        global::System.DateTime? ExtendedInfoNewestRecoveryPointInArchive { get; set; }
        /// <summary>The oldest backup copy available for this backup item across all tiers.</summary>
        global::System.DateTime? ExtendedInfoOldestRecoveryPoint { get; set; }
        /// <summary>The oldest backup copy available for this backup item in archive tier</summary>
        global::System.DateTime? ExtendedInfoOldestRecoveryPointInArchive { get; set; }
        /// <summary>The oldest backup copy available for this backup item in vault tier</summary>
        global::System.DateTime? ExtendedInfoOldestRecoveryPointInVault { get; set; }
        /// <summary>Indicates consistency of policy object and policy applied to this backup item.</summary>
        string ExtendedInfoPolicyState { get; set; }
        /// <summary>Indicates consistency of policy object and policy applied to this backup item.</summary>
        string ExtendedInfoRecoveryModel { get; set; }
        /// <summary>Number of backup copies available for this backup item.</summary>
        int? ExtendedInfoRecoveryPointCount { get; set; }
        /// <summary>Friendly name of the DB represented by this backup item.</summary>
        string FriendlyName { get; set; }
        /// <summary>Health details of different KPIs</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealths KpisHealth { get; set; }
        /// <summary>Error details in last backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 LastBackupErrorDetail { get; set; }
        /// <summary>Error code.</summary>
        string LastBackupErrorDetailCode { get; set; }
        /// <summary>Error Message related to the Code.</summary>
        string LastBackupErrorDetailMessage { get; set; }
        /// <summary>List of recommendation strings.</summary>
        System.Collections.Generic.List<string> LastBackupErrorDetailRecommendation { get; set; }
        /// <summary>Last backup operation status. Possible values: Healthy, Unhealthy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Healthy", "Unhealthy", "IRPending")]
        string LastBackupStatus { get; set; }
        /// <summary>Timestamp of the last backup operation on this backup item.</summary>
        global::System.DateTime? LastBackupTime { get; set; }
        /// <summary>List of the nodes in case of distributed container.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> NodesList { get; set; }
        /// <summary>Parent name of the DB such as Instance or Availability Group.</summary>
        string ParentName { get; set; }
        /// <summary>
        /// Parent type of protected item, example: for a DB, standalone server or distributed
        /// </summary>
        string ParentType { get; set; }
        /// <summary>Data ID of the protected item.</summary>
        string ProtectedItemDataSourceId { get; set; }
        /// <summary>Health status of the backup item, evaluated based on last heartbeat received</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Healthy", "Unhealthy", "NotReachable", "IRPending")]
        string ProtectedItemHealthStatus { get; set; }
        /// <summary>Backup state of this backup item.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "IRPending", "Protected", "ProtectionError", "ProtectionStopped", "ProtectionPaused", "BackupsSuspended")]
        string ProtectionState { get; set; }
        /// <summary>Backup status of this backup item.</summary>
        string ProtectionStatus { get; set; }
        /// <summary>Host/Cluster Name for instance or AG</summary>
        string ServerName { get; set; }

    }
}