// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// IaaS VM workload-specific backup item representing the Azure Resource Manager VM.
    /// </summary>
    public partial class AzureIaaSComputeVmprotectableItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSComputeVmprotectableItem,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSComputeVmprotectableItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItem"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItem __iaaSvmProtectableItem = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaaSvmProtectableItem();

        /// <summary>Type of backup management to backup an item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).BackupManagementType = value ?? null; }

        /// <summary>Friendly name of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).FriendlyName = value ?? null; }

        /// <summary>Type of the backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectableItemType { get => "Microsoft.Compute/virtualMachines"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).ProtectableItemType = "Microsoft.Compute/virtualMachines"; }

        /// <summary>State of the back up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).ProtectionState = value ?? null; }

        /// <summary>Resource group name of Recovery Services Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal)__iaaSvmProtectableItem).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal)__iaaSvmProtectableItem).ResourceGroup = value ?? null; }

        /// <summary>Fully qualified ARM ID of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string VirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal)__iaaSvmProtectableItem).VirtualMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal)__iaaSvmProtectableItem).VirtualMachineId = value ?? null; }

        /// <summary>
        /// Specifies whether the container represents a Classic or an Azure Resource Manager VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string VirtualMachineVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal)__iaaSvmProtectableItem).VirtualMachineVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal)__iaaSvmProtectableItem).VirtualMachineVersion = value ?? null; }

        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string WorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemInternal)__iaaSvmProtectableItem).WorkloadType = value ?? null; }

        /// <summary>Creates an new <see cref="AzureIaaSComputeVmprotectableItem" /> instance.</summary>
        public AzureIaaSComputeVmprotectableItem()
        {
            this.__iaaSvmProtectableItem.ProtectableItemType = "Microsoft.Compute/virtualMachines";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__iaaSvmProtectableItem), __iaaSvmProtectableItem);
            await eventListener.AssertObjectIsValid(nameof(__iaaSvmProtectableItem), __iaaSvmProtectableItem);
        }
    }
    /// IaaS VM workload-specific backup item representing the Azure Resource Manager VM.
    public partial interface IAzureIaaSComputeVmprotectableItem :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItem
    {

    }
    /// IaaS VM workload-specific backup item representing the Azure Resource Manager VM.
    internal partial interface IAzureIaaSComputeVmprotectableItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaaSvmProtectableItemInternal
    {

    }
}