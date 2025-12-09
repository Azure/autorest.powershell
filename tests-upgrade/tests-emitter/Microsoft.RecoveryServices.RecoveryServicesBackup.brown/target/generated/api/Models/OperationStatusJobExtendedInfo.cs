// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Operation status job extended info.</summary>
    public partial class OperationStatusJobExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusJobExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusJobExtendedInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo __operationStatusExtendedInfo = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.OperationStatusExtendedInfo();

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private string _jobId;

        /// <summary>ID of the job created for this protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string JobId { get => this._jobId; set => this._jobId = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "OperationStatusJobExtendedInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfoInternal)__operationStatusExtendedInfo).ObjectType = "OperationStatusJobExtendedInfo"; }

        /// <summary>Creates an new <see cref="OperationStatusJobExtendedInfo" /> instance.</summary>
        public OperationStatusJobExtendedInfo()
        {
            this.__operationStatusExtendedInfo.ObjectType = "OperationStatusJobExtendedInfo";
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
    /// Operation status job extended info.
    public partial interface IOperationStatusJobExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo
    {
        /// <summary>ID of the job created for this protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ID of the job created for this protected item.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get; set; }

    }
    /// Operation status job extended info.
    internal partial interface IOperationStatusJobExtendedInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfoInternal
    {
        /// <summary>ID of the job created for this protected item.</summary>
        string JobId { get; set; }

    }
}