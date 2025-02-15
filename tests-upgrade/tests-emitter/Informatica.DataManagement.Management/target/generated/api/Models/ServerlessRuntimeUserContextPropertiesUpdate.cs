// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>The template for adding optional properties.</summary>
    public partial class ServerlessRuntimeUserContextPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdateInternal
    {

        /// <summary>Backing field for <see cref="UserContextToken" /> property.</summary>
        private string _userContextToken;

        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string UserContextToken { get => this._userContextToken; set => this._userContextToken = value; }

        /// <summary>
        /// Creates an new <see cref="ServerlessRuntimeUserContextPropertiesUpdate" /> instance.
        /// </summary>
        public ServerlessRuntimeUserContextPropertiesUpdate()
        {

        }
    }
    /// The template for adding optional properties.
    public partial interface IServerlessRuntimeUserContextPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User context token for OBO flow.",
        SerializedName = @"userContextToken",
        PossibleTypes = new [] { typeof(string) })]
        string UserContextToken { get; set; }

    }
    /// The template for adding optional properties.
    internal partial interface IServerlessRuntimeUserContextPropertiesUpdateInternal

    {
        /// <summary>User context token for OBO flow.</summary>
        string UserContextToken { get; set; }

    }
}