// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// create an Azure Large Instance for the specified subscription,\nresource group, and instance name.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeInstances/{azureLargeInstanceName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzAzureLargeInstanceAzureLargeInstance_CreateViaIdentityExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Description(@"create an Azure Large Instance for the specified subscription,\nresource group, and instance name.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeInstances/{azureLargeInstanceName}", ApiVersion = "2024-08-01-preview")]
    public partial class NewAzAzureLargeInstanceAzureLargeInstance_CreateViaIdentityExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IContext
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

        /// <summary>
        /// Azure Large Instance info on Azure (ARM properties and AzureLargeInstance
        /// properties)
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance _resourceBody = new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstance();

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the Azure Large Instance unique ID.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the Azure Large Instance unique ID.",
        SerializedName = @"azureLargeInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        public string AzureLargeInstanceId { get => _resourceBody.AzureLargeInstanceId ?? null; set => _resourceBody.AzureLargeInstanceId = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.AzureLargeInstance Client => Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the Azure Large Instance SKU.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the Azure Large Instance SKU.",
        SerializedName = @"azureLargeInstanceSize",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        public string HardwareProfileAzureLargeInstanceSize { get => _resourceBody.HardwareProfileAzureLargeInstanceSize ?? null; set => _resourceBody.HardwareProfileAzureLargeInstanceSize = value; }

        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the hardware type (vendor and/or their product name)")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the hardware type (vendor and/or their product name)",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        public string HardwareProfileHardwareType { get => _resourceBody.HardwareProfileHardwareType ?? null; set => _resourceBody.HardwareProfileHardwareType = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Hardware revision of an Azure Large Instance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Hardware revision of an Azure Large Instance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hardware revision of an Azure Large Instance",
        SerializedName = @"hwRevision",
        PossibleTypes = new [] { typeof(string) })]
        public string HwRevision { get => _resourceBody.HwRevision ?? null; set => _resourceBody.HwRevision = value; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _resourceBody.Location ?? null; set => _resourceBody.Location = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the circuit id for connecting to express route.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the circuit id for connecting to express route.",
        SerializedName = @"circuitId",
        PossibleTypes = new [] { typeof(string) })]
        public string NetworkProfileCircuitId { get => _resourceBody.NetworkProfileCircuitId ?? null; set => _resourceBody.NetworkProfileCircuitId = value; }

        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the network interfaces for the Azure Large Instance.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the network interfaces for the Azure Large Instance.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress) })]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress[] NetworkProfileNetworkInterface { get => _resourceBody.NetworkProfileNetworkInterface?.ToArray() ?? null /* fixedArrayOf */; set => _resourceBody.NetworkProfileNetworkInterface = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress>(value) : null); }

        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the host OS name of the Azure Large Instance.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the host OS name of the Azure Large Instance.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        public string OSProfileComputerName { get => _resourceBody.OSProfileComputerName ?? null; set => _resourceBody.OSProfileComputerName = value; }

        /// <summary>This property allows you to specify the type of the OS.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This property allows you to specify the type of the OS.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This property allows you to specify the type of the OS.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        public string OSProfileOstype { get => _resourceBody.OSProfileOstype ?? null; set => _resourceBody.OSProfileOstype = value; }

        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the SSH public key used to access the operating system.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the SSH public key used to access the operating system.",
        SerializedName = @"sshPublicKey",
        PossibleTypes = new [] { typeof(string) })]
        public string OSProfileSshPublicKey { get => _resourceBody.OSProfileSshPublicKey ?? null; set => _resourceBody.OSProfileSshPublicKey = value; }

        /// <summary>Specifies version of operating system.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies version of operating system.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies version of operating system.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        public string OSProfileVersion { get => _resourceBody.OSProfileVersion ?? null; set => _resourceBody.OSProfileVersion = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Resource power state</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource power state")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource power state",
        SerializedName = @"powerState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("starting", "started", "stopping", "stopped", "restarting", "unknown")]
        public string PowerState { get => _resourceBody.PowerState ?? null; set => _resourceBody.PowerState = value; }

        /// <summary>Resource proximity placement group</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource proximity placement group")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource proximity placement group",
        SerializedName = @"proximityPlacementGroup",
        PossibleTypes = new [] { typeof(string) })]
        public string ProximityPlacementGroup { get => _resourceBody.ProximityPlacementGroup ?? null; set => _resourceBody.ProximityPlacementGroup = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>IP Address to connect to storage.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IP Address to connect to storage.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP Address to connect to storage.",
        SerializedName = @"nfsIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string StorageProfileNfsIPAddress { get => _resourceBody.StorageProfileNfsIPAddress ?? null; set => _resourceBody.StorageProfileNfsIPAddress = value; }

        /// <summary>
        /// Specifies information about the operating system disk used by Azure LargeInstance.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies information about the operating system disk used by Azure LargeInstance.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies information about the operating system disk used by Azure LargeInstance.",
        SerializedName = @"osDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk) })]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk[] StorageProfileOSDisk { get => _resourceBody.StorageProfileOSDisk?.ToArray() ?? null /* fixedArrayOf */; set => _resourceBody.StorageProfileOSDisk = (value != null ? new System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk>(value) : null); }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags Tag { get => _resourceBody.Tag ?? null /* object */; set => _resourceBody.Tag = value; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
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
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.Progress:
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
                }
                await Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAzAzureLargeInstanceAzureLargeInstance_CreateViaIdentityExpanded" /> cmdlet
        /// class.
        /// </summary>
        public NewAzAzureLargeInstanceAzureLargeInstance_CreateViaIdentityExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'AzureLargeInstancesCreate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (InputObject?.Id != null)
                    {
                        await this.Client.AzureLargeInstancesCreateViaIdentity(InputObject.Id, _resourceBody, onOk, onCreated, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeCreate);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == InputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.AzureLargeInstanceName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.AzureLargeInstanceName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        await this.Client.AzureLargeInstancesCreate(InputObject.SubscriptionId ?? null, InputObject.ResourceGroupName ?? null, InputObject.AzureLargeInstanceName ?? null, _resourceBody, onOk, onCreated, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeCreate);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>a delegate that is called when the remote service returns 201 (Created).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnCreated(responseMessage, response, ref _returnNow);
                // if overrideOnCreated has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onCreated - response for 201 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance
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

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IErrorResponse>(responseMessage, await response);
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance
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