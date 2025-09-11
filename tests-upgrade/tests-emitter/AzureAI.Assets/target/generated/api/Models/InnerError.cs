// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>
    /// An object containing more specific information about the error. As per Azure REST API guidelines - https://aka.ms/AzureRestApiGuidelines#handling-errors.
    /// </summary>
    public partial class InnerError :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Innererror" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError _innererror;

        /// <summary>Inner error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get => (this._innererror = this._innererror ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.InnerError()); set => this._innererror = value; }

        /// <summary>Creates an new <see cref="InnerError" /> instance.</summary>
        public InnerError()
        {

        }
    }
    /// An object containing more specific information about the error. As per Azure REST API guidelines - https://aka.ms/AzureRestApiGuidelines#handling-errors.
    public partial interface IInnerError :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"One of a server-defined set of error codes.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Inner error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Inner error.",
        SerializedName = @"innererror",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get; set; }

    }
    /// An object containing more specific information about the error. As per Azure REST API guidelines - https://aka.ms/AzureRestApiGuidelines#handling-errors.
    internal partial interface IInnerErrorInternal

    {
        /// <summary>One of a server-defined set of error codes.</summary>
        string Code { get; set; }
        /// <summary>Inner error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IInnerError Innererror { get; set; }

    }
}