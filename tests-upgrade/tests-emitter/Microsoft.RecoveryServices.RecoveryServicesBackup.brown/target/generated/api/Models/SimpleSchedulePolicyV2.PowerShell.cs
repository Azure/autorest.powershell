// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>The V2 policy schedule for IaaS that supports hourly backups.</summary>
    [System.ComponentModel.TypeConverter(typeof(SimpleSchedulePolicyV2TypeConverter))]
    public partial class SimpleSchedulePolicyV2
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicyV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2 DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SimpleSchedulePolicyV2(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicyV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2 DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SimpleSchedulePolicyV2(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleSchedulePolicyV2" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SimpleSchedulePolicyV2" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2 FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicyV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SimpleSchedulePolicyV2(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HourlySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule) content.GetValueForProperty("HourlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("DailySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule) content.GetValueForProperty("DailySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("WeeklySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule) content.GetValueForProperty("WeeklySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleRunFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).ScheduleRunFrequency = (string) content.GetValueForProperty("ScheduleRunFrequency",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).ScheduleRunFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("HourlyScheduleInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleInterval = (int?) content.GetValueForProperty("HourlyScheduleInterval",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HourlyScheduleWindowStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowStartTime = (global::System.DateTime?) content.GetValueForProperty("HourlyScheduleWindowStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("HourlyScheduleWindowDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowDuration = (int?) content.GetValueForProperty("HourlyScheduleWindowDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowDuration, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DailyScheduleRunTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailyScheduleRunTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("DailyScheduleRunTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailyScheduleRunTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("WeeklyScheduleRunDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunDay = (System.Collections.Generic.List<string>) content.GetValueForProperty("WeeklyScheduleRunDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunDay, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("WeeklyScheduleRunTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("WeeklyScheduleRunTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicyV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SimpleSchedulePolicyV2(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HourlySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule) content.GetValueForProperty("HourlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("DailySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule) content.GetValueForProperty("DailySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("WeeklySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule) content.GetValueForProperty("WeeklySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleRunFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).ScheduleRunFrequency = (string) content.GetValueForProperty("ScheduleRunFrequency",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).ScheduleRunFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("HourlyScheduleInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleInterval = (int?) content.GetValueForProperty("HourlyScheduleInterval",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HourlyScheduleWindowStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowStartTime = (global::System.DateTime?) content.GetValueForProperty("HourlyScheduleWindowStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("HourlyScheduleWindowDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowDuration = (int?) content.GetValueForProperty("HourlyScheduleWindowDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).HourlyScheduleWindowDuration, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DailyScheduleRunTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailyScheduleRunTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("DailyScheduleRunTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).DailyScheduleRunTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("WeeklyScheduleRunDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunDay = (System.Collections.Generic.List<string>) content.GetValueForProperty("WeeklyScheduleRunDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunDay, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("WeeklyScheduleRunTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("WeeklyScheduleRunTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal)this).WeeklyScheduleRunTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            AfterDeserializePSObject(content);
        }

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
    /// The V2 policy schedule for IaaS that supports hourly backups.
    [System.ComponentModel.TypeConverter(typeof(SimpleSchedulePolicyV2TypeConverter))]
    public partial interface ISimpleSchedulePolicyV2

    {

    }
}