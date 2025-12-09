// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// Base class for backup item. Workload-specific backup items are derived from this class.
    /// </summary>
    public partial class WorkloadProtectableItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal
    {

        /// <summary>Backing field for <see cref="BackupManagementType" /> property.</summary>
        private string _backupManagementType;

        /// <summary>Type of backup management to backup an item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string BackupManagementType { get => this._backupManagementType; set => this._backupManagementType = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="ProtectableItemType" /> property.</summary>
        private string _protectableItemType;

        /// <summary>Type of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ProtectableItemType { get => this._protectableItemType; set => this._protectableItemType = value; }

        /// <summary>Backing field for <see cref="ProtectionState" /> property.</summary>
        private string _protectionState;

        /// <summary>State of the back up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ProtectionState { get => this._protectionState; set => this._protectionState = value; }

        /// <summary>Backing field for <see cref="WorkloadType" /> property.</summary>
        private string _workloadType;

        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string WorkloadType { get => this._workloadType; set => this._workloadType = value; }

        /// <summary>Creates an new <see cref="WorkloadProtectableItem" /> instance.</summary>
        public WorkloadProtectableItem()
        {

        }
    }
    /// Base class for backup item. Workload-specific backup items are derived from this class.
    public partial interface IWorkloadProtectableItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Type of backup management to backup an item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup management to backup an item.",
        SerializedName = @"backupManagementType",
        PossibleTypes = new [] { typeof(string) })]
        string BackupManagementType { get; set; }
        /// <summary>Friendly name of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Friendly name of the backup item.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>Type of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the backup item.",
        SerializedName = @"protectableItemType",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectableItemType { get; set; }
        /// <summary>State of the back up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the back up item.",
        SerializedName = @"protectionState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "NotProtected", "Protecting", "Protected", "ProtectionFailed")]
        string ProtectionState { get; set; }
        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of workload for the backup management",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        string WorkloadType { get; set; }

    }
    /// Base class for backup item. Workload-specific backup items are derived from this class.
    internal partial interface IWorkloadProtectableItemInternal

    {
        /// <summary>Type of backup management to backup an item.</summary>
        string BackupManagementType { get; set; }
        /// <summary>Friendly name of the backup item.</summary>
        string FriendlyName { get; set; }
        /// <summary>Type of the backup item.</summary>
        string ProtectableItemType { get; set; }
        /// <summary>State of the back up item.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "NotProtected", "Protecting", "Protected", "ProtectionFailed")]
        string ProtectionState { get; set; }
        /// <summary>Type of workload for the backup management</summary>
        string WorkloadType { get; set; }

    }
}