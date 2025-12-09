// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Weekly retention format.</summary>
    public partial class WeeklyRetentionFormat :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormatInternal
    {

        /// <summary>Backing field for <see cref="DaysOfTheWeek" /> property.</summary>
        private System.Collections.Generic.List<string> _daysOfTheWeek;

        /// <summary>List of days of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DaysOfTheWeek { get => this._daysOfTheWeek; set => this._daysOfTheWeek = value; }

        /// <summary>Backing field for <see cref="WeeksOfTheMonth" /> property.</summary>
        private System.Collections.Generic.List<string> _weeksOfTheMonth;

        /// <summary>List of weeks of month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WeeksOfTheMonth { get => this._weeksOfTheMonth; set => this._weeksOfTheMonth = value; }

        /// <summary>Creates an new <see cref="WeeklyRetentionFormat" /> instance.</summary>
        public WeeklyRetentionFormat()
        {

        }
    }
    /// Weekly retention format.
    public partial interface IWeeklyRetentionFormat :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of days of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of days of the week.",
        SerializedName = @"daysOfTheWeek",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> DaysOfTheWeek { get; set; }
        /// <summary>List of weeks of month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of weeks of month.",
        SerializedName = @"weeksOfTheMonth",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("First", "Second", "Third", "Fourth", "Last", "Invalid")]
        System.Collections.Generic.List<string> WeeksOfTheMonth { get; set; }

    }
    /// Weekly retention format.
    internal partial interface IWeeklyRetentionFormatInternal

    {
        /// <summary>List of days of the week.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> DaysOfTheWeek { get; set; }
        /// <summary>List of weeks of month.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("First", "Second", "Third", "Fourth", "Last", "Invalid")]
        System.Collections.Generic.List<string> WeeksOfTheMonth { get; set; }

    }
}