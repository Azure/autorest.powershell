// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>A Serverless Runtime environment resource by Informatica.</summary>
    [System.ComponentModel.TypeConverter(typeof(InformaticaServerlessRuntimeResourceTypeConverter))]
    public partial class InformaticaServerlessRuntimeResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimeResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InformaticaServerlessRuntimeResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimeResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InformaticaServerlessRuntimeResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InformaticaServerlessRuntimeResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="InformaticaServerlessRuntimeResource" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimeResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InformaticaServerlessRuntimeResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ApplicationType = (string) content.GetValueForProperty("ApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ApplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeNetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile) content.GetValueForProperty("ServerlessRuntimeNetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerlessRuntimeConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfig = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties) content.GetValueForProperty("ServerlessRuntimeConfig",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfig, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerlessRuntimeUserContextProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties) content.GetValueForProperty("ServerlessRuntimeUserContextProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Platform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Platform = (string) content.GetValueForProperty("Platform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Platform, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ComputeUnit = (string) content.GetValueForProperty("ComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ComputeUnit, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ExecutionTimeout = (string) content.GetValueForProperty("ExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessAccountLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessAccountLocation = (string) content.GetValueForProperty("ServerlessAccountLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessAccountLocation, global::System.Convert.ToString);
            }
            if (content.Contains("AdvancedCustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).AdvancedCustomProperty = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties>) content.GetValueForProperty("AdvancedCustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).AdvancedCustomProperty, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.AdvancedCustomPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("SupplementaryFileLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).SupplementaryFileLocation = (string) content.GetValueForProperty("SupplementaryFileLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).SupplementaryFileLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeTag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag>) content.GetValueForProperty("ServerlessRuntimeTag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeTag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration) content.GetValueForProperty("ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.NetworkInterfaceConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkInterfaceConfigurationVnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetId = (string) content.GetValueForProperty("NetworkInterfaceConfigurationVnetId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetId, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkInterfaceConfigurationSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationSubnetId = (string) content.GetValueForProperty("NetworkInterfaceConfigurationSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeConfigCdiConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdiConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigCdiConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdiConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeConfigCdieConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdieConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigCdieConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdieConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeUserContextPropertyUserContextToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextPropertyUserContextToken = (string) content.GetValueForProperty("ServerlessRuntimeUserContextPropertyUserContextToken",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextPropertyUserContextToken, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkInterfaceConfigurationVnetResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetResourceGuid = (string) content.GetValueForProperty("NetworkInterfaceConfigurationVnetResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetResourceGuid, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimeResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InformaticaServerlessRuntimeResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ApplicationType = (string) content.GetValueForProperty("ApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ApplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeNetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile) content.GetValueForProperty("ServerlessRuntimeNetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerlessRuntimeConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfig = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties) content.GetValueForProperty("ServerlessRuntimeConfig",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfig, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerlessRuntimeUserContextProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties) content.GetValueForProperty("ServerlessRuntimeUserContextProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Platform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Platform = (string) content.GetValueForProperty("Platform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).Platform, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ComputeUnit = (string) content.GetValueForProperty("ComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ComputeUnit, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ExecutionTimeout = (string) content.GetValueForProperty("ExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessAccountLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessAccountLocation = (string) content.GetValueForProperty("ServerlessAccountLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessAccountLocation, global::System.Convert.ToString);
            }
            if (content.Contains("AdvancedCustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).AdvancedCustomProperty = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties>) content.GetValueForProperty("AdvancedCustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).AdvancedCustomProperty, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.AdvancedCustomPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("SupplementaryFileLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).SupplementaryFileLocation = (string) content.GetValueForProperty("SupplementaryFileLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).SupplementaryFileLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeTag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag>) content.GetValueForProperty("ServerlessRuntimeTag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeTag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration) content.GetValueForProperty("ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.NetworkInterfaceConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkInterfaceConfigurationVnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetId = (string) content.GetValueForProperty("NetworkInterfaceConfigurationVnetId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetId, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkInterfaceConfigurationSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationSubnetId = (string) content.GetValueForProperty("NetworkInterfaceConfigurationSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeConfigCdiConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdiConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigCdiConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdiConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeConfigCdieConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdieConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigCdieConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeConfigCdieConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeUserContextPropertyUserContextToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextPropertyUserContextToken = (string) content.GetValueForProperty("ServerlessRuntimeUserContextPropertyUserContextToken",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).ServerlessRuntimeUserContextPropertyUserContextToken, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkInterfaceConfigurationVnetResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetResourceGuid = (string) content.GetValueForProperty("NetworkInterfaceConfigurationVnetResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).NetworkInterfaceConfigurationVnetResourceGuid, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A Serverless Runtime environment resource by Informatica.
    [System.ComponentModel.TypeConverter(typeof(InformaticaServerlessRuntimeResourceTypeConverter))]
    public partial interface IInformaticaServerlessRuntimeResource

    {

    }
}