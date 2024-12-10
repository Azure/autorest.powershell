// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>Patch Report's properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReportPatchPropertiesTypeConverter))]
    public partial class ReportPatchProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReportPatchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReportPatchProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReportPatchProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ReportPatchProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReportPatchProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ComplianceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatus = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus) content.GetValueForProperty("ComplianceStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatus, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportComplianceStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfo = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo) content.GetValueForProperty("StorageInfo",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfo, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.StorageInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TriggerTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TriggerTime = (global::System.DateTime?) content.GetValueForProperty("TriggerTime",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TriggerTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("Resource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Resource = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata>) content.GetValueForProperty("Resource",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Resource, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResourceMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Error = (System.Collections.Generic.List<string>) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Error, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).OfferGuid = (string) content.GetValueForProperty("OfferGuid",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).OfferGuid, global::System.Convert.ToString);
            }
            if (content.Contains("NextTriggerTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).NextTriggerTime = (global::System.DateTime?) content.GetValueForProperty("NextTriggerTime",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).NextTriggerTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTriggerTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).LastTriggerTime = (global::System.DateTime?) content.GetValueForProperty("LastTriggerTime",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).LastTriggerTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Subscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Subscription = (System.Collections.Generic.List<string>) content.GetValueForProperty("Subscription",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Subscription, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CertRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).CertRecord = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord>) content.GetValueForProperty("CertRecord",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).CertRecord, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.CertSyncRecordTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ComplianceStatusM365"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatusM365 = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus) content.GetValueForProperty("ComplianceStatusM365",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatusM365, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.OverviewStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageInfoSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoSubscriptionId = (string) content.GetValueForProperty("StorageInfoSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageInfoResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoResourceGroup = (string) content.GetValueForProperty("StorageInfoResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("StorageInfoAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoAccountName = (string) content.GetValueForProperty("StorageInfoAccountName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageInfoLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoLocation = (string) content.GetValueForProperty("StorageInfoLocation",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoLocation, global::System.Convert.ToString);
            }
            if (content.Contains("M365PassedCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PassedCount = (int?) content.GetValueForProperty("M365PassedCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PassedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365FailedCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365FailedCount = (int?) content.GetValueForProperty("M365FailedCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365FailedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365ManualCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365ManualCount = (int?) content.GetValueForProperty("M365ManualCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365ManualCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365NotApplicableCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365NotApplicableCount = (int?) content.GetValueForProperty("M365NotApplicableCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365NotApplicableCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365PendingCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PendingCount = (int?) content.GetValueForProperty("M365PendingCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PendingCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReportPatchProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ComplianceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatus = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportComplianceStatus) content.GetValueForProperty("ComplianceStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatus, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportComplianceStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfo = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo) content.GetValueForProperty("StorageInfo",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfo, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.StorageInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TriggerTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TriggerTime = (global::System.DateTime?) content.GetValueForProperty("TriggerTime",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TriggerTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("Resource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Resource = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata>) content.GetValueForProperty("Resource",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Resource, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResourceMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Error = (System.Collections.Generic.List<string>) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Error, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).OfferGuid = (string) content.GetValueForProperty("OfferGuid",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).OfferGuid, global::System.Convert.ToString);
            }
            if (content.Contains("NextTriggerTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).NextTriggerTime = (global::System.DateTime?) content.GetValueForProperty("NextTriggerTime",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).NextTriggerTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTriggerTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).LastTriggerTime = (global::System.DateTime?) content.GetValueForProperty("LastTriggerTime",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).LastTriggerTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Subscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Subscription = (System.Collections.Generic.List<string>) content.GetValueForProperty("Subscription",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).Subscription, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CertRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).CertRecord = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord>) content.GetValueForProperty("CertRecord",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).CertRecord, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.CertSyncRecordTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ComplianceStatusM365"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatusM365 = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOverviewStatus) content.GetValueForProperty("ComplianceStatusM365",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).ComplianceStatusM365, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.OverviewStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageInfoSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoSubscriptionId = (string) content.GetValueForProperty("StorageInfoSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageInfoResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoResourceGroup = (string) content.GetValueForProperty("StorageInfoResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("StorageInfoAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoAccountName = (string) content.GetValueForProperty("StorageInfoAccountName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageInfoLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoLocation = (string) content.GetValueForProperty("StorageInfoLocation",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).StorageInfoLocation, global::System.Convert.ToString);
            }
            if (content.Contains("M365PassedCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PassedCount = (int?) content.GetValueForProperty("M365PassedCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PassedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365FailedCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365FailedCount = (int?) content.GetValueForProperty("M365FailedCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365FailedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365ManualCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365ManualCount = (int?) content.GetValueForProperty("M365ManualCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365ManualCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365NotApplicableCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365NotApplicableCount = (int?) content.GetValueForProperty("M365NotApplicableCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365NotApplicableCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("M365PendingCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PendingCount = (int?) content.GetValueForProperty("M365PendingCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportPatchPropertiesInternal)this).M365PendingCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Patch Report's properties.
    [System.ComponentModel.TypeConverter(typeof(ReportPatchPropertiesTypeConverter))]
    public partial interface IReportPatchProperties

    {

    }
}