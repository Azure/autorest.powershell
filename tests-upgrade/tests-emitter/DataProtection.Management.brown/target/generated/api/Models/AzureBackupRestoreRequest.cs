// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Azure backup restore request</summary>
    public partial class AzureBackupRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal
    {

        /// <summary>Backing field for <see cref="IdentityDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails _identityDetail;

        /// <summary>
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails IdentityDetail { get => (this._identityDetail = this._identityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetails()); set => this._identityDetail = value; }

        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? IdentityDetailUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetailsInternal)IdentityDetail).UseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetailsInternal)IdentityDetail).UseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>ARM URL for User Assigned Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string IdentityDetailUserAssignedIdentityArmUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetailsInternal)IdentityDetail).UserAssignedIdentityArmUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetailsInternal)IdentityDetail).UserAssignedIdentityArmUrl = value ?? null; }

        /// <summary>Internal Acessors for IdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal.IdentityDetail { get => (this._identityDetail = this._identityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetails()); set { {_identityDetail = value;} } }

        /// <summary>Internal Acessors for RestoreTargetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal.RestoreTargetInfo { get => (this._restoreTargetInfo = this._restoreTargetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfoBase()); set { {_restoreTargetInfo = value;} } }

        /// <summary>Internal Acessors for RestoreTargetInfoRecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequestInternal.RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RecoveryOption = value ; }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Backing field for <see cref="RestoreTargetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase _restoreTargetInfo;

        /// <summary>Gets or sets the restore target information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase RestoreTargetInfo { get => (this._restoreTargetInfo = this._restoreTargetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfoBase()); set => this._restoreTargetInfo = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).ObjectType = value ; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string RestoreTargetInfoRestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)RestoreTargetInfo).RestoreLocation = value ?? null; }

        /// <summary>Backing field for <see cref="SourceDataStoreType" /> property.</summary>
        private string _sourceDataStoreType;

        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string SourceDataStoreType { get => this._sourceDataStoreType; set => this._sourceDataStoreType = value; }

        /// <summary>Backing field for <see cref="SourceResourceId" /> property.</summary>
        private string _sourceResourceId;

        /// <summary>
        /// Fully qualified Azure Resource Manager ID of the datasource which is being recovered.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string SourceResourceId { get => this._sourceResourceId; set => this._sourceResourceId = value; }

        /// <summary>Creates an new <see cref="AzureBackupRestoreRequest" /> instance.</summary>
        public AzureBackupRestoreRequest()
        {

        }
    }
    /// Azure backup restore request
    public partial interface IAzureBackupRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
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

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }
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
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
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
        string SourceDataStoreType { get; set; }
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
        string SourceResourceId { get; set; }

    }
    /// Azure backup restore request
    internal partial interface IAzureBackupRestoreRequestInternal

    {
        /// <summary>
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails IdentityDetail { get; set; }
        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        bool? IdentityDetailUseSystemAssignedIdentity { get; set; }
        /// <summary>ARM URL for User Assigned Identity.</summary>
        string IdentityDetailUserAssignedIdentityArmUrl { get; set; }

        string ObjectType { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Gets or sets the restore target information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase RestoreTargetInfo { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string RestoreTargetInfoObjectType { get; set; }
        /// <summary>Recovery Option</summary>
        string RestoreTargetInfoRecoveryOption { get; set; }
        /// <summary>Target Restore region</summary>
        string RestoreTargetInfoRestoreLocation { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ArchiveStore", "SnapshotStore", "OperationalStore", "VaultStore")]
        string SourceDataStoreType { get; set; }
        /// <summary>
        /// Fully qualified Azure Resource Manager ID of the datasource which is being recovered.
        /// </summary>
        string SourceResourceId { get; set; }

    }
}