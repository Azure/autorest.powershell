// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Cmdlets;
    using System;

    /// <summary>update a StorageClassResource</summary>
    /// <remarks>
    /// [OpenAPI] Update=>PATCH:"/{resourceUri}/providers/Microsoft.KubernetesRuntime/storageClasses/{storageClassName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzContainerOrchestratorRuntimeStorageClass_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Description(@"update a StorageClassResource")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.HttpPath(Path = "/{resourceUri}/providers/Microsoft.KubernetesRuntime/storageClasses/{storageClassName}", ApiVersion = "2024-03-01")]
    public partial class UpdateAzContainerOrchestratorRuntimeStorageClass_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IContext
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

        /// <summary>The model for updating a storageClass</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResourceUpdate _propertiesBody = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassResourceUpdate();

        /// <summary>The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]",
        SerializedName = @"accessModes",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("ReadWriteOnce", "ReadWriteMany")]
        public string[] AccessMode { get => _propertiesBody.AccessMode?.ToArray() ?? null /* fixedArrayOf */; set => _propertiesBody.AccessMode = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>Volume can be expanded or not</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Volume can be expanded or not")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Volume can be expanded or not",
        SerializedName = @"allowVolumeExpansion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Allow", "Disallow")]
        public string AllowVolumeExpansion { get => _propertiesBody.AllowVolumeExpansion ?? null; set => _propertiesBody.AllowVolumeExpansion = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.MicrosoftKubernetesRuntime Client => Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.ClientAPI;

        /// <summary>Allow single data node failure</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Allow single data node failure")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allow single data node failure",
        SerializedName = @"dataResilience",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("NotDataResilient", "DataResilient")]
        public string DataResilience { get => _propertiesBody.DataResilience ?? null; set => _propertiesBody.DataResilience = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>Failover speed: NA, Slow, Fast</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Failover speed: NA, Slow, Fast")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Failover speed: NA, Slow, Fast",
        SerializedName = @"failoverSpeed",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("NotAvailable", "Slow", "Fast", "Super")]
        public string FailoverSpeed { get => _propertiesBody.FailoverSpeed ?? null; set => _propertiesBody.FailoverSpeed = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Limitations of the storage class</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Limitations of the storage class")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Limitations of the storage class",
        SerializedName = @"limitations",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Limitation { get => _propertiesBody.Limitation?.ToArray() ?? null /* fixedArrayOf */; set => _propertiesBody.Limitation = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Additional mount options</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Additional mount options")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional mount options",
        SerializedName = @"mountOptions",
        PossibleTypes = new [] { typeof(string) })]
        public string[] MountOption { get => _propertiesBody.MountOption?.ToArray() ?? null /* fixedArrayOf */; set => _propertiesBody.MountOption = (value != null ? new System.Collections.Generic.List<string>(value) : null); }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the the storage class</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the the storage class")]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the the storage class",
        SerializedName = @"storageClassName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("StorageClassName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>Performance tier</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Performance tier")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Performance tier",
        SerializedName = @"performance",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Undefined", "Basic", "Standard", "Premium", "Ultra")]
        public string Performance { get => _propertiesBody.Performance ?? null; set => _propertiesBody.Performance = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>
        /// Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(long) })]
        public long Priority { get => _propertiesBody.Priority ?? default(long); set => _propertiesBody.Priority = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceUri" /> property.</summary>
        private string _resourceUri;

        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The fully qualified Azure Resource manager identifier of the resource.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The fully qualified Azure Resource manager identifier of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Path)]
        public string ResourceUri { get => this._resourceUri; set => this._resourceUri = value; }

        /// <summary>Azure Storage Account Key</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure Storage Account Key")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Storage Account Key",
        SerializedName = @"azureStorageAccountKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString TypePropertyAzureStorageAccountKey { get => _propertiesBody.TypePropertyAzureStorageAccountKey ?? null; set => _propertiesBody.TypePropertyAzureStorageAccountKey = value; }

        /// <summary>Azure Storage Account Name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure Storage Account Name")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Storage Account Name",
        SerializedName = @"azureStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyAzureStorageAccountName { get => _propertiesBody.TypePropertyAzureStorageAccountName ?? null; set => _propertiesBody.TypePropertyAzureStorageAccountName = value; }

        /// <summary>The backing storageclass used to create new storageclass</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The backing storageclass used to create new storageclass")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The backing storageclass used to create new storageclass",
        SerializedName = @"backingStorageClassName",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyBackingStorageClassName { get => _propertiesBody.TypePropertyBackingStorageClassName ?? null; set => _propertiesBody.TypePropertyBackingStorageClassName = value; }

        /// <summary>Server domain</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Server domain")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Server domain",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyDomain { get => _propertiesBody.TypePropertyDomain ?? null; set => _propertiesBody.TypePropertyDomain = value; }

        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount",
        SerializedName = @"mountPermissions",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyMountPermission { get => _propertiesBody.TypePropertyMountPermission ?? null; set => _propertiesBody.TypePropertyMountPermission = value; }

        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The action to take when a NFS volume is deleted. Default is Delete")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action to take when a NFS volume is deleted. Default is Delete",
        SerializedName = @"onDelete",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Delete", "Retain")]
        public string TypePropertyOnDelete { get => _propertiesBody.TypePropertyOnDelete ?? null; set => _propertiesBody.TypePropertyOnDelete = value; }

        /// <summary>Server password</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Server password")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Server password",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString TypePropertyPassword { get => _propertiesBody.TypePropertyPassword ?? null; set => _propertiesBody.TypePropertyPassword = value; }

        /// <summary>NFS Server</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "NFS Server")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NFS Server",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyServer { get => _propertiesBody.TypePropertyServer ?? null; set => _propertiesBody.TypePropertyServer = value; }

        /// <summary>NFS share</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "NFS share")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NFS share",
        SerializedName = @"share",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyShare { get => _propertiesBody.TypePropertyShare ?? null; set => _propertiesBody.TypePropertyShare = value; }

        /// <summary>SMB Source</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "SMB Source")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SMB Source",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertySource { get => _propertiesBody.TypePropertySource ?? null; set => _propertiesBody.TypePropertySource = value; }

        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Sub directory under share. If the sub directory doesn't exist, driver will create it")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sub directory under share. If the sub directory doesn't exist, driver will create it",
        SerializedName = @"subDir",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertySubDir { get => _propertiesBody.TypePropertySubDir ?? null; set => _propertiesBody.TypePropertySubDir = value; }

        /// <summary>Server username</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Server username")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Server username",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        public string TypePropertyUsername { get => _propertiesBody.TypePropertyUsername ?? null; set => _propertiesBody.TypePropertyUsername = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource">Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>
        /// a duplicate instance of UpdateAzContainerOrchestratorRuntimeStorageClass_UpdateExpanded
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Cmdlets.UpdateAzContainerOrchestratorRuntimeStorageClass_UpdateExpanded Clone()
        {
            var clone = new UpdateAzContainerOrchestratorRuntimeStorageClass_UpdateExpanded();
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
            clone._propertiesBody = this._propertiesBody;
            clone.ResourceUri = this.ResourceUri;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.Progress:
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
                    case Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
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
                await Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'StorageClassUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.StorageClassUpdate(ResourceUri, Name, _propertiesBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SerializationMode.IncludeUpdate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ResourceUri=ResourceUri,Name=Name})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzContainerOrchestratorRuntimeStorageClass_UpdateExpanded" /> cmdlet
        /// class.
        /// </summary>
        public UpdateAzContainerOrchestratorRuntimeStorageClass_UpdateExpanded()
        {

        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource">Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResource
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}