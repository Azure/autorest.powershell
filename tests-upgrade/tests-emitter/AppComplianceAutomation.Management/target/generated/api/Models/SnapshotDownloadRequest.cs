// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Snapshot's download request.</summary>
    public partial class SnapshotDownloadRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotDownloadRequest,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotDownloadRequestInternal
    {

        /// <summary>Backing field for <see cref="DownloadType" /> property.</summary>
        private string _downloadType;

        /// <summary>Indicates the download type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string DownloadType { get => this._downloadType; set => this._downloadType = value; }

        /// <summary>Backing field for <see cref="OfferGuid" /> property.</summary>
        private string _offerGuid;

        /// <summary>The offerGuid which mapping to the reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string OfferGuid { get => this._offerGuid; set => this._offerGuid = value; }

        /// <summary>Backing field for <see cref="ReportCreatorTenantId" /> property.</summary>
        private string _reportCreatorTenantId;

        /// <summary>Tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ReportCreatorTenantId { get => this._reportCreatorTenantId; set => this._reportCreatorTenantId = value; }

        /// <summary>Creates an new <see cref="SnapshotDownloadRequest" /> instance.</summary>
        public SnapshotDownloadRequest()
        {

        }
    }
    /// Snapshot's download request.
    public partial interface ISnapshotDownloadRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the download type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the download type.",
        SerializedName = @"downloadType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("ComplianceReport", "CompliancePdfReport", "ComplianceDetailedPdfReport", "ResourceList")]
        string DownloadType { get; set; }
        /// <summary>The offerGuid which mapping to the reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The offerGuid which mapping to the reports.",
        SerializedName = @"offerGuid",
        PossibleTypes = new [] { typeof(string) })]
        string OfferGuid { get; set; }
        /// <summary>Tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant id.",
        SerializedName = @"reportCreatorTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ReportCreatorTenantId { get; set; }

    }
    /// Snapshot's download request.
    internal partial interface ISnapshotDownloadRequestInternal

    {
        /// <summary>Indicates the download type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("ComplianceReport", "CompliancePdfReport", "ComplianceDetailedPdfReport", "ResourceList")]
        string DownloadType { get; set; }
        /// <summary>The offerGuid which mapping to the reports.</summary>
        string OfferGuid { get; set; }
        /// <summary>Tenant id.</summary>
        string ReportCreatorTenantId { get; set; }

    }
}