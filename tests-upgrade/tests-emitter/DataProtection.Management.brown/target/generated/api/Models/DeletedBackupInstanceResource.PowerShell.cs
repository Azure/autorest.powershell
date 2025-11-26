// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Deleted Backup Instance</summary>
    [System.ComponentModel.TypeConverter(typeof(DeletedBackupInstanceResourceTypeConverter))]
    public partial class DeletedBackupInstanceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeletedBackupInstanceResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstanceTypeConverter.ConvertFrom);
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("IdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo) content.GetValueForProperty("DeletionInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfoPolicyParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters) content.GetValueForProperty("PolicyInfoPolicyParameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatusStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus = (string) content.GetValueForProperty("PropertiesProtectionStatusStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ProtectionErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails) content.GetValueForProperty("PropertiesProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).CurrentProtectionState = (string) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).CurrentProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType = (string) content.GetValueForProperty("DataSourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoObjectType = (string) content.GetValueForProperty("DataSourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceId = (string) content.GetValueForProperty("DataSourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation = (string) content.GetValueForProperty("DataSourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceName = (string) content.GetValueForProperty("DataSourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceType = (string) content.GetValueForProperty("DataSourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceUri = (string) content.GetValueForProperty("DataSourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType = (string) content.GetValueForProperty("DataSourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType = (string) content.GetValueForProperty("DataSourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId = (string) content.GetValueForProperty("DataSourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation = (string) content.GetValueForProperty("DataSourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName = (string) content.GetValueForProperty("DataSourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType = (string) content.GetValueForProperty("DataSourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri = (string) content.GetValueForProperty("DataSourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyId = (string) content.GetValueForProperty("PolicyInfoPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion = (string) content.GetValueForProperty("PolicyInfoPolicyVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStatusErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionStatusErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailCode = (string) content.GetValueForProperty("ProtectionErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ProtectionErrorDetailDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectionErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ProtectionErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage = (string) content.GetValueForProperty("ProtectionErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProtectionErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProtectionErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget = (string) content.GetValueForProperty("ProtectionErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeletionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeletionTime = (string) content.GetValueForProperty("DeletionInfoDeletionTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeletionTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoBillingEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoBillingEndDate = (string) content.GetValueForProperty("DeletionInfoBillingEndDate",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoBillingEndDate, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoScheduledPurgeTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoScheduledPurgeTime = (string) content.GetValueForProperty("DeletionInfoScheduledPurgeTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoScheduledPurgeTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeleteActivityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeleteActivityId = (string) content.GetValueForProperty("DeletionInfoDeleteActivityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeleteActivityId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyParameterDataStoreParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>) content.GetValueForProperty("PolicyParameterDataStoreParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DataStoreParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyParameterBackupDatasourceParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>) content.GetValueForProperty("PolicyParameterBackupDatasourceParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupDatasourceParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeletedBackupInstanceResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstance) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstanceTypeConverter.ConvertFrom);
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyInfo) content.GetValueForProperty("PolicyInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("IdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletionInfo) content.GetValueForProperty("DeletionInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyInfoPolicyParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPolicyParameters) content.GetValueForProperty("PolicyInfoPolicyParameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyParameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PolicyParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatusStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus = (string) content.GetValueForProperty("PropertiesProtectionStatusStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatusStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ProtectionErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DataSourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DataSourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesProtectionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails) content.GetValueForProperty("PropertiesProtectionStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PropertiesProtectionStatus, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProtectionStatusDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).CurrentProtectionState = (string) content.GetValueForProperty("CurrentProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).CurrentProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType = (string) content.GetValueForProperty("DataSourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoObjectType = (string) content.GetValueForProperty("DataSourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceId = (string) content.GetValueForProperty("DataSourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation = (string) content.GetValueForProperty("DataSourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceName = (string) content.GetValueForProperty("DataSourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceType = (string) content.GetValueForProperty("DataSourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceUri = (string) content.GetValueForProperty("DataSourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DataSourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataSourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType = (string) content.GetValueForProperty("DataSourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType = (string) content.GetValueForProperty("DataSourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId = (string) content.GetValueForProperty("DataSourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation = (string) content.GetValueForProperty("DataSourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName = (string) content.GetValueForProperty("DataSourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType = (string) content.GetValueForProperty("DataSourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri = (string) content.GetValueForProperty("DataSourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DataSourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DataSourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DataSourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyId = (string) content.GetValueForProperty("PolicyInfoPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyInfoPolicyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion = (string) content.GetValueForProperty("PolicyInfoPolicyVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyInfoPolicyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStatusErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("ProtectionStatusErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionStatusErrorDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("ErrorDetailInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailCode = (string) content.GetValueForProperty("ProtectionErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailDetails"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ProtectionErrorDetailDetails",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailDetails, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectionErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError = (bool?) content.GetValueForProperty("ProtectionErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ProtectionErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectionErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage = (string) content.GetValueForProperty("ProtectionErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProtectionErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProtectionErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget = (string) content.GetValueForProperty("ProtectionErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ProtectionErrorDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeletionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeletionTime = (string) content.GetValueForProperty("DeletionInfoDeletionTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeletionTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoBillingEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoBillingEndDate = (string) content.GetValueForProperty("DeletionInfoBillingEndDate",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoBillingEndDate, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoScheduledPurgeTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoScheduledPurgeTime = (string) content.GetValueForProperty("DeletionInfoScheduledPurgeTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoScheduledPurgeTime, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionInfoDeleteActivityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeleteActivityId = (string) content.GetValueForProperty("DeletionInfoDeleteActivityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).DeletionInfoDeleteActivityId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyParameterDataStoreParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>) content.GetValueForProperty("PolicyParameterDataStoreParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterDataStoreParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDataStoreParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DataStoreParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyParameterBackupDatasourceParametersList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>) content.GetValueForProperty("PolicyParameterBackupDatasourceParametersList",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).PolicyParameterBackupDatasourceParametersList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupDatasourceParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BackupDatasourceParametersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailCode = (string) content.GetValueForProperty("ErrorDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorDetailIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsRetryable = (bool?) content.GetValueForProperty("ErrorDetailIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsUserError = (bool?) content.GetValueForProperty("ErrorDetailIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ErrorDetailProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("ErrorDetailProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailMessage = (string) content.GetValueForProperty("ErrorDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetailRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("ErrorDetailRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ErrorDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailTarget = (string) content.GetValueForProperty("ErrorDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResourceInternal)this).ErrorDetailTarget, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeletedBackupInstanceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupInstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeletedBackupInstanceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeletedBackupInstanceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DeletedBackupInstanceResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupInstanceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

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
    [System.ComponentModel.TypeConverter(typeof(DeletedBackupInstanceResourceTypeConverter))]
    public partial interface IDeletedBackupInstanceResource

    {

    }
}