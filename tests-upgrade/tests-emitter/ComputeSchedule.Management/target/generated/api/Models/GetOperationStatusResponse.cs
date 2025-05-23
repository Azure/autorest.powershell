// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>This is the response from a get operations status request</summary>
    public partial class GetOperationStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationStatusResponse,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationStatusResponseInternal
    {

        /// <summary>Backing field for <see cref="Result" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> _result;

        /// <summary>An array of resource operations based on their operation ids</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> Result { get => this._result; set => this._result = value; }

        /// <summary>Creates an new <see cref="GetOperationStatusResponse" /> instance.</summary>
        public GetOperationStatusResponse()
        {

        }
    }
    /// This is the response from a get operations status request
    public partial interface IGetOperationStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>An array of resource operations based on their operation ids</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An array of resource operations based on their operation ids",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> Result { get; set; }

    }
    /// This is the response from a get operations status request
    internal partial interface IGetOperationStatusResponseInternal

    {
        /// <summary>An array of resource operations based on their operation ids</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> Result { get; set; }

    }
}