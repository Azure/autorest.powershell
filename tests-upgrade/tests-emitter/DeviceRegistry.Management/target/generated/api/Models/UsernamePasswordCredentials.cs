// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The credentials for authentication mode UsernamePassword.</summary>
    public partial class UsernamePasswordCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentialsInternal
    {

        /// <summary>Backing field for <see cref="PasswordSecretName" /> property.</summary>
        private string _passwordSecretName;

        /// <summary>The name of the secret containing the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string PasswordSecretName { get => this._passwordSecretName; set => this._passwordSecretName = value; }

        /// <summary>Backing field for <see cref="UsernameSecretName" /> property.</summary>
        private string _usernameSecretName;

        /// <summary>The name of the secret containing the username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string UsernameSecretName { get => this._usernameSecretName; set => this._usernameSecretName = value; }

        /// <summary>Creates an new <see cref="UsernamePasswordCredentials" /> instance.</summary>
        public UsernamePasswordCredentials()
        {

        }
    }
    /// The credentials for authentication mode UsernamePassword.
    public partial interface IUsernamePasswordCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The name of the secret containing the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the secret containing the password.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordSecretName { get; set; }
        /// <summary>The name of the secret containing the username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the secret containing the username.",
        SerializedName = @"usernameSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string UsernameSecretName { get; set; }

    }
    /// The credentials for authentication mode UsernamePassword.
    internal partial interface IUsernamePasswordCredentialsInternal

    {
        /// <summary>The name of the secret containing the password.</summary>
        string PasswordSecretName { get; set; }
        /// <summary>The name of the secret containing the username.</summary>
        string UsernameSecretName { get; set; }

    }
}