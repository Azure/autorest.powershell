// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Properties of the trusted signing account.</summary>
    public partial class CodeSigningAccountPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchPropertiesInternal
    {

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatch Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchPropertiesInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.AccountSkuPatch()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatch _sku;

        /// <summary>SKU of the trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatch Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.AccountSkuPatch()); set => this._sku = value; }

        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatchInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatchInternal)Sku).Name = value ?? null; }

        /// <summary>Creates an new <see cref="CodeSigningAccountPatchProperties" /> instance.</summary>
        public CodeSigningAccountPatchProperties()
        {

        }
    }
    /// Properties of the trusted signing account.
    public partial interface ICodeSigningAccountPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }

    }
    /// Properties of the trusted signing account.
    internal partial interface ICodeSigningAccountPatchPropertiesInternal

    {
        /// <summary>SKU of the trusted signing account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatch Sku { get; set; }
        /// <summary>Name of the SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }

    }
}