// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Preferences related to the Encryption.</summary>
    public partial class EncryptionPreferences :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferencesInternal
    {

        /// <summary>Backing field for <see cref="DoubleEncryption" /> property.</summary>
        private string _doubleEncryption;

        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DoubleEncryption { get => this._doubleEncryption; set => this._doubleEncryption = value; }

        /// <summary>Backing field for <see cref="HardwareEncryption" /> property.</summary>
        private string _hardwareEncryption;

        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string HardwareEncryption { get => this._hardwareEncryption; set => this._hardwareEncryption = value; }

        /// <summary>Creates an new <see cref="EncryptionPreferences" /> instance.</summary>
        public EncryptionPreferences()
        {

        }
    }
    /// Preferences related to the Encryption.
    public partial interface IEncryptionPreferences :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines secondary layer of software-based encryption enablement.",
        SerializedName = @"doubleEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines Hardware level encryption (Only for disk)",
        SerializedName = @"hardwareEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string HardwareEncryption { get; set; }

    }
    /// Preferences related to the Encryption.
    internal partial interface IEncryptionPreferencesInternal

    {
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string HardwareEncryption { get; set; }

    }
}