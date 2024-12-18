// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Informatica Serverless Runtime User context properties</summary>
    public partial class ServerlessRuntimeUserContextProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesInternal
    {

        /// <summary>Backing field for <see cref="UserContextToken" /> property.</summary>
        private string _userContextToken;

        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string UserContextToken { get => this._userContextToken; set => this._userContextToken = value; }

        /// <summary>Creates an new <see cref="ServerlessRuntimeUserContextProperties" /> instance.</summary>
        public ServerlessRuntimeUserContextProperties()
        {

        }
    }
    /// Informatica Serverless Runtime User context properties
    public partial interface IServerlessRuntimeUserContextProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User context token for OBO flow.",
        SerializedName = @"userContextToken",
        PossibleTypes = new [] { typeof(string) })]
        string UserContextToken { get; set; }

    }
    /// Informatica Serverless Runtime User context properties
    internal partial interface IServerlessRuntimeUserContextPropertiesInternal

    {
        /// <summary>User context token for OBO flow.</summary>
        string UserContextToken { get; set; }

    }
}