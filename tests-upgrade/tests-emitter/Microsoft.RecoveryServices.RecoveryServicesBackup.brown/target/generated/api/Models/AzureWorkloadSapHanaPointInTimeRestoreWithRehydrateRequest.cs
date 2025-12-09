// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// AzureWorkload SAP Hana-specific restore with integrated rehydration of recovery point.
    /// </summary>
    public partial class AzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreRequest __azureWorkloadSapHanaPointInTimeRestoreRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSapHanaPointInTimeRestoreRequest();

        /// <summary>Internal Acessors for SnapshotRestoreParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.SnapshotRestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.TargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UserAssignedManagedIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for UserAssignedManagedIdentityDetailUserAssignedIdentityProperty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RecoveryPointRehydrationInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequestInternal.RecoveryPointRehydrationInfo { get => (this._recoveryPointRehydrationInfo = this._recoveryPointRehydrationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointRehydrationInfo()); set { {_recoveryPointRehydrationInfo = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).ObjectType = "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest"; }

        /// <summary>PointInTime value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? PointInTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).PointInTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).PointInTime = value ?? default(global::System.DateTime); }

        /// <summary>Workload specific property bag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag PropertyBag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).PropertyBag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).PropertyBag = value ?? null /* model class */; }

        /// <summary>Defines whether the current recovery mode is file restore or database restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).RecoveryMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).RecoveryMode = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointRehydrationInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo _recoveryPointRehydrationInfo;

        /// <summary>RP Rehydration Info</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo RecoveryPointRehydrationInfo { get => (this._recoveryPointRehydrationInfo = this._recoveryPointRehydrationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointRehydrationInfo()); set => this._recoveryPointRehydrationInfo = value; }

        /// <summary>Rehydration Priority</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RecoveryPointRehydrationInfoRehydrationPriority { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationPriority; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationPriority = value ?? null; }

        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RecoveryPointRehydrationInfoRehydrationRetentionDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationRetentionDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationRetentionDuration = value ?? null; }

        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).RecoveryType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).RecoveryType = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters SnapshotRestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameter = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SnapshotRestoreParameterLogPointInTimeForDbRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameterLogPointInTimeForDbRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameterLogPointInTimeForDbRecovery = value ?? null; }

        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? SnapshotRestoreParameterSkipAttachAndMount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameterSkipAttachAndMount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SnapshotRestoreParameterSkipAttachAndMount = value ?? default(bool); }

        /// <summary>
        /// Fully qualified ARM ID of the VM on which workload that was running is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).SourceResourceId = value ?? null; }

        /// <summary>Details of target database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo TargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfo = value ?? null /* model class */; }

        /// <summary>Resource Id name of the container in which Target DataBase resides</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoContainerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoContainerId = value ?? null; }

        /// <summary>Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoDatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoDatabaseName = value ?? null; }

        /// <summary>Can Overwrite if Target DataBase already exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoOverwriteOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoOverwriteOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoOverwriteOption = value ?? null; }

        /// <summary>Target directory location for restore as files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoTargetDirectoryForFileRestore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoTargetDirectoryForFileRestore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetInfoTargetDirectoryForFileRestore = value ?? null; }

        /// <summary>Defines the Resource group of the Target VM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetResourceGroupName = value ?? null; }

        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetVirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetVirtualMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).TargetVirtualMachineId = value ?? null; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedIdentityPropertyClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedIdentityPropertyClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedIdentityPropertyPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedIdentityPropertyPrincipalId = value ?? null; }

        /// <summary>
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedManagedIdentityDetailIdentityArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailIdentityArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailIdentityArmId = value ?? null; }

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedManagedIdentityDetailIdentityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailIdentityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailIdentityName = value ?? null; }

        /// <summary>User assigned managed identity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadSapHanaPointInTimeRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>
        /// Creates an new <see cref="AzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequest" /> instance.
        /// </summary>
        public AzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequest()
        {
            this.__azureWorkloadSapHanaPointInTimeRestoreRequest.ObjectType = "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadSapHanaPointInTimeRestoreRequest), __azureWorkloadSapHanaPointInTimeRestoreRequest);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadSapHanaPointInTimeRestoreRequest), __azureWorkloadSapHanaPointInTimeRestoreRequest);
        }
    }
    /// AzureWorkload SAP Hana-specific restore with integrated rehydration of recovery point.
    public partial interface IAzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreRequest
    {
        /// <summary>Rehydration Priority</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rehydration Priority",
        SerializedName = @"rehydrationPriority",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Standard", "High")]
        string RecoveryPointRehydrationInfoRehydrationPriority { get; set; }
        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How long the rehydrated RP should be kept
        Should be ISO8601 Duration format e.g. ""P7D""",
        SerializedName = @"rehydrationRetentionDuration",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointRehydrationInfoRehydrationRetentionDuration { get; set; }

    }
    /// AzureWorkload SAP Hana-specific restore with integrated rehydration of recovery point.
    internal partial interface IAzureWorkloadSapHanaPointInTimeRestoreWithRehydrateRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRestoreRequestInternal
    {
        /// <summary>RP Rehydration Info</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo RecoveryPointRehydrationInfo { get; set; }
        /// <summary>Rehydration Priority</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Standard", "High")]
        string RecoveryPointRehydrationInfoRehydrationPriority { get; set; }
        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        string RecoveryPointRehydrationInfoRehydrationRetentionDuration { get; set; }

    }
}