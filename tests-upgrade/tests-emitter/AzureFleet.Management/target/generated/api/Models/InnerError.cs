// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Inner error details.</summary>
    public partial class InnerError :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerErrorInternal
    {

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private string _errorDetail;

        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Backing field for <see cref="ExceptionType" /> property.</summary>
        private string _exceptionType;

        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ExceptionType { get => this._exceptionType; set => this._exceptionType = value; }

        /// <summary>Creates an new <see cref="InnerError" /> instance.</summary>
        public InnerError()
        {

        }
    }
    /// Inner error details.
    public partial interface IInnerError :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The internal error message or exception dump.",
        SerializedName = @"errorDetail",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetail { get; set; }
        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The exception type.",
        SerializedName = @"exceptionType",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionType { get; set; }

    }
    /// Inner error details.
    internal partial interface IInnerErrorInternal

    {
        /// <summary>The internal error message or exception dump.</summary>
        string ErrorDetail { get; set; }
        /// <summary>The exception type.</summary>
        string ExceptionType { get; set; }

    }
}