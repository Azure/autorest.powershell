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
    /// create an Azure Large Storage Instance for the specified subscription,\nresource group, and instance name.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeStorageInstances/{azureLargeStorageInstanceName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzAzureLargeInstanceAzureLargeStorageInstance_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Description(@"create an Azure Large Storage Instance for the specified subscription,\nresource group, and instance name.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeStorageInstances/{azureLargeStorageInstanceName}", ApiVersion = "2024-08-01-preview")]
    public partial class NewAzAzureLargeInstanceAzureLargeStorageInstance_CreateExpanded : global::System.Management.Automation.PSCmdlet,
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
        /// AzureLargeStorageInstance info on Azure (ARM properties and
        /// AzureLargeStorageInstance properties)
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance _resourceBody = new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstance();

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the AzureLargeStorageInstance unique ID.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the AzureLargeStorageInstance unique ID.",
        SerializedName = @"azureLargeStorageInstanceUniqueIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        public string AzureLargeStorageInstanceUniqueIdentifier { get => _resourceBody.UniqueIdentifier ?? null; set => _resourceBody.UniqueIdentifier = value; }

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

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public global::System.Management.Automation.SwitchParameter EnableSystemAssignedIdentity { set => _resourceBody.IdentityType = value.IsPresent ? "SystemAssigned": null ; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

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

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the AzureLargeStorageInstance.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the AzureLargeStorageInstance.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the AzureLargeStorageInstance.",
        SerializedName = @"azureLargeStorageInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("AzureLargeStorageInstanceName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.HttpPipeline Pipeline { get; set; }

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

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>the billing mode for the storage instance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the billing mode for the storage instance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the billing mode for the storage instance",
        SerializedName = @"billingMode",
        PossibleTypes = new [] { typeof(string) })]
        public string StorageBillingPropertyBillingMode { get => _resourceBody.StorageBillingPropertyBillingMode ?? null; set => _resourceBody.StorageBillingPropertyBillingMode = value; }

        /// <summary>the SKU type that is provisioned</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the SKU type that is provisioned")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the SKU type that is provisioned",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        public string StorageBillingPropertySku { get => _resourceBody.StorageBillingPropertySku ?? null; set => _resourceBody.StorageBillingPropertySku = value; }

        /// <summary>the kind of storage instance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the kind of storage instance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the kind of storage instance",
        SerializedName = @"generation",
        PossibleTypes = new [] { typeof(string) })]
        public string StoragePropertyGeneration { get => _resourceBody.StoragePropertyGeneration ?? null; set => _resourceBody.StoragePropertyGeneration = value; }

        /// <summary>the hardware type of the storage instance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the hardware type of the storage instance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the hardware type of the storage instance",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        public string StoragePropertyHardwareType { get => _resourceBody.StoragePropertyHardwareType ?? null; set => _resourceBody.StoragePropertyHardwareType = value; }

        /// <summary>the offering type for which the resource is getting provisioned</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the offering type for which the resource is getting provisioned")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the offering type for which the resource is getting provisioned",
        SerializedName = @"offeringType",
        PossibleTypes = new [] { typeof(string) })]
        public string StoragePropertyOfferingType { get => _resourceBody.StoragePropertyOfferingType ?? null; set => _resourceBody.StoragePropertyOfferingType = value; }

        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "State of provisioning of the AzureLargeStorageInstance")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of provisioning of the AzureLargeStorageInstance",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Canceled", "Migrating")]
        public string StoragePropertyProvisioningState { get => _resourceBody.StoragePropertyProvisioningState ?? null; set => _resourceBody.StoragePropertyProvisioningState = value; }

        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the storage protocol for which the resource is getting provisioned")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the storage protocol for which the resource is getting provisioned",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        public string StoragePropertyStorageType { get => _resourceBody.StoragePropertyStorageType ?? null; set => _resourceBody.StoragePropertyStorageType = value; }

        /// <summary>the workload for which the resource is getting provisioned</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the workload for which the resource is getting provisioned")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the workload for which the resource is getting provisioned",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        public string StoragePropertyWorkloadType { get => _resourceBody.StoragePropertyWorkloadType ?? null; set => _resourceBody.StoragePropertyWorkloadType = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceTags Tag { get => _resourceBody.Tag ?? null /* object */; set => _resourceBody.Tag = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
        /// Initializes a new instance of the <see cref="NewAzAzureLargeInstanceAzureLargeStorageInstance_CreateExpanded" /> cmdlet
        /// class.
        /// </summary>
        public NewAzAzureLargeInstanceAzureLargeStorageInstance_CreateExpanded()
        {

        }

        private void PreProcessManagedIdentityParameters()
        {
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _resourceBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _resourceBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.UserAssignedIdentity());
                }
            }
            // calculate IdentityType
            if (this.UserAssignedIdentity?.Length > 0)
            {
                if ("SystemAssigned".Equals(_resourceBody.IdentityType, StringComparison.InvariantCultureIgnoreCase))
                {
                    _resourceBody.IdentityType = "SystemAssigned,UserAssigned";
                }
                else
                {
                    _resourceBody.IdentityType = "UserAssigned";
                }
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'AzureLargeStorageInstanceCreate' operation"))
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
                    this.PreProcessManagedIdentityParameters();
                    await this.Client.AzureLargeStorageInstanceCreate(SubscriptionId, ResourceGroupName, Name, _resourceBody, onOk, onCreated, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Name=Name})
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance
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
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance">Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance
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