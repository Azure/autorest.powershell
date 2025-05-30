// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent a AppComplianceAutomation report resource update properties.</summary>
    public partial class ReportResourcePatch :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatch,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal
    {

        /// <summary>List of synchronized certification records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> CertRecord { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).CertRecord; }

        /// <summary>List of report error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Error; }

        /// <summary>Report last collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastTriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).LastTriggerTime; }

        /// <summary>The count of all failed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365FailedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365FailedCount; }

        /// <summary>The count of all manual control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365ManualCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365ManualCount; }

        /// <summary>The count of all not applicable control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365NotApplicableCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365NotApplicableCount; }

        /// <summary>The count of all passed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365PassedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365PassedCount; }

        /// <summary>The count of all pending for approval control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365PendingCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365PendingCount; }

        /// <summary>Internal Acessors for CertRecord</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.CertRecord { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).CertRecord; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).CertRecord = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ComplianceStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.ComplianceStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ComplianceStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ComplianceStatus = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ComplianceStatusM365</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.ComplianceStatusM365 { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ComplianceStatusM365; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ComplianceStatusM365 = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Error</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Error = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.LastTriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).LastTriggerTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).LastTriggerTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for M365FailedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.M365FailedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365FailedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365FailedCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365ManualCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.M365ManualCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365ManualCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365ManualCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365NotApplicableCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.M365NotApplicableCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365NotApplicableCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365NotApplicableCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365PassedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.M365PassedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365PassedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365PassedCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365PendingCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.M365PendingCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365PendingCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).M365PendingCount = value ?? default(int); }

        /// <summary>Internal Acessors for NextTriggerTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.NextTriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).NextTriggerTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).NextTriggerTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPatchProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Internal Acessors for StorageInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.StorageInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Subscription</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.Subscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Subscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Subscription = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportResourcePatchInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TenantId = value ?? null; }

        /// <summary>Report next collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? NextTriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).NextTriggerTime; }

        /// <summary>
        /// A list of comma-separated offerGuids indicates a series of offerGuids that map to the report. For example, "00000000-0000-0000-0000-000000000001,00000000-0000-0000-0000-000000000002"
        /// and "00000000-0000-0000-0000-000000000003".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string OfferGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).OfferGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).OfferGuid = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties _property;

        /// <summary>Report property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPatchProperties()); set => this._property = value; }

        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).ProvisioningState; }

        /// <summary>List of resource data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata> Resource { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Resource = value ?? null /* arrayOf */; }

        /// <summary>Report status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Status; }

        /// <summary>'bring your own storage' account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoAccountName = value ?? null; }

        /// <summary>The region of 'bring your own storage' account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoLocation = value ?? null; }

        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoResourceGroup = value ?? null; }

        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string StorageInfoSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).StorageInfoSubscriptionId = value ?? null; }

        /// <summary>List of subscription Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Subscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).Subscription; }

        /// <summary>Report's tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TenantId; }

        /// <summary>
        /// Report collection trigger time's time zone, the available list can be obtained by executing "Get-TimeZone -ListAvailable"
        /// in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string TimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TimeZone = value ?? null; }

        /// <summary>Report collection trigger time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? TriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TriggerTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)Property).TriggerTime = value ?? default(global::System.DateTime); }

        /// <summary>Creates an new <see cref="ReportResourcePatch" /> instance.</summary>
        public ReportResourcePatch()
        {

        }
    }
    /// A class represent a AppComplianceAutomation report resource update properties.
    public partial interface IReportResourcePatch :
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
    /// A class represent a AppComplianceAutomation report resource update properties.
    internal partial interface IReportResourcePatchInternal

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
        /// <summary>Report property.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties Property { get; set; }
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