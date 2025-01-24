// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the SAP Central Services Instance properties.</summary>
    public partial class SapCentralServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="EnqueueReplicationServerProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties _enqueueReplicationServerProperty;

        /// <summary>Defines the SAP Enqueue Replication Server (ERS) properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties EnqueueReplicationServerProperty { get => (this._enqueueReplicationServerProperty = this._enqueueReplicationServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueReplicationServerProperties()); set => this._enqueueReplicationServerProperty = value; }

        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyErsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).ErsVersion; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).Health; }

        /// <summary>ERS SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).Hostname; }

        /// <summary>ERS SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).IPAddress; }

        /// <summary>ERS Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyInstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).InstanceNo; }

        /// <summary>ERS SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyKernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).KernelPatch; }

        /// <summary>ERS SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueReplicationServerPropertyKernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).KernelVersion; }

        /// <summary>Backing field for <see cref="EnqueueServerProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties _enqueueServerProperty;

        /// <summary>Defines the SAP Enqueue Server properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties EnqueueServerProperty { get => (this._enqueueServerProperty = this._enqueueServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueServerProperties()); set => this._enqueueServerProperty = value; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Health; }

        /// <summary>Enqueue Server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Hostname; }

        /// <summary>Enqueue Server SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string EnqueueServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).IPAddress; }

        /// <summary>Enqueue Server Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? EnqueueServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Port; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError _error;

        /// <summary>Defines the errors related to SAP Central Services Instance resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); }

        /// <summary>Backing field for <see cref="GatewayServerProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties _gatewayServerProperty;

        /// <summary>Defines the SAP Gateway Server properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties GatewayServerProperty { get => (this._gatewayServerProperty = this._gatewayServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.GatewayServerProperties()); set => this._gatewayServerProperty = value; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string GatewayServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerPropertiesInternal)GatewayServerProperty).Health; }

        /// <summary>Gateway Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? GatewayServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerPropertiesInternal)GatewayServerProperty).Port; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Health { get => this._health; }

        /// <summary>Backing field for <see cref="InstanceNo" /> property.</summary>
        private string _instanceNo;

        /// <summary>The central services instance number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string InstanceNo { get => this._instanceNo; }

        /// <summary>Backing field for <see cref="KernelPatch" /> property.</summary>
        private string _kernelPatch;

        /// <summary>The central services instance Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KernelPatch { get => this._kernelPatch; }

        /// <summary>Backing field for <see cref="KernelVersion" /> property.</summary>
        private string _kernelVersion;

        /// <summary>The central services instance Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KernelVersion { get => this._kernelVersion; }

        /// <summary>Backing field for <see cref="LoadBalancerDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails _loadBalancerDetail;

        /// <summary>
        /// The Load Balancer details such as LoadBalancer ID attached to ASCS Virtual Machines
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails LoadBalancerDetail { get => (this._loadBalancerDetail = this._loadBalancerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetails()); }

        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; }

        /// <summary>Backing field for <see cref="MessageServerProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties _messageServerProperty;

        /// <summary>Defines the SAP message server properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties MessageServerProperty { get => (this._messageServerProperty = this._messageServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.MessageServerProperties()); set => this._messageServerProperty = value; }

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string MessageServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).Health; }

        /// <summary>message server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string MessageServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).Hostname; }

        /// <summary>message server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyHttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).HttpPort; }

        /// <summary>message server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyHttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).HttpsPort; }

        /// <summary>message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string MessageServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).IPAddress; }

        /// <summary>message server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyInternalMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).InternalMSPort; }

        /// <summary>message server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? MessageServerPropertyMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).MSPort; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerProperty { get => (this._enqueueReplicationServerProperty = this._enqueueReplicationServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueReplicationServerProperties()); set { {_enqueueReplicationServerProperty = value;} } }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyErsVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyErsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).ErsVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).ErsVersion = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).Health = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).Hostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).Hostname = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).IPAddress = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyInstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyInstanceNo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).InstanceNo; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).InstanceNo = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyKernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyKernelPatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).KernelPatch; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).KernelPatch = value; }

        /// <summary>Internal Acessors for EnqueueReplicationServerPropertyKernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueReplicationServerPropertyKernelVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).KernelVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal)EnqueueReplicationServerProperty).KernelVersion = value; }

        /// <summary>Internal Acessors for EnqueueServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueServerProperty { get => (this._enqueueServerProperty = this._enqueueServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.EnqueueServerProperties()); set { {_enqueueServerProperty = value;} } }

        /// <summary>Internal Acessors for EnqueueServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Health = value; }

        /// <summary>Internal Acessors for EnqueueServerPropertyHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Hostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Hostname = value; }

        /// <summary>Internal Acessors for EnqueueServerPropertyIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).IPAddress = value; }

        /// <summary>Internal Acessors for EnqueueServerPropertyPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.EnqueueServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Port; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueServerPropertiesInternal)EnqueueServerProperty).Port = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.ErrorProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property = value; }

        /// <summary>Internal Acessors for GatewayServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.GatewayServerProperty { get => (this._gatewayServerProperty = this._gatewayServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.GatewayServerProperties()); set { {_gatewayServerProperty = value;} } }

        /// <summary>Internal Acessors for GatewayServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.GatewayServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerPropertiesInternal)GatewayServerProperty).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerPropertiesInternal)GatewayServerProperty).Health = value; }

        /// <summary>Internal Acessors for GatewayServerPropertyPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.GatewayServerPropertyPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerPropertiesInternal)GatewayServerProperty).Port; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IGatewayServerPropertiesInternal)GatewayServerProperty).Port = value; }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for InstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.InstanceNo { get => this._instanceNo; set { {_instanceNo = value;} } }

        /// <summary>Internal Acessors for KernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.KernelPatch { get => this._kernelPatch; set { {_kernelPatch = value;} } }

        /// <summary>Internal Acessors for KernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.KernelVersion { get => this._kernelVersion; set { {_kernelVersion = value;} } }

        /// <summary>Internal Acessors for LoadBalancerDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.LoadBalancerDetail { get => (this._loadBalancerDetail = this._loadBalancerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetails()); set { {_loadBalancerDetail = value;} } }

        /// <summary>Internal Acessors for LoadBalancerDetailId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message = value; }

        /// <summary>Internal Acessors for MessageServerProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerProperty { get => (this._messageServerProperty = this._messageServerProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.MessageServerProperties()); set { {_messageServerProperty = value;} } }

        /// <summary>Internal Acessors for MessageServerPropertyHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).Health = value; }

        /// <summary>Internal Acessors for MessageServerPropertyHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).Hostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).Hostname = value; }

        /// <summary>Internal Acessors for MessageServerPropertyHttpPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyHttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).HttpPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).HttpPort = value; }

        /// <summary>Internal Acessors for MessageServerPropertyHttpsPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyHttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).HttpsPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).HttpsPort = value; }

        /// <summary>Internal Acessors for MessageServerPropertyIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).IPAddress = value; }

        /// <summary>Internal Acessors for MessageServerPropertyInternalMSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyInternalMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).InternalMSPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).InternalMSPort = value; }

        /// <summary>Internal Acessors for MessageServerPropertyMSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.MessageServerPropertyMSPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).MSPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal)MessageServerProperty).MSPort = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.Subnet { get => this._subnet; set { {_subnet = value;} } }

        /// <summary>Internal Acessors for VMDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapCentralServerPropertiesInternal.VMDetail { get => this._vMDetail; set { {_vMDetail = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Defines the provisioning states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Defines the SAP Instance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private string _subnet;

        /// <summary>The central services instance subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Subnet { get => this._subnet; }

        /// <summary>Backing field for <see cref="VMDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> _vMDetail;

        /// <summary>The list of virtual machines corresponding to the Central Services instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> VMDetail { get => this._vMDetail; }

        /// <summary>Creates an new <see cref="SapCentralServerProperties" /> instance.</summary>
        public SapCentralServerProperties()
        {

        }
    }
    /// Defines the SAP Central Services Instance properties.
    public partial interface ISapCentralServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
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
    /// Defines the SAP Central Services Instance properties.
    internal partial interface ISapCentralServerPropertiesInternal

    {
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
        /// <summary>Defines the provisioning states.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Defines the SAP Instance status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get; set; }
        /// <summary>The central services instance subnet.</summary>
        string Subnet { get; set; }
        /// <summary>The list of virtual machines corresponding to the Central Services instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerVMDetails> VMDetail { get; set; }

    }
}