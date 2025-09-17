// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Represents the health policy used to evaluate the health of services belonging to a service type.
    /// </summary>
    public partial class ServiceTypeHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal
    {

        /// <summary>
        /// Backing field for <see cref="MaxPercentUnhealthyPartitionsPerService" /> property.
        /// </summary>
        private int _maxPercentUnhealthyPartitionsPerService;

        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentUnhealthyPartitionsPerService { get => this._maxPercentUnhealthyPartitionsPerService; set => this._maxPercentUnhealthyPartitionsPerService = value; }

        /// <summary>
        /// Backing field for <see cref="MaxPercentUnhealthyReplicasPerPartition" /> property.
        /// </summary>
        private int _maxPercentUnhealthyReplicasPerPartition;

        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentUnhealthyReplicasPerPartition { get => this._maxPercentUnhealthyReplicasPerPartition; set => this._maxPercentUnhealthyReplicasPerPartition = value; }

        /// <summary>Backing field for <see cref="MaxPercentUnhealthyService" /> property.</summary>
        private int _maxPercentUnhealthyService;

        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentUnhealthyService { get => this._maxPercentUnhealthyService; set => this._maxPercentUnhealthyService = value; }

        /// <summary>Creates an new <see cref="ServiceTypeHealthPolicy" /> instance.</summary>
        public ServiceTypeHealthPolicy()
        {

        }
    }
    /// Represents the health policy used to evaluate the health of services belonging to a service type.
    public partial interface IServiceTypeHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy partitions per service.

        The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered in error.
        If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the service.
        The computation rounds up to tolerate one failure on small numbers of partitions.",
        SerializedName = @"maxPercentUnhealthyPartitionsPerService",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy replicas per partition.

        The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered in error.
        If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        The computation rounds up to tolerate one failure on small numbers of replicas.",
        SerializedName = @"maxPercentUnhealthyReplicasPerPartition",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentUnhealthyReplicasPerPartition { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy services.

        The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is considered in error.
        If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        This is calculated by dividing the number of unhealthy services of the specific service type over the total number of services of the specific service type.
        The computation rounds up to tolerate one failure on small numbers of services.",
        SerializedName = @"maxPercentUnhealthyServices",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentUnhealthyService { get; set; }

    }
    /// Represents the health policy used to evaluate the health of services belonging to a service type.
    internal partial interface IServiceTypeHealthPolicyInternal

    {
        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        int MaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        int MaxPercentUnhealthyReplicasPerPartition { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        int MaxPercentUnhealthyService { get; set; }

    }
}