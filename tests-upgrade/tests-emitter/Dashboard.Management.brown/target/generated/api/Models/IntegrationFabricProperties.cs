// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    public partial class IntegrationFabricProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DataSourceResourceId" /> property.</summary>
        private string _dataSourceResourceId;

        /// <summary>
        /// The resource Id of the Azure resource which is used to configure Grafana data source. E.g., an Azure Monitor Workspace,
        /// an Azure Data Explorer cluster, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string DataSourceResourceId { get => this._dataSourceResourceId; set => this._dataSourceResourceId = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Scenario" /> property.</summary>
        private System.Collections.Generic.List<string> _scenario;

        /// <summary>A list of integration scenarios covered by this integration fabric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Scenario { get => this._scenario; set => this._scenario = value; }

        /// <summary>Backing field for <see cref="TargetResourceId" /> property.</summary>
        private string _targetResourceId;

        /// <summary>
        /// The resource Id of the Azure resource being integrated with Azure Managed Grafana. E.g., an Azure Kubernetes Service cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string TargetResourceId { get => this._targetResourceId; set => this._targetResourceId = value; }

        /// <summary>Creates an new <see cref="IntegrationFabricProperties" /> instance.</summary>
        public IntegrationFabricProperties()
        {

        }
    }
    public partial interface IIntegrationFabricProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The resource Id of the Azure resource which is used to configure Grafana data source. E.g., an Azure Monitor Workspace,
        /// an Azure Data Explorer cluster, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource Id of the Azure resource which is used to configure Grafana data source. E.g., an Azure Monitor Workspace, an Azure Data Explorer cluster, etc.",
        SerializedName = @"dataSourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceResourceId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get;  }
        /// <summary>A list of integration scenarios covered by this integration fabric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of integration scenarios covered by this integration fabric",
        SerializedName = @"scenarios",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Scenario { get; set; }
        /// <summary>
        /// The resource Id of the Azure resource being integrated with Azure Managed Grafana. E.g., an Azure Kubernetes Service cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource Id of the Azure resource being integrated with Azure Managed Grafana. E.g., an Azure Kubernetes Service cluster.",
        SerializedName = @"targetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceId { get; set; }

    }
    internal partial interface IIntegrationFabricPropertiesInternal

    {
        /// <summary>
        /// The resource Id of the Azure resource which is used to configure Grafana data source. E.g., an Azure Monitor Workspace,
        /// an Azure Data Explorer cluster, etc.
        /// </summary>
        string DataSourceResourceId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }
        /// <summary>A list of integration scenarios covered by this integration fabric</summary>
        System.Collections.Generic.List<string> Scenario { get; set; }
        /// <summary>
        /// The resource Id of the Azure resource being integrated with Azure Managed Grafana. E.g., an Azure Kubernetes Service cluster.
        /// </summary>
        string TargetResourceId { get; set; }

    }
}