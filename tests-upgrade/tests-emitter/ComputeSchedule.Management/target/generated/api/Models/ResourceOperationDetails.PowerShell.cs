// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell;

    /// <summary>The details of a response from an operation on a resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceOperationDetailsTypeConverter))]
    public partial class ResourceOperationDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResourceOperationDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResourceOperationDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResourceOperationDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ResourceOperationDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResourceOperationDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError) content.GetValueForProperty("ResourceOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationError, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy) content.GetValueForProperty("RetryPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicy, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("OpType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OpType = (string) content.GetValueForProperty("OpType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OpType, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Deadline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Deadline = (global::System.DateTime?) content.GetValueForProperty("Deadline",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Deadline, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DeadlineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).DeadlineType = (string) content.GetValueForProperty("DeadlineType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).DeadlineType, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("Timezone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Timezone = (string) content.GetValueForProperty("Timezone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Timezone, global::System.Convert.ToString);
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("CompletedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).CompletedAt = (global::System.DateTime?) content.GetValueForProperty("CompletedAt",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).CompletedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorCode = (string) content.GetValueForProperty("ResourceOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorDetail = (string) content.GetValueForProperty("ResourceOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorDetail, global::System.Convert.ToString);
            }
            if (content.Contains("RetryPolicyRetryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryCount = (int?) content.GetValueForProperty("RetryPolicyRetryCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetryPolicyRetryWindowInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryWindowInMinute = (int?) content.GetValueForProperty("RetryPolicyRetryWindowInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryWindowInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResourceOperationDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError) content.GetValueForProperty("ResourceOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationError, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy) content.GetValueForProperty("RetryPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicy, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("OpType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OpType = (string) content.GetValueForProperty("OpType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).OpType, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Deadline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Deadline = (global::System.DateTime?) content.GetValueForProperty("Deadline",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Deadline, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DeadlineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).DeadlineType = (string) content.GetValueForProperty("DeadlineType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).DeadlineType, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("Timezone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Timezone = (string) content.GetValueForProperty("Timezone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).Timezone, global::System.Convert.ToString);
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("CompletedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).CompletedAt = (global::System.DateTime?) content.GetValueForProperty("CompletedAt",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).CompletedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorCode = (string) content.GetValueForProperty("ResourceOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorDetail = (string) content.GetValueForProperty("ResourceOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).ResourceOperationErrorDetail, global::System.Convert.ToString);
            }
            if (content.Contains("RetryPolicyRetryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryCount = (int?) content.GetValueForProperty("RetryPolicyRetryCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetryPolicyRetryWindowInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryWindowInMinute = (int?) content.GetValueForProperty("RetryPolicyRetryWindowInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)this).RetryPolicyRetryWindowInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
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
    /// The details of a response from an operation on a resource
    [System.ComponentModel.TypeConverter(typeof(ResourceOperationDetailsTypeConverter))]
    public partial interface IResourceOperationDetails

    {

    }
}