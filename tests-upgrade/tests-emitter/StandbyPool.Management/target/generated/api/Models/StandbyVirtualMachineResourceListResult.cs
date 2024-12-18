// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>The response of a StandbyVirtualMachineResource list operation.</summary>
    public partial class StandbyVirtualMachineResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResource> _value;

        /// <summary>The StandbyVirtualMachineResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="StandbyVirtualMachineResourceListResult" /> instance.</summary>
        public StandbyVirtualMachineResourceListResult()
        {

        }
    }
    /// The response of a StandbyVirtualMachineResource list operation.
    public partial interface IStandbyVirtualMachineResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The StandbyVirtualMachineResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The StandbyVirtualMachineResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResource> Value { get; set; }

    }
    /// The response of a StandbyVirtualMachineResource list operation.
    internal partial interface IStandbyVirtualMachineResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The StandbyVirtualMachineResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResource> Value { get; set; }

    }
}