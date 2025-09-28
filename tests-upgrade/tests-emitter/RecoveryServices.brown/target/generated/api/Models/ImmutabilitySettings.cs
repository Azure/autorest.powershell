// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Immutability Settings of vault</summary>
    public partial class ImmutabilitySettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettingsInternal
    {

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="ImmutabilitySettings" /> instance.</summary>
        public ImmutabilitySettings()
        {

        }
    }
    /// Immutability Settings of vault
    public partial interface IImmutabilitySettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string State { get; set; }

    }
    /// Immutability Settings of vault
    internal partial interface IImmutabilitySettingsInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string State { get; set; }

    }
}