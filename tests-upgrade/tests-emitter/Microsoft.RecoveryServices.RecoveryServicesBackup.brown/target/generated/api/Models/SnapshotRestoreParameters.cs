// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Encapsulates information regarding snapshot recovery for SAP Hana</summary>
    public partial class SnapshotRestoreParameters :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParametersInternal
    {

        /// <summary>Backing field for <see cref="LogPointInTimeForDbRecovery" /> property.</summary>
        private string _logPointInTimeForDbRecovery;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string LogPointInTimeForDbRecovery { get => this._logPointInTimeForDbRecovery; set => this._logPointInTimeForDbRecovery = value; }

        /// <summary>Backing field for <see cref="SkipAttachAndMount" /> property.</summary>
        private bool? _skipAttachAndMount;

        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? SkipAttachAndMount { get => this._skipAttachAndMount; set => this._skipAttachAndMount = value; }

        /// <summary>Creates an new <see cref="SnapshotRestoreParameters" /> instance.</summary>
        public SnapshotRestoreParameters()
        {

        }
    }
    /// Encapsulates information regarding snapshot recovery for SAP Hana
    public partial interface ISnapshotRestoreParameters :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"logPointInTimeForDBRecovery",
        PossibleTypes = new [] { typeof(string) })]
        string LogPointInTimeForDbRecovery { get; set; }
        /// <summary>Boolean with `true` and `false` values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Boolean with `true` and `false` values.",
        SerializedName = @"skipAttachAndMount",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SkipAttachAndMount { get; set; }

    }
    /// Encapsulates information regarding snapshot recovery for SAP Hana
    internal partial interface ISnapshotRestoreParametersInternal

    {
        string LogPointInTimeForDbRecovery { get; set; }
        /// <summary>Boolean with `true` and `false` values.</summary>
        bool? SkipAttachAndMount { get; set; }

    }
}