// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Result of a long running operation.</summary>
    public partial class AsyncOperationResult :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IAsyncOperationResult,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IAsyncOperationResultInternal
    {

        /// <summary>standard error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessageInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessageInternal)Error).Code = value ?? null; }

        /// <summary>detailed summary of error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessageInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessageInternal)Error).Detail = value ?? null; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessage _error;

        /// <summary>Error message containing code, description and details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessage Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ErrorMessage()); set => this._error = value; }

        /// <summary>standard error description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessageInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessageInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessage Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IAsyncOperationResultInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ErrorMessage()); set { {_error = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>current status of a long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="AsyncOperationResult" /> instance.</summary>
        public AsyncOperationResult()
        {

        }
    }
    /// Result of a long running operation.
    public partial interface IAsyncOperationResult :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>standard error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"standard error code",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>detailed summary of error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"detailed summary of error",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get; set; }
        /// <summary>standard error description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"standard error description",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>current status of a long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"current status of a long running operation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Result of a long running operation.
    internal partial interface IAsyncOperationResultInternal

    {
        /// <summary>standard error code</summary>
        string Code { get; set; }
        /// <summary>detailed summary of error</summary>
        string Detail { get; set; }
        /// <summary>Error message containing code, description and details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IErrorMessage Error { get; set; }
        /// <summary>standard error description</summary>
        string Message { get; set; }
        /// <summary>current status of a long running operation.</summary>
        string Status { get; set; }

    }
}