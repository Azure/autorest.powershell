// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The overview of the compliance result for one report.</summary>
    public partial class OverviewStatus :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal
    {

        /// <summary>Backing field for <see cref="FailedCount" /> property.</summary>
        private int? _failedCount;

        /// <summary>The count of all failed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? FailedCount { get => this._failedCount; }

        /// <summary>Backing field for <see cref="ManualCount" /> property.</summary>
        private int? _manualCount;

        /// <summary>The count of all manual control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? ManualCount { get => this._manualCount; }

        /// <summary>Internal Acessors for FailedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal.FailedCount { get => this._failedCount; set { {_failedCount = value;} } }

        /// <summary>Internal Acessors for ManualCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal.ManualCount { get => this._manualCount; set { {_manualCount = value;} } }

        /// <summary>Internal Acessors for NotApplicableCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal.NotApplicableCount { get => this._notApplicableCount; set { {_notApplicableCount = value;} } }

        /// <summary>Internal Acessors for PassedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal.PassedCount { get => this._passedCount; set { {_passedCount = value;} } }

        /// <summary>Internal Acessors for PendingCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatusInternal.PendingCount { get => this._pendingCount; set { {_pendingCount = value;} } }

        /// <summary>Backing field for <see cref="NotApplicableCount" /> property.</summary>
        private int? _notApplicableCount;

        /// <summary>The count of all not applicable control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? NotApplicableCount { get => this._notApplicableCount; }

        /// <summary>Backing field for <see cref="PassedCount" /> property.</summary>
        private int? _passedCount;

        /// <summary>The count of all passed control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? PassedCount { get => this._passedCount; }

        /// <summary>Backing field for <see cref="PendingCount" /> property.</summary>
        private int? _pendingCount;

        /// <summary>The count of all pending for approval control.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? PendingCount { get => this._pendingCount; }

        /// <summary>Creates an new <see cref="OverviewStatus" /> instance.</summary>
        public OverviewStatus()
        {

        }
    }
    /// The overview of the compliance result for one report.
    public partial interface IOverviewStatus :
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
        int? FailedCount { get;  }
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
        int? ManualCount { get;  }
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
        int? NotApplicableCount { get;  }
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
        int? PassedCount { get;  }
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
        int? PendingCount { get;  }

    }
    /// The overview of the compliance result for one report.
    internal partial interface IOverviewStatusInternal

    {
        /// <summary>The count of all failed control.</summary>
        int? FailedCount { get; set; }
        /// <summary>The count of all manual control.</summary>
        int? ManualCount { get; set; }
        /// <summary>The count of all not applicable control.</summary>
        int? NotApplicableCount { get; set; }
        /// <summary>The count of all passed control.</summary>
        int? PassedCount { get; set; }
        /// <summary>The count of all pending for approval control.</summary>
        int? PendingCount { get; set; }

    }
}