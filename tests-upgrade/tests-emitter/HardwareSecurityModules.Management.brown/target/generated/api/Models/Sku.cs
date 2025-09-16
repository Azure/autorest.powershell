// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>SKU of the dedicated HSM</summary>
    public partial class Sku :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISkuInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>SKU of the dedicated HSM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Sku" /> instance.</summary>
        public Sku()
        {

        }
    }
    /// SKU of the dedicated HSM
    public partial interface ISku :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>SKU of the dedicated HSM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SKU of the dedicated HSM",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("SafeNet Luna Network HSM A790", "payShield10K_LMK1_CPS60", "payShield10K_LMK1_CPS250", "payShield10K_LMK1_CPS2500", "payShield10K_LMK2_CPS60", "payShield10K_LMK2_CPS250", "payShield10K_LMK2_CPS2500")]
        string Name { get; set; }

    }
    /// SKU of the dedicated HSM
    internal partial interface ISkuInternal

    {
        /// <summary>SKU of the dedicated HSM</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("SafeNet Luna Network HSM A790", "payShield10K_LMK1_CPS60", "payShield10K_LMK1_CPS250", "payShield10K_LMK1_CPS2500", "payShield10K_LMK2_CPS60", "payShield10K_LMK2_CPS250", "payShield10K_LMK2_CPS2500")]
        string Name { get; set; }

    }
}