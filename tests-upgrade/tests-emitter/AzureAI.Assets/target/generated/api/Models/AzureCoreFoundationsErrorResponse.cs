// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>A response containing error details.</summary>
    public partial class AzureCoreFoundationsErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorResponseInternal
    {

        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Code = value ; }

        /// <summary>An array of details about specific errors that led to this reported error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError _error;

        /// <summary>The error object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Error()); set => this._error = value; }

        /// <summary>
        /// An object containing more specific information than the current object about the error.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Innererror; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Innererror = value ?? null /* model class */; }

        /// <summary>A human-readable representation of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Message = value ; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Error()); set { {_error = value;} } }

        /// <summary>The target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal)Error).Target = value ?? null; }

        /// <summary>Creates an new <see cref="AzureCoreFoundationsErrorResponse" /> instance.</summary>
        public AzureCoreFoundationsErrorResponse()
        {

        }
    }
}