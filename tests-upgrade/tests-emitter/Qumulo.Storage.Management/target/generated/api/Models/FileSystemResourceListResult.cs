// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>The response of a FileSystemResource list operation.</summary>
    public partial class FileSystemResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource> _value;

        /// <summary>The FileSystemResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FileSystemResourceListResult" /> instance.</summary>
        public FileSystemResourceListResult()
        {

        }
    }
    /// The response of a FileSystemResource list operation.
    public partial interface IFileSystemResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The FileSystemResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The FileSystemResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource> Value { get; set; }

    }
    /// The response of a FileSystemResource list operation.
    internal partial interface IFileSystemResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The FileSystemResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource> Value { get; set; }

    }
}