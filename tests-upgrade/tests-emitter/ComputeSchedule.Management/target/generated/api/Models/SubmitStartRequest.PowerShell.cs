// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell;

    /// <summary>This is the request for start</summary>
    [System.ComponentModel.TypeConverter(typeof(SubmitStartRequestTypeConverter))]
    public partial class SubmitStartRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.SubmitStartRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SubmitStartRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.SubmitStartRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SubmitStartRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SubmitStartRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SubmitStartRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.SubmitStartRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SubmitStartRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Schedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Schedule = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISchedule) content.GetValueForProperty("Schedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Schedule, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExecutionParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameter = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters) content.GetValueForProperty("ExecutionParameter",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameter, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ExecutionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Resource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Resource = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources) content.GetValueForProperty("Resource",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Resource, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourcesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Correlationid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Correlationid = (string) content.GetValueForProperty("Correlationid",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Correlationid, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleDeadlineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadlineType = (string) content.GetValueForProperty("ScheduleDeadlineType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadlineType, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionParameterRetryPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterRetryPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy) content.GetValueForProperty("ExecutionParameterRetryPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterRetryPolicy, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExecutionParameterOptimizationPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterOptimizationPreference = (string) content.GetValueForProperty("ExecutionParameterOptimizationPreference",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterOptimizationPreference, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ResourceId = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ResourceId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ScheduleDeadline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadline = (global::System.DateTime?) content.GetValueForProperty("ScheduleDeadline",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadline, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduleDeadLine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadLine = (global::System.DateTime?) content.GetValueForProperty("ScheduleDeadLine",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadLine, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduleTimezone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimezone = (string) content.GetValueForProperty("ScheduleTimezone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimezone, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimeZone = (string) content.GetValueForProperty("ScheduleTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("RetryPolicyRetryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryCount = (int?) content.GetValueForProperty("RetryPolicyRetryCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetryPolicyRetryWindowInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryWindowInMinute = (int?) content.GetValueForProperty("RetryPolicyRetryWindowInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryWindowInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.SubmitStartRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SubmitStartRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Schedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Schedule = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISchedule) content.GetValueForProperty("Schedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Schedule, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExecutionParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameter = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters) content.GetValueForProperty("ExecutionParameter",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameter, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ExecutionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Resource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Resource = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources) content.GetValueForProperty("Resource",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Resource, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourcesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Correlationid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Correlationid = (string) content.GetValueForProperty("Correlationid",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).Correlationid, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleDeadlineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadlineType = (string) content.GetValueForProperty("ScheduleDeadlineType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadlineType, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionParameterRetryPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterRetryPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy) content.GetValueForProperty("ExecutionParameterRetryPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterRetryPolicy, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExecutionParameterOptimizationPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterOptimizationPreference = (string) content.GetValueForProperty("ExecutionParameterOptimizationPreference",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ExecutionParameterOptimizationPreference, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ResourceId = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ResourceId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ScheduleDeadline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadline = (global::System.DateTime?) content.GetValueForProperty("ScheduleDeadline",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadline, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduleDeadLine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadLine = (global::System.DateTime?) content.GetValueForProperty("ScheduleDeadLine",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleDeadLine, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduleTimezone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimezone = (string) content.GetValueForProperty("ScheduleTimezone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimezone, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimeZone = (string) content.GetValueForProperty("ScheduleTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).ScheduleTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("RetryPolicyRetryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryCount = (int?) content.GetValueForProperty("RetryPolicyRetryCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetryPolicyRetryWindowInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryWindowInMinute = (int?) content.GetValueForProperty("RetryPolicyRetryWindowInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISubmitStartRequestInternal)this).RetryPolicyRetryWindowInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// This is the request for start
    [System.ComponentModel.TypeConverter(typeof(SubmitStartRequestTypeConverter))]
    public partial interface ISubmitStartRequest

    {

    }
}