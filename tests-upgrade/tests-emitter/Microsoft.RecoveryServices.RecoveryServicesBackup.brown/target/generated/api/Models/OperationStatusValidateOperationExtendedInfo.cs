// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Operation status extended info for ValidateOperation action.</summary>
    public partial class OperationStatusValidateOperationExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusValidateOperationExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusValidateOperationExtendedInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo __operationStatusExtendedInfo = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.OperationStatusExtendedInfo();

        /// <summary>Internal Acessors for ValidateOperationResponse</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusValidateOperationExtendedInfoInternal.ValidateOperationResponse { get => (this._validateOperationResponse = this._validateOperationResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ValidateOperationResponse()); set { {_validateOperationResponse = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "OperationStatusValidateOperationExtendedInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfoInternal)__operationStatusExtendedInfo).ObjectType = "OperationStatusValidateOperationExtendedInfo"; }

        /// <summary>Backing field for <see cref="ValidateOperationResponse" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse _validateOperationResponse;

        /// <summary>Gets the validation operation response</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse ValidateOperationResponse { get => (this._validateOperationResponse = this._validateOperationResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ValidateOperationResponse()); set => this._validateOperationResponse = value; }

        /// <summary>Gets the validation result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidateOperationResponseValidationResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponseInternal)ValidateOperationResponse).ValidationResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponseInternal)ValidateOperationResponse).ValidationResult = value ?? null /* arrayOf */; }

        /// <summary>
        /// Creates an new <see cref="OperationStatusValidateOperationExtendedInfo" /> instance.
        /// </summary>
        public OperationStatusValidateOperationExtendedInfo()
        {
            this.__operationStatusExtendedInfo.ObjectType = "OperationStatusValidateOperationExtendedInfo";
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
    /// Operation status extended info for ValidateOperation action.
    public partial interface IOperationStatusValidateOperationExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfo
    {
        /// <summary>Gets the validation result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets the validation result",
        SerializedName = @"validationResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidateOperationResponseValidationResult { get; set; }

    }
    /// Operation status extended info for ValidateOperation action.
    internal partial interface IOperationStatusValidateOperationExtendedInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationStatusExtendedInfoInternal
    {
        /// <summary>Gets the validation operation response</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse ValidateOperationResponse { get; set; }
        /// <summary>Gets the validation result</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidateOperationResponseValidationResult { get; set; }

    }
}