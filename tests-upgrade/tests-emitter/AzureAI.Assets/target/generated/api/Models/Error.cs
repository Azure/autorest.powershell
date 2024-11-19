// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>The error object.</summary>
    public partial class Error :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError> _detail;

        /// <summary>An array of details about specific errors that led to this reported error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError> Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Backing field for <see cref="Innererror" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError _innererror;

        /// <summary>
        /// An object containing more specific information than the current object about the error.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get => (this._innererror = this._innererror ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.InnerError()); set => this._innererror = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>A human-readable representation of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>The target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="Error" /> instance.</summary>
        public Error()
        {

        }
    }
    /// The error object.
    public partial interface IError :
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
    /// The error object.
    internal partial interface IErrorInternal

    {
        /// <summary>One of a server-defined set of error codes.</summary>
        string Code { get; set; }
        /// <summary>An array of details about specific errors that led to this reported error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IError> Detail { get; set; }
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