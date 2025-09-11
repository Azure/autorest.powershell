// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Define the SAP Application Server Instance resource.</summary>
    public partial class SapApplicationServerInstance :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstance,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.TrackedResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Code; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Detail; }

        /// <summary>Application server instance dispatcher status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DispatcherStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).DispatcherStatus; }

        /// <summary>Application server instance gateway Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? GatewayPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).GatewayPort; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Health { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Health; }

        /// <summary>Application server instance SAP hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Hostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Hostname; }

        /// <summary>Application server instance SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string IPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IPAddress; }

        /// <summary>Application server instance ICM HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? IcmHttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IcmHttpPort; }

        /// <summary>Application server instance ICM HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? IcmHttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IcmHttpsPort; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Application server Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string InstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).InstanceNo; }

        /// <summary>Application server instance SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string KernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).KernelPatch; }

        /// <summary>Application server instance SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string KernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).KernelVersion; }

        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).LoadBalancerDetailId; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Message; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DispatcherStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.DispatcherStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).DispatcherStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).DispatcherStatus = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.ErrorProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).ErrorProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).ErrorProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GatewayPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.GatewayPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).GatewayPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).GatewayPort = value ?? default(long); }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Health { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Health = value ?? null; }

        /// <summary>Internal Acessors for Hostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Hostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Hostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Hostname = value ?? null; }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.IPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IPAddress = value ?? null; }

        /// <summary>Internal Acessors for IcmHttpPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.IcmHttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IcmHttpPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IcmHttpPort = value ?? default(long); }

        /// <summary>Internal Acessors for IcmHttpsPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.IcmHttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IcmHttpsPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).IcmHttpsPort = value ?? default(long); }

        /// <summary>Internal Acessors for InstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.InstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).InstanceNo; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).InstanceNo = value ?? null; }

        /// <summary>Internal Acessors for KernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.KernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).KernelPatch; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).KernelPatch = value ?? null; }

        /// <summary>Internal Acessors for KernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.KernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).KernelVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).KernelVersion = value ?? null; }

        /// <summary>Internal Acessors for LoadBalancerDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.LoadBalancerDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).LoadBalancerDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).LoadBalancerDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LoadBalancerDetailId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).LoadBalancerDetailId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).LoadBalancerDetailId = value ?? null; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapApplicationServerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Internal Acessors for Subnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Subnet = value ?? null; }

        /// <summary>Internal Acessors for VMDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal.VMDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).VMDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).VMDetail = value ?? null /* arrayOf */; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapApplicationServerProperties()); set => this._property = value; }

        /// <summary>Defines the provisioning states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Defines the SAP Instance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Status; }

        /// <summary>Application server Subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).Subnet; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>The list of virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> VMDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal)Property).VMDetail; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerInstanceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Creates an new <see cref="SapApplicationServerInstance" /> instance.</summary>
        public SapApplicationServerInstance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Define the SAP Application Server Instance resource.
    public partial interface ISapApplicationServerInstance :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get;  }
        /// <summary>Application server instance dispatcher status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance dispatcher status.",
        SerializedName = @"dispatcherStatus",
        PossibleTypes = new [] { typeof(string) })]
        string DispatcherStatus { get;  }
        /// <summary>Application server instance gateway Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance gateway Port.",
        SerializedName = @"gatewayPort",
        PossibleTypes = new [] { typeof(long) })]
        long? GatewayPort { get;  }
        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the health of SAP Instances.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get;  }
        /// <summary>Application server instance SAP hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance SAP hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get;  }
        /// <summary>Application server instance SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance SAP IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get;  }
        /// <summary>Application server instance ICM HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance ICM HTTP Port.",
        SerializedName = @"icmHttpPort",
        PossibleTypes = new [] { typeof(long) })]
        long? IcmHttpPort { get;  }
        /// <summary>Application server instance ICM HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance ICM HTTPS Port.",
        SerializedName = @"icmHttpsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? IcmHttpsPort { get;  }
        /// <summary>Application server Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server Instance Number.",
        SerializedName = @"instanceNo",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceNo { get;  }
        /// <summary>Application server instance SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance SAP Kernel Patch level.",
        SerializedName = @"kernelPatch",
        PossibleTypes = new [] { typeof(string) })]
        string KernelPatch { get;  }
        /// <summary>Application server instance SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server instance SAP Kernel Version.",
        SerializedName = @"kernelVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KernelVersion { get;  }
        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Fully qualified resource ID for the load balancer.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerDetailId { get;  }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Defines the provisioning states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the provisioning states.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>Defines the SAP Instance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the SAP Instance status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get;  }
        /// <summary>Application server Subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application server Subnet.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string Subnet { get;  }
        /// <summary>The list of virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of virtual machines.",
        SerializedName = @"vmDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> VMDetail { get;  }

    }
    /// Define the SAP Application Server Instance resource.
    internal partial interface ISapApplicationServerInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Internal error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get; set; }
        /// <summary>Application server instance dispatcher status.</summary>
        string DispatcherStatus { get; set; }
        /// <summary>Defines the Application Instance errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get; set; }
        /// <summary>The Virtual Instance for SAP error body.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition ErrorProperty { get; set; }
        /// <summary>Application server instance gateway Port.</summary>
        long? GatewayPort { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get; set; }
        /// <summary>Application server instance SAP hostname.</summary>
        string Hostname { get; set; }
        /// <summary>Application server instance SAP IP Address.</summary>
        string IPAddress { get; set; }
        /// <summary>Application server instance ICM HTTP Port.</summary>
        long? IcmHttpPort { get; set; }
        /// <summary>Application server instance ICM HTTPS Port.</summary>
        long? IcmHttpsPort { get; set; }
        /// <summary>Application server Instance Number.</summary>
        string InstanceNo { get; set; }
        /// <summary>Application server instance SAP Kernel Patch level.</summary>
        string KernelPatch { get; set; }
        /// <summary>Application server instance SAP Kernel Version.</summary>
        string KernelVersion { get; set; }
        /// <summary>
        /// The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails LoadBalancerDetail { get; set; }
        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        string LoadBalancerDetailId { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerProperties Property { get; set; }
        /// <summary>Defines the provisioning states.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Defines the SAP Instance status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get; set; }
        /// <summary>Application server Subnet.</summary>
        string Subnet { get; set; }
        /// <summary>The list of virtual machines.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> VMDetail { get; set; }

    }
}