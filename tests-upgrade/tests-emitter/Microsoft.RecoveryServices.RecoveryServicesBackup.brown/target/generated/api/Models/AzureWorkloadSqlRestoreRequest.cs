// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureWorkload SQL -specific restore. Specifically for full/diff restore</summary>
    public partial class AzureWorkloadSqlRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRestoreRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest __azureWorkloadRestoreRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequest();

        /// <summary>Backing field for <see cref="AlternateDirectoryPath" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping> _alternateDirectoryPath;

        /// <summary>Data directory details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping> AlternateDirectoryPath { get => this._alternateDirectoryPath; set => this._alternateDirectoryPath = value; }

        /// <summary>Backing field for <see cref="IsNonRecoverable" /> property.</summary>
        private bool? _isNonRecoverable;

        /// <summary>
        /// SQL specific property where user can chose to set no-recovery when restore operation is tried
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsNonRecoverable { get => this._isNonRecoverable; set => this._isNonRecoverable = value; }

        /// <summary>Internal Acessors for SnapshotRestoreParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.SnapshotRestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.TargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UserAssignedManagedIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for UserAssignedManagedIdentityDetailUserAssignedIdentityProperty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadSQLRestoreRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadRestoreRequest).ObjectType = "AzureWorkloadSQLRestoreRequest"; }

        /// <summary>Workload specific property bag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag PropertyBag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).PropertyBag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).PropertyBag = value ?? null /* model class */; }

        /// <summary>Defines whether the current recovery mode is file restore or database restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).RecoveryMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).RecoveryMode = value ?? null; }

        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).RecoveryType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).RecoveryType = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadRestoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__azureWorkloadRestoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ShouldUseAlternateTargetLocation" /> property.</summary>
        private bool? _shouldUseAlternateTargetLocation;

        /// <summary>
        /// Default option set to true. If this is set to false, alternate data directory must be provided
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? ShouldUseAlternateTargetLocation { get => this._shouldUseAlternateTargetLocation; set => this._shouldUseAlternateTargetLocation = value; }

        /// <summary>
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters SnapshotRestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameter = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SnapshotRestoreParameterLogPointInTimeForDbRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameterLogPointInTimeForDbRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameterLogPointInTimeForDbRecovery = value ?? null; }

        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? SnapshotRestoreParameterSkipAttachAndMount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameterSkipAttachAndMount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SnapshotRestoreParameterSkipAttachAndMount = value ?? default(bool); }

        /// <summary>
        /// Fully qualified ARM ID of the VM on which workload that was running is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).SourceResourceId = value ?? null; }

        /// <summary>Details of target database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo TargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfo = value ?? null /* model class */; }

        /// <summary>Resource Id name of the container in which Target DataBase resides</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoContainerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoContainerId = value ?? null; }

        /// <summary>Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoDatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoDatabaseName = value ?? null; }

        /// <summary>Can Overwrite if Target DataBase already exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoOverwriteOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoOverwriteOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoOverwriteOption = value ?? null; }

        /// <summary>Target directory location for restore as files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetInfoTargetDirectoryForFileRestore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoTargetDirectoryForFileRestore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetInfoTargetDirectoryForFileRestore = value ?? null; }

        /// <summary>Defines the Resource group of the Target VM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetResourceGroupName = value ?? null; }

        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetVirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetVirtualMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).TargetVirtualMachineId = value ?? null; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedIdentityPropertyClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedIdentityPropertyClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedIdentityPropertyPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedIdentityPropertyPrincipalId = value ?? null; }

        /// <summary>
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedManagedIdentityDetailIdentityArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailIdentityArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailIdentityArmId = value ?? null; }

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string UserAssignedManagedIdentityDetailIdentityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailIdentityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailIdentityName = value ?? null; }

        /// <summary>User assigned managed identity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)__azureWorkloadRestoreRequest).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="AzureWorkloadSqlRestoreRequest" /> instance.</summary>
        public AzureWorkloadSqlRestoreRequest()
        {
            this.__azureWorkloadRestoreRequest.ObjectType = "AzureWorkloadSQLRestoreRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadRestoreRequest), __azureWorkloadRestoreRequest);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadRestoreRequest), __azureWorkloadRestoreRequest);
        }
    }
    /// AzureWorkload SQL -specific restore. Specifically for full/diff restore
    public partial interface IAzureWorkloadSqlRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest
    {
        /// <summary>Data directory details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data directory details",
        SerializedName = @"alternateDirectoryPaths",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping> AlternateDirectoryPath { get; set; }
        /// <summary>
        /// SQL specific property where user can chose to set no-recovery when restore operation is tried
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SQL specific property where user can chose to set no-recovery when restore operation is tried",
        SerializedName = @"isNonRecoverable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsNonRecoverable { get; set; }
        /// <summary>
        /// Default option set to true. If this is set to false, alternate data directory must be provided
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Default option set to true. If this is set to false, alternate data directory must be provided",
        SerializedName = @"shouldUseAlternateTargetLocation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ShouldUseAlternateTargetLocation { get; set; }

    }
    /// AzureWorkload SQL -specific restore. Specifically for full/diff restore
    internal partial interface IAzureWorkloadSqlRestoreRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal
    {
        /// <summary>Data directory details</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping> AlternateDirectoryPath { get; set; }
        /// <summary>
        /// SQL specific property where user can chose to set no-recovery when restore operation is tried
        /// </summary>
        bool? IsNonRecoverable { get; set; }
        /// <summary>
        /// Default option set to true. If this is set to false, alternate data directory must be provided
        /// </summary>
        bool? ShouldUseAlternateTargetLocation { get; set; }

    }
}