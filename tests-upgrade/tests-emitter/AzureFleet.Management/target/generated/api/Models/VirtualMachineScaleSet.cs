// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>An AzureFleet's virtualMachineScaleSet</summary>
    public partial class VirtualMachineScaleSet :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSet,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal
    {

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Code; }

        /// <summary>The API error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiError _error;

        /// <summary>Error Information when `operationStatus` is `Failed`</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ApiError()); }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string InnererrorErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).InnererrorErrorDetail; }

        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string InnererrorExceptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).InnererrorExceptionType; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiError Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ApiError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Innererror</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Innererror { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Innererror; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Innererror = value ?? null /* model class */; }

        /// <summary>Internal Acessors for InnererrorErrorDetail</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.InnererrorErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).InnererrorErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).InnererrorErrorDetail = value ?? null; }

        /// <summary>Internal Acessors for InnererrorExceptionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.InnererrorExceptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).InnererrorExceptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).InnererrorExceptionType = value ?? null; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for OperationStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.OperationStatus { get => this._operationStatus; set { {_operationStatus = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Target = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="OperationStatus" /> property.</summary>
        private string _operationStatus;

        /// <summary>
        /// This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string OperationStatus { get => this._operationStatus; }

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal)Error).Target; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the virtualMachineScaleSet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSet" /> instance.</summary>
        public VirtualMachineScaleSet()
        {

        }
    }
    /// An AzureFleet's virtualMachineScaleSet
    public partial interface IVirtualMachineScaleSet :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The API error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The API error details",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Detail { get;  }
        /// <summary>
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The compute RP resource id of the virtualMachineScaleSet
        ""subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}""",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The internal error message or exception dump.",
        SerializedName = @"errorDetail",
        PossibleTypes = new [] { typeof(string) })]
        string InnererrorErrorDetail { get;  }
        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The exception type.",
        SerializedName = @"exceptionType",
        PossibleTypes = new [] { typeof(string) })]
        string InnererrorExceptionType { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>
        /// This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet resource.",
        SerializedName = @"operationStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Updating", "Deleting", "Migrating")]
        string OperationStatus { get;  }
        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The target of the particular error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }
        /// <summary>Type of the virtualMachineScaleSet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of the virtualMachineScaleSet",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An AzureFleet's virtualMachineScaleSet
    internal partial interface IVirtualMachineScaleSetInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The API error details</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Detail { get; set; }
        /// <summary>Error Information when `operationStatus` is `Failed`</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiError Error { get; set; }
        /// <summary>
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </summary>
        string Id { get; set; }
        /// <summary>The API inner error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError Innererror { get; set; }
        /// <summary>The internal error message or exception dump.</summary>
        string InnererrorErrorDetail { get; set; }
        /// <summary>The exception type.</summary>
        string InnererrorExceptionType { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>
        /// This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet
        /// resource.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Updating", "Deleting", "Migrating")]
        string OperationStatus { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }
        /// <summary>Type of the virtualMachineScaleSet</summary>
        string Type { get; set; }

    }
}