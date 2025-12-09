// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of a server backup.</summary>
    public partial class ServerBackupPropertiesV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupPropertiesV2,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupPropertiesV2Internal
    {

        /// <summary>Backing field for <see cref="BackupNameV2" /> property.</summary>
        private string _backupNameV2;

        /// <summary>Backup name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BackupNameV2 { get => this._backupNameV2; set => this._backupNameV2 = value; }

        /// <summary>Backing field for <see cref="BackupType" /> property.</summary>
        private string _backupType;

        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BackupType { get => this._backupType; set => this._backupType = value; }

        /// <summary>Backing field for <see cref="CompletedTime" /> property.</summary>
        private global::System.DateTime? _completedTime;

        /// <summary>Backup completed time (ISO8601 format).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? CompletedTime { get => this._completedTime; set => this._completedTime = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerBackupPropertiesV2Internal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of backup resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>Backup source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Creates an new <see cref="ServerBackupPropertiesV2" /> instance.</summary>
        public ServerBackupPropertiesV2()
        {

        }
    }
    /// The properties of a server backup.
    public partial interface IServerBackupPropertiesV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Backup name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup name",
        SerializedName = @"backupNameV2",
        PossibleTypes = new [] { typeof(string) })]
        string BackupNameV2 { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"backupType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("FULL")]
        string BackupType { get; set; }
        /// <summary>Backup completed time (ISO8601 format).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup completed time (ISO8601 format).",
        SerializedName = @"completedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CompletedTime { get; set; }
        /// <summary>The provisioning state of backup resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of backup resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Backup source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup source",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }

    }
    /// The properties of a server backup.
    internal partial interface IServerBackupPropertiesV2Internal

    {
        /// <summary>Backup name</summary>
        string BackupNameV2 { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("FULL")]
        string BackupType { get; set; }
        /// <summary>Backup completed time (ISO8601 format).</summary>
        global::System.DateTime? CompletedTime { get; set; }
        /// <summary>The provisioning state of backup resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Backup source</summary>
        string Source { get; set; }

    }
}