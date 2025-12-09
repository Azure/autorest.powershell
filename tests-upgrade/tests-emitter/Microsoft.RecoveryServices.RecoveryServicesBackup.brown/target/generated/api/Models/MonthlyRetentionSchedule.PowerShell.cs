// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Monthly retention schedule.</summary>
    [System.ComponentModel.TypeConverter(typeof(MonthlyRetentionScheduleTypeConverter))]
    public partial class MonthlyRetentionSchedule
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionSchedule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MonthlyRetentionSchedule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionSchedule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MonthlyRetentionSchedule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MonthlyRetentionSchedule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MonthlyRetentionSchedule" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionSchedule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MonthlyRetentionSchedule(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RetentionScheduleDaily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDaily = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat) content.GetValueForProperty("RetentionScheduleDaily",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDaily, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionScheduleWeekly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeekly = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat) content.GetValueForProperty("RetentionScheduleWeekly",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeekly, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("RetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionScheduleFormatType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleFormatType = (string) content.GetValueForProperty("RetentionScheduleFormatType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleFormatType, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("RetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("RetentionScheduleDailyDaysOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDailyDaysOfTheMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>) content.GetValueForProperty("RetentionScheduleDailyDaysOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDailyDaysOfTheMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DayTypeConverter.ConvertFrom));
            }
            if (content.Contains("RetentionScheduleWeeklyDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("RetentionScheduleWeeklyDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RetentionScheduleWeeklyWeeksOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyWeeksOfTheMonth = (System.Collections.Generic.List<string>) content.GetValueForProperty("RetentionScheduleWeeklyWeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyWeeksOfTheMonth, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationCount = (int?) content.GetValueForProperty("RetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationType = (string) content.GetValueForProperty("RetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionSchedule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MonthlyRetentionSchedule(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RetentionScheduleDaily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDaily = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat) content.GetValueForProperty("RetentionScheduleDaily",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDaily, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionScheduleWeekly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeekly = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat) content.GetValueForProperty("RetentionScheduleWeekly",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeekly, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("RetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionScheduleFormatType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleFormatType = (string) content.GetValueForProperty("RetentionScheduleFormatType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleFormatType, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("RetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("RetentionScheduleDailyDaysOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDailyDaysOfTheMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>) content.GetValueForProperty("RetentionScheduleDailyDaysOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleDailyDaysOfTheMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DayTypeConverter.ConvertFrom));
            }
            if (content.Contains("RetentionScheduleWeeklyDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("RetentionScheduleWeeklyDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RetentionScheduleWeeklyWeeksOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyWeeksOfTheMonth = (System.Collections.Generic.List<string>) content.GetValueForProperty("RetentionScheduleWeeklyWeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionScheduleWeeklyWeeksOfTheMonth, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationCount = (int?) content.GetValueForProperty("RetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationType = (string) content.GetValueForProperty("RetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)this).RetentionDurationType, global::System.Convert.ToString);
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
    /// Monthly retention schedule.
    [System.ComponentModel.TypeConverter(typeof(MonthlyRetentionScheduleTypeConverter))]
    public partial interface IMonthlyRetentionSchedule

    {

    }
}