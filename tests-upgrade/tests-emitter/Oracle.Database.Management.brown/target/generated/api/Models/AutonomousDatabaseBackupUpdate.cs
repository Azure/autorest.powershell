// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>The type used for update operations of the AutonomousDatabaseBackup.</summary>
    public partial class AutonomousDatabaseBackupUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdateInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.AutonomousDatabaseBackupUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.AutonomousDatabaseBackupUpdateProperties()); set => this._property = value; }

        /// <summary>Retention period, in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public int? RetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdatePropertiesInternal)Property).RetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdatePropertiesInternal)Property).RetentionPeriodInDay = value ?? default(int); }

        /// <summary>Creates an new <see cref="AutonomousDatabaseBackupUpdate" /> instance.</summary>
        public AutonomousDatabaseBackupUpdate()
        {

        }
    }
    /// The type used for update operations of the AutonomousDatabaseBackup.
    public partial interface IAutonomousDatabaseBackupUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Retention period, in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention period, in days",
        SerializedName = @"retentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPeriodInDay { get; set; }

    }
    /// The type used for update operations of the AutonomousDatabaseBackup.
    internal partial interface IAutonomousDatabaseBackupUpdateInternal

    {
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDatabaseBackupUpdateProperties Property { get; set; }
        /// <summary>Retention period, in days</summary>
        int? RetentionPeriodInDay { get; set; }

    }
}