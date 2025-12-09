// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>IaaS VM specific backup protection intent item.</summary>
    public partial class AzureResourceProtectionIntent :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureResourceProtectionIntent,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureResourceProtectionIntentInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntent"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntent __protectionIntent = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ProtectionIntent();

        /// <summary>Type of backup management for the backed up item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).BackupManagementType = value ?? null; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of the VM represented by this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>
        /// ID of the item which is getting protected, In case of Azure Vm , it is ProtectedItemId
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ItemId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).ItemId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).ItemId = value ?? null; }

        /// <summary>backup protectionIntent type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ItemType { get => "AzureResourceItem"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).ItemType = "AzureResourceItem"; }

        /// <summary>ID of the backup policy with which this item is backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).PolicyId = value ?? null; }

        /// <summary>Backup state of this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).ProtectionState = value ?? null; }

        /// <summary>ARM ID of the resource to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)__protectionIntent).SourceResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="AzureResourceProtectionIntent" /> instance.</summary>
        public AzureResourceProtectionIntent()
        {
            this.__protectionIntent.ItemType = "AzureResourceItem";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectionIntent), __protectionIntent);
            await eventListener.AssertObjectIsValid(nameof(__protectionIntent), __protectionIntent);
        }
    }
    /// IaaS VM specific backup protection intent item.
    public partial interface IAzureResourceProtectionIntent :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntent
    {
        /// <summary>Friendly name of the VM represented by this backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Friendly name of the VM represented by this backup item.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }

    }
    /// IaaS VM specific backup protection intent item.
    internal partial interface IAzureResourceProtectionIntentInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal
    {
        /// <summary>Friendly name of the VM represented by this backup item.</summary>
        string FriendlyName { get; set; }

    }
}