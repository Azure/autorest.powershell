// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>High availability validation properties of a server</summary>
    public partial class HighAvailabilityValidationEstimation :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityValidationEstimation,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityValidationEstimationInternal
    {

        /// <summary>Backing field for <see cref="EstimatedDowntime" /> property.</summary>
        private int? _estimatedDowntime;

        /// <summary>Estimated seconds of downtime for the deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? EstimatedDowntime { get => this._estimatedDowntime; }

        /// <summary>Backing field for <see cref="ExpectedStandbyAvailabilityZone" /> property.</summary>
        private string _expectedStandbyAvailabilityZone;

        /// <summary>Expected Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ExpectedStandbyAvailabilityZone { get => this._expectedStandbyAvailabilityZone; set => this._expectedStandbyAvailabilityZone = value; }

        /// <summary>Internal Acessors for EstimatedDowntime</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityValidationEstimationInternal.EstimatedDowntime { get => this._estimatedDowntime; set { {_estimatedDowntime = value;} } }

        /// <summary>Internal Acessors for ScheduledStandbyAvailabilityZone</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityValidationEstimationInternal.ScheduledStandbyAvailabilityZone { get => this._scheduledStandbyAvailabilityZone; set { {_scheduledStandbyAvailabilityZone = value;} } }

        /// <summary>Backing field for <see cref="ScheduledStandbyAvailabilityZone" /> property.</summary>
        private string _scheduledStandbyAvailabilityZone;

        /// <summary>Scheduled Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ScheduledStandbyAvailabilityZone { get => this._scheduledStandbyAvailabilityZone; }

        /// <summary>Creates an new <see cref="HighAvailabilityValidationEstimation" /> instance.</summary>
        public HighAvailabilityValidationEstimation()
        {

        }
    }
    /// High availability validation properties of a server
    public partial interface IHighAvailabilityValidationEstimation :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Estimated seconds of downtime for the deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Estimated seconds of downtime for the deployment.",
        SerializedName = @"estimatedDowntime",
        PossibleTypes = new [] { typeof(int) })]
        int? EstimatedDowntime { get;  }
        /// <summary>Expected Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Expected Availability zone of the standby server.",
        SerializedName = @"expectedStandbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string ExpectedStandbyAvailabilityZone { get; set; }
        /// <summary>Scheduled Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Scheduled Availability zone of the standby server.",
        SerializedName = @"scheduledStandbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduledStandbyAvailabilityZone { get;  }

    }
    /// High availability validation properties of a server
    internal partial interface IHighAvailabilityValidationEstimationInternal

    {
        /// <summary>Estimated seconds of downtime for the deployment.</summary>
        int? EstimatedDowntime { get; set; }
        /// <summary>Expected Availability zone of the standby server.</summary>
        string ExpectedStandbyAvailabilityZone { get; set; }
        /// <summary>Scheduled Availability zone of the standby server.</summary>
        string ScheduledStandbyAvailabilityZone { get; set; }

    }
}