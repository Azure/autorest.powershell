// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure Workload SQL Auto Protection intent item.</summary>
    public partial class AzureWorkloadSqlAutoProtectionIntent :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlAutoProtectionIntent,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlAutoProtectionIntentInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadAutoProtectionIntent"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadAutoProtectionIntent __azureWorkloadAutoProtectionIntent = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadAutoProtectionIntent();

        /// <summary>Type of backup management for the backed up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).BackupManagementType = value ?? null; }

        /// <summary>
        /// ID of the item which is getting protected, In case of Azure Vm , it is ProtectedItemId
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ItemId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).ItemId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).ItemId = value ?? null; }

        /// <summary>backup protectionIntent type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ItemType { get => "AzureWorkloadSQLAutoProtectionIntent"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).ItemType = "AzureWorkloadSQLAutoProtectionIntent"; }

        /// <summary>ID of the backup policy with which this item is backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).PolicyId = value ?? null; }

        /// <summary>Backup state of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).ProtectionState = value ?? null; }

        /// <summary>ARM ID of the resource to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__azureWorkloadAutoProtectionIntent).SourceResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="WorkloadItemType" /> property.</summary>
        private string _workloadItemType;

        /// <summary>Workload item type of the item for which intent is to be set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string WorkloadItemType { get => this._workloadItemType; set => this._workloadItemType = value; }

        /// <summary>Creates an new <see cref="AzureWorkloadSqlAutoProtectionIntent" /> instance.</summary>
        public AzureWorkloadSqlAutoProtectionIntent()
        {
            this.__azureWorkloadAutoProtectionIntent.ItemType = "AzureWorkloadSQLAutoProtectionIntent";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadAutoProtectionIntent), __azureWorkloadAutoProtectionIntent);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadAutoProtectionIntent), __azureWorkloadAutoProtectionIntent);
        }
    }
    /// Azure Workload SQL Auto Protection intent item.
    public partial interface IAzureWorkloadSqlAutoProtectionIntent :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadAutoProtectionIntent
    {
        /// <summary>Workload item type of the item for which intent is to be set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workload item type of the item for which intent is to be set",
        SerializedName = @"workloadItemType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "SQLInstance", "SQLDataBase", "SAPHanaSystem", "SAPHanaDatabase", "SAPAseSystem", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkloadItemType { get; set; }

    }
    /// Azure Workload SQL Auto Protection intent item.
    internal partial interface IAzureWorkloadSqlAutoProtectionIntentInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadAutoProtectionIntentInternal
    {
        /// <summary>Workload item type of the item for which intent is to be set</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "SQLInstance", "SQLDataBase", "SAPHanaSystem", "SAPHanaDatabase", "SAPAseSystem", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkloadItemType { get; set; }

    }
}