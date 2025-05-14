// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the SAP Application Server instance properties.</summary>
    public partial class SapApplicationServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="DispatcherStatus" /> property.</summary>
        private string _dispatcherStatus;

        /// <summary>Application server instance dispatcher status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DispatcherStatus { get => this._dispatcherStatus; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError _error;

        /// <summary>Defines the Application Instance errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); }

        /// <summary>Backing field for <see cref="GatewayPort" /> property.</summary>
        private long? _gatewayPort;

        /// <summary>Application server instance gateway Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? GatewayPort { get => this._gatewayPort; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Health { get => this._health; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>Application server instance SAP hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>Application server instance SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="IcmHttpPort" /> property.</summary>
        private long? _icmHttpPort;

        /// <summary>Application server instance ICM HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? IcmHttpPort { get => this._icmHttpPort; }

        /// <summary>Backing field for <see cref="IcmHttpsPort" /> property.</summary>
        private long? _icmHttpsPort;

        /// <summary>Application server instance ICM HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? IcmHttpsPort { get => this._icmHttpsPort; }

        /// <summary>Backing field for <see cref="InstanceNo" /> property.</summary>
        private string _instanceNo;

        /// <summary>Application server Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string InstanceNo { get => this._instanceNo; }

        /// <summary>Backing field for <see cref="KernelPatch" /> property.</summary>
        private string _kernelPatch;

        /// <summary>Application server instance SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KernelPatch { get => this._kernelPatch; }

        /// <summary>Backing field for <see cref="KernelVersion" /> property.</summary>
        private string _kernelVersion;

        /// <summary>Application server instance SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KernelVersion { get => this._kernelVersion; }

        /// <summary>Backing field for <see cref="LoadBalancerDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails _loadBalancerDetail;

        /// <summary>
        /// The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails LoadBalancerDetail { get => (this._loadBalancerDetail = this._loadBalancerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetails()); }

        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DispatcherStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.DispatcherStatus { get => this._dispatcherStatus; set { {_dispatcherStatus = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.ErrorProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GatewayPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.GatewayPort { get => this._gatewayPort; set { {_gatewayPort = value;} } }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for Hostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Hostname { get => this._hostname; set { {_hostname = value;} } }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for IcmHttpPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.IcmHttpPort { get => this._icmHttpPort; set { {_icmHttpPort = value;} } }

        /// <summary>Internal Acessors for IcmHttpsPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.IcmHttpsPort { get => this._icmHttpsPort; set { {_icmHttpsPort = value;} } }

        /// <summary>Internal Acessors for InstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.InstanceNo { get => this._instanceNo; set { {_instanceNo = value;} } }

        /// <summary>Internal Acessors for KernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.KernelPatch { get => this._kernelPatch; set { {_kernelPatch = value;} } }

        /// <summary>Internal Acessors for KernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.KernelVersion { get => this._kernelVersion; set { {_kernelVersion = value;} } }

        /// <summary>Internal Acessors for LoadBalancerDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.LoadBalancerDetail { get => (this._loadBalancerDetail = this._loadBalancerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetails()); set { {_loadBalancerDetail = value;} } }

        /// <summary>Internal Acessors for LoadBalancerDetailId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id = value ?? null; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.Subnet { get => this._subnet; set { {_subnet = value;} } }

        /// <summary>Internal Acessors for VMDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapApplicationServerPropertiesInternal.VMDetail { get => this._vMDetail; set { {_vMDetail = value;} } }

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

        /// <summary>Application server Subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Subnet { get => this._subnet; }

        /// <summary>Backing field for <see cref="VMDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> _vMDetail;

        /// <summary>The list of virtual machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> VMDetail { get => this._vMDetail; }

        /// <summary>Creates an new <see cref="SapApplicationServerProperties" /> instance.</summary>
        public SapApplicationServerProperties()
        {

        }
    }
    /// Defines the SAP Application Server instance properties.
    public partial interface ISapApplicationServerProperties :
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
    /// Defines the SAP Application Server instance properties.
    internal partial interface ISapApplicationServerPropertiesInternal

    {
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
        /// <summary>Defines the provisioning states.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Defines the SAP Instance status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get; set; }
        /// <summary>Application server Subnet.</summary>
        string Subnet { get; set; }
        /// <summary>The list of virtual machines.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails> VMDetail { get; set; }

    }
}