// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.PowerShell;

    /// <summary>Resource information with extended details.</summary>
    [System.ComponentModel.TypeConverter(typeof(DedicatedHsmTypeConverter))]
    public partial class DedicatedHsm
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DedicatedHsm(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("ManagementNetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StampId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StampId = (string) content.GetValueForProperty("StampId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StampId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("NetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("NetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnetResourceId = (string) content.GetValueForProperty("NetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagementNetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("ManagementNetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("ManagementNetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagementNetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnetResourceId = (string) content.GetValueForProperty("ManagementNetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DedicatedHsm(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile) content.GetValueForProperty("ManagementNetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StampId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StampId = (string) content.GetValueForProperty("StampId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StampId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("NetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("NetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnetResourceId = (string) content.GetValueForProperty("NetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).NetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagementNetworkProfileSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnet = (Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference) content.GetValueForProperty("ManagementNetworkProfileSubnet",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnet, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagementNetworkProfileNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>) content.GetValueForProperty("ManagementNetworkProfileNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagementNetworkProfileSubnetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnetResourceId = (string) content.GetValueForProperty("ManagementNetworkProfileSubnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal)this).ManagementNetworkProfileSubnetResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DedicatedHsm(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DedicatedHsm(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DedicatedHsm" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DedicatedHsm" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Resource information with extended details.
    [System.ComponentModel.TypeConverter(typeof(DedicatedHsmTypeConverter))]
    public partial interface IDedicatedHsm

    {

    }
}