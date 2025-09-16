// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Defines a health policy used to evaluate the health of the cluster or of a cluster node.
    /// </summary>
    public partial class ClusterHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicyInternal
    {

        /// <summary>Backing field for <see cref="MaxPercentUnhealthyApplication" /> property.</summary>
        private int _maxPercentUnhealthyApplication;

        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentUnhealthyApplication { get => this._maxPercentUnhealthyApplication; set => this._maxPercentUnhealthyApplication = value; }

        /// <summary>Backing field for <see cref="MaxPercentUnhealthyNode" /> property.</summary>
        private int _maxPercentUnhealthyNode;

        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentUnhealthyNode { get => this._maxPercentUnhealthyNode; set => this._maxPercentUnhealthyNode = value; }

        /// <summary>Creates an new <see cref="ClusterHealthPolicy" /> instance.</summary>
        public ClusterHealthPolicy()
        {

        }
    }
    /// Defines a health policy used to evaluate the health of the cluster or of a cluster node.
    public partial interface IClusterHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.

        The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.
        If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.

        The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.
        If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.

        In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.",
        SerializedName = @"maxPercentUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentUnhealthyNode { get; set; }

    }
    /// Defines a health policy used to evaluate the health of the cluster or of a cluster node.
    internal partial interface IClusterHealthPolicyInternal

    {
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        int MaxPercentUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        int MaxPercentUnhealthyNode { get; set; }

    }
}