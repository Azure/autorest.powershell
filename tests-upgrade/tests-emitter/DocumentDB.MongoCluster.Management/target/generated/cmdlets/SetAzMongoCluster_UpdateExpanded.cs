// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// update a mongo cluster. update overwrites all properties for the resource. To only modify some of the properties, use
    /// PATCH.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}"
    /// </remarks>
    [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"AzMongoCluster_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Description(@"update a mongo cluster. update overwrites all properties for the resource. To only modify some of the properties, use PATCH.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}", ApiVersion = "2024-07-01")]
    public partial class SetAzMongoCluster_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IContext
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

        /// <summary>A buffer to record first returned object in response.</summary>
        private object _firstResponse = null;

        /// <summary>Represents a mongo cluster resource.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster _resourceBody = new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoCluster();

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>The administrator password.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The administrator password.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator password.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString AdministratorPassword { get => _resourceBody.AdministratorPassword ?? null; set => _resourceBody.AdministratorPassword = value; }

        /// <summary>The administrator user name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The administrator user name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator user name.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        public string AdministratorUserName { get => _resourceBody.AdministratorUserName ?? null; set => _resourceBody.AdministratorUserName = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.MongoClusterManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.ClientAPI;

        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30', 'M40'.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30', 'M40'.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        public string ComputeTier { get => _resourceBody.ComputeTier ?? null; set => _resourceBody.ComputeTier = value; }

        /// <summary>The mode to create a mongo cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The mode to create a mongo cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mode to create a mongo cluster.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Default", "PointInTimeRestore", "GeoReplica", "Replica")]
        public string CreateMode { get => _resourceBody.CreateMode ?? null; set => _resourceBody.CreateMode = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>The target high availability mode requested for the cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The target high availability mode requested for the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target high availability mode requested for the cluster.",
        SerializedName = @"targetMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Disabled", "SameZone", "ZoneRedundantPreferred")]
        public string HighAvailabilityTargetMode { get => _resourceBody.HighAvailabilityTargetMode ?? null; set => _resourceBody.HighAvailabilityTargetMode = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _resourceBody.Location ?? null; set => _resourceBody.Location = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the mongo cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the mongo cluster.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the mongo cluster.",
        SerializedName = @"mongoClusterName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("MongoClusterName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>List of private endpoint connections.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of private endpoint connections.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of private endpoint connections.",
        SerializedName = @"previewFeatures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("GeoReplicas")]
        public string[] PreviewFeature { get => _resourceBody.PreviewFeature?.ToArray() ?? null /* fixedArrayOf */; set => _resourceBody.PreviewFeature = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether or not public endpoint access is allowed for this mongo cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not public endpoint access is allowed for this mongo cluster.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string PublicNetworkAccess { get => _resourceBody.PublicNetworkAccess ?? null; set => _resourceBody.PublicNetworkAccess = value; }

        /// <summary>The location of the source cluster</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The location of the source cluster")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the source cluster",
        SerializedName = @"sourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        public string ReplicaParameterSourceLocation { get => _resourceBody.ReplicaParameterSourceLocation ?? null; set => _resourceBody.ReplicaParameterSourceLocation = value; }

        /// <summary>The id of the replication source cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The id of the replication source cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the replication source cluster.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string ReplicaParameterSourceResourceId { get => _resourceBody.ReplicaParameterSourceResourceId ?? null; set => _resourceBody.ReplicaParameterSourceResourceId = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>UTC point in time to restore a mongo cluster</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC point in time to restore a mongo cluster")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UTC point in time to restore a mongo cluster",
        SerializedName = @"pointInTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime RestoreParameterPointInTimeUtc { get => _resourceBody.RestoreParameterPointInTimeUtc ?? default(global::System.DateTime); set => _resourceBody.RestoreParameterPointInTimeUtc = value; }

        /// <summary>Resource ID to locate the source cluster to restore</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource ID to locate the source cluster to restore")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID to locate the source cluster to restore",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string RestoreParameterSourceResourceId { get => _resourceBody.RestoreParameterSourceResourceId ?? null; set => _resourceBody.RestoreParameterSourceResourceId = value; }

        /// <summary>
        /// The Mongo DB server version. Defaults to the latest available version if not specified.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Mongo DB server version. Defaults to the latest available version if not specified.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Mongo DB server version. Defaults to the latest available version if not specified.",
        SerializedName = @"serverVersion",
        PossibleTypes = new [] { typeof(string) })]
        public string ServerVersion { get => _resourceBody.ServerVersion ?? null; set => _resourceBody.ServerVersion = value; }

        /// <summary>Number of shards to provision on the cluster.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Number of shards to provision on the cluster.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of shards to provision on the cluster.",
        SerializedName = @"shardCount",
        PossibleTypes = new [] { typeof(int) })]
        public int ShardingShardCount { get => _resourceBody.ShardingShardCount ?? default(int); set => _resourceBody.ShardingShardCount = value; }

        /// <summary>The size of the data disk assigned to each server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The size of the data disk assigned to each server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The size of the data disk assigned to each server.",
        SerializedName = @"sizeGb",
        PossibleTypes = new [] { typeof(long) })]
        public long StorageSizeGb { get => _resourceBody.StorageSizeGb ?? default(long); set => _resourceBody.StorageSizeGb = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags Tag { get => _resourceBody.Tag ?? null /* object */; set => _resourceBody.Tag = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster">Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of SetAzMongoCluster_UpdateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Cmdlets.SetAzMongoCluster_UpdateExpanded Clone()
        {
            var clone = new SetAzMongoCluster_UpdateExpanded();
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
            clone._resourceBody = this._resourceBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'MongoClustersCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.MongoClustersCreateOrUpdate(SubscriptionId, ResourceGroupName, Name, _resourceBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Name=Name})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAzMongoCluster_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public SetAzMongoCluster_UpdateExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster">Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster
                var result = (await response);
                if (null != result)
                {
                    if (0 == _responseSize)
                    {
                        _firstResponse = result;
                        _responseSize = 1;
                    }
                    else
                    {
                        if (1 ==_responseSize)
                        {
                            // Flush buffer
                            WriteObject(_firstResponse.AddMultipleTypeNameIntoPSObject());
                        }
                        WriteObject(result.AddMultipleTypeNameIntoPSObject());
                        _responseSize = 2;
                    }
                }
            }
        }
    }
}