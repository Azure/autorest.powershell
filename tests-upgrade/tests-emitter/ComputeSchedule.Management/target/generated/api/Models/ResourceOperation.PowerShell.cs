// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell;

    /// <summary>High level response from an operation on a resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceOperationTypeConverter))]
    public partial class ResourceOperation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResourceOperation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResourceOperation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResourceOperation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ResourceOperation" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResourceOperation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Operation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).Operation = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).Operation, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorCode = (string) content.GetValueForProperty("ErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorDetail = (string) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorDetail, global::System.Convert.ToString);
            }
            if (content.Contains("OperationRetryPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationRetryPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy) content.GetValueForProperty("OperationRetryPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationRetryPolicy, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceId = (string) content.GetValueForProperty("OperationResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationDeadlineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadlineType = (string) content.GetValueForProperty("OperationDeadlineType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadlineType, global::System.Convert.ToString);
            }
            if (content.Contains("OperationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationState = (string) content.GetValueForProperty("OperationState",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationState, global::System.Convert.ToString);
            }
            if (content.Contains("OperationResourceOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError) content.GetValueForProperty("OperationResourceOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceOperationError, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationOpType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationOpType = (string) content.GetValueForProperty("OperationOpType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationOpType, global::System.Convert.ToString);
            }
            if (content.Contains("OperationSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationSubscriptionId = (string) content.GetValueForProperty("OperationSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationDeadline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadline = (global::System.DateTime?) content.GetValueForProperty("OperationDeadline",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadline, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OperationTimezone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimezone = (string) content.GetValueForProperty("OperationTimezone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimezone, global::System.Convert.ToString);
            }
            if (content.Contains("OperationTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimeZone = (string) content.GetValueForProperty("OperationTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("OperationCompletedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationCompletedAt = (global::System.DateTime?) content.GetValueForProperty("OperationCompletedAt",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationCompletedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorCode = (string) content.GetValueForProperty("ResourceOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorDetail = (string) content.GetValueForProperty("ResourceOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorDetail, global::System.Convert.ToString);
            }
            if (content.Contains("RetryPolicyRetryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryCount = (int?) content.GetValueForProperty("RetryPolicyRetryCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetryPolicyRetryWindowInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryWindowInMinute = (int?) content.GetValueForProperty("RetryPolicyRetryWindowInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryWindowInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResourceOperation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Operation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).Operation = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).Operation, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorCode = (string) content.GetValueForProperty("ErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorDetail = (string) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ErrorDetail, global::System.Convert.ToString);
            }
            if (content.Contains("OperationRetryPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationRetryPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy) content.GetValueForProperty("OperationRetryPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationRetryPolicy, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceId = (string) content.GetValueForProperty("OperationResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationDeadlineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadlineType = (string) content.GetValueForProperty("OperationDeadlineType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadlineType, global::System.Convert.ToString);
            }
            if (content.Contains("OperationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationState = (string) content.GetValueForProperty("OperationState",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationState, global::System.Convert.ToString);
            }
            if (content.Contains("OperationResourceOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError) content.GetValueForProperty("OperationResourceOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationResourceOperationError, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationOpType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationOpType = (string) content.GetValueForProperty("OperationOpType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationOpType, global::System.Convert.ToString);
            }
            if (content.Contains("OperationSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationSubscriptionId = (string) content.GetValueForProperty("OperationSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationDeadline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadline = (global::System.DateTime?) content.GetValueForProperty("OperationDeadline",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationDeadline, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OperationTimezone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimezone = (string) content.GetValueForProperty("OperationTimezone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimezone, global::System.Convert.ToString);
            }
            if (content.Contains("OperationTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimeZone = (string) content.GetValueForProperty("OperationTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("OperationCompletedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationCompletedAt = (global::System.DateTime?) content.GetValueForProperty("OperationCompletedAt",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).OperationCompletedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorCode = (string) content.GetValueForProperty("ResourceOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorDetail = (string) content.GetValueForProperty("ResourceOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).ResourceOperationErrorDetail, global::System.Convert.ToString);
            }
            if (content.Contains("RetryPolicyRetryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryCount = (int?) content.GetValueForProperty("RetryPolicyRetryCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetryPolicyRetryWindowInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryWindowInMinute = (int?) content.GetValueForProperty("RetryPolicyRetryWindowInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal)this).RetryPolicyRetryWindowInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
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
    /// High level response from an operation on a resource
    [System.ComponentModel.TypeConverter(typeof(ResourceOperationTypeConverter))]
    public partial interface IResourceOperation

    {

    }
}