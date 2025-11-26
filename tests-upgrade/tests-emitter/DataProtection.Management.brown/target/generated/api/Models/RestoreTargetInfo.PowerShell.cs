// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Class encapsulating restore target parameters</summary>
    [System.ComponentModel.TypeConverter(typeof(RestoreTargetInfoTypeConverter))]
    public partial class RestoreTargetInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RestoreTargetInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RestoreTargetInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RestoreTargetInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RestoreTargetInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RestoreTargetInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DatasourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DatasourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DatasourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RecoveryOption = (string) content.GetValueForProperty("RecoveryOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RecoveryOption, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RestoreLocation = (string) content.GetValueForProperty("RestoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RestoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DatasourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoDatasourceType = (string) content.GetValueForProperty("DatasourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoObjectType = (string) content.GetValueForProperty("DatasourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceId = (string) content.GetValueForProperty("DatasourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceLocation = (string) content.GetValueForProperty("DatasourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceName = (string) content.GetValueForProperty("DatasourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceType = (string) content.GetValueForProperty("DatasourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceUri = (string) content.GetValueForProperty("DatasourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DatasourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DatasourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoDatasourceType = (string) content.GetValueForProperty("DatasourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoObjectType = (string) content.GetValueForProperty("DatasourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceId = (string) content.GetValueForProperty("DatasourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceLocation = (string) content.GetValueForProperty("DatasourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceName = (string) content.GetValueForProperty("DatasourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceType = (string) content.GetValueForProperty("DatasourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceUri = (string) content.GetValueForProperty("DatasourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DatasourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RestoreTargetInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DatasourceInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource) content.GetValueForProperty("DatasourceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceSetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet) content.GetValueForProperty("DatasourceSetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceAuthCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials) content.GetValueForProperty("DatasourceAuthCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentials, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RecoveryOption = (string) content.GetValueForProperty("RecoveryOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RecoveryOption, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RestoreLocation = (string) content.GetValueForProperty("RestoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)this).RestoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DatasourceInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoDatasourceType = (string) content.GetValueForProperty("DatasourceInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoObjectType = (string) content.GetValueForProperty("DatasourceInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceId = (string) content.GetValueForProperty("DatasourceInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceLocation = (string) content.GetValueForProperty("DatasourceInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceName = (string) content.GetValueForProperty("DatasourceInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceType = (string) content.GetValueForProperty("DatasourceInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceUri = (string) content.GetValueForProperty("DatasourceInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DatasourceInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties) content.GetValueForProperty("DatasourceSetInfoResourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.BaseResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatasourceSetInfoDatasourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoDatasourceType = (string) content.GetValueForProperty("DatasourceSetInfoDatasourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoDatasourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoObjectType = (string) content.GetValueForProperty("DatasourceSetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceId = (string) content.GetValueForProperty("DatasourceSetInfoResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceLocation = (string) content.GetValueForProperty("DatasourceSetInfoResourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceName = (string) content.GetValueForProperty("DatasourceSetInfoResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceType = (string) content.GetValueForProperty("DatasourceSetInfoResourceType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceUri = (string) content.GetValueForProperty("DatasourceSetInfoResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceSetInfoResourcePropertiesObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourcePropertiesObjectType = (string) content.GetValueForProperty("DatasourceSetInfoResourcePropertiesObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceSetInfoResourcePropertiesObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("DatasourceAuthCredentialsObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentialsObjectType = (string) content.GetValueForProperty("DatasourceAuthCredentialsObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoInternal)this).DatasourceAuthCredentialsObjectType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

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
    /// Class encapsulating restore target parameters
    [System.ComponentModel.TypeConverter(typeof(RestoreTargetInfoTypeConverter))]
    public partial interface IRestoreTargetInfo

    {

    }
}