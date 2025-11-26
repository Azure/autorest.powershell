// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Backup Instance</summary>
    public partial class BackupInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal
    {

        /// <summary>Backing field for <see cref="CurrentProtectionState" /> property.</summary>
        private string _currentProtectionState;

        /// <summary>Specifies the current protection state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string CurrentProtectionState { get => this._currentProtectionState; }

        /// <summary>Backing field for <see cref="DataSourceInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource _dataSourceInfo;

        /// <summary>Gets or sets the data source information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource DataSourceInfo { get => (this._dataSourceInfo = this._dataSourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Datasource()); set => this._dataSourceInfo = value; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).Type = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceId = value ; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourcePropertyObjectType; }

        /// <summary>Properties specific to data source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceUri = value ?? null; }

        /// <summary>Backing field for <see cref="DataSourceSetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet _dataSourceSetInfo;

        /// <summary>Gets or sets the data source set information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet DataSourceSetInfo { get => (this._dataSourceSetInfo = this._dataSourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSet()); set => this._dataSourceSetInfo = value; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).DatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).DatasourceType = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceId = value ?? null; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourcePropertyObjectType; }

        /// <summary>Properties specific to data source set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceUri = value ?? null; }

        /// <summary>Backing field for <see cref="DatasourceAuthCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials _datasourceAuthCredentials;

        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials DatasourceAuthCredentials { get => (this._datasourceAuthCredentials = this._datasourceAuthCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentials()); set => this._datasourceAuthCredentials = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceAuthCredentialsObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentialsInternal)DatasourceAuthCredentials).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentialsInternal)DatasourceAuthCredentials).ObjectType = value ?? null; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailDetails; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailCode; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailInnerError; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailIsRetryable; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailIsUserError; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailMessage; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailProperty; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailRecommendedAction; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailTarget; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Gets or sets the Backup Instance friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

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

        /// <summary>Internal Acessors for CurrentProtectionState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.CurrentProtectionState { get => this._currentProtectionState; set { {_currentProtectionState = value;} } }

        /// <summary>Internal Acessors for DataSourceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceInfo { get => (this._dataSourceInfo = this._dataSourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Datasource()); set { {_dataSourceInfo = value;} } }

        /// <summary>Internal Acessors for DataSourceInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourcePropertyObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourcePropertyObjectType = value ?? null; }

        /// <summary>Internal Acessors for DataSourceInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DataSourceInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceSetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceSetInfo { get => (this._dataSourceSetInfo = this._dataSourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSet()); set { {_dataSourceSetInfo = value;} } }

        /// <summary>Internal Acessors for DataSourceSetInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourcePropertyObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourcePropertyObjectType = value ?? null; }

        /// <summary>Internal Acessors for DataSourceSetInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DataSourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DataSourceSetInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatasourceAuthCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.DatasourceAuthCredentials { get => (this._datasourceAuthCredentials = this._datasourceAuthCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentials()); set { {_datasourceAuthCredentials = value;} } }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailDetails; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailDetails = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailInnerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailInnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailInnerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetailIsRetryable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailIsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailIsRetryable = value ?? default(bool); }

        /// <summary>Internal Acessors for ErrorDetailIsUserError</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailIsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailIsUserError = value ?? default(bool); }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetailRecommendedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailRecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailRecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetailTarget = value ?? null; }

        /// <summary>Internal Acessors for IdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.IdentityDetail { get => (this._identityDetail = this._identityDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetails()); set { {_identityDetail = value;} } }

        /// <summary>Internal Acessors for PolicyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.PolicyInfo { get => (this._policyInfo = this._policyInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfo()); set { {_policyInfo = value;} } }

        /// <summary>Internal Acessors for PolicyInfoPolicyParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.PolicyInfoPolicyParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyParameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfoPolicyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.PolicyInfoPolicyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyVersion = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetail { get => (this._protectionErrorDetail = this._protectionErrorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingError()); set { {_protectionErrorDetail = value;} } }

        /// <summary>Internal Acessors for ProtectionErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Code = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetailDetails</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailInnerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).InnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).InnerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailIsRetryable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).IsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).IsRetryable = value ?? default(bool); }

        /// <summary>Internal Acessors for ProtectionErrorDetailIsUserError</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).IsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).IsUserError = value ?? default(bool); }

        /// <summary>Internal Acessors for ProtectionErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Message = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetailProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Property = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailRecommendedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).RecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).RecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Target = value ?? null; }

        /// <summary>Internal Acessors for ProtectionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionStatus { get => (this._protectionStatus = this._protectionStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetails()); set { {_protectionStatus = value;} } }

        /// <summary>Internal Acessors for ProtectionStatusErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionStatusErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).ErrorDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionStatusStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProtectionStatusStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).Status = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="PolicyInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo _policyInfo;

        /// <summary>Gets or sets the policy information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo PolicyInfo { get => (this._policyInfo = this._policyInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfo()); set => this._policyInfo = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string PolicyInfoPolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyId = value ; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string PolicyInfoPolicyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyVersion; }

        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyParameterBackupDatasourceParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyParameterBackupDatasourceParametersList = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the DataStore Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyParameterDataStoreParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfoInternal)PolicyInfo).PolicyParameterDataStoreParametersList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ProtectionErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError _protectionErrorDetail;

        /// <summary>Specifies the protection error of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ProtectionErrorDetail { get => (this._protectionErrorDetail = this._protectionErrorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingError()); }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Code; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ProtectionErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Detail; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ProtectionErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).InnerError; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ProtectionErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).IsRetryable; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ProtectionErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).IsUserError; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Message; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ProtectionErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Property; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ProtectionErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).RecommendedAction; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ProtectionErrorDetail).Target; }

        /// <summary>Backing field for <see cref="ProtectionStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails _protectionStatus;

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails ProtectionStatus { get => (this._protectionStatus = this._protectionStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetails()); }

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionStatusStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal)ProtectionStatus).Status; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Backing field for <see cref="ValidationType" /> property.</summary>
        private string _validationType;

        /// <summary>
        /// Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ValidationType { get => this._validationType; set => this._validationType = value; }

        /// <summary>Creates an new <see cref="BackupInstance" /> instance.</summary>
        public BackupInstance()
        {

        }
    }
    /// Backup Instance
    public partial interface IBackupInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the current protection state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the current protection state of the resource",
        SerializedName = @"currentProtectionState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Invalid", "NotProtected", "ConfiguringProtection", "ProtectionConfigured", "BackupSchedulesSuspended", "RetentionSchedulesSuspended", "ProtectionStopped", "ProtectionError", "ConfiguringProtectionFailed", "SoftDeleting", "SoftDeleted", "UpdatingProtection")]
        string CurrentProtectionState { get;  }
        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DatasourceType of the resource.",
        SerializedName = @"datasourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.",
        SerializedName = @"resourceID",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location of datasource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier of the resource in the context of parent.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoResourcePropertiesObjectType { get;  }
        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Type of Datasource.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Uri of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceInfoResourceUri { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DatasourceType of the resource.",
        SerializedName = @"datasourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.",
        SerializedName = @"resourceID",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location of datasource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier of the resource in the context of parent.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoResourcePropertiesObjectType { get;  }
        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Type of Datasource.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Uri of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string DataSourceSetInfoResourceUri { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceAuthCredentialsObjectType { get; set; }
        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Additional related Errors",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetail { get;  }
        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique code for this error",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get;  }
        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Inner Error",
        SerializedName = @"innerError",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get;  }
        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the operation will be retryable or not",
        SerializedName = @"isRetryable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ErrorDetailIsRetryable { get;  }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the operation is due to a user error or service error",
        SerializedName = @"isUserError",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ErrorDetailIsUserError { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get;  }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Any key value pairs that can be injected inside error object",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get;  }
        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"RecommendedAction � localized.",
        SerializedName = @"recommendedAction",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get;  }
        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailTarget { get;  }
        /// <summary>Gets or sets the Backup Instance friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Backup Instance friendly name.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
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

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyInfoPolicyId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"policyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyInfoPolicyVersion { get;  }
        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Backup Data Source Parameters",
        SerializedName = @"backupDatasourceParametersList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get; set; }
        /// <summary>Gets or sets the DataStore Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the DataStore Parameters",
        SerializedName = @"dataStoreParametersList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get; set; }
        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique code for this error",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionErrorDetailCode { get;  }
        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Additional related Errors",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ProtectionErrorDetailDetails { get;  }
        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Inner Error",
        SerializedName = @"innerError",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ProtectionErrorDetailInnerError { get;  }
        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the operation will be retryable or not",
        SerializedName = @"isRetryable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProtectionErrorDetailIsRetryable { get;  }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the operation is due to a user error or service error",
        SerializedName = @"isUserError",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProtectionErrorDetailIsUserError { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionErrorDetailMessage { get;  }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Any key value pairs that can be injected inside error object",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ProtectionErrorDetailProperty { get;  }
        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"RecommendedAction � localized.",
        SerializedName = @"recommendedAction",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ProtectionErrorDetailRecommendedAction { get;  }
        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionErrorDetailTarget { get;  }
        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the protection status of the resource",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ConfiguringProtection", "ConfiguringProtectionFailed", "ProtectionConfigured", "ProtectionStopped", "SoftDeleted", "SoftDeleting")]
        string ProtectionStatusStatus { get;  }
        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
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
        /// <summary>
        /// Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.",
        SerializedName = @"validationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ShallowValidation", "DeepValidation")]
        string ValidationType { get; set; }

    }
    /// Backup Instance
    internal partial interface IBackupInstanceInternal

    {
        /// <summary>Specifies the current protection state of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Invalid", "NotProtected", "ConfiguringProtection", "ProtectionConfigured", "BackupSchedulesSuspended", "RetentionSchedulesSuspended", "ProtectionStopped", "ProtectionError", "ConfiguringProtectionFailed", "SoftDeleting", "SoftDeleted", "UpdatingProtection")]
        string CurrentProtectionState { get; set; }
        /// <summary>Gets or sets the data source information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource DataSourceInfo { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        string DataSourceInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DataSourceInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        string DataSourceInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        string DataSourceInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        string DataSourceInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DataSourceInfoResourcePropertiesObjectType { get; set; }
        /// <summary>Properties specific to data source</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceInfoResourceProperty { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        string DataSourceInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        string DataSourceInfoResourceUri { get; set; }
        /// <summary>Gets or sets the data source set information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet DataSourceSetInfo { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        string DataSourceSetInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DataSourceSetInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        string DataSourceSetInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        string DataSourceSetInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        string DataSourceSetInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DataSourceSetInfoResourcePropertiesObjectType { get; set; }
        /// <summary>Properties specific to data source set</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceSetInfoResourceProperty { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        string DataSourceSetInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        string DataSourceSetInfoResourceUri { get; set; }
        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials DatasourceAuthCredentials { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DatasourceAuthCredentialsObjectType { get; set; }
        /// <summary>Additional related Errors</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetail { get; set; }
        /// <summary>Unique code for this error</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Inner Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        bool? ErrorDetailIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        bool? ErrorDetailIsUserError { get; set; }

        string ErrorDetailMessage { get; set; }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get; set; }
        /// <summary>RecommendedAction � localized.</summary>
        System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        string ErrorDetailTarget { get; set; }
        /// <summary>Gets or sets the Backup Instance friendly name.</summary>
        string FriendlyName { get; set; }
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
        /// <summary>Gets or sets the policy information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo PolicyInfo { get; set; }

        string PolicyInfoPolicyId { get; set; }
        /// <summary>Policy parameters for the backup instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters PolicyInfoPolicyParameter { get; set; }

        string PolicyInfoPolicyVersion { get; set; }
        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get; set; }
        /// <summary>Gets or sets the DataStore Parameters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get; set; }
        /// <summary>Specifies the protection error of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ProtectionErrorDetail { get; set; }
        /// <summary>Unique code for this error</summary>
        string ProtectionErrorDetailCode { get; set; }
        /// <summary>Additional related Errors</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ProtectionErrorDetailDetails { get; set; }
        /// <summary>Inner Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ProtectionErrorDetailInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        bool? ProtectionErrorDetailIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        bool? ProtectionErrorDetailIsUserError { get; set; }

        string ProtectionErrorDetailMessage { get; set; }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ProtectionErrorDetailProperty { get; set; }
        /// <summary>RecommendedAction � localized.</summary>
        System.Collections.Generic.List<string> ProtectionErrorDetailRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        string ProtectionErrorDetailTarget { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails ProtectionStatus { get; set; }
        /// <summary>Specifies the protection status error of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ProtectionStatusErrorDetail { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ConfiguringProtection", "ConfiguringProtectionFailed", "ProtectionConfigured", "ProtectionStopped", "SoftDeleted", "SoftDeleting")]
        string ProtectionStatusStatus { get; set; }
        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>
        /// Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ShallowValidation", "DeepValidation")]
        string ValidationType { get; set; }

    }
}