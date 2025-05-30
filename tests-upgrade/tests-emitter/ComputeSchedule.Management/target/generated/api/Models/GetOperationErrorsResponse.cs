// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>This is the response from a get operations errors request</summary>
    public partial class GetOperationErrorsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationErrorsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationErrorsResponseInternal
    {

        /// <summary>Backing field for <see cref="Result" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult> _result;

        /// <summary>An array of operationids and their corresponding errors if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult> Result { get => this._result; set => this._result = value; }

        /// <summary>Creates an new <see cref="GetOperationErrorsResponse" /> instance.</summary>
        public GetOperationErrorsResponse()
        {

        }
    }
    /// This is the response from a get operations errors request
    public partial interface IGetOperationErrorsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>An array of operationids and their corresponding errors if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An array of operationids and their corresponding errors if any",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult> Result { get; set; }

    }
    /// This is the response from a get operations errors request
    internal partial interface IGetOperationErrorsResponseInternal

    {
        /// <summary>An array of operationids and their corresponding errors if any</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult> Result { get; set; }

    }
}