// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Extended information of the container.</summary>
    public partial class AzureWorkloadContainerExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailCode; }

        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailMessage; }

        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailRecommendation; }

        /// <summary>Backing field for <see cref="HostServerName" /> property.</summary>
        private string _hostServerName;

        /// <summary>
        /// Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string HostServerName { get => this._hostServerName; set => this._hostServerName = value; }

        /// <summary>Backing field for <see cref="InquiryInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfo _inquiryInfo;

        /// <summary>Inquiry Status for the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfo InquiryInfo { get => (this._inquiryInfo = this._inquiryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InquiryInfo()); set => this._inquiryInfo = value; }

        /// <summary>
        /// Inquiry Details which will have workload specific details.
        /// For e.g. - For SQL and oracle this will contain different details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetails> InquiryInfoInquiryDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).InquiryDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).InquiryDetail = value ?? null /* arrayOf */; }

        /// <summary>
        /// Inquiry Status for this container such as
        /// InProgress | Failed | Succeeded
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string InquiryInfoStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).Status = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailRecommendation</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal.ErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailRecommendation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetailRecommendation = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for InquiryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal.InquiryInfo { get => (this._inquiryInfo = this._inquiryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InquiryInfo()); set { {_inquiryInfo = value;} } }

        /// <summary>Internal Acessors for InquiryInfoErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerExtendedInfoInternal.InquiryInfoErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfoInternal)InquiryInfo).ErrorDetail = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="NodesList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> _nodesList;

        /// <summary>List of the nodes in case of distributed container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> NodesList { get => this._nodesList; set => this._nodesList = value; }

        /// <summary>Creates an new <see cref="AzureWorkloadContainerExtendedInfo" /> instance.</summary>
        public AzureWorkloadContainerExtendedInfo()
        {

        }
    }
    /// Extended information of the container.
    public partial interface IAzureWorkloadContainerExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
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
        string HostServerName { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> NodesList { get; set; }

    }
    /// Extended information of the container.
    internal partial interface IAzureWorkloadContainerExtendedInfoInternal

    {
        /// <summary>Error code.</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Error Message related to the Code.</summary>
        string ErrorDetailMessage { get; set; }
        /// <summary>List of recommendation strings.</summary>
        System.Collections.Generic.List<string> ErrorDetailRecommendation { get; set; }
        /// <summary>
        /// Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.
        /// </summary>
        string HostServerName { get; set; }
        /// <summary>Inquiry Status for the container.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryInfo InquiryInfo { get; set; }
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
        /// <summary>List of the nodes in case of distributed container.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDistributedNodesInfo> NodesList { get; set; }

    }
}