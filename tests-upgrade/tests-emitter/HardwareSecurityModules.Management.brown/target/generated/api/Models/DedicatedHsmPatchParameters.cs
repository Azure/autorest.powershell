// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Patchable properties of the dedicated HSM</summary>
    public partial class DedicatedHsmPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParametersInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParametersTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmPatchParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="DedicatedHsmPatchParameters" /> instance.</summary>
        public DedicatedHsmPatchParameters()
        {

        }
    }
    /// Patchable properties of the dedicated HSM
    public partial interface IDedicatedHsmPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParametersTags Tag { get; set; }

    }
    /// Patchable properties of the dedicated HSM
    internal partial interface IDedicatedHsmPatchParametersInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPatchParametersTags Tag { get; set; }

    }
}