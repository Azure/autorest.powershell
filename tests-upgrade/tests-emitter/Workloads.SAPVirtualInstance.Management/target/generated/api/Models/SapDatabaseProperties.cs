// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the Database properties.</summary>
    public partial class SapDatabaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; }

        /// <summary>Backing field for <see cref="DatabaseSid" /> property.</summary>
        private string _databaseSid;

        /// <summary>Database SID name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DatabaseSid { get => this._databaseSid; }

        /// <summary>Backing field for <see cref="DatabaseType" /> property.</summary>
        private string _databaseType;

        /// <summary>
        /// Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DatabaseType { get => this._databaseType; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError _error;

        /// <summary>Defines the errors related to Database resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>Database IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="LoadBalancerDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails _loadBalancerDetail;

        /// <summary>
        /// The Load Balancer details such as LoadBalancer ID attached to Database Virtual Machines
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
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code = value; }

        /// <summary>Internal Acessors for DatabaseSid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.DatabaseSid { get => this._databaseSid; set { {_databaseSid = value;} } }

        /// <summary>Internal Acessors for DatabaseType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.DatabaseType { get => this._databaseType; set { {_databaseType = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.ErrorProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property = value; }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for LoadBalancerDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.LoadBalancerDetail { get => (this._loadBalancerDetail = this._loadBalancerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetails()); set { {_loadBalancerDetail = value;} } }

        /// <summary>Internal Acessors for LoadBalancerDetailId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.LoadBalancerDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal)LoadBalancerDetail).Id = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.Subnet { get => this._subnet; set { {_subnet = value;} } }

        /// <summary>Internal Acessors for VMDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal.VMDetail { get => this._vMDetail; set { {_vMDetail = value;} } }

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

        /// <summary>Database subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Subnet { get => this._subnet; }

        /// <summary>Backing field for <see cref="VMDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails> _vMDetail;

        /// <summary>The list of virtual machines corresponding to the Database resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails> VMDetail { get => this._vMDetail; }

        /// <summary>Creates an new <see cref="SapDatabaseProperties" /> instance.</summary>
        public SapDatabaseProperties()
        {

        }
    }
    /// Defines the Database properties.
    public partial interface ISapDatabaseProperties :
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
        /// <summary>Database SID name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Database SID name.",
        SerializedName = @"databaseSid",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseSid { get;  }
        /// <summary>
        /// Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server.",
        SerializedName = @"databaseType",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseType { get;  }
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
        /// <summary>Database IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Database IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get;  }
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
        /// <summary>Database subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Database subnet.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string Subnet { get;  }
        /// <summary>The list of virtual machines corresponding to the Database resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of virtual machines corresponding to the Database resource.",
        SerializedName = @"vmDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails> VMDetail { get;  }

    }
    /// Defines the Database properties.
    internal partial interface ISapDatabasePropertiesInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Database SID name.</summary>
        string DatabaseSid { get; set; }
        /// <summary>
        /// Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server.
        /// </summary>
        string DatabaseType { get; set; }
        /// <summary>Internal error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get; set; }
        /// <summary>Defines the errors related to Database resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get; set; }
        /// <summary>The Virtual Instance for SAP error body.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition ErrorProperty { get; set; }
        /// <summary>Database IP Address.</summary>
        string IPAddress { get; set; }
        /// <summary>
        /// The Load Balancer details such as LoadBalancer ID attached to Database Virtual Machines
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
        /// <summary>Database subnet.</summary>
        string Subnet { get; set; }
        /// <summary>The list of virtual machines corresponding to the Database resource.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails> VMDetail { get; set; }

    }
}