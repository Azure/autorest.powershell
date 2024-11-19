// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// A response containing error details.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>One of a server-defined set of error codes.</summary>
        string Code { get; set; }
        /// <summary>An array of details about specific errors that led to this reported error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError> Detail { get; set; }
        /// <summary>The error object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError Error { get; set; }
        /// <summary>
        /// An object containing more specific information than the current object about the error.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get; set; }
        /// <summary>A human-readable representation of the error.</summary>
        string Message { get; set; }
        /// <summary>The target of the error.</summary>
        string Target { get; set; }

    }
}