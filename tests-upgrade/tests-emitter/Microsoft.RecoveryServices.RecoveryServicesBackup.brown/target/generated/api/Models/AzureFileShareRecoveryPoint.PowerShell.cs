// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Azure File Share workload specific backup copy.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureFileShareRecoveryPointTypeConverter))]
    public partial class AzureFileShareRecoveryPoint
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureFileShareRecoveryPoint(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryPointProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties) content.GetValueForProperty("RecoveryPointProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointType = (string) content.GetValueForProperty("RecoveryPointType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("RecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FileShareSnapshotUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).FileShareSnapshotUri = (string) content.GetValueForProperty("FileShareSnapshotUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).FileShareSnapshotUri, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointSizeInGb = (int?) content.GetValueForProperty("RecoveryPointSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointTierDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTierDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformation>) content.GetValueForProperty("RecoveryPointTierDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTierDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointTierInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime = (string) content.GetValueForProperty("RecoveryPointPropertyExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyRuleName = (string) content.GetValueForProperty("RecoveryPointPropertyRuleName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyIsSoftDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted = (bool?) content.GetValueForProperty("RecoveryPointPropertyIsSoftDeleted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureFileShareRecoveryPoint(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryPointProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties) content.GetValueForProperty("RecoveryPointProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointType = (string) content.GetValueForProperty("RecoveryPointType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("RecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FileShareSnapshotUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).FileShareSnapshotUri = (string) content.GetValueForProperty("FileShareSnapshotUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).FileShareSnapshotUri, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointSizeInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointSizeInGb = (int?) content.GetValueForProperty("RecoveryPointSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointTierDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTierDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformation>) content.GetValueForProperty("RecoveryPointTierDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointTierDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointTierInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime = (string) content.GetValueForProperty("RecoveryPointPropertyExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyRuleName = (string) content.GetValueForProperty("RecoveryPointPropertyRuleName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyIsSoftDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted = (bool?) content.GetValueForProperty("RecoveryPointPropertyIsSoftDeleted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPoint"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPoint DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureFileShareRecoveryPoint(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPoint"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPoint DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureFileShareRecoveryPoint(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureFileShareRecoveryPoint" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureFileShareRecoveryPoint" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareRecoveryPoint FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Azure File Share workload specific backup copy.
    [System.ComponentModel.TypeConverter(typeof(AzureFileShareRecoveryPointTypeConverter))]
    public partial interface IAzureFileShareRecoveryPoint

    {

    }
}