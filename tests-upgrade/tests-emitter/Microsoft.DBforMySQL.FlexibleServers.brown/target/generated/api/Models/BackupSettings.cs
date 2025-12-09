// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Backup Settings</summary>
    public partial class BackupSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettingsInternal
    {

        /// <summary>Backing field for <see cref="BackupFormat" /> property.</summary>
        private string _backupFormat;

        /// <summary>Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BackupFormat { get => this._backupFormat; set => this._backupFormat = value; }

        /// <summary>Backing field for <see cref="BackupName" /> property.</summary>
        private string _backupName;

        /// <summary>The name of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BackupName { get => this._backupName; set => this._backupName = value; }

        /// <summary>Creates an new <see cref="BackupSettings" /> instance.</summary>
        public BackupSettings()
        {

        }
    }
    /// Backup Settings
    public partial interface IBackupSettings :
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
        string BackupFormat { get; set; }
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
        string BackupName { get; set; }

    }
    /// Backup Settings
    internal partial interface IBackupSettingsInternal

    {
        /// <summary>Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("CollatedFormat", "Raw")]
        string BackupFormat { get; set; }
        /// <summary>The name of the backup.</summary>
        string BackupName { get; set; }

    }
}