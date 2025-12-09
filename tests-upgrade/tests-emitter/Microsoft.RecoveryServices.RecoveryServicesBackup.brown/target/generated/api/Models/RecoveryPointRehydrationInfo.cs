// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>RP Rehydration Info</summary>
    public partial class RecoveryPointRehydrationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal
    {

        /// <summary>Backing field for <see cref="RehydrationPriority" /> property.</summary>
        private string _rehydrationPriority;

        /// <summary>Rehydration Priority</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RehydrationPriority { get => this._rehydrationPriority; set => this._rehydrationPriority = value; }

        /// <summary>Backing field for <see cref="RehydrationRetentionDuration" /> property.</summary>
        private string _rehydrationRetentionDuration;

        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RehydrationRetentionDuration { get => this._rehydrationRetentionDuration; set => this._rehydrationRetentionDuration = value; }

        /// <summary>Creates an new <see cref="RecoveryPointRehydrationInfo" /> instance.</summary>
        public RecoveryPointRehydrationInfo()
        {

        }
    }
    /// RP Rehydration Info
    public partial interface IRecoveryPointRehydrationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Rehydration Priority</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rehydration Priority",
        SerializedName = @"rehydrationPriority",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Standard", "High")]
        string RehydrationPriority { get; set; }
        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How long the rehydrated RP should be kept
        Should be ISO8601 Duration format e.g. ""P7D""",
        SerializedName = @"rehydrationRetentionDuration",
        PossibleTypes = new [] { typeof(string) })]
        string RehydrationRetentionDuration { get; set; }

    }
    /// RP Rehydration Info
    internal partial interface IRecoveryPointRehydrationInfoInternal

    {
        /// <summary>Rehydration Priority</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Standard", "High")]
        string RehydrationPriority { get; set; }
        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        string RehydrationRetentionDuration { get; set; }

    }
}