// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Evidence file's download request.</summary>
    public partial class EvidenceFileDownloadRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadRequest,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadRequestInternal
    {

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

        /// <summary>Creates an new <see cref="EvidenceFileDownloadRequest" /> instance.</summary>
        public EvidenceFileDownloadRequest()
        {

        }
    }
    /// Evidence file's download request.
    public partial interface IEvidenceFileDownloadRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
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
    /// Evidence file's download request.
    internal partial interface IEvidenceFileDownloadRequestInternal

    {
        /// <summary>The offerGuid which mapping to the reports.</summary>
        string OfferGuid { get; set; }
        /// <summary>Tenant id.</summary>
        string ReportCreatorTenantId { get; set; }

    }
}