// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureWorkload-specific restore.</summary>
    public partial class AzureWorkloadRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest __restoreRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RestoreRequest();

        /// <summary>Internal Acessors for SnapshotRestoreParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.SnapshotRestoreParameter { get => (this._snapshotRestoreParameter = this._snapshotRestoreParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotRestoreParameters()); set { {_snapshotRestoreParameter = value;} } }

        /// <summary>Internal Acessors for TargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.TargetInfo { get => (this._targetInfo = this._targetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetRestoreInfo()); set { {_targetInfo = value;} } }

        /// <summary>Internal Acessors for UserAssignedManagedIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetail { get => (this._userAssignedManagedIdentityDetail = this._userAssignedManagedIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetails()); set { {_userAssignedManagedIdentityDetail = value;} } }

        /// <summary>
        /// Internal Acessors for UserAssignedManagedIdentityDetailUserAssignedIdentityProperty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal.UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadRestoreRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__restoreRequest).ObjectType = "AzureWorkloadRestoreRequest"; }

        /// <summary>Backing field for <see cref="PropertyBag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag _propertyBag;

        /// <summary>Workload specific property bag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag PropertyBag { get => (this._propertyBag = this._propertyBag ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequestPropertyBag()); set => this._propertyBag = value; }

        /// <summary>Backing field for <see cref="RecoveryMode" /> property.</summary>
        private string _recoveryMode;

        /// <summary>Defines whether the current recovery mode is file restore or database restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RecoveryMode { get => this._recoveryMode; set => this._recoveryMode = value; }

        /// <summary>Backing field for <see cref="RecoveryType" /> property.</summary>
        private string _recoveryType;

        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RecoveryType { get => this._recoveryType; set => this._recoveryType = value; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__restoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__restoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="SnapshotRestoreParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters _snapshotRestoreParameter;

        /// <summary>
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters SnapshotRestoreParameter { get => (this._snapshotRestoreParameter = this._snapshotRestoreParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotRestoreParameters()); set => this._snapshotRestoreParameter = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string SnapshotRestoreParameterLogPointInTimeForDbRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParametersInternal)SnapshotRestoreParameter).LogPointInTimeForDbRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParametersInternal)SnapshotRestoreParameter).LogPointInTimeForDbRecovery = value ?? null; }

        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? SnapshotRestoreParameterSkipAttachAndMount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParametersInternal)SnapshotRestoreParameter).SkipAttachAndMount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParametersInternal)SnapshotRestoreParameter).SkipAttachAndMount = value ?? default(bool); }

        /// <summary>Backing field for <see cref="SourceResourceId" /> property.</summary>
        private string _sourceResourceId;

        /// <summary>
        /// Fully qualified ARM ID of the VM on which workload that was running is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceResourceId { get => this._sourceResourceId; set => this._sourceResourceId = value; }

        /// <summary>Backing field for <see cref="TargetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo _targetInfo;

        /// <summary>Details of target database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo TargetInfo { get => (this._targetInfo = this._targetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetRestoreInfo()); set => this._targetInfo = value; }

        /// <summary>Resource Id name of the container in which Target DataBase resides</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string TargetInfoContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).ContainerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).ContainerId = value ?? null; }

        /// <summary>Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string TargetInfoDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).DatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).DatabaseName = value ?? null; }

        /// <summary>Can Overwrite if Target DataBase already exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string TargetInfoOverwriteOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).OverwriteOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).OverwriteOption = value ?? null; }

        /// <summary>Target directory location for restore as files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string TargetInfoTargetDirectoryForFileRestore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).TargetDirectoryForFileRestore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfoInternal)TargetInfo).TargetDirectoryForFileRestore = value ?? null; }

        /// <summary>Backing field for <see cref="TargetResourceGroupName" /> property.</summary>
        private string _targetResourceGroupName;

        /// <summary>Defines the Resource group of the Target VM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TargetResourceGroupName { get => this._targetResourceGroupName; set => this._targetResourceGroupName = value; }

        /// <summary>Backing field for <see cref="TargetVirtualMachineId" /> property.</summary>
        private string _targetVirtualMachineId;

        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TargetVirtualMachineId { get => this._targetVirtualMachineId; set => this._targetVirtualMachineId = value; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyPrincipalId = value ?? null; }

        /// <summary>Backing field for <see cref="UserAssignedManagedIdentityDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails _userAssignedManagedIdentityDetail;

        /// <summary>
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get => (this._userAssignedManagedIdentityDetail = this._userAssignedManagedIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetails()); set => this._userAssignedManagedIdentityDetail = value; }

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentityDetailIdentityArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityArmId = value ?? null; }

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentityDetailIdentityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityName = value ?? null; }

        /// <summary>Creates an new <see cref="AzureWorkloadRestoreRequest" /> instance.</summary>
        public AzureWorkloadRestoreRequest()
        {
            this.__restoreRequest.ObjectType = "AzureWorkloadRestoreRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__restoreRequest), __restoreRequest);
            await eventListener.AssertObjectIsValid(nameof(__restoreRequest), __restoreRequest);
        }
    }
    /// AzureWorkload-specific restore.
    public partial interface IAzureWorkloadRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest
    {
        /// <summary>Workload specific property bag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workload specific property bag.",
        SerializedName = @"propertyBag",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag PropertyBag { get; set; }
        /// <summary>Defines whether the current recovery mode is file restore or database restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines whether the current recovery mode is file restore or database restore",
        SerializedName = @"recoveryMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "FileRecovery", "WorkloadRecovery", "SnapshotAttach", "RecoveryUsingSnapshot", "SnapshotAttachAndRecover")]
        string RecoveryMode { get; set; }
        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of this recovery.",
        SerializedName = @"recoveryType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "OriginalLocation", "AlternateLocation", "RestoreDisks", "Offline")]
        string RecoveryType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"logPointInTimeForDBRecovery",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotRestoreParameterLogPointInTimeForDbRecovery { get; set; }
        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Boolean with `true` and `false` values.",
        SerializedName = @"skipAttachAndMount",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SnapshotRestoreParameterSkipAttachAndMount { get; set; }
        /// <summary>
        /// Fully qualified ARM ID of the VM on which workload that was running is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fully qualified ARM ID of the VM on which workload that was running is being recovered.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceId { get; set; }
        /// <summary>Resource Id name of the container in which Target DataBase resides</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id name of the container in which Target DataBase resides",
        SerializedName = @"containerId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetInfoContainerId { get; set; }
        /// <summary>Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana",
        SerializedName = @"databaseName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetInfoDatabaseName { get; set; }
        /// <summary>Can Overwrite if Target DataBase already exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Can Overwrite if Target DataBase already exists",
        SerializedName = @"overwriteOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "FailOnConflict", "Overwrite")]
        string TargetInfoOverwriteOption { get; set; }
        /// <summary>Target directory location for restore as files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target directory location for restore as files.",
        SerializedName = @"targetDirectoryForFileRestore",
        PossibleTypes = new [] { typeof(string) })]
        string TargetInfoTargetDirectoryForFileRestore { get; set; }
        /// <summary>Defines the Resource group of the Target VM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the Resource group of the Target VM",
        SerializedName = @"targetResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroupName { get; set; }
        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This is the complete ARM Id of the target VM
        For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}",
        SerializedName = @"targetVirtualMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVirtualMachineId { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The client ID of the assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The principal ID of the assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyPrincipalId { get; set; }
        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM id of the assigned identity.",
        SerializedName = @"identityArmId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentityDetailIdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the assigned identity.",
        SerializedName = @"identityName",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentityDetailIdentityName { get; set; }

    }
    /// AzureWorkload-specific restore.
    internal partial interface IAzureWorkloadRestoreRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal
    {
        /// <summary>Workload specific property bag.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag PropertyBag { get; set; }
        /// <summary>Defines whether the current recovery mode is file restore or database restore</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "FileRecovery", "WorkloadRecovery", "SnapshotAttach", "RecoveryUsingSnapshot", "SnapshotAttachAndRecover")]
        string RecoveryMode { get; set; }
        /// <summary>Type of this recovery.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "OriginalLocation", "AlternateLocation", "RestoreDisks", "Offline")]
        string RecoveryType { get; set; }
        /// <summary>
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters SnapshotRestoreParameter { get; set; }

        string SnapshotRestoreParameterLogPointInTimeForDbRecovery { get; set; }
        /// <summary>Boolean with `true` and `false` values.</summary>
        bool? SnapshotRestoreParameterSkipAttachAndMount { get; set; }
        /// <summary>
        /// Fully qualified ARM ID of the VM on which workload that was running is being recovered.
        /// </summary>
        string SourceResourceId { get; set; }
        /// <summary>Details of target database</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo TargetInfo { get; set; }
        /// <summary>Resource Id name of the container in which Target DataBase resides</summary>
        string TargetInfoContainerId { get; set; }
        /// <summary>Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana</summary>
        string TargetInfoDatabaseName { get; set; }
        /// <summary>Can Overwrite if Target DataBase already exists</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "FailOnConflict", "Overwrite")]
        string TargetInfoOverwriteOption { get; set; }
        /// <summary>Target directory location for restore as files.</summary>
        string TargetInfoTargetDirectoryForFileRestore { get; set; }
        /// <summary>Defines the Resource group of the Target VM</summary>
        string TargetResourceGroupName { get; set; }
        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        string TargetVirtualMachineId { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyPrincipalId { get; set; }
        /// <summary>
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get; set; }
        /// <summary>The ARM id of the assigned identity.</summary>
        string UserAssignedManagedIdentityDetailIdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        string UserAssignedManagedIdentityDetailIdentityName { get; set; }
        /// <summary>User assigned managed identity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get; set; }

    }
}