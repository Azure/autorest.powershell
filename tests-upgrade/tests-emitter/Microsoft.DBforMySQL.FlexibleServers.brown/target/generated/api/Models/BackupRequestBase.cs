// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>BackupRequestBase is the base for all backup request.</summary>
    public partial class BackupRequestBase :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBase,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal
    {

        /// <summary>Backing field for <see cref="BackupSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings _backupSetting;

        /// <summary>Backup Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings BackupSetting { get => (this._backupSetting = this._backupSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.BackupSettings()); set => this._backupSetting = value; }

        /// <summary>Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string BackupSettingBackupFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettingsInternal)BackupSetting).BackupFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettingsInternal)BackupSetting).BackupFormat = value ?? null; }

        /// <summary>The name of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string BackupSettingBackupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettingsInternal)BackupSetting).BackupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettingsInternal)BackupSetting).BackupName = value ; }

        /// <summary>Internal Acessors for BackupSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal.BackupSetting { get => (this._backupSetting = this._backupSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.BackupSettings()); set { {_backupSetting = value;} } }

        /// <summary>Creates an new <see cref="BackupRequestBase" /> instance.</summary>
        public BackupRequestBase()
        {

        }
    }
    /// BackupRequestBase is the base for all backup request.
    public partial interface IBackupRequestBase :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)",
        SerializedName = @"backupFormat",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("CollatedFormat", "Raw")]
        string BackupSettingBackupFormat { get; set; }
        /// <summary>The name of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the backup.",
        SerializedName = @"backupName",
        PossibleTypes = new [] { typeof(string) })]
        string BackupSettingBackupName { get; set; }

    }
    /// BackupRequestBase is the base for all backup request.
    internal partial interface IBackupRequestBaseInternal

    {
        /// <summary>Backup Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings BackupSetting { get; set; }
        /// <summary>Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("CollatedFormat", "Raw")]
        string BackupSettingBackupFormat { get; set; }
        /// <summary>The name of the backup.</summary>
        string BackupSettingBackupName { get; set; }

    }
}