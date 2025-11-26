// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Cross Region Restore Request Object</summary>
    [System.ComponentModel.TypeConverter(typeof(CrossRegionRestoreRequestObjectTypeConverter))]
    public partial class CrossRegionRestoreRequestObject
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CrossRegionRestoreRequestObject(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RestoreRequestObject"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObject = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest) content.GetValueForProperty("RestoreRequestObject",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObject, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AzureBackupRestoreRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("CrossRegionRestoreDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetails) content.GetValueForProperty("CrossRegionRestoreDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreRequestObjectIdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectIdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("RestoreRequestObjectIdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectIdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreRequestObjectRestoreTargetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase) content.GetValueForProperty("RestoreRequestObjectRestoreTargetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfoBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreRequestObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectType = (string) content.GetValueForProperty("RestoreRequestObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreRequestObjectSourceDataStoreType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType = (string) content.GetValueForProperty("RestoreRequestObjectSourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreRequestObjectSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceResourceId = (string) content.GetValueForProperty("RestoreRequestObjectSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreRequestObjectResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("RestoreRequestObjectResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RestoreTargetInfoRecoveryOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption = (string) content.GetValueForProperty("RestoreTargetInfoRecoveryOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption, global::System.Convert.ToString);
            }
            if (content.Contains("CrossRegionRestoreDetailSourceRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceRegion = (string) content.GetValueForProperty("CrossRegionRestoreDetailSourceRegion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceRegion, global::System.Convert.ToString);
            }
            if (content.Contains("CrossRegionRestoreDetailSourceBackupInstanceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceBackupInstanceId = (string) content.GetValueForProperty("CrossRegionRestoreDetailSourceBackupInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceBackupInstanceId, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreTargetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType = (string) content.GetValueForProperty("RestoreTargetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreTargetInfoRestoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation = (string) content.GetValueForProperty("RestoreTargetInfoRestoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CrossRegionRestoreRequestObject(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RestoreRequestObject"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObject = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureBackupRestoreRequest) content.GetValueForProperty("RestoreRequestObject",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObject, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AzureBackupRestoreRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("CrossRegionRestoreDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreDetails) content.GetValueForProperty("CrossRegionRestoreDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreRequestObjectIdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectIdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IIdentityDetails) content.GetValueForProperty("RestoreRequestObjectIdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectIdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreRequestObjectRestoreTargetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase) content.GetValueForProperty("RestoreRequestObjectRestoreTargetInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectRestoreTargetInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfoBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreRequestObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectType = (string) content.GetValueForProperty("RestoreRequestObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreRequestObjectSourceDataStoreType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType = (string) content.GetValueForProperty("RestoreRequestObjectSourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceDataStoreType, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreRequestObjectSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceResourceId = (string) content.GetValueForProperty("RestoreRequestObjectSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreRequestObjectResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("RestoreRequestObjectResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreRequestObjectResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RestoreTargetInfoRecoveryOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption = (string) content.GetValueForProperty("RestoreTargetInfoRecoveryOption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRecoveryOption, global::System.Convert.ToString);
            }
            if (content.Contains("CrossRegionRestoreDetailSourceRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceRegion = (string) content.GetValueForProperty("CrossRegionRestoreDetailSourceRegion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceRegion, global::System.Convert.ToString);
            }
            if (content.Contains("CrossRegionRestoreDetailSourceBackupInstanceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceBackupInstanceId = (string) content.GetValueForProperty("CrossRegionRestoreDetailSourceBackupInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).CrossRegionRestoreDetailSourceBackupInstanceId, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreTargetInfoObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType = (string) content.GetValueForProperty("RestoreTargetInfoObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreTargetInfoRestoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation = (string) content.GetValueForProperty("RestoreTargetInfoRestoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).RestoreTargetInfoRestoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityDetailUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityDetailUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityDetailUserAssignedIdentityArmUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUserAssignedIdentityArmUrl = (string) content.GetValueForProperty("IdentityDetailUserAssignedIdentityArmUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObjectInternal)this).IdentityDetailUserAssignedIdentityArmUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObject" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObject DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CrossRegionRestoreRequestObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreRequestObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObject" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObject DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CrossRegionRestoreRequestObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CrossRegionRestoreRequestObject" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CrossRegionRestoreRequestObject" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreRequestObject FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Cross Region Restore Request Object
    [System.ComponentModel.TypeConverter(typeof(CrossRegionRestoreRequestObjectTypeConverter))]
    public partial interface ICrossRegionRestoreRequestObject

    {

    }
}