// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.PowerShell;

    /// <summary>Properties of the dedicated hsm</summary>
    [System.ComponentModel.TypeConverter(typeof(DedicatedHsmPropertiesTypeConverter))]
    public partial class DedicatedHsmProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DedicatedHsmProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("ManagementNetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StampId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StampId = (string) content.GetValueForProperty("StampId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StampId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("NetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("NetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnetResourceId = (string) content.GetValueForProperty("NetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagementNetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("ManagementNetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("ManagementNetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagementNetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnetResourceId = (string) content.GetValueForProperty("ManagementNetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DedicatedHsmProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("ManagementNetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StampId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StampId = (string) content.GetValueForProperty("StampId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StampId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("NetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("NetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnetResourceId = (string) content.GetValueForProperty("NetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).NetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagementNetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("ManagementNetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("ManagementNetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagementNetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnetResourceId = (string) content.GetValueForProperty("ManagementNetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)this).ManagementNetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DedicatedHsmProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DedicatedHsmProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DedicatedHsmProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DedicatedHsmProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the dedicated hsm
    [System.ComponentModel.TypeConverter(typeof(DedicatedHsmPropertiesTypeConverter))]
    public partial interface IDedicatedHsmProperties

    {

    }
}