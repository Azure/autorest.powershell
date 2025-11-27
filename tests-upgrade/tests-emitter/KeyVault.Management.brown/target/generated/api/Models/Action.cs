// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The action of key rotation policy lifetimeAction.</summary>
    public partial class Action :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAction,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IActionInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="Action" /> instance.</summary>
        public Action()
        {

        }
    }
    /// The action of key rotation policy lifetimeAction.
    public partial interface IAction :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>The type of action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of action.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("rotate", "notify")]
        string Type { get; set; }

    }
    /// The action of key rotation policy lifetimeAction.
    internal partial interface IActionInternal

    {
        /// <summary>The type of action.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("rotate", "notify")]
        string Type { get; set; }

    }
}