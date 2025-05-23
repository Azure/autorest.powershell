// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Define the Virtual Instance for SAP solutions resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(SapVirtualInstanceTypeConverter))]
    public partial class SapVirtualInstance
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstance DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SapVirtualInstance(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstance DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SapVirtualInstance(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SapVirtualInstance" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SapVirtualInstance" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstance FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SapVirtualInstance(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstancePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceIdentity1TypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Configuration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Configuration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedResourceGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfiguration) content.GetValueForProperty("ManagedResourceGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ManagedRgConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Environment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("SapProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).SapProduct = (string) content.GetValueForProperty("SapProduct",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).SapProduct, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourcesNetworkAccessType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourcesNetworkAccessType = (string) content.GetValueForProperty("ManagedResourcesNetworkAccessType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourcesNetworkAccessType, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ConfigurationType = (string) content.GetValueForProperty("ConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfigurationName = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SapVirtualInstance(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstancePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceIdentity1TypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Configuration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Configuration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedResourceGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfiguration) content.GetValueForProperty("ManagedResourceGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ManagedRgConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Environment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("SapProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).SapProduct = (string) content.GetValueForProperty("SapProduct",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).SapProduct, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourcesNetworkAccessType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourcesNetworkAccessType = (string) content.GetValueForProperty("ManagedResourcesNetworkAccessType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourcesNetworkAccessType, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ConfigurationType = (string) content.GetValueForProperty("ConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfigurationName = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ManagedResourceGroupConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Define the Virtual Instance for SAP solutions resource.
    [System.ComponentModel.TypeConverter(typeof(SapVirtualInstanceTypeConverter))]
    public partial interface ISapVirtualInstance

    {

    }
}