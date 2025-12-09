// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure VM workload-specific workload item.</summary>
    public partial class AzureVMWorkloadItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItem __workloadItem = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WorkloadItem();

        /// <summary>Type of backup management to backup an item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).BackupManagementType = value ?? null; }

        /// <summary>Friendly name of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).FriendlyName = value ?? null; }

        /// <summary>Backing field for <see cref="IsAutoProtectable" /> property.</summary>
        private bool? _isAutoProtectable;

        /// <summary>Indicates if workload item is auto-protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsAutoProtectable { get => this._isAutoProtectable; set => this._isAutoProtectable = value; }

        /// <summary>Backing field for <see cref="ParentName" /> property.</summary>
        private string _parentName;

        /// <summary>Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ParentName { get => this._parentName; set => this._parentName = value; }

        /// <summary>State of the back up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).ProtectionState = value ?? null; }

        /// <summary>Backing field for <see cref="ServerName" /> property.</summary>
        private string _serverName;

        /// <summary>Host/Cluster Name for instance or AG</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ServerName { get => this._serverName; set => this._serverName = value; }

        /// <summary>Backing field for <see cref="SubWorkloadItemCount" /> property.</summary>
        private int? _subWorkloadItemCount;

        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? SubWorkloadItemCount { get => this._subWorkloadItemCount; set => this._subWorkloadItemCount = value; }

        /// <summary>Backing field for <see cref="Subinquireditemcount" /> property.</summary>
        private int? _subinquireditemcount;

        /// <summary>For instance or AG, indicates number of DB's present</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? Subinquireditemcount { get => this._subinquireditemcount; set => this._subinquireditemcount = value; }

        /// <summary>Type of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "AzureVmWorkloadItem"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).Type = "AzureVmWorkloadItem"; }

        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal)__workloadItem).WorkloadType = value ?? null; }

        /// <summary>Creates an new <see cref="AzureVMWorkloadItem" /> instance.</summary>
        public AzureVMWorkloadItem()
        {
            this.__workloadItem.Type = "AzureVmWorkloadItem";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workloadItem), __workloadItem);
            await eventListener.AssertObjectIsValid(nameof(__workloadItem), __workloadItem);
        }
    }
    /// Azure VM workload-specific workload item.
    public partial interface IAzureVMWorkloadItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItem
    {
        /// <summary>Indicates if workload item is auto-protectable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if workload item is auto-protectable",
        SerializedName = @"isAutoProtectable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAutoProtectable { get; set; }
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
        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For instance or AG, indicates number of DB's to be protected",
        SerializedName = @"subWorkloadItemCount",
        PossibleTypes = new [] { typeof(int) })]
        int? SubWorkloadItemCount { get; set; }
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

    }
    /// Azure VM workload-specific workload item.
    internal partial interface IAzureVMWorkloadItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadItemInternal
    {
        /// <summary>Indicates if workload item is auto-protectable</summary>
        bool? IsAutoProtectable { get; set; }
        /// <summary>Name for instance or AG</summary>
        string ParentName { get; set; }
        /// <summary>Host/Cluster Name for instance or AG</summary>
        string ServerName { get; set; }
        /// <summary>For instance or AG, indicates number of DB's to be protected</summary>
        int? SubWorkloadItemCount { get; set; }
        /// <summary>For instance or AG, indicates number of DB's present</summary>
        int? Subinquireditemcount { get; set; }

    }
}