// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Snapshot Backup related fields for WorkloadType SaPHanaSystem</summary>
    public partial class SnapshotBackupAdditionalDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal
    {

        /// <summary>Backing field for <see cref="InstantRpDetail" /> property.</summary>
        private string _instantRpDetail;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string InstantRpDetail { get => this._instantRpDetail; set => this._instantRpDetail = value; }

        /// <summary>Backing field for <see cref="InstantRpRetentionRangeInDay" /> property.</summary>
        private int? _instantRpRetentionRangeInDay;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? InstantRpRetentionRangeInDay { get => this._instantRpRetentionRangeInDay; set => this._instantRpRetentionRangeInDay = value; }

        /// <summary>Internal Acessors for UserAssignedManagedIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal.UserAssignedManagedIdentityDetail { get => (this._userAssignedManagedIdentityDetail = this._userAssignedManagedIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetails()); set { {_userAssignedManagedIdentityDetail = value;} } }

        /// <summary>
        /// Internal Acessors for UserAssignedManagedIdentityDetailUserAssignedIdentityProperty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal.UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).UserAssignedIdentityPropertyPrincipalId = value ?? null; }

        /// <summary>Backing field for <see cref="UserAssignedManagedIdentityDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails _userAssignedManagedIdentityDetail;

        /// <summary>User assigned managed identity details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get => (this._userAssignedManagedIdentityDetail = this._userAssignedManagedIdentityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetails()); set => this._userAssignedManagedIdentityDetail = value; }

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentityDetailIdentityArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityArmId = value ?? null; }

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentityDetailIdentityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal)UserAssignedManagedIdentityDetail).IdentityName = value ?? null; }

        /// <summary>Creates an new <see cref="SnapshotBackupAdditionalDetails" /> instance.</summary>
        public SnapshotBackupAdditionalDetails()
        {

        }
    }
    /// Snapshot Backup related fields for WorkloadType SaPHanaSystem
    public partial interface ISnapshotBackupAdditionalDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"instantRPDetails",
        PossibleTypes = new [] { typeof(string) })]
        string InstantRpDetail { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"instantRpRetentionRangeInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? InstantRpRetentionRangeInDay { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The client ID of the assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The principal ID of the assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyPrincipalId { get; set; }
        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM id of the assigned identity.",
        SerializedName = @"identityArmId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentityDetailIdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the assigned identity.",
        SerializedName = @"identityName",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentityDetailIdentityName { get; set; }

    }
    /// Snapshot Backup related fields for WorkloadType SaPHanaSystem
    internal partial interface ISnapshotBackupAdditionalDetailsInternal

    {
        string InstantRpDetail { get; set; }

        int? InstantRpRetentionRangeInDay { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyPrincipalId { get; set; }
        /// <summary>User assigned managed identity details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetail { get; set; }
        /// <summary>The ARM id of the assigned identity.</summary>
        string UserAssignedManagedIdentityDetailIdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        string UserAssignedManagedIdentityDetailIdentityName { get; set; }
        /// <summary>User assigned managed identity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get; set; }

    }
}