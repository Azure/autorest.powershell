// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details for KeyVault.</summary>
    public partial class KeyVaultInfo :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IKeyVaultInfo,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IKeyVaultInfoInternal
    {

        /// <summary>Backing field for <see cref="KeyVaultUrl" /> property.</summary>
        private string _keyVaultUrl;

        /// <summary>key vault url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string KeyVaultUrl { get => this._keyVaultUrl; set => this._keyVaultUrl = value; }

        /// <summary>Creates an new <see cref="KeyVaultInfo" /> instance.</summary>
        public KeyVaultInfo()
        {

        }
    }
    /// Details for KeyVault.
    public partial interface IKeyVaultInfo :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>key vault url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"key vault url.",
        SerializedName = @"keyVaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultUrl { get; set; }

    }
    /// Details for KeyVault.
    internal partial interface IKeyVaultInfoInternal

    {
        /// <summary>key vault url.</summary>
        string KeyVaultUrl { get; set; }

    }
}