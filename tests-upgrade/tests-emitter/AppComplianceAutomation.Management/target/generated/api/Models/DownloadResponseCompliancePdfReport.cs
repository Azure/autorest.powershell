// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Compliance pdf report</summary>
    public partial class DownloadResponseCompliancePdfReport :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReportInternal
    {

        /// <summary>Internal Acessors for SasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReportInternal.SasUri { get => this._sasUri; set { {_sasUri = value;} } }

        /// <summary>Backing field for <see cref="SasUri" /> property.</summary>
        private string _sasUri;

        /// <summary>The uri of compliance pdf report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string SasUri { get => this._sasUri; }

        /// <summary>Creates an new <see cref="DownloadResponseCompliancePdfReport" /> instance.</summary>
        public DownloadResponseCompliancePdfReport()
        {

        }
    }
    /// Compliance pdf report
    public partial interface IDownloadResponseCompliancePdfReport :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
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
        string SasUri { get;  }

    }
    /// Compliance pdf report
    internal partial interface IDownloadResponseCompliancePdfReportInternal

    {
        /// <summary>The uri of compliance pdf report</summary>
        string SasUri { get; set; }

    }
}