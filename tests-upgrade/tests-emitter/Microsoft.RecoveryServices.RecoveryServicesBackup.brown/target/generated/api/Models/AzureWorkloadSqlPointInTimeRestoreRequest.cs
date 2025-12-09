// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureWorkload SQL -specific restore. Specifically for PointInTime/Log restore</summary>
    public partial class AzureWorkloadSqlPointInTimeRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlPointInTimeRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlPointInTimeRestoreRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequest __azureWorkloadSqlRestoreRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSqlRestoreRequest();

        /// <summary>Data directory details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping> AlternateDirectoryPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).AlternateDirectoryPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).AlternateDirectoryPath = value ?? null /* arrayOf */; }

        /// <summary>
        /// SQL specific property where user can chose to set no-recovery when restore operation is tried
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IsNonRecoverable { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).IsNonRecoverable; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).IsNonRecoverable = value ?? default(bool); }

        /// <summary>Internal Acessors for SnapshotRestoreParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.SnapshotRestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.TargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UserAssignedManagedIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for UserAssignedManagedIdentityDetailUserAssignedIdentityProperty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadSQLPointInTimeRestoreRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).ObjectType = "AzureWorkloadSQLPointInTimeRestoreRequest"; }

        /// <summary>Backing field for <see cref="PointInTime" /> property.</summary>
        private global::System.DateTime? _pointInTime;

        /// <summary>PointInTime value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? PointInTime { get => this._pointInTime; set => this._pointInTime = value; }

        /// <summary>Workload specific property bag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag PropertyBag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).PropertyBag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).PropertyBag = value ?? null /* model class */; }

        /// <summary>Defines whether the current recovery mode is file restore or database restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).RecoveryMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).RecoveryMode = value ?? null; }

        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).RecoveryType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).RecoveryType = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>
        /// Default option set to true. If this is set to false, alternate data directory must be provided
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? ShouldUseAlternateTargetLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).ShouldUseAlternateTargetLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).ShouldUseAlternateTargetLocation = value ?? default(bool); }

        /// <summary>
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters SnapshotRestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameter = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SnapshotRestoreParameterLogPointInTimeForDbRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameterLogPointInTimeForDbRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameterLogPointInTimeForDbRecovery = value ?? null; }

        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? SnapshotRestoreParameterSkipAttachAndMount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameterSkipAttachAndMount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SnapshotRestoreParameterSkipAttachAndMount = value ?? default(bool); }

        /// <summary>
        /// Fully qualified ARM ID of the VM on which workload that was running is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).SourceResourceId = value ?? null; }

        /// <summary>Details of target database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo TargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfo = value ?? null /* model class */; }

        /// <summary>Resource Id name of the container in which Target DataBase resides</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoContainerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoContainerId = value ?? null; }

        /// <summary>Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoDatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoDatabaseName = value ?? null; }

        /// <summary>Can Overwrite if Target DataBase already exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoOverwriteOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoOverwriteOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoOverwriteOption = value ?? null; }

        /// <summary>Target directory location for restore as files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoTargetDirectoryForFileRestore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoTargetDirectoryForFileRestore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetInfoTargetDirectoryForFileRestore = value ?? null; }

        /// <summary>Defines the Resource group of the Target VM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetResourceGroupName = value ?? null; }

        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetVirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetVirtualMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).TargetVirtualMachineId = value ?? null; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedIdentityPropertyClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedIdentityPropertyClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedIdentityPropertyPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedIdentityPropertyPrincipalId = value ?? null; }

        /// <summary>
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedManagedIdentityDetailIdentityArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailIdentityArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailIdentityArmId = value ?? null; }

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedManagedIdentityDetailIdentityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailIdentityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailIdentityName = value ?? null; }

        /// <summary>User assigned managed identity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSqlRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>
        /// Creates an new <see cref="AzureWorkloadSqlPointInTimeRestoreRequest" /> instance.
        /// </summary>
        public AzureWorkloadSqlPointInTimeRestoreRequest()
        {
            this.__azureWorkloadSqlRestoreRequest.ObjectType = "AzureWorkloadSQLPointInTimeRestoreRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadSqlRestoreRequest), __azureWorkloadSqlRestoreRequest);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadSqlRestoreRequest), __azureWorkloadSqlRestoreRequest);
        }
    }
    /// AzureWorkload SQL -specific restore. Specifically for PointInTime/Log restore
    public partial interface IAzureWorkloadSqlPointInTimeRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequest
    {
        /// <summary>PointInTime value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"PointInTime value",
        SerializedName = @"pointInTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PointInTime { get; set; }

    }
    /// AzureWorkload SQL -specific restore. Specifically for PointInTime/Log restore
    internal partial interface IAzureWorkloadSqlPointInTimeRestoreRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal
    {
        /// <summary>PointInTime value</summary>
        global::System.DateTime? PointInTime { get; set; }

    }
}