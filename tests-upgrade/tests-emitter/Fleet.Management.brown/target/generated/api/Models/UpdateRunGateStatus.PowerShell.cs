// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.PowerShell;

    /// <summary>The status of the Gate, as represented in the Update Run.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateRunGateStatusTypeConverter))]
    public partial class UpdateRunGateStatus
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateRunGateStatus(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateRunGateStatus(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateRunGateStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UpdateRunGateStatus" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateRunGateStatus(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("GateId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).GateId = (string) content.GetValueForProperty("GateId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).GateId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusStartTime = (global::System.DateTime?) content.GetValueForProperty("StatusStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusCompletedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusCompletedTime = (global::System.DateTime?) content.GetValueForProperty("StatusCompletedTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusCompletedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusState = (string) content.GetValueForProperty("StatusState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusState, global::System.Convert.ToString);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateRunGateStatus(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("GateId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).GateId = (string) content.GetValueForProperty("GateId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).GateId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusStartTime = (global::System.DateTime?) content.GetValueForProperty("StatusStartTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusCompletedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusCompletedTime = (global::System.DateTime?) content.GetValueForProperty("StatusCompletedTime",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusCompletedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusState = (string) content.GetValueForProperty("StatusState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).StatusState, global::System.Convert.ToString);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The status of the Gate, as represented in the Update Run.
    [System.ComponentModel.TypeConverter(typeof(UpdateRunGateStatusTypeConverter))]
    public partial interface IUpdateRunGateStatus

    {

    }
}