// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Operation result info.</summary>
    public partial class OperationResultInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfoBase __operationResultInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.OperationResultInfoBase();

        /// <summary>Backing field for <see cref="JobList" /> property.</summary>
        private System.Collections.Generic.List<string> _jobList;

        /// <summary>List of jobs created by this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> JobList { get => this._jobList; set => this._jobList = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "OperationResultInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfoBaseInternal)__operationResultInfoBase).ObjectType = "OperationResultInfo"; }

        /// <summary>Creates an new <see cref="OperationResultInfo" /> instance.</summary>
        public OperationResultInfo()
        {
            this.__operationResultInfoBase.ObjectType = "OperationResultInfo";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__operationResultInfoBase), __operationResultInfoBase);
            await eventListener.AssertObjectIsValid(nameof(__operationResultInfoBase), __operationResultInfoBase);
        }
    }
    /// Operation result info.
    public partial interface IOperationResultInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfoBase
    {
        /// <summary>List of jobs created by this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of jobs created by this operation.",
        SerializedName = @"jobList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> JobList { get; set; }

    }
    /// Operation result info.
    internal partial interface IOperationResultInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationResultInfoBaseInternal
    {
        /// <summary>List of jobs created by this operation.</summary>
        System.Collections.Generic.List<string> JobList { get; set; }

    }
}