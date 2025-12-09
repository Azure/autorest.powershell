// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Long term retention policy.</summary>
    [System.ComponentModel.TypeConverter(typeof(LongTermRetentionPolicyTypeConverter))]
    public partial class LongTermRetentionPolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.LongTermRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LongTermRetentionPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.LongTermRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LongTermRetentionPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LongTermRetentionPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="LongTermRetentionPolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.LongTermRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LongTermRetentionPolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DailySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule) content.GetValueForProperty("DailySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("WeeklySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionSchedule) content.GetValueForProperty("WeeklySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule) content.GetValueForProperty("MonthlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule) content.GetValueForProperty("YearlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.YearlyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("DailyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("DailyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("WeeklyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("WeeklyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("MonthlyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("YearlyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DailyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("DailyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("WeeklyScheduleDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("WeeklyScheduleDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("WeeklyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("WeeklyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleDaily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDaily = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat) content.GetValueForProperty("MonthlyScheduleRetentionScheduleDaily",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDaily, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleWeekly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeekly = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat) content.GetValueForProperty("MonthlyScheduleRetentionScheduleWeekly",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeekly, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleFormatType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleFormatType = (string) content.GetValueForProperty("MonthlyScheduleRetentionScheduleFormatType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleFormatType, global::System.Convert.ToString);
            }
            if (content.Contains("MonthlyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("MonthlyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("YearlyScheduleRetentionScheduleDaily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDaily = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat) content.GetValueForProperty("YearlyScheduleRetentionScheduleDaily",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDaily, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlyScheduleRetentionScheduleWeekly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeekly = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat) content.GetValueForProperty("YearlyScheduleRetentionScheduleWeekly",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeekly, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlyScheduleRetentionScheduleFormatType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleFormatType = (string) content.GetValueForProperty("YearlyScheduleRetentionScheduleFormatType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleFormatType, global::System.Convert.ToString);
            }
            if (content.Contains("YearlyScheduleMonthsOfYear"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleMonthsOfYear = (System.Collections.Generic.List<string>) content.GetValueForProperty("YearlyScheduleMonthsOfYear",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleMonthsOfYear, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("YearlyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("YearlyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("DailyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("DailyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DailyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationType = (string) content.GetValueForProperty("DailyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            if (content.Contains("WeeklyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("WeeklyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("WeeklyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationType = (string) content.GetValueForProperty("WeeklyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>) content.GetValueForProperty("MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DayTypeConverter.ConvertFrom));
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth = (System.Collections.Generic.List<string>) content.GetValueForProperty("MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MonthlyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("MonthlyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MonthlyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationType = (string) content.GetValueForProperty("MonthlyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            if (content.Contains("YearlyScheduleRetentionScheduleDailyDaysOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDailyDaysOfTheMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>) content.GetValueForProperty("YearlyScheduleRetentionScheduleDailyDaysOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDailyDaysOfTheMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DayTypeConverter.ConvertFrom));
            }
            if (content.Contains("YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth = (System.Collections.Generic.List<string>) content.GetValueForProperty("YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("YearlyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("YearlyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("YearlyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationType = (string) content.GetValueForProperty("YearlyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.LongTermRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LongTermRetentionPolicy(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DailySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule) content.GetValueForProperty("DailySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("WeeklySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionSchedule) content.GetValueForProperty("WeeklySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule) content.GetValueForProperty("MonthlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlySchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule) content.GetValueForProperty("YearlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.YearlyRetentionScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("DailyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("DailyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("WeeklyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("WeeklyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("MonthlyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlyScheduleRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("YearlyScheduleRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DailyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("DailyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("WeeklyScheduleDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("WeeklyScheduleDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("WeeklyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("WeeklyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleDaily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDaily = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat) content.GetValueForProperty("MonthlyScheduleRetentionScheduleDaily",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDaily, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleWeekly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeekly = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat) content.GetValueForProperty("MonthlyScheduleRetentionScheduleWeekly",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeekly, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleFormatType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleFormatType = (string) content.GetValueForProperty("MonthlyScheduleRetentionScheduleFormatType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleFormatType, global::System.Convert.ToString);
            }
            if (content.Contains("MonthlyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("MonthlyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("YearlyScheduleRetentionScheduleDaily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDaily = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat) content.GetValueForProperty("YearlyScheduleRetentionScheduleDaily",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDaily, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlyScheduleRetentionScheduleWeekly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeekly = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat) content.GetValueForProperty("YearlyScheduleRetentionScheduleWeekly",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeekly, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("YearlyScheduleRetentionScheduleFormatType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleFormatType = (string) content.GetValueForProperty("YearlyScheduleRetentionScheduleFormatType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleFormatType, global::System.Convert.ToString);
            }
            if (content.Contains("YearlyScheduleMonthsOfYear"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleMonthsOfYear = (System.Collections.Generic.List<string>) content.GetValueForProperty("YearlyScheduleMonthsOfYear",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleMonthsOfYear, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("YearlyScheduleRetentionTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("YearlyScheduleRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("DailyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("DailyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DailyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationType = (string) content.GetValueForProperty("DailyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).DailyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            if (content.Contains("WeeklyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("WeeklyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("WeeklyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationType = (string) content.GetValueForProperty("WeeklyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).WeeklyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>) content.GetValueForProperty("MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DayTypeConverter.ConvertFrom));
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth = (System.Collections.Generic.List<string>) content.GetValueForProperty("MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MonthlyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("MonthlyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MonthlyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationType = (string) content.GetValueForProperty("MonthlyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).MonthlyScheduleRetentionDurationType, global::System.Convert.ToString);
            }
            if (content.Contains("YearlyScheduleRetentionScheduleDailyDaysOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDailyDaysOfTheMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>) content.GetValueForProperty("YearlyScheduleRetentionScheduleDailyDaysOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleDailyDaysOfTheMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DayTypeConverter.ConvertFrom));
            }
            if (content.Contains("YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek = (System.Collections.Generic.List<string>) content.GetValueForProperty("YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth = (System.Collections.Generic.List<string>) content.GetValueForProperty("YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("YearlyScheduleRetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationCount = (int?) content.GetValueForProperty("YearlyScheduleRetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("YearlyScheduleRetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationType = (string) content.GetValueForProperty("YearlyScheduleRetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal)this).YearlyScheduleRetentionDurationType, global::System.Convert.ToString);
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
    /// Long term retention policy.
    [System.ComponentModel.TypeConverter(typeof(LongTermRetentionPolicyTypeConverter))]
    public partial interface ILongTermRetentionPolicy

    {

    }
}