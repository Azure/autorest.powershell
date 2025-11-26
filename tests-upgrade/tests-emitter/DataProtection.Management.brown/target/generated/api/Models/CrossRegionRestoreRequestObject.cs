// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Cross Region Restore Request Object</summary>
    public partial class CrossRegionRestoreRequestObject :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObject,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal
    {

        /// <summary>Backing field for <see cref="CrossRegionRestoreDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetails _crossRegionRestoreDetail;

        /// <summary>Cross region restore details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetails CrossRegionRestoreDetail { get => (this._crossRegionRestoreDetail = this._crossRegionRestoreDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreDetails()); set => this._crossRegionRestoreDetail = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CrossRegionRestoreDetailSourceBackupInstanceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetailsInternal)CrossRegionRestoreDetail).SourceBackupInstanceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetailsInternal)CrossRegionRestoreDetail).SourceBackupInstanceId = value ; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CrossRegionRestoreDetailSourceRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetailsInternal)CrossRegionRestoreDetail).SourceRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetailsInternal)CrossRegionRestoreDetail).SourceRegion = value ; }

        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? IdentityDetailUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).IdentityDetailUseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).IdentityDetailUseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>ARM URL for User Assigned Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string IdentityDetailUserAssignedIdentityArmUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).IdentityDetailUserAssignedIdentityArmUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).IdentityDetailUserAssignedIdentityArmUrl = value ?? null; }

        /// <summary>Internal Acessors for CrossRegionRestoreDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal.CrossRegionRestoreDetail { get => (this._crossRegionRestoreDetail = this._crossRegionRestoreDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreDetails()); set { {_crossRegionRestoreDetail = value;} } }

        /// <summary>Internal Acessors for RestoreRequestObject</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal.RestoreRequestObject { get => (this._restoreRequestObject = this._restoreRequestObject ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AzureBackupRestoreRequest()); set { {_restoreRequestObject = value;} } }

        /// <summary>Internal Acessors for RestoreRequestObjectIdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal.RestoreRequestObjectIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).IdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).IdentityDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RestoreRequestObjectRestoreTargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal.RestoreRequestObjectRestoreTargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RestoreTargetInfoRecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal.RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRecoveryOption = value ; }

        /// <summary>Backing field for <see cref="RestoreRequestObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest _restoreRequestObject;

        /// <summary>Gets or sets the restore request object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest RestoreRequestObject { get => (this._restoreRequestObject = this._restoreRequestObject ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AzureBackupRestoreRequest()); set => this._restoreRequestObject = value; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RestoreRequestObjectResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the restore target information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase RestoreRequestObjectRestoreTargetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfo = value ?? null /* model class */; }

        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreRequestObjectSourceDataStoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).SourceDataStoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).SourceDataStoreType = value ; }

        /// <summary>
        /// Fully qualified Azure Resource Manager ID of the datasource which is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreRequestObjectSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).SourceResourceId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreRequestObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).ObjectType = value ; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoObjectType = value ; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal)RestoreRequestObject).RestoreTargetInfoRestoreLocation = value ?? null; }

        /// <summary>Creates an new <see cref="CrossRegionRestoreRequestObject" /> instance.</summary>
        public CrossRegionRestoreRequestObject()
        {

        }
    }
    /// Cross Region Restore Request Object
    public partial interface ICrossRegionRestoreRequestObject :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"sourceBackupInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string CrossRegionRestoreDetailSourceBackupInstanceId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"sourceRegion",
        PossibleTypes = new [] { typeof(string) })]
        string CrossRegionRestoreDetailSourceRegion { get; set; }
        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies if the BI is protected by System Identity.",
        SerializedName = @"useSystemAssignedIdentity",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdentityDetailUseSystemAssignedIdentity { get; set; }
        /// <summary>ARM URL for User Assigned Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM URL for User Assigned Identity.",
        SerializedName = @"userAssignedIdentityArmUrl",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityDetailUserAssignedIdentityArmUrl { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RestoreRequestObjectResourceGuardOperationRequest { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the type of the source data store.",
        SerializedName = @"sourceDataStoreType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ArchiveStore", "SnapshotStore", "OperationalStore", "VaultStore")]
        string RestoreRequestObjectSourceDataStoreType { get; set; }
        /// <summary>
        /// Fully qualified Azure Resource Manager ID of the datasource which is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fully qualified Azure Resource Manager ID of the datasource which is being recovered.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreRequestObjectSourceResourceId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreRequestObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreTargetInfoObjectType { get; set; }
        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Recovery Option",
        SerializedName = @"recoveryOption",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreTargetInfoRecoveryOption { get;  }
        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target Restore region",
        SerializedName = @"restoreLocation",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreTargetInfoRestoreLocation { get; set; }

    }
    /// Cross Region Restore Request Object
    internal partial interface ICrossRegionRestoreRequestObjectInternal

    {
        /// <summary>Cross region restore details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetails CrossRegionRestoreDetail { get; set; }

        string CrossRegionRestoreDetailSourceBackupInstanceId { get; set; }

        string CrossRegionRestoreDetailSourceRegion { get; set; }
        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        bool? IdentityDetailUseSystemAssignedIdentity { get; set; }
        /// <summary>ARM URL for User Assigned Identity.</summary>
        string IdentityDetailUserAssignedIdentityArmUrl { get; set; }
        /// <summary>Gets or sets the restore request object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest RestoreRequestObject { get; set; }
        /// <summary>
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails RestoreRequestObjectIdentityDetail { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> RestoreRequestObjectResourceGuardOperationRequest { get; set; }
        /// <summary>Gets or sets the restore target information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase RestoreRequestObjectRestoreTargetInfo { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ArchiveStore", "SnapshotStore", "OperationalStore", "VaultStore")]
        string RestoreRequestObjectSourceDataStoreType { get; set; }
        /// <summary>
        /// Fully qualified Azure Resource Manager ID of the datasource which is being recovered.
        /// </summary>
        string RestoreRequestObjectSourceResourceId { get; set; }

        string RestoreRequestObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string RestoreTargetInfoObjectType { get; set; }
        /// <summary>Recovery Option</summary>
        string RestoreTargetInfoRecoveryOption { get; set; }
        /// <summary>Target Restore region</summary>
        string RestoreTargetInfoRestoreLocation { get; set; }

    }
}