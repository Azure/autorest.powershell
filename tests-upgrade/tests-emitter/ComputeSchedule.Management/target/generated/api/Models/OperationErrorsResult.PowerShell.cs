// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.PowerShell;

    /// <summary>
    /// This is the first level of operation errors from the request when clients get errors per vm operation
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(OperationErrorsResultTypeConverter))]
    public partial class OperationErrorsResult
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorsResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationErrorsResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorsResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationErrorsResult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationErrorsResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OperationErrorsResult" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorsResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationErrorsResult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("CreationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ActivationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).ActivationTime = (global::System.DateTime?) content.GetValueForProperty("ActivationTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).ActivationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CompletedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CompletedAt = (global::System.DateTime?) content.GetValueForProperty("CompletedAt",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CompletedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails>) content.GetValueForProperty("OperationError",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("RequestErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorCode = (string) content.GetValueForProperty("RequestErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("RequestErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorDetail = (string) content.GetValueForProperty("RequestErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorDetail, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorsResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationErrorsResult(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("CreationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ActivationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).ActivationTime = (global::System.DateTime?) content.GetValueForProperty("ActivationTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).ActivationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CompletedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CompletedAt = (global::System.DateTime?) content.GetValueForProperty("CompletedAt",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).CompletedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails>) content.GetValueForProperty("OperationError",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).OperationError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.OperationErrorDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("RequestErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorCode = (string) content.GetValueForProperty("RequestErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("RequestErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorDetail = (string) content.GetValueForProperty("RequestErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal)this).RequestErrorDetail, global::System.Convert.ToString);
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
    /// This is the first level of operation errors from the request when clients get errors per vm operation
    [System.ComponentModel.TypeConverter(typeof(OperationErrorsResultTypeConverter))]
    public partial interface IOperationErrorsResult

    {

    }
}