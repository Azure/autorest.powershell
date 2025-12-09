// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Parameters to detach Vnet.</summary>
    public partial class ServerDetachVNetParameter :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerDetachVNetParameter,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerDetachVNetParameterInternal
    {

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="ServerDetachVNetParameter" /> instance.</summary>
        public ServerDetachVNetParameter()
        {

        }
    }
    /// Parameters to detach Vnet.
    public partial interface IServerDetachVNetParameter :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }

    }
    /// Parameters to detach Vnet.
    internal partial interface IServerDetachVNetParameterInternal

    {
        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }

    }
}