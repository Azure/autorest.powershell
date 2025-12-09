// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureRestoreValidation request.</summary>
    public partial class ValidateIaasVMRestoreOperationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateIaasVMRestoreOperationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateIaasVMRestoreOperationRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequest __validateRestoreOperationRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ValidateRestoreOperationRequest();

        /// <summary>Internal Acessors for RestoreRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal.RestoreRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequest = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "ValidateIaasVMRestoreOperationRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationRequestInternal)__validateRestoreOperationRequest).ObjectType = "ValidateIaasVMRestoreOperationRequest"; }

        /// <summary>Sets restore request to be validated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest RestoreRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequest = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RestoreRequestObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequestObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequestObjectType = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> RestoreRequestResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequestResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal)__validateRestoreOperationRequest).RestoreRequestResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__validateRestoreOperationRequest), __validateRestoreOperationRequest);
            await eventListener.AssertObjectIsValid(nameof(__validateRestoreOperationRequest), __validateRestoreOperationRequest);
        }

        /// <summary>Creates an new <see cref="ValidateIaasVMRestoreOperationRequest" /> instance.</summary>
        public ValidateIaasVMRestoreOperationRequest()
        {
            this.__validateRestoreOperationRequest.ObjectType = "ValidateIaasVMRestoreOperationRequest";
        }
    }
    /// AzureRestoreValidation request.
    public partial interface IValidateIaasVMRestoreOperationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequest
    {

    }
    /// AzureRestoreValidation request.
    internal partial interface IValidateIaasVMRestoreOperationRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal
    {

    }
}