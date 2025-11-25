// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Request body to get the configuration for the region.</summary>
    [System.ComponentModel.TypeConverter(typeof(RegionConfigurationRequestTypeConverter))]
    public partial class RegionConfigurationRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.RegionConfigurationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RegionConfigurationRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.RegionConfigurationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RegionConfigurationRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RegionConfigurationRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RegionConfigurationRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.RegionConfigurationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RegionConfigurationRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ScheduleAvailabilityRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest) content.GetValueForProperty("ScheduleAvailabilityRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransportAvailabilityRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequest) content.GetValueForProperty("TransportAvailabilityRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportAvailabilityRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatacenterAddressRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequest) content.GetValueForProperty("DatacenterAddressRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceCapabilityRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest) content.GetValueForProperty("DeviceCapabilityRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceCapabilityRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleAvailabilityRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestSkuName = (string) content.GetValueForProperty("ScheduleAvailabilityRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("TransportAvailabilityRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestSkuName = (string) content.GetValueForProperty("TransportAvailabilityRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestSkuName = (string) content.GetValueForProperty("DatacenterAddressRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceCapabilityRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestSkuName = (string) content.GetValueForProperty("DeviceCapabilityRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleAvailabilityRequestStorageLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestStorageLocation = (string) content.GetValueForProperty("ScheduleAvailabilityRequestStorageLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestStorageLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleAvailabilityRequestCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestCountry = (string) content.GetValueForProperty("ScheduleAvailabilityRequestCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleAvailabilityRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestModel = (string) content.GetValueForProperty("ScheduleAvailabilityRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestModel, global::System.Convert.ToString);
            }
            if (content.Contains("TransportAvailabilityRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestModel = (string) content.GetValueForProperty("TransportAvailabilityRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestModel, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressRequestStorageLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestStorageLocation = (string) content.GetValueForProperty("DatacenterAddressRequestStorageLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestStorageLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestModel = (string) content.GetValueForProperty("DatacenterAddressRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestModel, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceCapabilityRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestModel = (string) content.GetValueForProperty("DeviceCapabilityRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestModel, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.RegionConfigurationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RegionConfigurationRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ScheduleAvailabilityRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest) content.GetValueForProperty("ScheduleAvailabilityRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransportAvailabilityRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequest) content.GetValueForProperty("TransportAvailabilityRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportAvailabilityRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatacenterAddressRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequest) content.GetValueForProperty("DatacenterAddressRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceCapabilityRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequest = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest) content.GetValueForProperty("DeviceCapabilityRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequest, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceCapabilityRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleAvailabilityRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestSkuName = (string) content.GetValueForProperty("ScheduleAvailabilityRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("TransportAvailabilityRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestSkuName = (string) content.GetValueForProperty("TransportAvailabilityRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestSkuName = (string) content.GetValueForProperty("DatacenterAddressRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceCapabilityRequestSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestSkuName = (string) content.GetValueForProperty("DeviceCapabilityRequestSkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleAvailabilityRequestStorageLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestStorageLocation = (string) content.GetValueForProperty("ScheduleAvailabilityRequestStorageLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestStorageLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleAvailabilityRequestCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestCountry = (string) content.GetValueForProperty("ScheduleAvailabilityRequestCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ScheduleAvailabilityRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestModel = (string) content.GetValueForProperty("ScheduleAvailabilityRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).ScheduleAvailabilityRequestModel, global::System.Convert.ToString);
            }
            if (content.Contains("TransportAvailabilityRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestModel = (string) content.GetValueForProperty("TransportAvailabilityRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).TransportAvailabilityRequestModel, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressRequestStorageLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestStorageLocation = (string) content.GetValueForProperty("DatacenterAddressRequestStorageLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestStorageLocation, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestModel = (string) content.GetValueForProperty("DatacenterAddressRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DatacenterAddressRequestModel, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceCapabilityRequestModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestModel = (string) content.GetValueForProperty("DeviceCapabilityRequestModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal)this).DeviceCapabilityRequestModel, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Request body to get the configuration for the region.
    [System.ComponentModel.TypeConverter(typeof(RegionConfigurationRequestTypeConverter))]
    public partial interface IRegionConfigurationRequest

    {

    }
}