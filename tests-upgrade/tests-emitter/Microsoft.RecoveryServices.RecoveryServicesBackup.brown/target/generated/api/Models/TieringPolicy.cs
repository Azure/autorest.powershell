// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// Tiering Policy for a target tier.
    /// If the policy is not specified for a given target tier, service retains the existing configured tiering policy for that
    /// tier
    /// </summary>
    public partial class TieringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringPolicyInternal
    {

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private int? _duration;

        /// <summary>
        /// Number of days/weeks/months/years to retain backups in current tier before tiering.
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Backing field for <see cref="DurationType" /> property.</summary>
        private string _durationType;

        /// <summary>
        /// Retention duration type: days/weeks/months/years
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string DurationType { get => this._durationType; set => this._durationType = value; }

        /// <summary>Backing field for <see cref="TieringMode" /> property.</summary>
        private string _tieringMode;

        /// <summary>
        /// Tiering Mode to control automatic tiering of recovery points. Supported values are:
        /// 1. TierRecommended: Tier all recovery points recommended to be tiered
        /// 2. TierAfter: Tier all recovery points after a fixed period, as specified in duration + durationType below.
        /// 3. DoNotTier: Do not tier any recovery points
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TieringMode { get => this._tieringMode; set => this._tieringMode = value; }

        /// <summary>Creates an new <see cref="TieringPolicy" /> instance.</summary>
        public TieringPolicy()
        {

        }
    }
    /// Tiering Policy for a target tier.
    /// If the policy is not specified for a given target tier, service retains the existing configured tiering policy for that
    /// tier
    public partial interface ITieringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Number of days/weeks/months/years to retain backups in current tier before tiering.
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of days/weeks/months/years to retain backups in current tier before tiering.
        Used only if TieringMode is set to TierAfter",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(int) })]
        int? Duration { get; set; }
        /// <summary>
        /// Retention duration type: days/weeks/months/years
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention duration type: days/weeks/months/years
        Used only if TieringMode is set to TierAfter",
        SerializedName = @"durationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string DurationType { get; set; }
        /// <summary>
        /// Tiering Mode to control automatic tiering of recovery points. Supported values are:
        /// 1. TierRecommended: Tier all recovery points recommended to be tiered
        /// 2. TierAfter: Tier all recovery points after a fixed period, as specified in duration + durationType below.
        /// 3. DoNotTier: Do not tier any recovery points
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tiering Mode to control automatic tiering of recovery points. Supported values are:
        1. TierRecommended: Tier all recovery points recommended to be tiered
        2. TierAfter: Tier all recovery points after a fixed period, as specified in duration + durationType below.
        3. DoNotTier: Do not tier any recovery points",
        SerializedName = @"tieringMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "TierRecommended", "TierAfter", "DoNotTier")]
        string TieringMode { get; set; }

    }
    /// Tiering Policy for a target tier.
    /// If the policy is not specified for a given target tier, service retains the existing configured tiering policy for that
    /// tier
    internal partial interface ITieringPolicyInternal

    {
        /// <summary>
        /// Number of days/weeks/months/years to retain backups in current tier before tiering.
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        int? Duration { get; set; }
        /// <summary>
        /// Retention duration type: days/weeks/months/years
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string DurationType { get; set; }
        /// <summary>
        /// Tiering Mode to control automatic tiering of recovery points. Supported values are:
        /// 1. TierRecommended: Tier all recovery points recommended to be tiered
        /// 2. TierAfter: Tier all recovery points after a fixed period, as specified in duration + durationType below.
        /// 3. DoNotTier: Do not tier any recovery points
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "TierRecommended", "TierAfter", "DoNotTier")]
        string TieringMode { get; set; }

    }
}