// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>
    /// Key release policy in response. It will be used for both output and input. Omitted if empty
    /// </summary>
    public partial class KeyReleasePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyReleasePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyReleasePolicyInternal
    {

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>Content type and version of key release policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Backing field for <see cref="Data" /> property.</summary>
        private byte[] _data;

        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public byte[] Data { get => this._data; set => this._data = value; }

        /// <summary>Creates an new <see cref="KeyReleasePolicy" /> instance.</summary>
        public KeyReleasePolicy()
        {

        }
    }
    /// Key release policy in response. It will be used for both output and input. Omitted if empty
    public partial interface IKeyReleasePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>Content type and version of key release policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Content type and version of key release policy",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ContentType { get; set; }
        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Blob encoding the policy rules under which the key can be released.",
        SerializedName = @"data",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] Data { get; set; }

    }
    /// Key release policy in response. It will be used for both output and input. Omitted if empty
    internal partial interface IKeyReleasePolicyInternal

    {
        /// <summary>Content type and version of key release policy</summary>
        string ContentType { get; set; }
        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        byte[] Data { get; set; }

    }
}