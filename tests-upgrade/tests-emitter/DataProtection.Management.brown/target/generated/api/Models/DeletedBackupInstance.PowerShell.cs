// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Deleted Backup Instance</summary>
    [System.ComponentModel.TypeConverter(typeof(DeletedBackupInstanceTypeConverter))]
    public partial class DeletedBackupInstance
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeletedBackupInstance(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeletionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo) content.GetValueForProperty("DeletionInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfoPolicyParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyParameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters) content.GetValueForProperty("PolicyInfoPolicyParameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyParameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionStatusStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusStatus = (string) content.GetValueForProperty("ProtectionStatusStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ProtectionErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoDatasourceType = (string) content.GetValueForProperty("DataSourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoObjectType = (string) content.GetValueForProperty("DataSourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceId = (string) content.GetValueForProperty("DataSourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceLocation = (string) content.GetValueForProperty("DataSourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceName = (string) content.GetValueForProperty("DataSourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceType = (string) content.GetValueForProperty("DataSourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceUri = (string) content.GetValueForProperty("DataSourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoDatasourceType = (string) content.GetValueForProperty("DataSourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoObjectType = (string) content.GetValueForProperty("DataSourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceId = (string) content.GetValueForProperty("DataSourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceLocation = (string) content.GetValueForProperty("DataSourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceName = (string) content.GetValueForProperty("DataSourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceType = (string) content.GetValueForProperty("DataSourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceUri = (string) content.GetValueForProperty("DataSourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyId = (string) content.GetValueForProperty("PolicyInfoPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyVersion = (string) content.GetValueForProperty("PolicyInfoPolicyVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStatusErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionStatusErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailCode = (string) content.GetValueForProperty("ProtectionErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailDetails = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ProtectionErrorDetailDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailDetails, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectionErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsUserError = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ProtectionErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailMessage = (string) content.GetValueForProperty("ProtectionErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProtectionErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProtectionErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailTarget = (string) content.GetValueForProperty("ProtectionErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyParameterDataStoreParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterDataStoreParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>) content.GetValueForProperty("PolicyParameterDataStoreParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterDataStoreParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DataStoreParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyParameterBackupDatasourceParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterBackupDatasourceParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>) content.GetValueForProperty("PolicyParameterBackupDatasourceParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterBackupDatasourceParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupDatasourceParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails) content.GetValueForProperty("ProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetails = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetails, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("IdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).CurrentProtectionState = (string) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).CurrentProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeletionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeletionTime = (string) content.GetValueForProperty("DeletionInfoDeletionTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeletionTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoBillingEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoBillingEndDate = (string) content.GetValueForProperty("DeletionInfoBillingEndDate",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoBillingEndDate, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoScheduledPurgeTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoScheduledPurgeTime = (string) content.GetValueForProperty("DeletionInfoScheduledPurgeTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoScheduledPurgeTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeleteActivityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeleteActivityId = (string) content.GetValueForProperty("DeletionInfoDeleteActivityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeleteActivityId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeletedBackupInstance(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeletionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo) content.GetValueForProperty("DeletionInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfoPolicyParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyParameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters) content.GetValueForProperty("PolicyInfoPolicyParameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyParameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionStatusStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusStatus = (string) content.GetValueForProperty("ProtectionStatusStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ProtectionErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoDatasourceType = (string) content.GetValueForProperty("DataSourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoObjectType = (string) content.GetValueForProperty("DataSourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceId = (string) content.GetValueForProperty("DataSourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceLocation = (string) content.GetValueForProperty("DataSourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceName = (string) content.GetValueForProperty("DataSourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceType = (string) content.GetValueForProperty("DataSourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceUri = (string) content.GetValueForProperty("DataSourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoDatasourceType = (string) content.GetValueForProperty("DataSourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoObjectType = (string) content.GetValueForProperty("DataSourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceId = (string) content.GetValueForProperty("DataSourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceLocation = (string) content.GetValueForProperty("DataSourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceName = (string) content.GetValueForProperty("DataSourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceType = (string) content.GetValueForProperty("DataSourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceUri = (string) content.GetValueForProperty("DataSourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyId = (string) content.GetValueForProperty("PolicyInfoPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyVersion = (string) content.GetValueForProperty("PolicyInfoPolicyVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfoPolicyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStatusErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionStatusErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatusErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailCode = (string) content.GetValueForProperty("ProtectionErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailDetails = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ProtectionErrorDetailDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailDetails, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectionErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsUserError = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ProtectionErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailMessage = (string) content.GetValueForProperty("ProtectionErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProtectionErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProtectionErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailTarget = (string) content.GetValueForProperty("ProtectionErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyParameterDataStoreParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterDataStoreParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>) content.GetValueForProperty("PolicyParameterDataStoreParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterDataStoreParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DataStoreParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyParameterBackupDatasourceParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterBackupDatasourceParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>) content.GetValueForProperty("PolicyParameterBackupDatasourceParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyParameterBackupDatasourceParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupDatasourceParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails) content.GetValueForProperty("ProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetails = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProtectionErrorDetails, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("IdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).IdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).CurrentProtectionState = (string) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).CurrentProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeletionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeletionTime = (string) content.GetValueForProperty("DeletionInfoDeletionTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeletionTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoBillingEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoBillingEndDate = (string) content.GetValueForProperty("DeletionInfoBillingEndDate",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoBillingEndDate, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoScheduledPurgeTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoScheduledPurgeTime = (string) content.GetValueForProperty("DeletionInfoScheduledPurgeTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoScheduledPurgeTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeleteActivityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeleteActivityId = (string) content.GetValueForProperty("DeletionInfoDeleteActivityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceInternal)this).DeletionInfoDeleteActivityId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeletedBackupInstance(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeletedBackupInstance(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeletedBackupInstance" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DeletedBackupInstance" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Deleted Backup Instance
    [System.ComponentModel.TypeConverter(typeof(DeletedBackupInstanceTypeConverter))]
    public partial interface IDeletedBackupInstance

    {

    }
}