// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The response of a SAPDatabaseInstance list operation.</summary>
    public partial class SapDatabaseInstanceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstanceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstanceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstance> _value;

        /// <summary>The SAPDatabaseInstance items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstance> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SapDatabaseInstanceListResult" /> instance.</summary>
        public SapDatabaseInstanceListResult()
        {

        }
    }
    /// The response of a SAPDatabaseInstance list operation.
    public partial interface ISapDatabaseInstanceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The SAPDatabaseInstance items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAPDatabaseInstance items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstance) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstance> Value { get; set; }

    }
    /// The response of a SAPDatabaseInstance list operation.
    internal partial interface ISapDatabaseInstanceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The SAPDatabaseInstance items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseInstance> Value { get; set; }

    }
}