// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Server version capabilities.</summary>
    public partial class ServerVersionCapabilityV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2Internal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2Internal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>server version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="ServerVersionCapabilityV2" /> instance.</summary>
        public ServerVersionCapabilityV2()
        {

        }
    }
    /// Server version capabilities.
    public partial interface IServerVersionCapabilityV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>server version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"server version",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Server version capabilities.
    internal partial interface IServerVersionCapabilityV2Internal

    {
        /// <summary>server version</summary>
        string Name { get; set; }

    }
}