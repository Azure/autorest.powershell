// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure VM workload-specific protectable item.</summary>
    public partial class AzureVMWorkloadProtectableItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectableItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectableItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItem __workloadProtectableItem = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WorkloadProtectableItem();

        /// <summary>Type of backup management to backup an item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).BackupManagementType = value ?? null; }

        /// <summary>Friendly name of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).FriendlyName = value ?? null; }

        /// <summary>Backing field for <see cref="IsAutoProtectable" /> property.</summary>
        private bool? _isAutoProtectable;

        /// <summary>Indicates if protectable item is auto-protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsAutoProtectable { get => this._isAutoProtectable; set => this._isAutoProtectable = value; }

        /// <summary>Backing field for <see cref="IsAutoProtected" /> property.</summary>
        private bool? _isAutoProtected;

        /// <summary>Indicates if protectable item is auto-protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsAutoProtected { get => this._isAutoProtected; set => this._isAutoProtected = value; }

        /// <summary>Backing field for <see cref="IsProtectable" /> property.</summary>
        private bool? _isProtectable;

        /// <summary>Indicates if item is protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsProtectable { get => this._isProtectable; set => this._isProtectable = value; }

        /// <summary>Internal Acessors for Prebackupvalidation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidation Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectableItemInternal.Prebackupvalidation { get => (this._prebackupvalidation = this._prebackupvalidation ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.PreBackupValidation()); set { {_prebackupvalidation = value;} } }

        /// <summary>Backing field for <see cref="ParentName" /> property.</summary>
        private string _parentName;

        /// <summary>Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ParentName { get => this._parentName; set => this._parentName = value; }

        /// <summary>Backing field for <see cref="ParentUniqueName" /> property.</summary>
        private string _parentUniqueName;

        /// <summary>
        /// Parent Unique Name is added to provide the service formatted URI Name of the Parent
        /// Only Applicable for data bases where the parent would be either Instance or a SQL AG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ParentUniqueName { get => this._parentUniqueName; set => this._parentUniqueName = value; }

        /// <summary>Backing field for <see cref="Prebackupvalidation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidation _prebackupvalidation;

        /// <summary>Pre-backup validation for protectable objects</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidation Prebackupvalidation { get => (this._prebackupvalidation = this._prebackupvalidation ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.PreBackupValidation()); set => this._prebackupvalidation = value; }

        /// <summary>Error code of protectable item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string PrebackupvalidationCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidationInternal)Prebackupvalidation).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidationInternal)Prebackupvalidation).Code = value ?? null; }

        /// <summary>Message corresponding to the error code for the protectable item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string PrebackupvalidationMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidationInternal)Prebackupvalidation).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidationInternal)Prebackupvalidation).Message = value ?? null; }

        /// <summary>Status of protectable item, i.e. InProgress,Succeeded,Failed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string PrebackupvalidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidationInternal)Prebackupvalidation).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidationInternal)Prebackupvalidation).Status = value ?? null; }

        /// <summary>Type of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectableItemType { get => "AzureVmWorkloadProtectableItem"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).ProtectableItemType = "AzureVmWorkloadProtectableItem"; }

        /// <summary>State of the back up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).ProtectionState = value ?? null; }

        /// <summary>Backing field for <see cref="ServerName" /> property.</summary>
        private string _serverName;

        /// <summary>Host/Cluster Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ServerName { get => this._serverName; set => this._serverName = value; }

        /// <summary>Backing field for <see cref="Subinquireditemcount" /> property.</summary>
        private int? _subinquireditemcount;

        /// <summary>For instance or AG, indicates number of DB's present</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? Subinquireditemcount { get => this._subinquireditemcount; set => this._subinquireditemcount = value; }

        /// <summary>Backing field for <see cref="Subprotectableitemcount" /> property.</summary>
        private int? _subprotectableitemcount;

        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? Subprotectableitemcount { get => this._subprotectableitemcount; set => this._subprotectableitemcount = value; }

        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__workloadProtectableItem).WorkloadType = value ?? null; }

        /// <summary>Creates an new <see cref="AzureVMWorkloadProtectableItem" /> instance.</summary>
        public AzureVMWorkloadProtectableItem()
        {
            this.__workloadProtectableItem.ProtectableItemType = "AzureVmWorkloadProtectableItem";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workloadProtectableItem), __workloadProtectableItem);
            await eventListener.AssertObjectIsValid(nameof(__workloadProtectableItem), __workloadProtectableItem);
        }
    }
    /// Azure VM workload-specific protectable item.
    public partial interface IAzureVMWorkloadProtectableItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItem
    {
        /// <summary>Indicates if protectable item is auto-protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if protectable item is auto-protectable",
        SerializedName = @"isAutoProtectable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAutoProtectable { get; set; }
        /// <summary>Indicates if protectable item is auto-protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if protectable item is auto-protected",
        SerializedName = @"isAutoProtected",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAutoProtected { get; set; }
        /// <summary>Indicates if item is protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if item is protectable",
        SerializedName = @"isProtectable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsProtectable { get; set; }
        /// <summary>Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name for instance or AG",
        SerializedName = @"parentName",
        PossibleTypes = new [] { typeof(string) })]
        string ParentName { get; set; }
        /// <summary>
        /// Parent Unique Name is added to provide the service formatted URI Name of the Parent
        /// Only Applicable for data bases where the parent would be either Instance or a SQL AG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Parent Unique Name is added to provide the service formatted URI Name of the Parent
        Only Applicable for data bases where the parent would be either Instance or a SQL AG.",
        SerializedName = @"parentUniqueName",
        PossibleTypes = new [] { typeof(string) })]
        string ParentUniqueName { get; set; }
        /// <summary>Error code of protectable item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Error code of protectable item",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string PrebackupvalidationCode { get; set; }
        /// <summary>Message corresponding to the error code for the protectable item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Message corresponding to the error code for the protectable item",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string PrebackupvalidationMessage { get; set; }
        /// <summary>Status of protectable item, i.e. InProgress,Succeeded,Failed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of protectable item, i.e. InProgress,Succeeded,Failed",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Success", "Failed")]
        string PrebackupvalidationStatus { get; set; }
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
        /// <summary>For instance or AG, indicates number of DB's present</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For instance or AG, indicates number of DB's present",
        SerializedName = @"subinquireditemcount",
        PossibleTypes = new [] { typeof(int) })]
        int? Subinquireditemcount { get; set; }
        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For instance or AG, indicates number of DB's to be protected",
        SerializedName = @"subprotectableitemcount",
        PossibleTypes = new [] { typeof(int) })]
        int? Subprotectableitemcount { get; set; }

    }
    /// Azure VM workload-specific protectable item.
    internal partial interface IAzureVMWorkloadProtectableItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal
    {
        /// <summary>Indicates if protectable item is auto-protectable</summary>
        bool? IsAutoProtectable { get; set; }
        /// <summary>Indicates if protectable item is auto-protected</summary>
        bool? IsAutoProtected { get; set; }
        /// <summary>Indicates if item is protectable</summary>
        bool? IsProtectable { get; set; }
        /// <summary>Name for instance or AG</summary>
        string ParentName { get; set; }
        /// <summary>
        /// Parent Unique Name is added to provide the service formatted URI Name of the Parent
        /// Only Applicable for data bases where the parent would be either Instance or a SQL AG.
        /// </summary>
        string ParentUniqueName { get; set; }
        /// <summary>Pre-backup validation for protectable objects</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPreBackupValidation Prebackupvalidation { get; set; }
        /// <summary>Error code of protectable item</summary>
        string PrebackupvalidationCode { get; set; }
        /// <summary>Message corresponding to the error code for the protectable item</summary>
        string PrebackupvalidationMessage { get; set; }
        /// <summary>Status of protectable item, i.e. InProgress,Succeeded,Failed</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Success", "Failed")]
        string PrebackupvalidationStatus { get; set; }
        /// <summary>Host/Cluster Name for instance or AG</summary>
        string ServerName { get; set; }
        /// <summary>For instance or AG, indicates number of DB's present</summary>
        int? Subinquireditemcount { get; set; }
        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        int? Subprotectableitemcount { get; set; }

    }
}