// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    public partial class DashboardIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IDashboardIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IDashboardIdentityInternal
    {

        /// <summary>Backing field for <see cref="DashboardName" /> property.</summary>
        private string _dashboardName;

        /// <summary>The name of the Azure Managed Dashboard.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string DashboardName { get => this._dashboardName; set => this._dashboardName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IntegrationFabricName" /> property.</summary>
        private string _integrationFabricName;

        /// <summary>The integration fabric name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string IntegrationFabricName { get => this._integrationFabricName; set => this._integrationFabricName = value; }

        /// <summary>Backing field for <see cref="ManagedPrivateEndpointName" /> property.</summary>
        private string _managedPrivateEndpointName;

        /// <summary>The managed private endpoint name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string ManagedPrivateEndpointName { get => this._managedPrivateEndpointName; set => this._managedPrivateEndpointName = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnectionName" /> property.</summary>
        private string _privateEndpointConnectionName;

        /// <summary>The private endpoint connection name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PrivateEndpointConnectionName { get => this._privateEndpointConnectionName; set => this._privateEndpointConnectionName = value; }

        /// <summary>Backing field for <see cref="PrivateLinkResourceName" /> property.</summary>
        private string _privateLinkResourceName;

        /// <summary>A sequence of textual characters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PrivateLinkResourceName { get => this._privateLinkResourceName; set => this._privateLinkResourceName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="WorkspaceName" /> property.</summary>
        private string _workspaceName;

        /// <summary>The workspace name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string WorkspaceName { get => this._workspaceName; set => this._workspaceName = value; }

        /// <summary>Creates an new <see cref="DashboardIdentity" /> instance.</summary>
        public DashboardIdentity()
        {

        }
    }
    public partial interface IDashboardIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The name of the Azure Managed Dashboard.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Azure Managed Dashboard.",
        SerializedName = @"dashboardName",
        PossibleTypes = new [] { typeof(string) })]
        string DashboardName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The integration fabric name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The integration fabric name of Azure Managed Grafana.",
        SerializedName = @"integrationFabricName",
        PossibleTypes = new [] { typeof(string) })]
        string IntegrationFabricName { get; set; }
        /// <summary>The managed private endpoint name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The managed private endpoint name of Azure Managed Grafana.",
        SerializedName = @"managedPrivateEndpointName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedPrivateEndpointName { get; set; }
        /// <summary>The private endpoint connection name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private endpoint connection name of Azure Managed Grafana.",
        SerializedName = @"privateEndpointConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>A sequence of textual characters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A sequence of textual characters.",
        SerializedName = @"privateLinkResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The workspace name of Azure Managed Grafana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The workspace name of Azure Managed Grafana.",
        SerializedName = @"workspaceName",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceName { get; set; }

    }
    internal partial interface IDashboardIdentityInternal

    {
        /// <summary>The name of the Azure Managed Dashboard.</summary>
        string DashboardName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The integration fabric name of Azure Managed Grafana.</summary>
        string IntegrationFabricName { get; set; }
        /// <summary>The managed private endpoint name of Azure Managed Grafana.</summary>
        string ManagedPrivateEndpointName { get; set; }
        /// <summary>The private endpoint connection name of Azure Managed Grafana.</summary>
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>A sequence of textual characters.</summary>
        string PrivateLinkResourceName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The workspace name of Azure Managed Grafana.</summary>
        string WorkspaceName { get; set; }

    }
}