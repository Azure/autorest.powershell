// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Server Gtid set parameters: Replication with Global Transaction Identifiers.</summary>
    public partial class ServerGtidSetParameter :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerGtidSetParameter,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerGtidSetParameterInternal
    {

        /// <summary>Backing field for <see cref="GtidSet" /> property.</summary>
        private string _gtidSet;

        /// <summary>The Gtid set of server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string GtidSet { get => this._gtidSet; set => this._gtidSet = value; }

        /// <summary>Creates an new <see cref="ServerGtidSetParameter" /> instance.</summary>
        public ServerGtidSetParameter()
        {

        }
    }
    /// Server Gtid set parameters: Replication with Global Transaction Identifiers.
    public partial interface IServerGtidSetParameter :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The Gtid set of server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Gtid set of server.",
        SerializedName = @"gtidSet",
        PossibleTypes = new [] { typeof(string) })]
        string GtidSet { get; set; }

    }
    /// Server Gtid set parameters: Replication with Global Transaction Identifiers.
    internal partial interface IServerGtidSetParameterInternal

    {
        /// <summary>The Gtid set of server.</summary>
        string GtidSet { get; set; }

    }
}