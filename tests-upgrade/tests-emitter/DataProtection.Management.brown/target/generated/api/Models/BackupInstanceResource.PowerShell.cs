// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>BackupInstance Resource</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupInstanceResourceTypeConverter))]
    public partial class BackupInstanceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupInstanceResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("IdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails) content.GetValueForProperty("PropertiesProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).CurrentProtectionState = (string) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).CurrentProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters) content.GetValueForProperty("PolicyInfoPolicyParameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatusStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus = (string) content.GetValueForProperty("PropertiesProtectionStatusStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ProtectionErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType = (string) content.GetValueForProperty("DataSourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoObjectType = (string) content.GetValueForProperty("DataSourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceId = (string) content.GetValueForProperty("DataSourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation = (string) content.GetValueForProperty("DataSourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceName = (string) content.GetValueForProperty("DataSourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceType = (string) content.GetValueForProperty("DataSourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceUri = (string) content.GetValueForProperty("DataSourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType = (string) content.GetValueForProperty("DataSourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType = (string) content.GetValueForProperty("DataSourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId = (string) content.GetValueForProperty("DataSourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation = (string) content.GetValueForProperty("DataSourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName = (string) content.GetValueForProperty("DataSourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType = (string) content.GetValueForProperty("DataSourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri = (string) content.GetValueForProperty("DataSourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyId = (string) content.GetValueForProperty("PolicyInfoPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion = (string) content.GetValueForProperty("PolicyInfoPolicyVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStatusErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionStatusErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailCode = (string) content.GetValueForProperty("ProtectionErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ProtectionErrorDetailDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectionErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ProtectionErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage = (string) content.GetValueForProperty("ProtectionErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProtectionErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProtectionErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget = (string) content.GetValueForProperty("ProtectionErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyParameterDataStoreParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>) content.GetValueForProperty("PolicyParameterDataStoreParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DataStoreParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyParameterBackupDatasourceParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>) content.GetValueForProperty("PolicyParameterBackupDatasourceParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupDatasourceParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupInstanceResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstance) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("IdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails) content.GetValueForProperty("PropertiesProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).CurrentProtectionState = (string) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).CurrentProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters) content.GetValueForProperty("PolicyInfoPolicyParameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatusStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus = (string) content.GetValueForProperty("PropertiesProtectionStatusStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ProtectionErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType = (string) content.GetValueForProperty("DataSourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoObjectType = (string) content.GetValueForProperty("DataSourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceId = (string) content.GetValueForProperty("DataSourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation = (string) content.GetValueForProperty("DataSourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceName = (string) content.GetValueForProperty("DataSourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceType = (string) content.GetValueForProperty("DataSourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceUri = (string) content.GetValueForProperty("DataSourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType = (string) content.GetValueForProperty("DataSourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType = (string) content.GetValueForProperty("DataSourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId = (string) content.GetValueForProperty("DataSourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation = (string) content.GetValueForProperty("DataSourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName = (string) content.GetValueForProperty("DataSourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType = (string) content.GetValueForProperty("DataSourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri = (string) content.GetValueForProperty("DataSourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyId = (string) content.GetValueForProperty("PolicyInfoPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion = (string) content.GetValueForProperty("PolicyInfoPolicyVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStatusErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionStatusErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailCode = (string) content.GetValueForProperty("ProtectionErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ProtectionErrorDetailDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectionErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ProtectionErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage = (string) content.GetValueForProperty("ProtectionErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProtectionErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProtectionErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget = (string) content.GetValueForProperty("ProtectionErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyParameterDataStoreParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>) content.GetValueForProperty("PolicyParameterDataStoreParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DataStoreParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyParameterBackupDatasourceParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>) content.GetValueForProperty("PolicyParameterBackupDatasourceParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupDatasourceParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResourceInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupInstanceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupInstanceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupInstanceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BackupInstanceResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstanceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// BackupInstance Resource
    [System.ComponentModel.TypeConverter(typeof(BackupInstanceResourceTypeConverter))]
    public partial interface IBackupInstanceResource

    {

    }
}