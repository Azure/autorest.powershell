// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Object that includes all the possible response for the download operation.</summary>
    public partial class DownloadResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal
    {

        /// <summary>Backing field for <see cref="ComplianceDetailedPdfReport" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReport _complianceDetailedPdfReport;

        /// <summary>The detailed compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReport ComplianceDetailedPdfReport { get => (this._complianceDetailedPdfReport = this._complianceDetailedPdfReport ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseComplianceDetailedPdfReport()); }

        /// <summary>The uri of detailed compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ComplianceDetailedPdfReportSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReportInternal)ComplianceDetailedPdfReport).SasUri; }

        /// <summary>Backing field for <see cref="CompliancePdfReport" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport _compliancePdfReport;

        /// <summary>Compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport CompliancePdfReport { get => (this._compliancePdfReport = this._compliancePdfReport ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseCompliancePdfReport()); }

        /// <summary>The uri of compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string CompliancePdfReportSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReportInternal)CompliancePdfReport).SasUri; }

        /// <summary>Backing field for <see cref="ComplianceReport" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem> _complianceReport;

        /// <summary>List of the compliance result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem> ComplianceReport { get => this._complianceReport; }

        /// <summary>Internal Acessors for ComplianceDetailedPdfReport</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReport Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal.ComplianceDetailedPdfReport { get => (this._complianceDetailedPdfReport = this._complianceDetailedPdfReport ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseComplianceDetailedPdfReport()); set { {_complianceDetailedPdfReport = value;} } }

        /// <summary>Internal Acessors for ComplianceDetailedPdfReportSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal.ComplianceDetailedPdfReportSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReportInternal)ComplianceDetailedPdfReport).SasUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReportInternal)ComplianceDetailedPdfReport).SasUri = value ?? null; }

        /// <summary>Internal Acessors for CompliancePdfReport</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal.CompliancePdfReport { get => (this._compliancePdfReport = this._compliancePdfReport ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseCompliancePdfReport()); set { {_compliancePdfReport = value;} } }

        /// <summary>Internal Acessors for CompliancePdfReportSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal.CompliancePdfReportSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReportInternal)CompliancePdfReport).SasUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReportInternal)CompliancePdfReport).SasUri = value ?? null; }

        /// <summary>Internal Acessors for ComplianceReport</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal.ComplianceReport { get => this._complianceReport; set { {_complianceReport = value;} } }

        /// <summary>Internal Acessors for ResourceList</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal.ResourceList { get => this._resourceList; set { {_resourceList = value;} } }

        /// <summary>Backing field for <see cref="ResourceList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem> _resourceList;

        /// <summary>Resource list of the report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem> ResourceList { get => this._resourceList; }

        /// <summary>Creates an new <see cref="DownloadResponse" /> instance.</summary>
        public DownloadResponse()
        {

        }
    }
    /// Object that includes all the possible response for the download operation.
    public partial interface IDownloadResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The uri of detailed compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The uri of detailed compliance pdf report",
        SerializedName = @"sasUri",
        PossibleTypes = new [] { typeof(string) })]
        string ComplianceDetailedPdfReportSasUri { get;  }
        /// <summary>The uri of compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The uri of compliance pdf report",
        SerializedName = @"sasUri",
        PossibleTypes = new [] { typeof(string) })]
        string CompliancePdfReportSasUri { get;  }
        /// <summary>List of the compliance result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of the compliance result",
        SerializedName = @"complianceReport",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem> ComplianceReport { get;  }
        /// <summary>Resource list of the report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource list of the report",
        SerializedName = @"resourceList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem> ResourceList { get;  }

    }
    /// Object that includes all the possible response for the download operation.
    internal partial interface IDownloadResponseInternal

    {
        /// <summary>The detailed compliance pdf report</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReport ComplianceDetailedPdfReport { get; set; }
        /// <summary>The uri of detailed compliance pdf report</summary>
        string ComplianceDetailedPdfReportSasUri { get; set; }
        /// <summary>Compliance pdf report</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport CompliancePdfReport { get; set; }
        /// <summary>The uri of compliance pdf report</summary>
        string CompliancePdfReportSasUri { get; set; }
        /// <summary>List of the compliance result</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem> ComplianceReport { get; set; }
        /// <summary>Resource list of the report</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem> ResourceList { get; set; }

    }
}