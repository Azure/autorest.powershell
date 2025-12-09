// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Daily retention format.</summary>
    public partial class DailyRetentionFormat :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormatInternal
    {

        /// <summary>Backing field for <see cref="DaysOfTheMonth" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> _daysOfTheMonth;

        /// <summary>List of days of the month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> DaysOfTheMonth { get => this._daysOfTheMonth; set => this._daysOfTheMonth = value; }

        /// <summary>Creates an new <see cref="DailyRetentionFormat" /> instance.</summary>
        public DailyRetentionFormat()
        {

        }
    }
    /// Daily retention format.
    public partial interface IDailyRetentionFormat :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of days of the month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of days of the month.",
        SerializedName = @"daysOfTheMonth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> DaysOfTheMonth { get; set; }

    }
    /// Daily retention format.
    internal partial interface IDailyRetentionFormatInternal

    {
        /// <summary>List of days of the month.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> DaysOfTheMonth { get; set; }

    }
}