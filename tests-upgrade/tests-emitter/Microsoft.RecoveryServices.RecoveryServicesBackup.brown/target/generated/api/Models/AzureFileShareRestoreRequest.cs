// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureFileShare Restore Request</summary>
    public partial class AzureFileShareRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRestoreRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest __restoreRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RestoreRequest();

        /// <summary>Backing field for <see cref="CopyOption" /> property.</summary>
        private string _copyOption;

        /// <summary>Options to resolve copy conflicts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string CopyOption { get => this._copyOption; set => this._copyOption = value; }

        /// <summary>Internal Acessors for TargetDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRestoreRequestInternal.TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetAfsRestoreInfo()); set { {_targetDetail = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureFileShareRestoreRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__restoreRequest).ObjectType = "AzureFileShareRestoreRequest"; }

        /// <summary>Backing field for <see cref="RecoveryType" /> property.</summary>
        private string _recoveryType;

        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RecoveryType { get => this._recoveryType; set => this._recoveryType = value; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__restoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__restoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="RestoreFileSpec" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreFileSpecs> _restoreFileSpec;

        /// <summary>
        /// List of Source Files/Folders(which need to recover) and TargetFolderPath details
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreFileSpecs> RestoreFileSpec { get => this._restoreFileSpec; set => this._restoreFileSpec = value; }

        /// <summary>Backing field for <see cref="RestoreRequestType" /> property.</summary>
        private string _restoreRequestType;

        /// <summary>Restore Type (FullShareRestore or ItemLevelRestore)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RestoreRequestType { get => this._restoreRequestType; set => this._restoreRequestType = value; }

        /// <summary>Backing field for <see cref="SourceResourceId" /> property.</summary>
        private string _sourceResourceId;

        /// <summary>Source storage account ARM Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceResourceId { get => this._sourceResourceId; set => this._sourceResourceId = value; }

        /// <summary>Backing field for <see cref="TargetDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfo _targetDetail;

        /// <summary>Target File Share Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfo TargetDetail { get => (this._targetDetail = this._targetDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetAfsRestoreInfo()); set => this._targetDetail = value; }

        /// <summary>File share name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string TargetDetailName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfoInternal)TargetDetail).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfoInternal)TargetDetail).Name = value ?? null; }

        /// <summary>Target file share resource ARM ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string TargetDetailTargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfoInternal)TargetDetail).TargetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfoInternal)TargetDetail).TargetResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="AzureFileShareRestoreRequest" /> instance.</summary>
        public AzureFileShareRestoreRequest()
        {
            this.__restoreRequest.ObjectType = "AzureFileShareRestoreRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__restoreRequest), __restoreRequest);
            await eventListener.AssertObjectIsValid(nameof(__restoreRequest), __restoreRequest);
        }
    }
    /// AzureFileShare Restore Request
    public partial interface IAzureFileShareRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequest
    {
        /// <summary>Options to resolve copy conflicts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Options to resolve copy conflicts.",
        SerializedName = @"copyOptions",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "CreateCopy", "Skip", "Overwrite", "FailOnConflict")]
        string CopyOption { get; set; }
        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of this recovery.",
        SerializedName = @"recoveryType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "OriginalLocation", "AlternateLocation", "RestoreDisks", "Offline")]
        string RecoveryType { get; set; }
        /// <summary>
        /// List of Source Files/Folders(which need to recover) and TargetFolderPath details
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Source Files/Folders(which need to recover) and TargetFolderPath details",
        SerializedName = @"restoreFileSpecs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreFileSpecs) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreFileSpecs> RestoreFileSpec { get; set; }
        /// <summary>Restore Type (FullShareRestore or ItemLevelRestore)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Restore Type (FullShareRestore or ItemLevelRestore)",
        SerializedName = @"restoreRequestType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "FullShareRestore", "ItemLevelRestore")]
        string RestoreRequestType { get; set; }
        /// <summary>Source storage account ARM Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source storage account ARM Id",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceId { get; set; }
        /// <summary>File share name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"File share name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailName { get; set; }
        /// <summary>Target file share resource ARM ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target file share resource ARM ID",
        SerializedName = @"targetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDetailTargetResourceId { get; set; }

    }
    /// AzureFileShare Restore Request
    internal partial interface IAzureFileShareRestoreRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal
    {
        /// <summary>Options to resolve copy conflicts.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "CreateCopy", "Skip", "Overwrite", "FailOnConflict")]
        string CopyOption { get; set; }
        /// <summary>Type of this recovery.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "OriginalLocation", "AlternateLocation", "RestoreDisks", "Offline")]
        string RecoveryType { get; set; }
        /// <summary>
        /// List of Source Files/Folders(which need to recover) and TargetFolderPath details
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreFileSpecs> RestoreFileSpec { get; set; }
        /// <summary>Restore Type (FullShareRestore or ItemLevelRestore)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "FullShareRestore", "ItemLevelRestore")]
        string RestoreRequestType { get; set; }
        /// <summary>Source storage account ARM Id</summary>
        string SourceResourceId { get; set; }
        /// <summary>Target File Share Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetAfsRestoreInfo TargetDetail { get; set; }
        /// <summary>File share name</summary>
        string TargetDetailName { get; set; }
        /// <summary>Target file share resource ARM ID</summary>
        string TargetDetailTargetResourceId { get; set; }

    }
}