// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Class encapsulating restore as files target parameters</summary>
    public partial class RestoreFilesTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreFilesTargetInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreFilesTargetInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase __restoreTargetInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfoBase();

        /// <summary>Internal Acessors for TargetDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreFilesTargetInfoInternal.TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.TargetDetails()); set { {_targetDetail = value;} } }

        /// <summary>Internal Acessors for RecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal.RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption = value ; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ObjectType { get => "RestoreFilesTargetInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType = "RestoreFilesTargetInfo"; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string RestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation = value ?? null; }

        /// <summary>Backing field for <see cref="TargetDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetails _targetDetail;

        /// <summary>Destination of RestoreAsFiles operation, when destination is not a datasource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetails TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.TargetDetails()); set => this._targetDetail = value; }

        /// <summary>
        /// Restore operation may create multiple files inside location pointed by Url
        /// Below will be the common prefix for all of them
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string TargetDetailFilePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).FilePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).FilePrefix = value ; }

        /// <summary>
        /// Denotes the target location where the data will be restored,
        /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string TargetDetailRestoreTargetLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).RestoreTargetLocationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).RestoreTargetLocationType = value ; }

        /// <summary>
        /// Full ARM Id denoting the restore destination. It is the ARM Id pointing to container / file share
        /// This is optional if the target subscription can be identified with the URL field. If not
        /// then this is needed if CrossSubscriptionRestore field of BackupVault is in any of the disabled states
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string TargetDetailTargetResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).TargetResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).TargetResourceArmId = value ?? null; }

        /// <summary>
        /// Url denoting the restore destination. It can point to container / file share etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string TargetDetailUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).Url; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetailsInternal)TargetDetail).Url = value ; }

        /// <summary>Creates an new <see cref="RestoreFilesTargetInfo" /> instance.</summary>
        public RestoreFilesTargetInfo()
        {
            this.__restoreTargetInfoBase.ObjectType = "RestoreFilesTargetInfo";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
            await eventListener.AssertObjectIsValid(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
        }
    }
    /// Class encapsulating restore as files target parameters
    public partial interface IRestoreFilesTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase
    {
        /// <summary>
        /// Restore operation may create multiple files inside location pointed by Url
        /// Below will be the common prefix for all of them
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Restore operation may create multiple files inside location pointed by Url
        Below will be the common prefix for all of them",
        SerializedName = @"filePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailFilePrefix { get; set; }
        /// <summary>
        /// Denotes the target location where the data will be restored,
        /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Denotes the target location where the data will be restored,
        string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}",
        SerializedName = @"restoreTargetLocationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Invalid", "AzureBlobs", "AzureFiles")]
        string TargetDetailRestoreTargetLocationType { get; set; }
        /// <summary>
        /// Full ARM Id denoting the restore destination. It is the ARM Id pointing to container / file share
        /// This is optional if the target subscription can be identified with the URL field. If not
        /// then this is needed if CrossSubscriptionRestore field of BackupVault is in any of the disabled states
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full ARM Id denoting the restore destination. It is the ARM Id pointing to container / file share
        This is optional if the target subscription can be identified with the URL field. If not
        then this is needed if CrossSubscriptionRestore field of BackupVault is in any of the disabled states",
        SerializedName = @"targetResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailTargetResourceArmId { get; set; }
        /// <summary>
        /// Url denoting the restore destination. It can point to container / file share etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Url denoting the restore destination. It can point to container / file share etc",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailUrl { get; set; }

    }
    /// Class encapsulating restore as files target parameters
    internal partial interface IRestoreFilesTargetInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal
    {
        /// <summary>Destination of RestoreAsFiles operation, when destination is not a datasource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ITargetDetails TargetDetail { get; set; }
        /// <summary>
        /// Restore operation may create multiple files inside location pointed by Url
        /// Below will be the common prefix for all of them
        /// </summary>
        string TargetDetailFilePrefix { get; set; }
        /// <summary>
        /// Denotes the target location where the data will be restored,
        /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Invalid", "AzureBlobs", "AzureFiles")]
        string TargetDetailRestoreTargetLocationType { get; set; }
        /// <summary>
        /// Full ARM Id denoting the restore destination. It is the ARM Id pointing to container / file share
        /// This is optional if the target subscription can be identified with the URL field. If not
        /// then this is needed if CrossSubscriptionRestore field of BackupVault is in any of the disabled states
        /// </summary>
        string TargetDetailTargetResourceArmId { get; set; }
        /// <summary>
        /// Url denoting the restore destination. It can point to container / file share etc
        /// </summary>
        string TargetDetailUrl { get; set; }

    }
}