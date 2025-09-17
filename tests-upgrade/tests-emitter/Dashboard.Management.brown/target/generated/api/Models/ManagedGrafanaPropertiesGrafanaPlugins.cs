// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// Installed plugin list of the Grafana instance. Key is plugin id, value is plugin definition.
    /// </summary>
    public partial class ManagedGrafanaPropertiesGrafanaPlugins :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPlugins,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPluginsInternal
    {

        /// <summary>Creates an new <see cref="ManagedGrafanaPropertiesGrafanaPlugins" /> instance.</summary>
        public ManagedGrafanaPropertiesGrafanaPlugins()
        {

        }
    }
    /// Installed plugin list of the Grafana instance. Key is plugin id, value is plugin definition.
    public partial interface IManagedGrafanaPropertiesGrafanaPlugins :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaPlugin>
    {

    }
    /// Installed plugin list of the Grafana instance. Key is plugin id, value is plugin definition.
    internal partial interface IManagedGrafanaPropertiesGrafanaPluginsInternal

    {

    }
}