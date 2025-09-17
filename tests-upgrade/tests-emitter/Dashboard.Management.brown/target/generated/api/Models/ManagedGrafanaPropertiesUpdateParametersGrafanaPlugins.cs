// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given
    /// plugin id will be removed. Otherwise, given plugin will be installed.
    /// </summary>
    public partial class ManagedGrafanaPropertiesUpdateParametersGrafanaPlugins :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPluginsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ManagedGrafanaPropertiesUpdateParametersGrafanaPlugins" /> instance.
        /// </summary>
        public ManagedGrafanaPropertiesUpdateParametersGrafanaPlugins()
        {

        }
    }
    /// Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given
    /// plugin id will be removed. Otherwise, given plugin will be installed.
    public partial interface IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaPlugin>
    {

    }
    /// Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given
    /// plugin id will be removed. Otherwise, given plugin will be installed.
    internal partial interface IManagedGrafanaPropertiesUpdateParametersGrafanaPluginsInternal

    {

    }
}