// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The uri of evidence file</summary>
    public partial class EvidenceFileDownloadResponseEvidenceFile :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFile,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFileInternal
    {

        /// <summary>Internal Acessors for Url</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponseEvidenceFileInternal.Url { get => this._url; set { {_url = value;} } }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>The url of evidence file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Url { get => this._url; }

        /// <summary>
        /// Creates an new <see cref="EvidenceFileDownloadResponseEvidenceFile" /> instance.
        /// </summary>
        public EvidenceFileDownloadResponseEvidenceFile()
        {

        }
    }
    /// The uri of evidence file
    public partial interface IEvidenceFileDownloadResponseEvidenceFile :
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
        string Url { get;  }

    }
    /// The uri of evidence file
    internal partial interface IEvidenceFileDownloadResponseEvidenceFileInternal

    {
        /// <summary>The url of evidence file</summary>
        string Url { get; set; }

    }
}