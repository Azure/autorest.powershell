// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>The response of a CodeSigningAccount list operation.</summary>
    public partial class CodeSigningAccountListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountListResult,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccount> _value;

        /// <summary>The CodeSigningAccount items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccount> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CodeSigningAccountListResult" /> instance.</summary>
        public CodeSigningAccountListResult()
        {

        }
    }
    /// The response of a CodeSigningAccount list operation.
    public partial interface ICodeSigningAccountListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The CodeSigningAccount items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The CodeSigningAccount items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccount) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccount> Value { get; set; }

    }
    /// The response of a CodeSigningAccount list operation.
    internal partial interface ICodeSigningAccountListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The CodeSigningAccount items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccount> Value { get; set; }

    }
}