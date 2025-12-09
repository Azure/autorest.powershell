// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Base class for validate operation response.</summary>
    public partial class ValidateOperationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationResponseInternal
    {

        /// <summary>Backing field for <see cref="ValidationResult" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> _validationResult;

        /// <summary>Gets the validation result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidationResult { get => this._validationResult; set => this._validationResult = value; }

        /// <summary>Creates an new <see cref="ValidateOperationResponse" /> instance.</summary>
        public ValidateOperationResponse()
        {

        }
    }
    /// Base class for validate operation response.
    public partial interface IValidateOperationResponse :
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidationResult { get; set; }

    }
    /// Base class for validate operation response.
    internal partial interface IValidateOperationResponseInternal

    {
        /// <summary>Gets the validation result</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1> ValidationResult { get; set; }

    }
}