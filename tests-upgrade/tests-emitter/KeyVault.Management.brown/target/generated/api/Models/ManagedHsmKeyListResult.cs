// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The response of a ManagedHsmKey list operation.</summary>
    public partial class ManagedHsmKeyListResult :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyListResult,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKey> _value;

        /// <summary>The ManagedHsmKey items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKey> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ManagedHsmKeyListResult" /> instance.</summary>
        public ManagedHsmKeyListResult()
        {

        }
    }
    /// The response of a ManagedHsmKey list operation.
    public partial interface IManagedHsmKeyListResult :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ManagedHsmKey items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ManagedHsmKey items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKey) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKey> Value { get; set; }

    }
    /// The response of a ManagedHsmKey list operation.
    internal partial interface IManagedHsmKeyListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ManagedHsmKey items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKey> Value { get; set; }

    }
}