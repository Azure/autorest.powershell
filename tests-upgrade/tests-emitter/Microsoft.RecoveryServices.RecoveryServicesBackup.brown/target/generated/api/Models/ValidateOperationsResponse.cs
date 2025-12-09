// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    public partial class ValidateOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationsResponseInternal
    {

        /// <summary>Internal Acessors for ValidateOperationResponse</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationsResponseInternal.ValidateOperationResponse { get => (this._validateOperationResponse = this._validateOperationResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ValidateOperationResponse()); set { {_validateOperationResponse = value;} } }

        /// <summary>Backing field for <see cref="ValidateOperationResponse" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse _validateOperationResponse;

        /// <summary>Base class for validate operation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse ValidateOperationResponse { get => (this._validateOperationResponse = this._validateOperationResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ValidateOperationResponse()); set => this._validateOperationResponse = value; }

        /// <summary>Gets the validation result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidateOperationResponseValidationResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponseInternal)ValidateOperationResponse).ValidationResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponseInternal)ValidateOperationResponse).ValidationResult = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ValidateOperationsResponse" /> instance.</summary>
        public ValidateOperationsResponse()
        {

        }
    }
    public partial interface IValidateOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
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
    internal partial interface IValidateOperationsResponseInternal

    {
        /// <summary>Base class for validate operation response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse ValidateOperationResponse { get; set; }
        /// <summary>Gets the validation result</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidateOperationResponseValidationResult { get; set; }

    }
}