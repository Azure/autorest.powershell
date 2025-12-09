// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureRestoreValidation request.</summary>
    public partial class ValidateRestoreOperationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationRequest __validateOperationRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ValidateOperationRequest();

        /// <summary>Internal Acessors for RestoreRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateRestoreOperationRequestInternal.RestoreRequest { get => (this._restoreRequest = this._restoreRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RestoreRequest()); set { {_restoreRequest = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "ValidateRestoreOperationRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationRequestInternal)__validateOperationRequest).ObjectType = "ValidateRestoreOperationRequest"; }

        /// <summary>Backing field for <see cref="RestoreRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest _restoreRequest;

        /// <summary>Sets restore request to be validated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest RestoreRequest { get => (this._restoreRequest = this._restoreRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RestoreRequest()); set => this._restoreRequest = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RestoreRequestObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)RestoreRequest).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)RestoreRequest).ObjectType = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RestoreRequestResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)RestoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)RestoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__validateOperationRequest), __validateOperationRequest);
            await eventListener.AssertObjectIsValid(nameof(__validateOperationRequest), __validateOperationRequest);
        }

        /// <summary>Creates an new <see cref="ValidateRestoreOperationRequest" /> instance.</summary>
        public ValidateRestoreOperationRequest()
        {
            this.__validateOperationRequest.ObjectType = "ValidateRestoreOperationRequest";
        }
    }
    /// AzureRestoreValidation request.
    public partial interface IValidateRestoreOperationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationRequest
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreRequestObjectType { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RestoreRequestResourceGuardOperationRequest { get; set; }

    }
    /// AzureRestoreValidation request.
    internal partial interface IValidateRestoreOperationRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IValidateOperationRequestInternal
    {
        /// <summary>Sets restore request to be validated</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest RestoreRequest { get; set; }
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        string RestoreRequestObjectType { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> RestoreRequestResourceGuardOperationRequest { get; set; }

    }
}