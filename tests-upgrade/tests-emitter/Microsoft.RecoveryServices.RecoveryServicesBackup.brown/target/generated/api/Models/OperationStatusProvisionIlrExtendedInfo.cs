// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Operation status extended info for ILR provision action.</summary>
    public partial class OperationStatusProvisionIlrExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusProvisionIlrExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusProvisionIlrExtendedInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo __operationStatusExtendedInfo = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.OperationStatusExtendedInfo();

        /// <summary>Internal Acessors for RecoveryTarget</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTarget Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusProvisionIlrExtendedInfoInternal.RecoveryTarget { get => (this._recoveryTarget = this._recoveryTarget ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InstantItemRecoveryTarget()); set { {_recoveryTarget = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "OperationStatusProvisionILRExtendedInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfoInternal)__operationStatusExtendedInfo).ObjectType = "OperationStatusProvisionILRExtendedInfo"; }

        /// <summary>Backing field for <see cref="RecoveryTarget" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTarget _recoveryTarget;

        /// <summary>Target details for file / folder restore.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTarget RecoveryTarget { get => (this._recoveryTarget = this._recoveryTarget ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InstantItemRecoveryTarget()); set => this._recoveryTarget = value; }

        /// <summary>List of client scripts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> RecoveryTargetClientScript { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTargetInternal)RecoveryTarget).ClientScript; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTargetInternal)RecoveryTarget).ClientScript = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationStatusProvisionIlrExtendedInfo" /> instance.</summary>
        public OperationStatusProvisionIlrExtendedInfo()
        {
            this.__operationStatusExtendedInfo.ObjectType = "OperationStatusProvisionILRExtendedInfo";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__operationStatusExtendedInfo), __operationStatusExtendedInfo);
            await eventListener.AssertObjectIsValid(nameof(__operationStatusExtendedInfo), __operationStatusExtendedInfo);
        }
    }
    /// Operation status extended info for ILR provision action.
    public partial interface IOperationStatusProvisionIlrExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo
    {
        /// <summary>List of client scripts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of client scripts.",
        SerializedName = @"clientScripts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> RecoveryTargetClientScript { get; set; }

    }
    /// Operation status extended info for ILR provision action.
    internal partial interface IOperationStatusProvisionIlrExtendedInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfoInternal
    {
        /// <summary>Target details for file / folder restore.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTarget RecoveryTarget { get; set; }
        /// <summary>List of client scripts.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> RecoveryTargetClientScript { get; set; }

    }
}