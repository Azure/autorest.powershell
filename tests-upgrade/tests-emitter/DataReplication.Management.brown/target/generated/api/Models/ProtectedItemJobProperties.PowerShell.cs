// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>Protected item job properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProtectedItemJobPropertiesTypeConverter))]
    public partial class ProtectedItemJobProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProtectedItemJobProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProtectedItemJobProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProtectedItemJobProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProtectedItemJobProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProtectedItemJobProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).ScenarioName = (string) content.GetValueForProperty("ScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).ScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProtectedItemJobProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).ScenarioName = (string) content.GetValueForProperty("ScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).ScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Protected item job properties.
    [System.ComponentModel.TypeConverter(typeof(ProtectedItemJobPropertiesTypeConverter))]
    public partial interface IProtectedItemJobProperties

    {

    }
}