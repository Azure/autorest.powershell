// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Parameters for creating or updating a trusted signing account.</summary>
    public partial class CodeSigningAccountPatch :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatch,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchProperties Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CodeSigningAccountPatchProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatch Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchPropertiesInternal)Property).Sku = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchProperties _property;

        /// <summary>Properties of the trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CodeSigningAccountPatchProperties()); set => this._property = value; }

        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchPropertiesInternal)Property).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchPropertiesInternal)Property).SkuName = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="CodeSigningAccountPatch" /> instance.</summary>
        public CodeSigningAccountPatch()
        {

        }
    }
    /// Parameters for creating or updating a trusted signing account.
    public partial interface ICodeSigningAccountPatch :
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
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ITags Tag { get; set; }

    }
    /// Parameters for creating or updating a trusted signing account.
    internal partial interface ICodeSigningAccountPatchInternal

    {
        /// <summary>Properties of the trusted signing account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPatchProperties Property { get; set; }
        /// <summary>SKU of the trusted signing account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuPatch Sku { get; set; }
        /// <summary>Name of the SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ITags Tag { get; set; }

    }
}