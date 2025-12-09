// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Simple policy schedule.</summary>
    [System.ComponentModel.TypeConverter(typeof(SimpleSchedulePolicyTypeConverter))]
    public partial class SimpleSchedulePolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SimpleSchedulePolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SimpleSchedulePolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleSchedulePolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SimpleSchedulePolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SimpleSchedulePolicy(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule) content.GetValueForProperty("HourlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleRunFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunFrequency = (string) content.GetValueForProperty("ScheduleRunFrequency",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleRunDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunDay = (System.Collections.Generic.List<string>) content.GetValueForProperty("ScheduleRunDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunDay, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ScheduleRunTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("ScheduleRunTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("ScheduleWeeklyFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleWeeklyFrequency = (int?) content.GetValueForProperty("ScheduleWeeklyFrequency",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleWeeklyFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("HourlyScheduleInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleInterval = (int?) content.GetValueForProperty("HourlyScheduleInterval",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HourlyScheduleWindowStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowStartTime = (global::System.DateTime?) content.GetValueForProperty("HourlyScheduleWindowStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("HourlyScheduleWindowDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowDuration = (int?) content.GetValueForProperty("HourlyScheduleWindowDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowDuration, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleSchedulePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SimpleSchedulePolicy(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlySchedule = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule) content.GetValueForProperty("HourlySchedule",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlySchedule, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlyScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleRunFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunFrequency = (string) content.GetValueForProperty("ScheduleRunFrequency",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleRunDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunDay = (System.Collections.Generic.List<string>) content.GetValueForProperty("ScheduleRunDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunDay, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ScheduleRunTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunTime = (System.Collections.Generic.List<global::System.DateTime>) content.GetValueForProperty("ScheduleRunTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleRunTime, __y => TypeConverterExtensions.SelectToList<global::System.DateTime>(__y, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified)));
            }
            if (content.Contains("ScheduleWeeklyFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleWeeklyFrequency = (int?) content.GetValueForProperty("ScheduleWeeklyFrequency",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).ScheduleWeeklyFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("HourlyScheduleInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleInterval = (int?) content.GetValueForProperty("HourlyScheduleInterval",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HourlyScheduleWindowStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowStartTime = (global::System.DateTime?) content.GetValueForProperty("HourlyScheduleWindowStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("HourlyScheduleWindowDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowDuration = (int?) content.GetValueForProperty("HourlyScheduleWindowDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal)this).HourlyScheduleWindowDuration, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
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
    /// Simple policy schedule.
    [System.ComponentModel.TypeConverter(typeof(SimpleSchedulePolicyTypeConverter))]
    public partial interface ISimpleSchedulePolicy

    {

    }
}