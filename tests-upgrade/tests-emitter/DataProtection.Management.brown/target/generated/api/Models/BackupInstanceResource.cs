// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>BackupInstance Resource</summary>
    public partial class BackupInstanceResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProxyResource();

        /// <summary>Specifies the current protection state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CurrentProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).CurrentProtectionState; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoDatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoDatasourceType = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceId = value ?? null; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourcePropertiesObjectType; }

        /// <summary>Properties specific to data source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceUri = value ?? null; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoDatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoDatasourceType = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceId = value ?? null; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourcePropertiesObjectType; }

        /// <summary>Properties specific to data source set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DataSourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DataSourceSetInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceUri = value ?? null; }

        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials DatasourceAuthCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DatasourceAuthCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DatasourceAuthCredentials = value ?? null /* model class */; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceAuthCredentialsObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DatasourceAuthCredentialsObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DatasourceAuthCredentialsObjectType = value ?? null; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetail; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailCode; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailInnerError; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailIsRetryable; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailIsUserError; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailMessage; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailProperty; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailRecommendedAction; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailTarget; }

        /// <summary>Gets or sets the Backup Instance friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).FriendlyName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Specifies if the BI is protected by System Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? IdentityDetailUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).IdentityDetailUseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).IdentityDetailUseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>ARM URL for User Assigned Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string IdentityDetailUserAssignedIdentityArmUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).IdentityDetailUserAssignedIdentityArmUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).IdentityDetailUserAssignedIdentityArmUrl = value ?? null; }

        /// <summary>Internal Acessors for CurrentProtectionState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.CurrentProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).CurrentProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).CurrentProtectionState = value ?? null; }

        /// <summary>Internal Acessors for DataSourceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DataSourceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DataSourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourcePropertiesObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourcePropertiesObjectType = value ?? null; }

        /// <summary>Internal Acessors for DataSourceInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DataSourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceSetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DataSourceSetInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DataSourceSetInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DataSourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourcePropertiesObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourcePropertiesObjectType = value ?? null; }

        /// <summary>Internal Acessors for DataSourceSetInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DataSourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DataSourceSetInfoResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatasourceAuthCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.DatasourceAuthCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DatasourceAuthCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).DatasourceAuthCredentials = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailInnerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailInnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailInnerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetailIsRetryable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailIsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailIsRetryable = value ?? default(bool); }

        /// <summary>Internal Acessors for ErrorDetailIsUserError</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailIsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailIsUserError = value ?? default(bool); }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetailRecommendedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailRecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailRecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ErrorDetailTarget = value ?? null; }

        /// <summary>Internal Acessors for IdentityDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.IdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).IdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).IdentityDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.PolicyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfoPolicyParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.PolicyInfoPolicyParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyParameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PolicyInfoPolicyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.PolicyInfoPolicyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyVersion = value ?? null; }

        /// <summary>Internal Acessors for PropertiesProtectionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.PropertiesProtectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatus = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PropertiesProtectionStatusStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.PropertiesProtectionStatusStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatusStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatusStatus = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstance()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProtectionErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetailDetails</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailDetails; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailDetails = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailInnerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailInnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailInnerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailIsRetryable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailIsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailIsRetryable = value ?? default(bool); }

        /// <summary>Internal Acessors for ProtectionErrorDetailIsUserError</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailIsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailIsUserError = value ?? default(bool); }

        /// <summary>Internal Acessors for ProtectionErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ProtectionErrorDetailProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailRecommendedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailRecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailRecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProtectionErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailTarget = value ?? null; }

        /// <summary>Internal Acessors for ProtectionStatusErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProtectionStatusErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatusErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatusErrorDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Name; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ObjectType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string PolicyInfoPolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string PolicyInfoPolicyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyInfoPolicyVersion; }

        /// <summary>Gets or sets the Backup Data Source Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters> PolicyParameterBackupDatasourceParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyParameterBackupDatasourceParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyParameterBackupDatasourceParametersList = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the DataStore Parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters> PolicyParameterDataStoreParametersList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyParameterDataStoreParametersList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).PolicyParameterDataStoreParametersList = value ?? null /* arrayOf */; }

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string PropertiesProtectionStatusStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionStatusStatus; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance _property;

        /// <summary>BackupInstanceResource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstance()); set => this._property = value; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailCode; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ProtectionErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailDetails; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ProtectionErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailInnerError; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ProtectionErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailIsRetryable; }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ProtectionErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailIsUserError; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailMessage; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ProtectionErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailProperty; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ProtectionErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailRecommendedAction; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProtectionErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProtectionErrorDetailTarget; }

        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags _tag;

        /// <summary>Proxy Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResourceTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>
        /// Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ValidationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ValidationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)Property).ValidationType = value ?? null; }

        /// <summary>Creates an new <see cref="BackupInstanceResource" /> instance.</summary>
        public BackupInstanceResource()
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
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// BackupInstance Resource
    public partial interface IBackupInstanceResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResource
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
        Required = false,
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
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
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
        string PropertiesProtectionStatusStatus { get;  }
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
        /// <summary>Proxy Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Proxy Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags Tag { get; set; }
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
    /// BackupInstance Resource
    internal partial interface IBackupInstanceResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResourceInternal
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
        /// <summary>Specifies the protection status of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails PropertiesProtectionStatus { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ConfiguringProtection", "ConfiguringProtectionFailed", "ProtectionConfigured", "ProtectionStopped", "SoftDeleted", "SoftDeleting")]
        string PropertiesProtectionStatusStatus { get; set; }
        /// <summary>BackupInstanceResource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance Property { get; set; }
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
        /// <summary>Specifies the protection status error of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ProtectionStatusErrorDetail { get; set; }
        /// <summary>
        /// Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Proxy Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags Tag { get; set; }
        /// <summary>
        /// Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ShallowValidation", "DeepValidation")]
        string ValidationType { get; set; }

    }
}