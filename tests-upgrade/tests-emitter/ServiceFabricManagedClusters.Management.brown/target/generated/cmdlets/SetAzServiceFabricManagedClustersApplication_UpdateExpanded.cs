// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Cmdlets;
    using System;

    /// <summary>update a Service Fabric managed application resource with the specified name.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/applications/{applicationName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"AzServiceFabricManagedClustersApplication_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Description(@"update a Service Fabric managed application resource with the specified name.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/applications/{applicationName}", ApiVersion = "2025-06-01-preview")]
    public partial class SetAzServiceFabricManagedClustersApplication_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IContext
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>A dictionary to carry over additional data for pipeline.</summary>
        private global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object> _extensibleParameters = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>The application resource.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource _parametersBody = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResource();

        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether warnings are treated with the same severity as errors.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether warnings are treated with the same severity as errors.",
        SerializedName = @"considerWarningAsError",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ApplicationHealthPolicyConsiderWarningAsError { get => _parametersBody.ApplicationHealthPolicyConsiderWarningAsError ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.ApplicationHealthPolicyConsiderWarningAsError = value; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.The
        /// percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.This is calculated by dividing the number of unhealthy deployed applications over the number of
        /// nodes where the application is currently deployed on in the cluster.The computation rounds up to tolerate one failure
        /// on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyDeployedApplications",
        PossibleTypes = new [] { typeof(int) })]
        public int ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication { get => _parametersBody.ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication ?? default(int); set => _parametersBody.ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = value; }

        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The map with service type health policy per service type name. The map is empty by default.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The map with service type health policy per service type name. The map is empty by default.",
        SerializedName = @"serviceTypeHealthPolicyMap",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ApplicationHealthPolicyServiceTypeHealthPolicyMap { get => _parametersBody.ApplicationHealthPolicyServiceTypeHealthPolicyMap ?? null /* object */; set => _parametersBody.ApplicationHealthPolicyServiceTypeHealthPolicyMap = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ServiceFabricManagedClustersManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>The name of the cluster resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the cluster resource.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the cluster resource.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.The percentage represents the maximum tolerated percentage
        /// of partitions that can be unhealthy before the service is considered in error.If the percentage is respected but there
        /// is at least one unhealthy partition, the health is evaluated as Warning.The percentage is calculated by dividing the number
        /// of unhealthy partitions over the total number of partitions in the service.The computation rounds up to tolerate one failure
        /// on small numbers of partitions.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of unhealthy partitions per service.The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered in error.If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the service.The computation rounds up to tolerate one failure on small numbers of partitions.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of unhealthy partitions per service.The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered in error.If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the service.The computation rounds up to tolerate one failure on small numbers of partitions.",
        SerializedName = @"maxPercentUnhealthyPartitionsPerService",
        PossibleTypes = new [] { typeof(int) })]
        public int DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get => _parametersBody.DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService ?? default(int); set => _parametersBody.DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = value; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.The percentage represents the maximum tolerated percentage
        /// of replicas that can be unhealthy before the partition is considered in error.If the percentage is respected but there
        /// is at least one unhealthy replica, the health is evaluated as Warning.The percentage is calculated by dividing the number
        /// of unhealthy replicas over the total number of replicas in the partition.The computation rounds up to tolerate one failure
        /// on small numbers of replicas.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of unhealthy replicas per partition.The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered in error.If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.The computation rounds up to tolerate one failure on small numbers of replicas.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of unhealthy replicas per partition.The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered in error.If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.The computation rounds up to tolerate one failure on small numbers of replicas.",
        SerializedName = @"maxPercentUnhealthyReplicasPerPartition",
        PossibleTypes = new [] { typeof(int) })]
        public int DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get => _parametersBody.DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition ?? default(int); set => _parametersBody.DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = value; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy services.The percentage represents the maximum tolerated percentage of services
        /// that can be unhealthy before the application is considered in error.If the percentage is respected but there is at least
        /// one unhealthy service, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy services
        /// of the specific service type over the total number of services of the specific service type.The computation rounds up
        /// to tolerate one failure on small numbers of services.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum allowed percentage of unhealthy services.The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is considered in error.If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy services of the specific service type over the total number of services of the specific service type.The computation rounds up to tolerate one failure on small numbers of services.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed percentage of unhealthy services.The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is considered in error.If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.This is calculated by dividing the number of unhealthy services of the specific service type over the total number of services of the specific service type.The computation rounds up to tolerate one failure on small numbers of services.",
        SerializedName = @"maxPercentUnhealthyServices",
        PossibleTypes = new [] { typeof(int) })]
        public int DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get => _parametersBody.DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService ?? default(int); set => _parametersBody.DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = value; }

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public System.Boolean? EnableSystemAssignedIdentity { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _parametersBody.Location ?? null; set => _parametersBody.Location = value; }

        /// <summary>
        /// List of user assigned identities for the application, each mapped to a friendly name.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of user assigned identities for the application, each mapped to a friendly name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of user assigned identities for the application, each mapped to a friendly name.",
        SerializedName = @"managedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity[] ManagedIdentity { get => _parametersBody.ManagedIdentity?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.ManagedIdentity = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>(value) : null); }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the application resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the application resource.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the application resource.",
        SerializedName = @"applicationName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("ApplicationName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// List of application parameters with overridden values from their default values specified in the application manifest.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of application parameters with overridden values from their default values specified in the application manifest.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of application parameters with overridden values from their default values specified in the application manifest.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters Parameter { get => _parametersBody.Parameter ?? null /* object */; set => _parametersBody.Parameter = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.",
        SerializedName = @"failureAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Rollback", "Manual")]
        public string RollingUpgradeMonitoringPolicyFailureAction { get => _parametersBody.RollingUpgradeMonitoringPolicyFailureAction ?? null; set => _parametersBody.RollingUpgradeMonitoringPolicyFailureAction = value; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format \"hh:mm:ss.fff\".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout { get => _parametersBody.RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout ?? null; set => _parametersBody.RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = value; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format \"hh:mm:ss.fff\".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        public string RollingUpgradeMonitoringPolicyHealthCheckStableDuration { get => _parametersBody.RollingUpgradeMonitoringPolicyHealthCheckStableDuration ?? null; set => _parametersBody.RollingUpgradeMonitoringPolicyHealthCheckStableDuration = value; }

        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format \"hh:mm:ss.fff\".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        public string RollingUpgradeMonitoringPolicyHealthCheckWaitDuration { get => _parametersBody.RollingUpgradeMonitoringPolicyHealthCheckWaitDuration ?? null; set => _parametersBody.RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = value; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format \"hh:mm:ss.fff\".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string RollingUpgradeMonitoringPolicyUpgradeDomainTimeout { get => _parametersBody.RollingUpgradeMonitoringPolicyUpgradeDomainTimeout ?? null; set => _parametersBody.RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = value; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format \"hh:mm:ss.fff\".")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        public string RollingUpgradeMonitoringPolicyUpgradeTimeout { get => _parametersBody.RollingUpgradeMonitoringPolicyUpgradeTimeout ?? null; set => _parametersBody.RollingUpgradeMonitoringPolicyUpgradeTimeout = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceTags Tag { get => _parametersBody.Tag ?? null /* object */; set => _parametersBody.Tag = value; }

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).",
        SerializedName = @"forceRestart",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UpgradePolicyForceRestart { get => _parametersBody.UpgradePolicyForceRestart ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UpgradePolicyForceRestart = value; }

        /// <summary>
        /// Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully.
        /// This would be effective when the instance is closing during the application/cluster upgrade, only for those instances
        /// which have a non-zero delay duration configured in the service description.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully. This would be effective when the instance is closing during the application/cluster upgrade, only for those instances which have a non-zero delay duration configured in the service description.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully. This would be effective when the instance is closing during the application/cluster upgrade, only for those instances which have a non-zero delay duration configured in the service description.",
        SerializedName = @"instanceCloseDelayDuration",
        PossibleTypes = new [] { typeof(long) })]
        public long UpgradePolicyInstanceCloseDelayDuration { get => _parametersBody.UpgradePolicyInstanceCloseDelayDuration ?? default(long); set => _parametersBody.UpgradePolicyInstanceCloseDelayDuration = value; }

        /// <summary>
        /// Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters
        /// are not allowed.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed.",
        SerializedName = @"recreateApplication",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UpgradePolicyRecreateApplication { get => _parametersBody.UpgradePolicyRecreateApplication ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.UpgradePolicyRecreateApplication = value; }

        /// <summary>
        /// The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.",
        SerializedName = @"upgradeMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Monitored", "UnmonitoredAuto")]
        public string UpgradePolicyUpgradeMode { get => _parametersBody.UpgradePolicyUpgradeMode ?? null; set => _parametersBody.UpgradePolicyUpgradeMode = value; }

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned
        /// 32-bit integer). Unit is in seconds.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). Unit is in seconds.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). Unit is in seconds.",
        SerializedName = @"upgradeReplicaSetCheckTimeout",
        PossibleTypes = new [] { typeof(long) })]
        public long UpgradePolicyUpgradeReplicaSetCheckTimeout { get => _parametersBody.UpgradePolicyUpgradeReplicaSetCheckTimeout ?? default(long); set => _parametersBody.UpgradePolicyUpgradeReplicaSetCheckTimeout = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>
        /// The version of the application type as defined in the application manifest.This name must be the full Arm Resource ID
        /// for the referenced application type version.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The version of the application type as defined in the application manifest.This name must be the full Arm Resource ID for the referenced application type version.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the application type as defined in the application manifest.This name must be the full Arm Resource ID for the referenced application type version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        public string Version { get => _parametersBody.Version ?? null; set => _parametersBody.Version = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>
        /// a duplicate instance of SetAzServiceFabricManagedClustersApplication_UpdateExpanded
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Cmdlets.SetAzServiceFabricManagedClustersApplication_UpdateExpanded Clone()
        {
            var clone = new SetAzServiceFabricManagedClustersApplication_UpdateExpanded();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone._parametersBody = this._parametersBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.ClusterName = this.ClusterName;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
            if (telemetryInfo != null)
            {
                telemetryInfo.TryGetValue("ShowSecretsWarning", out var showSecretsWarning);
                telemetryInfo.TryGetValue("SanitizedProperties", out var sanitizedProperties);
                telemetryInfo.TryGetValue("InvocationName", out var invocationName);
                if (showSecretsWarning == "true")
                {
                    if (string.IsNullOrEmpty(sanitizedProperties))
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing secrets. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                    else
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing the following secrets: {sanitizedProperties}. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                }
            }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.Progress:
                    {
                        var data = messageData();
                        int progress = (int)data.Value;
                        string activityMessage, statusDescription;
                        global::System.Management.Automation.ProgressRecordType recordType;
                        if (progress < 100)
                        {
                            activityMessage = "In progress";
                            statusDescription = "Checking operation status";
                            recordType = System.Management.Automation.ProgressRecordType.Processing;
                        }
                        else
                        {
                            activityMessage = "Completed";
                            statusDescription = "Completed";
                            recordType = System.Management.Automation.ProgressRecordType.Completed;
                        }
                        WriteProgress(new global::System.Management.Automation.ProgressRecord(1, activityMessage, statusDescription)
                        {
                            PercentComplete = progress,
                        RecordType = recordType
                        });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        else
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                int delay = (int)(response.Headers.RetryAfter?.Delta?.TotalSeconds ?? 30);
                                WriteDebug($"Delaying {delay} seconds before polling.");
                                for (var now = 0; now < delay; ++now)
                                {
                                    WriteProgress(new global::System.Management.Automation.ProgressRecord(1, "In progress", "Checking operation status")
                                    {
                                        PercentComplete = now * 100 / delay
                                    });
                                    await global::System.Threading.Tasks.Task.Delay(1000, token);
                                }
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        private void PreProcessManagedIdentityParameters()
        {
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _parametersBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _parametersBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.UserAssignedIdentity());
                }
            }
            // calculate IdentityType
            if (this.UserAssignedIdentity?.Length > 0)
            {
                if ("SystemAssigned".Equals(_parametersBody.IdentityType, StringComparison.InvariantCultureIgnoreCase))
                {
                    _parametersBody.IdentityType = "SystemAssigned,UserAssigned";
                }
                else
                {
                    _parametersBody.IdentityType = "UserAssigned";
                }
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ApplicationsCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    this.PreProcessManagedIdentityParameters();
                    await this.Client.ApplicationsCreateOrUpdate(SubscriptionId, ResourceGroupName, ClusterName, Name, _parametersBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,ClusterName=ClusterName,Name=Name})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAzServiceFabricManagedClustersApplication_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public SetAzServiceFabricManagedClustersApplication_UpdateExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource">Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}