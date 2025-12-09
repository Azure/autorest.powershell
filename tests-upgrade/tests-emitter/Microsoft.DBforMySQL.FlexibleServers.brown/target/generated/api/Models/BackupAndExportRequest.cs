// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>BackupAndExport API Request</summary>
    public partial class BackupAndExportRequest :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportRequest,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBase" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBase __backupRequestBase = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.BackupRequestBase();

        /// <summary>Backup Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings BackupSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSetting = value ?? null /* model class */; }

        /// <summary>Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string BackupSettingBackupFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSettingBackupFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSettingBackupFormat = value ?? null; }

        /// <summary>The name of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string BackupSettingBackupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSettingBackupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSettingBackupName = value ; }

        /// <summary>Internal Acessors for TargetDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupAndExportRequestInternal.TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.BackupStoreDetails()); set { {_targetDetail = value;} } }

        /// <summary>Internal Acessors for BackupSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupSettings Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal.BackupSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal)__backupRequestBase).BackupSetting = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="TargetDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails _targetDetail;

        /// <summary>Backup Target Store Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.BackupStoreDetails()); set => this._targetDetail = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string TargetDetailObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetailsInternal)TargetDetail).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetailsInternal)TargetDetail).ObjectType = value ; }

        /// <summary>Creates an new <see cref="BackupAndExportRequest" /> instance.</summary>
        public BackupAndExportRequest()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__backupRequestBase), __backupRequestBase);
            await eventListener.AssertObjectIsValid(nameof(__backupRequestBase), __backupRequestBase);
        }
    }
    /// BackupAndExport API Request
    public partial interface IBackupAndExportRequest :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBase
    {
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailObjectType { get; set; }

    }
    /// BackupAndExport API Request
    internal partial interface IBackupAndExportRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupRequestBaseInternal
    {
        /// <summary>Backup Target Store Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails TargetDetail { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string TargetDetailObjectType { get; set; }

    }
}