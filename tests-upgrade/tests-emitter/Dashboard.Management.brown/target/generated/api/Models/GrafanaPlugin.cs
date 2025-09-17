// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Plugin of Grafana</summary>
    public partial class GrafanaPlugin :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaPlugin,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaPluginInternal
    {

        /// <summary>Internal Acessors for PluginId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaPluginInternal.PluginId { get => this._pluginId; set { {_pluginId = value;} } }

        /// <summary>Backing field for <see cref="PluginId" /> property.</summary>
        private string _pluginId;

        /// <summary>Grafana plugin id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PluginId { get => this._pluginId; }

        /// <summary>Creates an new <see cref="GrafanaPlugin" /> instance.</summary>
        public GrafanaPlugin()
        {

        }
    }
    /// Plugin of Grafana
    public partial interface IGrafanaPlugin :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Grafana plugin id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Grafana plugin id",
        SerializedName = @"pluginId",
        PossibleTypes = new [] { typeof(string) })]
        string PluginId { get;  }

    }
    /// Plugin of Grafana
    internal partial interface IGrafanaPluginInternal

    {
        /// <summary>Grafana plugin id</summary>
        string PluginId { get; set; }

    }
}