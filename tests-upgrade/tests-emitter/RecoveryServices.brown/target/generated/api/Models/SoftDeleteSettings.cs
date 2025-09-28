// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Soft delete Settings of vault</summary>
    public partial class SoftDeleteSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal
    {

        /// <summary>Backing field for <see cref="EnhancedSecurityState" /> property.</summary>
        private string _enhancedSecurityState;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string EnhancedSecurityState { get => this._enhancedSecurityState; set => this._enhancedSecurityState = value; }

        /// <summary>Backing field for <see cref="SoftDeleteRetentionPeriodInDay" /> property.</summary>
        private int? _softDeleteRetentionPeriodInDay;

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? SoftDeleteRetentionPeriodInDay { get => this._softDeleteRetentionPeriodInDay; set => this._softDeleteRetentionPeriodInDay = value; }

        /// <summary>Backing field for <see cref="SoftDeleteState" /> property.</summary>
        private string _softDeleteState;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string SoftDeleteState { get => this._softDeleteState; set => this._softDeleteState = value; }

        /// <summary>Creates an new <see cref="SoftDeleteSettings" /> instance.</summary>
        public SoftDeleteSettings()
        {

        }
    }
    /// Soft delete Settings of vault
    public partial interface ISoftDeleteSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"enhancedSecurityState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string EnhancedSecurityState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft delete retention period in days",
        SerializedName = @"softDeleteRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SoftDeleteRetentionPeriodInDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"softDeleteState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteState { get; set; }

    }
    /// Soft delete Settings of vault
    internal partial interface ISoftDeleteSettingsInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string EnhancedSecurityState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        int? SoftDeleteRetentionPeriodInDay { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteState { get; set; }

    }
}