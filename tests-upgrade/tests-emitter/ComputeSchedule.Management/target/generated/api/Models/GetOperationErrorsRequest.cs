// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>This is the request to get errors per vm operations</summary>
    public partial class GetOperationErrorsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationErrorsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationErrorsRequestInternal
    {

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private System.Collections.Generic.List<string> _operationId;

        /// <summary>The list of operation ids to query errors of</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Creates an new <see cref="GetOperationErrorsRequest" /> instance.</summary>
        public GetOperationErrorsRequest()
        {

        }
    }
    /// This is the request to get errors per vm operations
    public partial interface IGetOperationErrorsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>The list of operation ids to query errors of</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of operation ids to query errors of",
        SerializedName = @"operationIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> OperationId { get; set; }

    }
    /// This is the request to get errors per vm operations
    internal partial interface IGetOperationErrorsRequestInternal

    {
        /// <summary>The list of operation ids to query errors of</summary>
        System.Collections.Generic.List<string> OperationId { get; set; }

    }
}