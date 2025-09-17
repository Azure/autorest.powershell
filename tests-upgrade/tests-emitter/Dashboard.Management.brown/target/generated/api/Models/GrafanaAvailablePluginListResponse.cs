// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    public partial class GrafanaAvailablePluginListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePluginListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePluginListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePlugin> _value;

        /// <summary>Array of GrafanaAvailablePlugin</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePlugin> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="GrafanaAvailablePluginListResponse" /> instance.</summary>
        public GrafanaAvailablePluginListResponse()
        {

        }
    }
    public partial interface IGrafanaAvailablePluginListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of GrafanaAvailablePlugin</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of GrafanaAvailablePlugin",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePlugin) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePlugin> Value { get; set; }

    }
    internal partial interface IGrafanaAvailablePluginListResponseInternal

    {
        string NextLink { get; set; }
        /// <summary>Array of GrafanaAvailablePlugin</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaAvailablePlugin> Value { get; set; }

    }
}