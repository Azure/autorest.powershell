// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    /// </summary>
    public partial class ApplicationHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal
    {

        /// <summary>Backing field for <see cref="ConsiderWarningAsError" /> property.</summary>
        private bool _considerWarningAsError;

        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool ConsiderWarningAsError { get => this._considerWarningAsError; set => this._considerWarningAsError = value; }

        /// <summary>Backing field for <see cref="DefaultServiceTypeHealthPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy _defaultServiceTypeHealthPolicy;

        /// <summary>The health policy used by default to evaluate the health of a service type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy DefaultServiceTypeHealthPolicy { get => (this._defaultServiceTypeHealthPolicy = this._defaultServiceTypeHealthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicy()); set => this._defaultServiceTypeHealthPolicy = value; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal)DefaultServiceTypeHealthPolicy).MaxPercentUnhealthyPartitionsPerService; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal)DefaultServiceTypeHealthPolicy).MaxPercentUnhealthyPartitionsPerService = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal)DefaultServiceTypeHealthPolicy).MaxPercentUnhealthyReplicasPerPartition; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal)DefaultServiceTypeHealthPolicy).MaxPercentUnhealthyReplicasPerPartition = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal)DefaultServiceTypeHealthPolicy).MaxPercentUnhealthyService; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicyInternal)DefaultServiceTypeHealthPolicy).MaxPercentUnhealthyService = value ?? default(int); }

        /// <summary>
        /// Backing field for <see cref="MaxPercentUnhealthyDeployedApplication" /> property.
        /// </summary>
        private int _maxPercentUnhealthyDeployedApplication;

        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPercentUnhealthyDeployedApplication { get => this._maxPercentUnhealthyDeployedApplication; set => this._maxPercentUnhealthyDeployedApplication = value; }

        /// <summary>Internal Acessors for DefaultServiceTypeHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal.DefaultServiceTypeHealthPolicy { get => (this._defaultServiceTypeHealthPolicy = this._defaultServiceTypeHealthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicy()); set { {_defaultServiceTypeHealthPolicy = value;} } }

        /// <summary>Backing field for <see cref="ServiceTypeHealthPolicyMap" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap _serviceTypeHealthPolicyMap;

        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ServiceTypeHealthPolicyMap { get => (this._serviceTypeHealthPolicyMap = this._serviceTypeHealthPolicyMap ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMap()); set => this._serviceTypeHealthPolicyMap = value; }

        /// <summary>Creates an new <see cref="ApplicationHealthPolicy" /> instance.</summary>
        public ApplicationHealthPolicy()
        {

        }
    }
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    public partial interface IApplicationHealthPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether warnings are treated with the same severity as errors.",
        SerializedName = @"considerWarningAsError",
        PossibleTypes = new [] { typeof(bool) })]
        bool ConsiderWarningAsError { get; set; }
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
        Required = false,
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
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
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
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get; set; }
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
        Required = false,
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
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.
        This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.
        The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyDeployedApplications",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPercentUnhealthyDeployedApplication { get; set; }
        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The map with service type health policy per service type name. The map is empty by default.",
        SerializedName = @"serviceTypeHealthPolicyMap",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ServiceTypeHealthPolicyMap { get; set; }

    }
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    internal partial interface IApplicationHealthPolicyInternal

    {
        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        bool ConsiderWarningAsError { get; set; }
        /// <summary>The health policy used by default to evaluate the health of a service type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy DefaultServiceTypeHealthPolicy { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        int MaxPercentUnhealthyDeployedApplication { get; set; }
        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ServiceTypeHealthPolicyMap { get; set; }

    }
}