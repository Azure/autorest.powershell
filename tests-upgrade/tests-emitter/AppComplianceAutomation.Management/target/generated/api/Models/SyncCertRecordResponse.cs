// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Synchronize certification record response.</summary>
    public partial class SyncCertRecordResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISyncCertRecordResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISyncCertRecordResponseInternal
    {

        /// <summary>Backing field for <see cref="CertRecord" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord _certRecord;

        /// <summary>certification record synchronized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord CertRecord { get => (this._certRecord = this._certRecord ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.CertSyncRecord()); set => this._certRecord = value; }

        /// <summary>Indicates the status of certification process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string CertRecordCertificationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).CertificationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).CertificationStatus = value ?? null; }

        /// <summary>The control records list to be synchronized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> CertRecordControl { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).Control; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).Control = value ?? null /* arrayOf */; }

        /// <summary>Indicates the status of compliance process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string CertRecordIngestionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).IngestionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).IngestionStatus = value ?? null; }

        /// <summary>The offerGuid which mapping to the reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string CertRecordOfferGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).OfferGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal)CertRecord).OfferGuid = value ?? null; }

        /// <summary>Internal Acessors for CertRecord</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISyncCertRecordResponseInternal.CertRecord { get => (this._certRecord = this._certRecord ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.CertSyncRecord()); set { {_certRecord = value;} } }

        /// <summary>Creates an new <see cref="SyncCertRecordResponse" /> instance.</summary>
        public SyncCertRecordResponse()
        {

        }
    }
    /// Synchronize certification record response.
    public partial interface ISyncCertRecordResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the status of certification process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the status of certification process.",
        SerializedName = @"certificationStatus",
        PossibleTypes = new [] { typeof(string) })]
        string CertRecordCertificationStatus { get; set; }
        /// <summary>The control records list to be synchronized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The control records list to be synchronized.",
        SerializedName = @"controls",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> CertRecordControl { get; set; }
        /// <summary>Indicates the status of compliance process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the status of compliance process.",
        SerializedName = @"ingestionStatus",
        PossibleTypes = new [] { typeof(string) })]
        string CertRecordIngestionStatus { get; set; }
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
        string CertRecordOfferGuid { get; set; }

    }
    /// Synchronize certification record response.
    internal partial interface ISyncCertRecordResponseInternal

    {
        /// <summary>certification record synchronized.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord CertRecord { get; set; }
        /// <summary>Indicates the status of certification process.</summary>
        string CertRecordCertificationStatus { get; set; }
        /// <summary>The control records list to be synchronized.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> CertRecordControl { get; set; }
        /// <summary>Indicates the status of compliance process.</summary>
        string CertRecordIngestionStatus { get; set; }
        /// <summary>The offerGuid which mapping to the reports.</summary>
        string CertRecordOfferGuid { get; set; }

    }
}