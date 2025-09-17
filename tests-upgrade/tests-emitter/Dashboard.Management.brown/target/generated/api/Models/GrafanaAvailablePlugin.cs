// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Available plugins of grafana</summary>
    public partial class GrafanaAvailablePlugin :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePlugin,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePluginInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePluginInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PluginId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePluginInternal.PluginId { get => this._pluginId; set { {_pluginId = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Grafana plugin display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="PluginId" /> property.</summary>
        private string _pluginId;

        /// <summary>Grafana plugin id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PluginId { get => this._pluginId; }

        /// <summary>Creates an new <see cref="GrafanaAvailablePlugin" /> instance.</summary>
        public GrafanaAvailablePlugin()
        {

        }
    }
    /// Available plugins of grafana
    public partial interface IGrafanaAvailablePlugin :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Grafana plugin display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Grafana plugin display name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
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
    /// Available plugins of grafana
    internal partial interface IGrafanaAvailablePluginInternal

    {
        /// <summary>Grafana plugin display name</summary>
        string Name { get; set; }
        /// <summary>Grafana plugin id</summary>
        string PluginId { get; set; }

    }
}