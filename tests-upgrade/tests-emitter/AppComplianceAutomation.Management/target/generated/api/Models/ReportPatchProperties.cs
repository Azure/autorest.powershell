// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Patch Report's properties.</summary>
    public partial class ReportPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CertRecord" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> _certRecord;

        /// <summary>List of synchronized certification records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> CertRecord { get => this._certRecord; }

        /// <summary>Backing field for <see cref="ComplianceStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus _complianceStatus;

        /// <summary>Report compliance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus ComplianceStatus { get => (this._complianceStatus = this._complianceStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportComplianceStatus()); }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private System.Collections.Generic.List<string> _error;

        /// <summary>List of report error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Error { get => this._error; }

        /// <summary>Backing field for <see cref="LastTriggerTime" /> property.</summary>
        private global::System.DateTime? _lastTriggerTime;

        /// <summary>Report last collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? LastTriggerTime { get => this._lastTriggerTime; }

        /// <summary>The count of all failed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365FailedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365FailedCount; }

        /// <summary>The count of all manual control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365ManualCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365ManualCount; }

        /// <summary>The count of all not applicable control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365NotApplicableCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365NotApplicableCount; }

        /// <summary>The count of all passed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365PassedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365PassedCount; }

        /// <summary>The count of all pending for approval control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365PendingCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365PendingCount; }

        /// <summary>Internal Acessors for CertRecord</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.CertRecord { get => this._certRecord; set { {_certRecord = value;} } }

        /// <summary>Internal Acessors for ComplianceStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.ComplianceStatus { get => (this._complianceStatus = this._complianceStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportComplianceStatus()); set { {_complianceStatus = value;} } }

        /// <summary>Internal Acessors for ComplianceStatusM365</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.ComplianceStatusM365 { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365 = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Error</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.Error { get => this._error; set { {_error = value;} } }

        /// <summary>Internal Acessors for LastTriggerTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.LastTriggerTime { get => this._lastTriggerTime; set { {_lastTriggerTime = value;} } }

        /// <summary>Internal Acessors for M365FailedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.M365FailedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365FailedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365FailedCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365ManualCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.M365ManualCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365ManualCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365ManualCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365NotApplicableCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.M365NotApplicableCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365NotApplicableCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365NotApplicableCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365PassedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.M365PassedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365PassedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365PassedCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365PendingCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.M365PendingCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365PendingCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal)ComplianceStatus).M365PendingCount = value ?? default(int); }

        /// <summary>Internal Acessors for NextTriggerTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.NextTriggerTime { get => this._nextTriggerTime; set { {_nextTriggerTime = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for StorageInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.StorageInfo { get => (this._storageInfo = this._storageInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.StorageInfo()); set { {_storageInfo = value;} } }

        /// <summary>Internal Acessors for Subscription</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.Subscription { get => this._subscription; set { {_subscription = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="NextTriggerTime" /> property.</summary>
        private global::System.DateTime? _nextTriggerTime;

        /// <summary>Report next collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? NextTriggerTime { get => this._nextTriggerTime; }

        /// <summary>Backing field for <see cref="OfferGuid" /> property.</summary>
        private string _offerGuid;

        /// <summary>
        /// A list of comma-separated offerGuids indicates a series of offerGuids that map to the report. For example, "00000000-0000-0000-0000-000000000001,00000000-0000-0000-0000-000000000002"
        /// and "00000000-0000-0000-0000-000000000003".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string OfferGuid { get => this._offerGuid; set => this._offerGuid = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata> _resource;

        /// <summary>List of resource data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata> Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Report status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="StorageInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo _storageInfo;

        /// <summary>The information of 'bring your own storage' binding to the report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo StorageInfo { get => (this._storageInfo = this._storageInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.StorageInfo()); set => this._storageInfo = value; }

        /// <summary>'bring your own storage' account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).AccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).AccountName = value ?? null; }

        /// <summary>The region of 'bring your own storage' account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).Location = value ?? null; }

        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).ResourceGroup = value ?? null; }

        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal)StorageInfo).SubscriptionId = value ?? null; }

        /// <summary>Backing field for <see cref="Subscription" /> property.</summary>
        private System.Collections.Generic.List<string> _subscription;

        /// <summary>List of subscription Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Subscription { get => this._subscription; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Report's tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable"
        /// in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Backing field for <see cref="TriggerTime" /> property.</summary>
        private global::System.DateTime? _triggerTime;

        /// <summary>Report collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? TriggerTime { get => this._triggerTime; set => this._triggerTime = value; }

        /// <summary>Creates an new <see cref="ReportPatchProperties" /> instance.</summary>
        public ReportPatchProperties()
        {

        }
    }
    /// Patch Report's properties.
    public partial interface IReportPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of synchronized certification records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of synchronized certification records.",
        SerializedName = @"certRecords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> CertRecord { get;  }
        /// <summary>List of report error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of report error codes.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Error { get;  }
        /// <summary>Report last collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Report last collection trigger time.",
        SerializedName = @"lastTriggerTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastTriggerTime { get;  }
        /// <summary>The count of all failed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The count of all failed control.",
        SerializedName = @"failedCount",
        PossibleTypes = new [] { typeof(int) })]
        int? M365FailedCount { get;  }
        /// <summary>The count of all manual control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The count of all manual control.",
        SerializedName = @"manualCount",
        PossibleTypes = new [] { typeof(int) })]
        int? M365ManualCount { get;  }
        /// <summary>The count of all not applicable control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The count of all not applicable control.",
        SerializedName = @"notApplicableCount",
        PossibleTypes = new [] { typeof(int) })]
        int? M365NotApplicableCount { get;  }
        /// <summary>The count of all passed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The count of all passed control.",
        SerializedName = @"passedCount",
        PossibleTypes = new [] { typeof(int) })]
        int? M365PassedCount { get;  }
        /// <summary>The count of all pending for approval control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The count of all pending for approval control.",
        SerializedName = @"pendingCount",
        PossibleTypes = new [] { typeof(int) })]
        int? M365PendingCount { get;  }
        /// <summary>Report next collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Report next collection trigger time.",
        SerializedName = @"nextTriggerTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NextTriggerTime { get;  }
        /// <summary>
        /// A list of comma-separated offerGuids indicates a series of offerGuids that map to the report. For example, "00000000-0000-0000-0000-000000000001,00000000-0000-0000-0000-000000000002"
        /// and "00000000-0000-0000-0000-000000000003".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of comma-separated offerGuids indicates a series of offerGuids that map to the report. For example, ""00000000-0000-0000-0000-000000000001,00000000-0000-0000-0000-000000000002"" and ""00000000-0000-0000-0000-000000000003"".",
        SerializedName = @"offerGuid",
        PossibleTypes = new [] { typeof(string) })]
        string OfferGuid { get; set; }
        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure lifecycle management",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>List of resource data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of resource data.",
        SerializedName = @"resources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata> Resource { get; set; }
        /// <summary>Report status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Report status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Active", "Failed", "Reviewing", "Disabled")]
        string Status { get;  }
        /// <summary>'bring your own storage' account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"'bring your own storage' account name",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageInfoAccountName { get; set; }
        /// <summary>The region of 'bring your own storage' account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The region of 'bring your own storage' account",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string StorageInfoLocation { get; set; }
        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resourceGroup which 'bring your own storage' account belongs to",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string StorageInfoResourceGroup { get; set; }
        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subscription id which 'bring your own storage' account belongs to",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageInfoSubscriptionId { get; set; }
        /// <summary>List of subscription Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of subscription Ids.",
        SerializedName = @"subscriptions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Subscription { get;  }
        /// <summary>Report's tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Report's tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable"
        /// in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Report collection trigger time's time zone, the available list can be obtained by executing ""Get-TimeZone -ListAvailable"" in PowerShell.
        An example of valid timezone id is ""Pacific Standard Time"".",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }
        /// <summary>Report collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Report collection trigger time.",
        SerializedName = @"triggerTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TriggerTime { get; set; }

    }
    /// Patch Report's properties.
    internal partial interface IReportPatchPropertiesInternal

    {
        /// <summary>List of synchronized certification records.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> CertRecord { get; set; }
        /// <summary>Report compliance status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus ComplianceStatus { get; set; }
        /// <summary>The Microsoft 365 certification name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus ComplianceStatusM365 { get; set; }
        /// <summary>List of report error codes.</summary>
        System.Collections.Generic.List<string> Error { get; set; }
        /// <summary>Report last collection trigger time.</summary>
        global::System.DateTime? LastTriggerTime { get; set; }
        /// <summary>The count of all failed control.</summary>
        int? M365FailedCount { get; set; }
        /// <summary>The count of all manual control.</summary>
        int? M365ManualCount { get; set; }
        /// <summary>The count of all not applicable control.</summary>
        int? M365NotApplicableCount { get; set; }
        /// <summary>The count of all passed control.</summary>
        int? M365PassedCount { get; set; }
        /// <summary>The count of all pending for approval control.</summary>
        int? M365PendingCount { get; set; }
        /// <summary>Report next collection trigger time.</summary>
        global::System.DateTime? NextTriggerTime { get; set; }
        /// <summary>
        /// A list of comma-separated offerGuids indicates a series of offerGuids that map to the report. For example, "00000000-0000-0000-0000-000000000001,00000000-0000-0000-0000-000000000002"
        /// and "00000000-0000-0000-0000-000000000003".
        /// </summary>
        string OfferGuid { get; set; }
        /// <summary>Azure lifecycle management</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>List of resource data.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata> Resource { get; set; }
        /// <summary>Report status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Active", "Failed", "Reviewing", "Disabled")]
        string Status { get; set; }
        /// <summary>The information of 'bring your own storage' binding to the report</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo StorageInfo { get; set; }
        /// <summary>'bring your own storage' account name</summary>
        string StorageInfoAccountName { get; set; }
        /// <summary>The region of 'bring your own storage' account</summary>
        string StorageInfoLocation { get; set; }
        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        string StorageInfoResourceGroup { get; set; }
        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        string StorageInfoSubscriptionId { get; set; }
        /// <summary>List of subscription Ids.</summary>
        System.Collections.Generic.List<string> Subscription { get; set; }
        /// <summary>Report's tenant id.</summary>
        string TenantId { get; set; }
        /// <summary>
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable"
        /// in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </summary>
        string TimeZone { get; set; }
        /// <summary>Report collection trigger time.</summary>
        global::System.DateTime? TriggerTime { get; set; }

    }
}