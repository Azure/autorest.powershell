// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A list which includes all the compliance result for one report.</summary>
    public partial class ReportComplianceStatus :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal
    {

        /// <summary>Backing field for <see cref="M365" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus _m365;

        /// <summary>The Microsoft 365 certification name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus M365 { get => (this._m365 = this._m365 ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.OverviewStatus()); }

        /// <summary>The count of all failed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365FailedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).FailedCount; }

        /// <summary>The count of all manual control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365ManualCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).ManualCount; }

        /// <summary>The count of all not applicable control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365NotApplicableCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).NotApplicableCount; }

        /// <summary>The count of all passed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365PassedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).PassedCount; }

        /// <summary>The count of all pending for approval control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public int? M365PendingCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).PendingCount; }

        /// <summary>Internal Acessors for M365</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal.M365 { get => (this._m365 = this._m365 ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.OverviewStatus()); set { {_m365 = value;} } }

        /// <summary>Internal Acessors for M365FailedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal.M365FailedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).FailedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).FailedCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365ManualCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal.M365ManualCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).ManualCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).ManualCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365NotApplicableCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal.M365NotApplicableCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).NotApplicableCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).NotApplicableCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365PassedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal.M365PassedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).PassedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).PassedCount = value ?? default(int); }

        /// <summary>Internal Acessors for M365PendingCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatusInternal.M365PendingCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).PendingCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal)M365).PendingCount = value ?? default(int); }

        /// <summary>Creates an new <see cref="ReportComplianceStatus" /> instance.</summary>
        public ReportComplianceStatus()
        {

        }
    }
    /// A list which includes all the compliance result for one report.
    public partial interface IReportComplianceStatus :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
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

    }
    /// A list which includes all the compliance result for one report.
    internal partial interface IReportComplianceStatusInternal

    {
        /// <summary>The Microsoft 365 certification name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus M365 { get; set; }
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

    }
}