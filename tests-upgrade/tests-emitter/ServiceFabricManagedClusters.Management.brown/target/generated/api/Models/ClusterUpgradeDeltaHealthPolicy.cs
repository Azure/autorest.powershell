// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the delta health policies for the cluster upgrade.</summary>
    public partial class ClusterUpgradeDeltaHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal
    {

        /// <summary>Backing field for <see cref="MaxPercentDeltaUnhealthyApplication" /> property.</summary>
        private int? _maxPercentDeltaUnhealthyApplication;

        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? MaxPercentDeltaUnhealthyApplication { get => this._maxPercentDeltaUnhealthyApplication; set => this._maxPercentDeltaUnhealthyApplication = value; }

        /// <summary>Backing field for <see cref="MaxPercentDeltaUnhealthyNode" /> property.</summary>
        private int _maxPercentDeltaUnhealthyNode;

        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentDeltaUnhealthyNode { get => this._maxPercentDeltaUnhealthyNode; set => this._maxPercentDeltaUnhealthyNode = value; }

        /// <summary>
        /// Backing field for <see cref="MaxPercentUpgradeDomainDeltaUnhealthyNode" /> property.
        /// </summary>
        private int? _maxPercentUpgradeDomainDeltaUnhealthyNode;

        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? MaxPercentUpgradeDomainDeltaUnhealthyNode { get => this._maxPercentUpgradeDomainDeltaUnhealthyNode; set => this._maxPercentUpgradeDomainDeltaUnhealthyNode = value; }

        /// <summary>Creates an new <see cref="ClusterUpgradeDeltaHealthPolicy" /> instance.</summary>
        public ClusterUpgradeDeltaHealthPolicy()
        {

        }
    }
    /// Describes the delta health policies for the cluster upgrade.
    public partial interface IClusterUpgradeDeltaHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.
        NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications",
        SerializedName = @"maxPercentDeltaUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxPercentDeltaUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.",
        SerializedName = @"maxPercentDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.",
        SerializedName = @"maxPercentUpgradeDomainDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxPercentUpgradeDomainDeltaUnhealthyNode { get; set; }

    }
    /// Describes the delta health policies for the cluster upgrade.
    internal partial interface IClusterUpgradeDeltaHealthPolicyInternal

    {
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        int? MaxPercentDeltaUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        int MaxPercentDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        int? MaxPercentUpgradeDomainDeltaUnhealthyNode { get; set; }

    }
}