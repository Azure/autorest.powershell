// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>
    /// Object that includes all the possible response for the evidence file download operation.
    /// </summary>
    public partial class EvidenceFileDownloadResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseInternal
    {

        /// <summary>Backing field for <see cref="EvidenceFile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFile _evidenceFile;

        /// <summary>The uri of evidence file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFile EvidenceFile { get => (this._evidenceFile = this._evidenceFile ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.EvidenceFileDownloadResponseEvidenceFile()); }

        /// <summary>The url of evidence file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string EvidenceFileUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFileInternal)EvidenceFile).Url; }

        /// <summary>Internal Acessors for EvidenceFile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFile Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseInternal.EvidenceFile { get => (this._evidenceFile = this._evidenceFile ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.EvidenceFileDownloadResponseEvidenceFile()); set { {_evidenceFile = value;} } }

        /// <summary>Internal Acessors for EvidenceFileUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseInternal.EvidenceFileUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFileInternal)EvidenceFile).Url; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFileInternal)EvidenceFile).Url = value ?? null; }

        /// <summary>Creates an new <see cref="EvidenceFileDownloadResponse" /> instance.</summary>
        public EvidenceFileDownloadResponse()
        {

        }
    }
    /// Object that includes all the possible response for the evidence file download operation.
    public partial interface IEvidenceFileDownloadResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The url of evidence file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The url of evidence file",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string EvidenceFileUrl { get;  }

    }
    /// Object that includes all the possible response for the evidence file download operation.
    internal partial interface IEvidenceFileDownloadResponseInternal

    {
        /// <summary>The uri of evidence file</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFile EvidenceFile { get; set; }
        /// <summary>The url of evidence file</summary>
        string EvidenceFileUrl { get; set; }

    }
}