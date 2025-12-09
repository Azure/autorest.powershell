// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The response of a ServerBackupV2 list operation.</summary>
    public partial class ServerBackupV2ListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2ListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2ListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2> _value;

        /// <summary>The ServerBackupV2 items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ServerBackupV2ListResult" /> instance.</summary>
        public ServerBackupV2ListResult()
        {

        }
    }
    /// The response of a ServerBackupV2 list operation.
    public partial interface IServerBackupV2ListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ServerBackupV2 items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ServerBackupV2 items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2> Value { get; set; }

    }
    /// The response of a ServerBackupV2 list operation.
    internal partial interface IServerBackupV2ListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ServerBackupV2 items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupV2> Value { get; set; }

    }
}