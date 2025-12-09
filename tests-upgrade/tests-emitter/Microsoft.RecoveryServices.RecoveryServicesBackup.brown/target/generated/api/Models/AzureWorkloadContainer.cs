// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Container for the workloads running inside Azure Compute or Classic Compute.</summary>
    public partial class AzureWorkloadContainer :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainer,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainer"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainer __protectionContainer = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ProtectionContainer();

        /// <summary>Type of backup management for the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).BackupManagementType = value ?? null; }

        /// <summary>
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ContainerType { get => "AzureWorkloadContainer"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).ContainerType = "AzureWorkloadContainer"; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailCode; }

        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailMessage; }

        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailRecommendation; }

        /// <summary>Backing field for <see cref="ExtendedInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfo _extendedInfo;

        /// <summary>Additional details of a workload container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfo ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadContainerExtendedInfo()); set => this._extendedInfo = value; }

        /// <summary>
        /// Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoHostServerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).HostServerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).HostServerName = value ?? null; }

        /// <summary>List of the nodes in case of distributed container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> ExtendedInfoNodesList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).NodesList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).NodesList = value ?? null /* arrayOf */; }

        /// <summary>Friendly name of the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).FriendlyName = value ?? null; }

        /// <summary>Status of health of the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).HealthStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).HealthStatus = value ?? null; }

        /// <summary>
        /// Inquiry Details which will have workload specific details.
        /// For e.g. - For SQL and oracle this will contain different details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetails> InquiryInfoInquiryDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfoInquiryDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfoInquiryDetail = value ?? null /* arrayOf */; }

        /// <summary>
        /// Inquiry Status for this container such as
        /// InProgress | Failed | Succeeded
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string InquiryInfoStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfoStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfoStatus = value ?? null; }

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private global::System.DateTime? _lastUpdatedTime;

        /// <summary>Time stamp when this container was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdatedTime { get => this._lastUpdatedTime; set => this._lastUpdatedTime = value; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailRecommendation</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal.ErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailRecommendation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).ErrorDetailRecommendation = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal.ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadContainerExtendedInfo()); set { {_extendedInfo = value;} } }

        /// <summary>Internal Acessors for ExtendedInfoInquiryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal.ExtendedInfoInquiryInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for InquiryInfoErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerInternal.InquiryInfoErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfoErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal)ExtendedInfo).InquiryInfoErrorDetail = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="OperationType" /> property.</summary>
        private string _operationType;

        /// <summary>Re-Do Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string OperationType { get => this._operationType; set => this._operationType = value; }

        /// <summary>Type of the protectable object associated with this container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ProtectableObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).ProtectableObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).ProtectableObjectType = value ?? null; }

        /// <summary>Status of registration of the container with the Recovery Services Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RegistrationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).RegistrationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)__protectionContainer).RegistrationStatus = value ?? null; }

        /// <summary>Backing field for <see cref="SourceResourceId" /> property.</summary>
        private string _sourceResourceId;

        /// <summary>ARM ID of the virtual machine represented by this Azure Workload Container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceResourceId { get => this._sourceResourceId; set => this._sourceResourceId = value; }

        /// <summary>Backing field for <see cref="WorkloadType" /> property.</summary>
        private string _workloadType;

        /// <summary>Workload type for which registration was sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string WorkloadType { get => this._workloadType; set => this._workloadType = value; }

        /// <summary>Creates an new <see cref="AzureWorkloadContainer" /> instance.</summary>
        public AzureWorkloadContainer()
        {
            this.__protectionContainer.ContainerType = "AzureWorkloadContainer";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectionContainer), __protectionContainer);
            await eventListener.AssertObjectIsValid(nameof(__protectionContainer), __protectionContainer);
        }
    }
    /// Container for the workloads running inside Azure Compute or Classic Compute.
    public partial interface IAzureWorkloadContainer :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainer
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get;  }
        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error Message related to the Code.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get;  }
        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of recommendation strings.",
        SerializedName = @"recommendations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ErrorDetailRecommendation { get;  }
        /// <summary>
        /// Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.",
        SerializedName = @"hostServerName",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoHostServerName { get; set; }
        /// <summary>List of the nodes in case of distributed container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of the nodes in case of distributed container.",
        SerializedName = @"nodesList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> ExtendedInfoNodesList { get; set; }
        /// <summary>
        /// Inquiry Details which will have workload specific details.
        /// For e.g. - For SQL and oracle this will contain different details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Inquiry Details which will have workload specific details.
        For e.g. - For SQL and oracle this will contain different details.",
        SerializedName = @"inquiryDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetails> InquiryInfoInquiryDetail { get; set; }
        /// <summary>
        /// Inquiry Status for this container such as
        /// InProgress | Failed | Succeeded
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Inquiry Status for this container such as
        InProgress | Failed | Succeeded",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string InquiryInfoStatus { get; set; }
        /// <summary>Time stamp when this container was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time stamp when this container was updated.",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdatedTime { get; set; }
        /// <summary>Re-Do Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Re-Do Operation",
        SerializedName = @"operationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Register", "Reregister", "Rehydrate")]
        string OperationType { get; set; }
        /// <summary>ARM ID of the virtual machine represented by this Azure Workload Container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM ID of the virtual machine represented by this Azure Workload Container",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceId { get; set; }
        /// <summary>Workload type for which registration was sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workload type for which registration was sent.",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkloadType { get; set; }

    }
    /// Container for the workloads running inside Azure Compute or Classic Compute.
    internal partial interface IAzureWorkloadContainerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal
    {
        /// <summary>Error code.</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Error Message related to the Code.</summary>
        string ErrorDetailMessage { get; set; }
        /// <summary>List of recommendation strings.</summary>
        System.Collections.Generic.List<string> ErrorDetailRecommendation { get; set; }
        /// <summary>Additional details of a workload container.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfo ExtendedInfo { get; set; }
        /// <summary>
        /// Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.
        /// </summary>
        string ExtendedInfoHostServerName { get; set; }
        /// <summary>Inquiry Status for the container.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfo ExtendedInfoInquiryInfo { get; set; }
        /// <summary>List of the nodes in case of distributed container.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> ExtendedInfoNodesList { get; set; }
        /// <summary>Error Details if the Status is non-success.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 InquiryInfoErrorDetail { get; set; }
        /// <summary>
        /// Inquiry Details which will have workload specific details.
        /// For e.g. - For SQL and oracle this will contain different details.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetails> InquiryInfoInquiryDetail { get; set; }
        /// <summary>
        /// Inquiry Status for this container such as
        /// InProgress | Failed | Succeeded
        /// </summary>
        string InquiryInfoStatus { get; set; }
        /// <summary>Time stamp when this container was updated.</summary>
        global::System.DateTime? LastUpdatedTime { get; set; }
        /// <summary>Re-Do Operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Register", "Reregister", "Rehydrate")]
        string OperationType { get; set; }
        /// <summary>ARM ID of the virtual machine represented by this Azure Workload Container</summary>
        string SourceResourceId { get; set; }
        /// <summary>Workload type for which registration was sent.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkloadType { get; set; }

    }
}