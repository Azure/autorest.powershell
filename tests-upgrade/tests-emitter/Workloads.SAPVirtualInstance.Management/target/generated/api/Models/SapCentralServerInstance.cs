// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Define the SAP Central Services Instance resource.</summary>
    public partial class SapCentralServerInstance :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstance,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal,
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
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Code; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Detail; }

        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyErsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyErsVersion; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyHealth; }

        /// <summary>ERS SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyHostname; }

        /// <summary>ERS SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyIPAddress; }

        /// <summary>ERS Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyInstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyInstanceNo; }

        /// <summary>ERS SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyKernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyKernelPatch; }

        /// <summary>ERS SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyKernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyKernelVersion; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyHealth; }

        /// <summary>Enqueue Server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyHostname; }

        /// <summary>Enqueue Server SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyIPAddress; }

        /// <summary>Enqueue Server Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? EnqueueServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyPort; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string GatewayServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerPropertyHealth; }

        /// <summary>Gateway Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? GatewayServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerPropertyPort; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Health { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Health; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The central services instance number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string InstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).InstanceNo; }

        /// <summary>The central services instance Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string KernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).KernelPatch; }

        /// <summary>The central services instance Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string KernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).KernelVersion; }

        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).LoadBalancerDetailId; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Message; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string MessageServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHealth; }

        /// <summary>message server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string MessageServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHostname; }

        /// <summary>message server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyHttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHttpPort; }

        /// <summary>message server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyHttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHttpsPort; }

        /// <summary>message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string MessageServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyIPAddress; }

        /// <summary>message server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyInternalMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyInternalMSPort; }

        /// <summary>message server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyMSPort; }

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
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for EnqueueReplicationServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyErsVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyErsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyErsVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyErsVersion = value ?? null; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyHealth = value ?? null; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyHostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyHostname = value ?? null; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyIPAddress = value ?? null; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyInstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyInstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyInstanceNo; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyInstanceNo = value ?? null; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyKernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyKernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyKernelPatch; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyKernelPatch = value ?? null; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyKernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueReplicationServerPropertyKernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyKernelVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueReplicationServerPropertyKernelVersion = value ?? null; }

        /// <summary>Internal Acessors for EnqueueServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueServerProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EnqueueServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyHealth = value ?? null; }

        /// <summary>Internal Acessors for EnqueueServerPropertyHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyHostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyHostname = value ?? null; }

        /// <summary>Internal Acessors for EnqueueServerPropertyIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyIPAddress = value ?? null; }

        /// <summary>Internal Acessors for EnqueueServerPropertyPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.EnqueueServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).EnqueueServerPropertyPort = value ?? default(long); }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.ErrorProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).ErrorProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).ErrorProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GatewayServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.GatewayServerProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GatewayServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.GatewayServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerPropertyHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerPropertyHealth = value ?? null; }

        /// <summary>Internal Acessors for GatewayServerPropertyPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.GatewayServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerPropertyPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).GatewayServerPropertyPort = value ?? default(long); }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Health { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Health = value ?? null; }

        /// <summary>Internal Acessors for InstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.InstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).InstanceNo; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).InstanceNo = value ?? null; }

        /// <summary>Internal Acessors for KernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.KernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).KernelPatch; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).KernelPatch = value ?? null; }

        /// <summary>Internal Acessors for KernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.KernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).KernelVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).KernelVersion = value ?? null; }

        /// <summary>Internal Acessors for LoadBalancerDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.LoadBalancerDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).LoadBalancerDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).LoadBalancerDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LoadBalancerDetailId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).LoadBalancerDetailId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).LoadBalancerDetailId = value ?? null; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for MessageServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MessageServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHealth = value ?? null; }

        /// <summary>Internal Acessors for MessageServerPropertyHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHostname = value ?? null; }

        /// <summary>Internal Acessors for MessageServerPropertyHttpPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyHttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHttpPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHttpPort = value ?? default(long); }

        /// <summary>Internal Acessors for MessageServerPropertyHttpsPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyHttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHttpsPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyHttpsPort = value ?? default(long); }

        /// <summary>Internal Acessors for MessageServerPropertyIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyIPAddress = value ?? null; }

        /// <summary>Internal Acessors for MessageServerPropertyInternalMSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyInternalMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyInternalMSPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyInternalMSPort = value ?? default(long); }

        /// <summary>Internal Acessors for MessageServerPropertyMSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.MessageServerPropertyMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyMSPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).MessageServerPropertyMSPort = value ?? default(long); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapCentralServerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Internal Acessors for Subnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Subnet = value ?? null; }

        /// <summary>Internal Acessors for VMDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal.VMDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).VMDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).VMDetail = value ?? null /* arrayOf */; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapCentralServerProperties()); set => this._property = value; }

        /// <summary>Defines the provisioning states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Defines the SAP Instance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Status; }

        /// <summary>The central services instance subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).Subnet; }

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

        /// <summary>The list of virtual machines corresponding to the Central Services instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> VMDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal)Property).VMDetail; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerInstanceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Creates an new <see cref="SapCentralServerInstance" /> instance.</summary>
        public SapCentralServerInstance()
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
    /// Define the SAP Central Services Instance resource.
    public partial interface ISapCentralServerInstance :
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
        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the type of Enqueue Replication Server.",
        SerializedName = @"ersVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("EnqueueReplicator1", "EnqueueReplicator2")]
        string EnqueueReplicationServerPropertyErsVersion { get;  }
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
        string EnqueueReplicationServerPropertyHealth { get;  }
        /// <summary>ERS SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP Hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueReplicationServerPropertyHostname { get;  }
        /// <summary>ERS SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueReplicationServerPropertyIPAddress { get;  }
        /// <summary>ERS Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS Instance Number.",
        SerializedName = @"instanceNo",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueReplicationServerPropertyInstanceNo { get;  }
        /// <summary>ERS SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP Kernel Patch level.",
        SerializedName = @"kernelPatch",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueReplicationServerPropertyKernelPatch { get;  }
        /// <summary>ERS SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP Kernel Version.",
        SerializedName = @"kernelVersion",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueReplicationServerPropertyKernelVersion { get;  }
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
        string EnqueueServerPropertyHealth { get;  }
        /// <summary>Enqueue Server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Enqueue Server SAP Hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueServerPropertyHostname { get;  }
        /// <summary>Enqueue Server SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Enqueue Server SAP IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EnqueueServerPropertyIPAddress { get;  }
        /// <summary>Enqueue Server Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Enqueue Server Port.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(long) })]
        long? EnqueueServerPropertyPort { get;  }
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
        string GatewayServerPropertyHealth { get;  }
        /// <summary>Gateway Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gateway Port.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(long) })]
        long? GatewayServerPropertyPort { get;  }
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
        /// <summary>The central services instance number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The central services instance number.",
        SerializedName = @"instanceNo",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceNo { get;  }
        /// <summary>The central services instance Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The central services instance Kernel Patch level.",
        SerializedName = @"kernelPatch",
        PossibleTypes = new [] { typeof(string) })]
        string KernelPatch { get;  }
        /// <summary>The central services instance Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The central services instance Kernel Version.",
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
        string MessageServerPropertyHealth { get;  }
        /// <summary>message server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server SAP Hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string MessageServerPropertyHostname { get;  }
        /// <summary>message server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server HTTP Port.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageServerPropertyHttpPort { get;  }
        /// <summary>message server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server HTTPS Port.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageServerPropertyHttpsPort { get;  }
        /// <summary>message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string MessageServerPropertyIPAddress { get;  }
        /// <summary>message server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server internal MS port.",
        SerializedName = @"internalMsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageServerPropertyInternalMSPort { get;  }
        /// <summary>message server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server port.",
        SerializedName = @"msPort",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageServerPropertyMSPort { get;  }
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
        /// <summary>The central services instance subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The central services instance subnet.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string Subnet { get;  }
        /// <summary>The list of virtual machines corresponding to the Central Services instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of virtual machines corresponding to the Central Services instance.",
        SerializedName = @"vmDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> VMDetail { get;  }

    }
    /// Define the SAP Central Services Instance resource.
    internal partial interface ISapCentralServerInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Internal error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get; set; }
        /// <summary>Defines the SAP Enqueue Replication Server (ERS) properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties EnqueueReplicationServerProperty { get; set; }
        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("EnqueueReplicator1", "EnqueueReplicator2")]
        string EnqueueReplicationServerPropertyErsVersion { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string EnqueueReplicationServerPropertyHealth { get; set; }
        /// <summary>ERS SAP Hostname.</summary>
        string EnqueueReplicationServerPropertyHostname { get; set; }
        /// <summary>ERS SAP IP Address.</summary>
        string EnqueueReplicationServerPropertyIPAddress { get; set; }
        /// <summary>ERS Instance Number.</summary>
        string EnqueueReplicationServerPropertyInstanceNo { get; set; }
        /// <summary>ERS SAP Kernel Patch level.</summary>
        string EnqueueReplicationServerPropertyKernelPatch { get; set; }
        /// <summary>ERS SAP Kernel Version.</summary>
        string EnqueueReplicationServerPropertyKernelVersion { get; set; }
        /// <summary>Defines the SAP Enqueue Server properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties EnqueueServerProperty { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string EnqueueServerPropertyHealth { get; set; }
        /// <summary>Enqueue Server SAP Hostname.</summary>
        string EnqueueServerPropertyHostname { get; set; }
        /// <summary>Enqueue Server SAP IP Address.</summary>
        string EnqueueServerPropertyIPAddress { get; set; }
        /// <summary>Enqueue Server Port.</summary>
        long? EnqueueServerPropertyPort { get; set; }
        /// <summary>Defines the errors related to SAP Central Services Instance resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get; set; }
        /// <summary>The Virtual Instance for SAP error body.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition ErrorProperty { get; set; }
        /// <summary>Defines the SAP Gateway Server properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties GatewayServerProperty { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string GatewayServerPropertyHealth { get; set; }
        /// <summary>Gateway Port.</summary>
        long? GatewayServerPropertyPort { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get; set; }
        /// <summary>The central services instance number.</summary>
        string InstanceNo { get; set; }
        /// <summary>The central services instance Kernel Patch level.</summary>
        string KernelPatch { get; set; }
        /// <summary>The central services instance Kernel Version.</summary>
        string KernelVersion { get; set; }
        /// <summary>
        /// The Load Balancer details such as LoadBalancer ID attached to ASCS Virtual Machines
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails LoadBalancerDetail { get; set; }
        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        string LoadBalancerDetailId { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }
        /// <summary>Defines the SAP message server properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties MessageServerProperty { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string MessageServerPropertyHealth { get; set; }
        /// <summary>message server SAP Hostname.</summary>
        string MessageServerPropertyHostname { get; set; }
        /// <summary>message server HTTP Port.</summary>
        long? MessageServerPropertyHttpPort { get; set; }
        /// <summary>message server HTTPS Port.</summary>
        long? MessageServerPropertyHttpsPort { get; set; }
        /// <summary>message server IP Address.</summary>
        string MessageServerPropertyIPAddress { get; set; }
        /// <summary>message server internal MS port.</summary>
        long? MessageServerPropertyInternalMSPort { get; set; }
        /// <summary>message server port.</summary>
        long? MessageServerPropertyMSPort { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties Property { get; set; }
        /// <summary>Defines the provisioning states.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Defines the SAP Instance status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get; set; }
        /// <summary>The central services instance subnet.</summary>
        string Subnet { get; set; }
        /// <summary>The list of virtual machines corresponding to the Central Services instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> VMDetail { get; set; }

    }
}