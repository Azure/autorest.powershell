// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell;

    /// <summary>Describes the properties of an Azure Large Instance.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureLargeInstancePropertiesTypeConverter))]
    public partial class AzureLargeInstanceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureLargeInstanceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HardwareProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile) content.GetValueForProperty("HardwareProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.HardwareProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureLargeInstanceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).AzureLargeInstanceId = (string) content.GetValueForProperty("AzureLargeInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).AzureLargeInstanceId, global::System.Convert.ToString);
            }
            if (content.Contains("PowerState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).PowerState = (string) content.GetValueForProperty("PowerState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).PowerState, global::System.Convert.ToString);
            }
            if (content.Contains("ProximityPlacementGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProximityPlacementGroup = (string) content.GetValueForProperty("ProximityPlacementGroup",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProximityPlacementGroup, global::System.Convert.ToString);
            }
            if (content.Contains("HwRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HwRevision = (string) content.GetValueForProperty("HwRevision",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HwRevision, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StorageProfileOSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileOSDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk>) content.GetValueForProperty("StorageProfileOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileOSDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.DiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress>) content.GetValueForProperty("NetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress>(__y, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IPAddressTypeConverter.ConvertFrom));
            }
            if (content.Contains("HardwareProfileHardwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileHardwareType = (string) content.GetValueForProperty("HardwareProfileHardwareType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileHardwareType, global::System.Convert.ToString);
            }
            if (content.Contains("HardwareProfileAzureLargeInstanceSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileAzureLargeInstanceSize = (string) content.GetValueForProperty("HardwareProfileAzureLargeInstanceSize",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileAzureLargeInstanceSize, global::System.Convert.ToString);
            }
            if (content.Contains("StorageProfileNfsIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileNfsIPAddress = (string) content.GetValueForProperty("StorageProfileNfsIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileNfsIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileComputerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileComputerName = (string) content.GetValueForProperty("OSProfileComputerName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileComputerName, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileOstype = (string) content.GetValueForProperty("OSProfileOstype",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileOstype, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileVersion = (string) content.GetValueForProperty("OSProfileVersion",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileSshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileSshPublicKey = (string) content.GetValueForProperty("OSProfileSshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileSshPublicKey, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfileCircuitId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileCircuitId = (string) content.GetValueForProperty("NetworkProfileCircuitId",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileCircuitId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureLargeInstanceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HardwareProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile) content.GetValueForProperty("HardwareProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.HardwareProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureLargeInstanceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).AzureLargeInstanceId = (string) content.GetValueForProperty("AzureLargeInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).AzureLargeInstanceId, global::System.Convert.ToString);
            }
            if (content.Contains("PowerState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).PowerState = (string) content.GetValueForProperty("PowerState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).PowerState, global::System.Convert.ToString);
            }
            if (content.Contains("ProximityPlacementGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProximityPlacementGroup = (string) content.GetValueForProperty("ProximityPlacementGroup",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProximityPlacementGroup, global::System.Convert.ToString);
            }
            if (content.Contains("HwRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HwRevision = (string) content.GetValueForProperty("HwRevision",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HwRevision, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StorageProfileOSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileOSDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk>) content.GetValueForProperty("StorageProfileOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileOSDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.DiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress>) content.GetValueForProperty("NetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress>(__y, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IPAddressTypeConverter.ConvertFrom));
            }
            if (content.Contains("HardwareProfileHardwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileHardwareType = (string) content.GetValueForProperty("HardwareProfileHardwareType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileHardwareType, global::System.Convert.ToString);
            }
            if (content.Contains("HardwareProfileAzureLargeInstanceSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileAzureLargeInstanceSize = (string) content.GetValueForProperty("HardwareProfileAzureLargeInstanceSize",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).HardwareProfileAzureLargeInstanceSize, global::System.Convert.ToString);
            }
            if (content.Contains("StorageProfileNfsIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileNfsIPAddress = (string) content.GetValueForProperty("StorageProfileNfsIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).StorageProfileNfsIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileComputerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileComputerName = (string) content.GetValueForProperty("OSProfileComputerName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileComputerName, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileOstype = (string) content.GetValueForProperty("OSProfileOstype",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileOstype, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileVersion = (string) content.GetValueForProperty("OSProfileVersion",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileSshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileSshPublicKey = (string) content.GetValueForProperty("OSProfileSshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).OSProfileSshPublicKey, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfileCircuitId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileCircuitId = (string) content.GetValueForProperty("NetworkProfileCircuitId",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)this).NetworkProfileCircuitId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureLargeInstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureLargeInstanceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureLargeInstanceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureLargeInstanceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Describes the properties of an Azure Large Instance.
    [System.ComponentModel.TypeConverter(typeof(AzureLargeInstancePropertiesTypeConverter))]
    public partial interface IAzureLargeInstanceProperties

    {

    }
}