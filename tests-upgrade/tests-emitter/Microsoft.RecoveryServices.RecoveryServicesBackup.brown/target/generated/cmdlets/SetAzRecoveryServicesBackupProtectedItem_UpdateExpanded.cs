// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// Enables backup of an item or to modifies the backup policy information of an already backed up item. This is an\nasynchronous
    /// operation. To know the status of the operation, call the GetItemOperationResult API.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"AzRecoveryServicesBackupProtectedItem_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Description(@"Enables backup of an item or to modifies the backup policy information of an already backed up item. This is an\nasynchronous operation. To know the status of the operation, call the GetItemOperationResult API.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}", ApiVersion = "2025-08-01")]
    public partial class SetAzRecoveryServicesBackupProtectedItem_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IContext
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

        /// <summary>Base class for backup items.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource _parametersBody = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ProtectedItemResource();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Name of the backup set the backup item belongs to</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the backup set the backup item belongs to")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the backup set the backup item belongs to",
        SerializedName = @"backupSetName",
        PossibleTypes = new [] { typeof(string) })]
        public string BackupSetName { get => _parametersBody.BackupSetName ?? null; set => _parametersBody.BackupSetName = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.RecoveryServicesBackupClient Client => Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="ContainerName" /> property.</summary>
        private string _containerName;

        /// <summary>Name of the container whose details need to be fetched.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the container whose details need to be fetched.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the container whose details need to be fetched.",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Path)]
        public string ContainerName { get => this._containerName; set => this._containerName = value; }

        /// <summary>
        /// Create mode to indicate recovery of existing soft deleted data source or creation of new data source.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Create mode to indicate recovery of existing soft deleted data source or creation of new data source.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Create mode to indicate recovery of existing soft deleted data source or creation of new data source.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Default", "Recover")]
        public string CreateMode { get => _parametersBody.CreateMode ?? null; set => _parametersBody.CreateMode = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Time for deferred deletion in UTC</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Time for deferred deletion in UTC")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time for deferred deletion in UTC",
        SerializedName = @"deferredDeleteTimeInUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime DeferredDeleteTimeInUtc { get => _parametersBody.DeferredDeleteTimeInUtc ?? default(global::System.DateTime); set => _parametersBody.DeferredDeleteTimeInUtc = value; }

        /// <summary>Time remaining before the DS marked for deferred delete is permanently deleted</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Time remaining before the DS marked for deferred delete is permanently deleted")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time remaining before the DS marked for deferred delete is permanently deleted",
        SerializedName = @"deferredDeleteTimeRemaining",
        PossibleTypes = new [] { typeof(string) })]
        public string DeferredDeleteTimeRemaining { get => _parametersBody.DeferredDeleteTimeRemaining ?? null; set => _parametersBody.DeferredDeleteTimeRemaining = value; }

        /// <summary>Optional ETag.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Optional ETag.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional ETag.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        public string ETag { get => _parametersBody.ETag ?? null; set => _parametersBody.ETag = value; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>Backing field for <see cref="FabricName" /> property.</summary>
        private string _fabricName;

        /// <summary>The name of the BackupFabricResource</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the BackupFabricResource")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the BackupFabricResource",
        SerializedName = @"fabricName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Path)]
        public string FabricName { get => this._fabricName; set => this._fabricName = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Flag to identify whether datasource is protected in archive</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to identify whether datasource is protected in archive")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to identify whether datasource is protected in archive",
        SerializedName = @"isArchiveEnabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsArchiveEnabled { get => _parametersBody.IsArchiveEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsArchiveEnabled = value; }

        /// <summary>Flag to identify whether the deferred deleted DS is to be purged soon</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to identify whether the deferred deleted DS is to be purged soon")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to identify whether the deferred deleted DS is to be purged soon",
        SerializedName = @"isDeferredDeleteScheduleUpcoming",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsDeferredDeleteScheduleUpcoming { get => _parametersBody.IsDeferredDeleteScheduleUpcoming ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsDeferredDeleteScheduleUpcoming = value; }

        /// <summary>Flag to identify that deferred deleted DS is to be moved into Pause state</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to identify that deferred deleted DS is to be moved into Pause state")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to identify that deferred deleted DS is to be moved into Pause state",
        SerializedName = @"isRehydrate",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsRehydrate { get => _parametersBody.IsRehydrate ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsRehydrate = value; }

        /// <summary>Flag to identify whether the DS is scheduled for deferred delete</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Flag to identify whether the DS is scheduled for deferred delete")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to identify whether the DS is scheduled for deferred delete",
        SerializedName = @"isScheduledForDeferredDelete",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IsScheduledForDeferredDelete { get => _parametersBody.IsScheduledForDeferredDelete ?? default(global::System.Management.Automation.SwitchParameter); set => _parametersBody.IsScheduledForDeferredDelete = value; }

        /// <summary>Timestamp when the last (latest) backup copy was created for this backup item.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Timestamp when the last (latest) backup copy was created for this backup item.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when the last (latest) backup copy was created for this backup item.",
        SerializedName = @"lastRecoveryPoint",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime LastRecoveryPoint { get => _parametersBody.LastRecoveryPoint ?? default(global::System.DateTime); set => _parametersBody.LastRecoveryPoint = value; }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _parametersBody.Location ?? null; set => _parametersBody.Location = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Backed up item name whose details are to be fetched.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Backed up item name whose details are to be fetched.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Backed up item name whose details are to be fetched.",
        SerializedName = @"protectedItemName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("ProtectedItemName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>ID of the backup policy with which this item is backed up.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "ID of the backup policy with which this item is backed up.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the backup policy with which this item is backed up.",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        public string PolicyId { get => _parametersBody.PolicyId ?? null; set => _parametersBody.PolicyId = value; }

        /// <summary>Name of the policy used for protection</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the policy used for protection")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the policy used for protection",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        public string PolicyName { get => _parametersBody.PolicyName ?? null; set => _parametersBody.PolicyName = value; }

        /// <summary>Unique name of container</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Unique name of container")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique name of container",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        public string PropertiesContainerName { get => _parametersBody.ContainerName ?? null; set => _parametersBody.ContainerName = value; }

        /// <summary>backup item type.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "backup item type.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"backup item type.",
        SerializedName = @"protectedItemType",
        PossibleTypes = new [] { typeof(string) })]
        public string ProtectedItemType { get => _parametersBody.ProtectedItemType ?? null; set => _parametersBody.ProtectedItemType = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "ResourceGuardOperationRequests on which LAC check will be performed")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        public string[] ResourceGuardOperationRequest { get => _parametersBody.ResourceGuardOperationRequest?.ToArray() ?? null /* fixedArrayOf */; set => _parametersBody.ResourceGuardOperationRequest = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>Soft delete retention period in days</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Soft delete retention period in days")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Soft delete retention period in days",
        SerializedName = @"softDeleteRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        public int SoftDeleteRetentionPeriodInDay { get => _parametersBody.SoftDeleteRetentionPeriodInDay ?? default(int); set => _parametersBody.SoftDeleteRetentionPeriodInDay = value; }

        /// <summary>ARM ID of the resource to be backed up.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "ARM ID of the resource to be backed up.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM ID of the resource to be backed up.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string SourceResourceId { get => _parametersBody.SourceResourceId ?? null; set => _parametersBody.SourceResourceId = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResourceTags Tag { get => _parametersBody.Tag ?? null /* object */; set => _parametersBody.Tag = value; }

        /// <summary>Backing field for <see cref="VaultName" /> property.</summary>
        private string _vaultName;

        /// <summary>The name of the VaultResource</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the VaultResource")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the VaultResource",
        SerializedName = @"vaultName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Path)]
        public string VaultName { get => this._vaultName; set => this._vaultName = value; }

        /// <summary>Backing field for <see cref="XmsAuthorizationAuxiliary" /> property.</summary>
        private string _xmsAuthorizationAuxiliary;

        /// <summary>A sequence of textual characters.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A sequence of textual characters.")]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A sequence of textual characters.",
        SerializedName = @"x-ms-authorization-auxiliary",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Category(global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.ParameterCategory.Header)]
        public string XmsAuthorizationAuxiliary { get => this._xmsAuthorizationAuxiliary; set => this._xmsAuthorizationAuxiliary = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of SetAzRecoveryServicesBackupProtectedItem_UpdateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Cmdlets.SetAzRecoveryServicesBackupProtectedItem_UpdateExpanded Clone()
        {
            var clone = new SetAzRecoveryServicesBackupProtectedItem_UpdateExpanded();
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
            clone.VaultName = this.VaultName;
            clone.FabricName = this.FabricName;
            clone.ContainerName = this.ContainerName;
            clone.Name = this.Name;
            clone.XmsAuthorizationAuxiliary = this.XmsAuthorizationAuxiliary;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ProtectedItemsCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ProtectedItemsCreateOrUpdate(SubscriptionId, ResourceGroupName, VaultName, FabricName, ContainerName, Name, this.InvocationInformation.BoundParameters.ContainsKey("XmsAuthorizationAuxiliary") ? XmsAuthorizationAuxiliary : null, _parametersBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,VaultName=VaultName,FabricName=FabricName,ContainerName=ContainerName,Name=Name,XmsAuthorizationAuxiliary=this.InvocationInformation.BoundParameters.ContainsKey("XmsAuthorizationAuxiliary") ? XmsAuthorizationAuxiliary : null})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAzRecoveryServicesBackupProtectedItem_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public SetAzRecoveryServicesBackupProtectedItem_UpdateExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource">Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemResource
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}