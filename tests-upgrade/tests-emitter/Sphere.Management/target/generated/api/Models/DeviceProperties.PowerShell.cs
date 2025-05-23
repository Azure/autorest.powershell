// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell;

    /// <summary>The properties of device</summary>
    [System.ComponentModel.TypeConverter(typeof(DevicePropertiesTypeConverter))]
    public partial class DeviceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeviceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeviceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeviceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).DeviceId = (string) content.GetValueForProperty("DeviceId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).DeviceId, global::System.Convert.ToString);
            }
            if (content.Contains("ChipSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ChipSku = (string) content.GetValueForProperty("ChipSku",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ChipSku, global::System.Convert.ToString);
            }
            if (content.Contains("LastAvailableOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastAvailableOSVersion = (string) content.GetValueForProperty("LastAvailableOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastAvailableOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastInstalledOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastInstalledOSVersion = (string) content.GetValueForProperty("LastInstalledOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastInstalledOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastOSUpdateUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastOSUpdateUtc = (global::System.DateTime?) content.GetValueForProperty("LastOSUpdateUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastOSUpdateUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdateRequestUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastUpdateRequestUtc = (global::System.DateTime?) content.GetValueForProperty("LastUpdateRequestUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastUpdateRequestUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeviceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).DeviceId = (string) content.GetValueForProperty("DeviceId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).DeviceId, global::System.Convert.ToString);
            }
            if (content.Contains("ChipSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ChipSku = (string) content.GetValueForProperty("ChipSku",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ChipSku, global::System.Convert.ToString);
            }
            if (content.Contains("LastAvailableOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastAvailableOSVersion = (string) content.GetValueForProperty("LastAvailableOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastAvailableOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastInstalledOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastInstalledOSVersion = (string) content.GetValueForProperty("LastInstalledOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastInstalledOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastOSUpdateUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastOSUpdateUtc = (global::System.DateTime?) content.GetValueForProperty("LastOSUpdateUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastOSUpdateUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdateRequestUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastUpdateRequestUtc = (global::System.DateTime?) content.GetValueForProperty("LastUpdateRequestUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).LastUpdateRequestUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevicePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeviceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DeviceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The properties of device
    [System.ComponentModel.TypeConverter(typeof(DevicePropertiesTypeConverter))]
    public partial interface IDeviceProperties

    {

    }
}