// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Deleted Backup Instance</summary>
    public partial class DeletedBackupInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance __backupInstance = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstance();

        /// <summary>Specifies the current protection state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string CurrentProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).CurrentProtectionState; }

        /// <summary>Gets or sets the data source information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource DataSourceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfo = value ?? null /* model class */; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoDatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoDatasourceType = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceId = value ; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourcePropertiesObjectType; }

        /// <summary>Properties specific to data source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceUri = value ?? null; }

        /// <summary>Gets or sets the data source set information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet DataSourceSetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfo = value ?? null /* model class */; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoDatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoDatasourceType = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceId = value ?? null; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourcePropertiesObjectType; }

        /// <summary>Properties specific to data source set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DataSourceSetInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceUri = value ?? null; }

        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials DatasourceAuthCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DatasourceAuthCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DatasourceAuthCredentials = value ?? null /* model class */; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string DatasourceAuthCredentialsObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DatasourceAuthCredentialsObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DatasourceAuthCredentialsObjectType = value ?? null; }

        /// <summary>Backing field for <see cref="DeletionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo _deletionInfo;

        /// <summary>Deletion info of Backup Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo DeletionInfo { get => (this._deletionInfo = this._deletionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletionInfo()); }

        /// <summary>Specifies billing end date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DeletionInfoBillingEndDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).BillingEndDate; }

        /// <summary>Delete activity ID for troubleshooting purpose</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DeletionInfoDeleteActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).DeleteActivityId; }

        /// <summary>Specifies time of deletion</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DeletionInfoDeletionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).DeletionTime; }

        /// <summary>Specifies purge time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DeletionInfoScheduledPurgeTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).ScheduledPurgeTime; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetail; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailCode; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailInnerError; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public bool? ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailIsRetryable; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public bool? ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailIsUserError; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailMessage; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailProperty; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailRecommendedAction; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailTarget; }

        /// <summary>Gets or sets the Backup Instance friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).FriendlyName = value ?? null; }

        /// <summary>
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails IdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetail = value ?? null /* model class */; }

        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public bool? IdentityDetailUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetailUseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetailUseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>ARM URL for User Assigned Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string IdentityDetailUserAssignedIdentityArmUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetailUserAssignedIdentityArmUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetailUserAssignedIdentityArmUrl = value ?? null; }

        /// <summary>Internal Acessors for CurrentProtectionState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.CurrentProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).CurrentProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).CurrentProtectionState = value ?? null; }

        /// <summary>Internal Acessors for DataSourceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourcePropertiesObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourcePropertiesObjectType = value ?? null; }

        /// <summary>Internal Acessors for DataSourceInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceSetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceSetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceSetInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourcePropertiesObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourcePropertiesObjectType = value ?? null; }

        /// <summary>Internal Acessors for DataSourceSetInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DataSourceSetInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatasourceAuthCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DatasourceAuthCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DatasourceAuthCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).DatasourceAuthCredentials = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailInnerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailInnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailInnerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetailIsRetryable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailIsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailIsRetryable = value ?? default(bool); }

        /// <summary>Internal Acessors for ErrorDetailIsUserError</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailIsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailIsUserError = value ?? default(bool); }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetailRecommendedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailRecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailRecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ErrorDetailTarget = value ?? null; }

        /// <summary>Internal Acessors for IdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.IdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).IdentityDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.PolicyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfoPolicyParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.PolicyInfoPolicyParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyParameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfoPolicyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.PolicyInfoPolicyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyVersion = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailDetails; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailDetails = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetailInnerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailInnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailInnerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailIsRetryable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailIsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailIsRetryable = value ?? default(bool); }

        /// <summary>Internal Acessors for ProtectionErrorDetailIsUserError</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailIsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailIsUserError = value ?? default(bool); }

        /// <summary>Internal Acessors for ProtectionErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetailProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailRecommendedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailRecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailRecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailTarget = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetails</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatus = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionStatusErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionStatusErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatusErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatusErrorDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionStatusStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionStatusStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatusStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatusStatus = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for DeletionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal.DeletionInfo { get => (this._deletionInfo = this._deletionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletionInfo()); set { {_deletionInfo = value;} } }

        /// <summary>Internal Acessors for DeletionInfoBillingEndDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal.DeletionInfoBillingEndDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).BillingEndDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).BillingEndDate = value ?? null; }

        /// <summary>Internal Acessors for DeletionInfoDeleteActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal.DeletionInfoDeleteActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).DeleteActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).DeleteActivityId = value ?? null; }

        /// <summary>Internal Acessors for DeletionInfoDeletionTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal.DeletionInfoDeletionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).DeletionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).DeletionTime = value ?? null; }

        /// <summary>Internal Acessors for DeletionInfoScheduledPurgeTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal.DeletionInfoScheduledPurgeTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).ScheduledPurgeTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfoInternal)DeletionInfo).ScheduledPurgeTime = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ObjectType = value ; }

        /// <summary>Gets or sets the policy information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo PolicyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfo = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string PolicyInfoPolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyId = value ; }

        /// <summary>Policy parameters for the backup instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters PolicyInfoPolicyParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyParameter = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string PolicyInfoPolicyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyInfoPolicyVersion; }

        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyParameterBackupDatasourceParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyParameterBackupDatasourceParametersList = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the DataStore Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyParameterDataStoreParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).PolicyParameterDataStoreParametersList = value ?? null /* arrayOf */; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ProtectionErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailDetails; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ProtectionErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailCode; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ProtectionErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailInnerError; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public bool? ProtectionErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailIsRetryable; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public bool? ProtectionErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailIsUserError; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ProtectionErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailMessage; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ProtectionErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailProperty; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ProtectionErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailRecommendedAction; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ProtectionErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetailTarget; }

        /// <summary>Specifies the protection error of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ProtectionErrorDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionErrorDetail = value ?? null /* model class */; }

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails ProtectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatus = value ?? null /* model class */; }

        /// <summary>Specifies the protection status error of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ProtectionStatusErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatusErrorDetail; }

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ProtectionStatusStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProtectionStatusStatus; }

        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ProvisioningState; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>
        /// Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ValidationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ValidationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)__backupInstance).ValidationType = value ?? null; }

        /// <summary>Creates an new <see cref="DeletedBackupInstance" /> instance.</summary>
        public DeletedBackupInstance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__backupInstance), __backupInstance);
            await eventListener.AssertObjectIsValid(nameof(__backupInstance), __backupInstance);
        }
    }
    /// Deleted Backup Instance
    public partial interface IDeletedBackupInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance
    {
        /// <summary>Specifies billing end date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies billing end date",
        SerializedName = @"billingEndDate",
        PossibleTypes = new [] { typeof(string) })]
        string DeletionInfoBillingEndDate { get;  }
        /// <summary>Delete activity ID for troubleshooting purpose</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Delete activity ID for troubleshooting purpose",
        SerializedName = @"deleteActivityID",
        PossibleTypes = new [] { typeof(string) })]
        string DeletionInfoDeleteActivityId { get;  }
        /// <summary>Specifies time of deletion</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies time of deletion",
        SerializedName = @"deletionTime",
        PossibleTypes = new [] { typeof(string) })]
        string DeletionInfoDeletionTime { get;  }
        /// <summary>Specifies purge time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies purge time",
        SerializedName = @"scheduledPurgeTime",
        PossibleTypes = new [] { typeof(string) })]
        string DeletionInfoScheduledPurgeTime { get;  }

    }
    /// Deleted Backup Instance
    internal partial interface IDeletedBackupInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal
    {
        /// <summary>Deletion info of Backup Instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo DeletionInfo { get; set; }
        /// <summary>Specifies billing end date</summary>
        string DeletionInfoBillingEndDate { get; set; }
        /// <summary>Delete activity ID for troubleshooting purpose</summary>
        string DeletionInfoDeleteActivityId { get; set; }
        /// <summary>Specifies time of deletion</summary>
        string DeletionInfoDeletionTime { get; set; }
        /// <summary>Specifies purge time</summary>
        string DeletionInfoScheduledPurgeTime { get; set; }

    }
}