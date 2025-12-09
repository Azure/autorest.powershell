// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Recovery point specific to PointInTime in SAPHana</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureWorkloadSapHanaPointInTimeRecoveryPointTypeConverter))]
    public partial class AzureWorkloadSapHanaPointInTimeRecoveryPoint
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSapHanaPointInTimeRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureWorkloadSapHanaPointInTimeRecoveryPoint(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime = (string) content.GetValueForProperty("RecoveryPointPropertyExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyRuleName = (string) content.GetValueForProperty("RecoveryPointPropertyRuleName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyIsSoftDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted = (bool?) content.GetValueForProperty("RecoveryPointPropertyIsSoftDeleted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RecoveryPointProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties) content.GetValueForProperty("RecoveryPointProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("RecoveryPointTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointTierDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTierDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>) content.GetValueForProperty("RecoveryPointTierDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTierDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointTierInformationV2TypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryPointMoveReadinessInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo) content.GetValueForProperty("RecoveryPointMoveReadinessInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRecoveryPointMoveReadinessInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TimeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal)this).TimeRange = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange>) content.GetValueForProperty("TimeRange",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal)this).TimeRange, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.PointInTimeRangeTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSapHanaPointInTimeRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureWorkloadSapHanaPointInTimeRecoveryPoint(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime = (string) content.GetValueForProperty("RecoveryPointPropertyExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyRuleName = (string) content.GetValueForProperty("RecoveryPointPropertyRuleName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyIsSoftDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted = (bool?) content.GetValueForProperty("RecoveryPointPropertyIsSoftDeleted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RecoveryPointProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties) content.GetValueForProperty("RecoveryPointProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("RecoveryPointTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointTierDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTierDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>) content.GetValueForProperty("RecoveryPointTierDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointTierDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointTierInformationV2TypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryPointMoveReadinessInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo) content.GetValueForProperty("RecoveryPointMoveReadinessInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRecoveryPointMoveReadinessInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TimeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal)this).TimeRange = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange>) content.GetValueForProperty("TimeRange",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal)this).TimeRange, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.PointInTimeRangeTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSapHanaPointInTimeRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRecoveryPoint"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRecoveryPoint DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureWorkloadSapHanaPointInTimeRecoveryPoint(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSapHanaPointInTimeRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRecoveryPoint"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRecoveryPoint DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureWorkloadSapHanaPointInTimeRecoveryPoint(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureWorkloadSapHanaPointInTimeRecoveryPoint" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureWorkloadSapHanaPointInTimeRecoveryPoint" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapHanaPointInTimeRecoveryPoint FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Recovery point specific to PointInTime in SAPHana
    [System.ComponentModel.TypeConverter(typeof(AzureWorkloadSapHanaPointInTimeRecoveryPointTypeConverter))]
    public partial interface IAzureWorkloadSapHanaPointInTimeRecoveryPoint

    {

    }
}