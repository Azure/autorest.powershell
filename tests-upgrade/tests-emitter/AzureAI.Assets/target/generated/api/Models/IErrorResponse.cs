// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// A response containing error details.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"One of a server-defined set of error codes.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>An array of details about specific errors that led to this reported error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An array of details about specific errors that led to this reported error.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError> Detail { get; set; }
        /// <summary>
        /// An object containing more specific information than the current object about the error.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An object containing more specific information than the current object about the error.",
        SerializedName = @"innererror",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get; set; }
        /// <summary>A human-readable representation of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A human-readable representation of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
}