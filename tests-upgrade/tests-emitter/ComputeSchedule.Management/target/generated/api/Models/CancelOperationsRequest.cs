// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>
    /// This is the request to cancel running operations in scheduled actions using the operation ids
    /// </summary>
    public partial class CancelOperationsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ICancelOperationsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ICancelOperationsRequestInternal
    {

        /// <summary>Backing field for <see cref="Correlationid" /> property.</summary>
        private string _correlationid;

        /// <summary>CorrelationId item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string Correlationid { get => this._correlationid; set => this._correlationid = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private System.Collections.Generic.List<string> _operationId;

        /// <summary>The list of operation ids to cancel operations on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Creates an new <see cref="CancelOperationsRequest" /> instance.</summary>
        public CancelOperationsRequest()
        {

        }
    }
    /// This is the request to cancel running operations in scheduled actions using the operation ids
    public partial interface ICancelOperationsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>CorrelationId item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CorrelationId item",
        SerializedName = @"correlationid",
        PossibleTypes = new [] { typeof(string) })]
        string Correlationid { get; set; }
        /// <summary>The list of operation ids to cancel operations on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of operation ids to cancel operations on",
        SerializedName = @"operationIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> OperationId { get; set; }

    }
    /// This is the request to cancel running operations in scheduled actions using the operation ids
    internal partial interface ICancelOperationsRequestInternal

    {
        /// <summary>CorrelationId item</summary>
        string Correlationid { get; set; }
        /// <summary>The list of operation ids to cancel operations on</summary>
        System.Collections.Generic.List<string> OperationId { get; set; }

    }
}