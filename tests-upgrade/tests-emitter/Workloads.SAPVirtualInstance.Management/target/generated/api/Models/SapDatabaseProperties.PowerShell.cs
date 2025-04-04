// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Defines the Database properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(SapDatabasePropertiesTypeConverter))]
    public partial class SapDatabaseProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SapDatabaseProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SapDatabaseProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SapDatabaseProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SapDatabaseProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabaseProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SapDatabaseProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LoadBalancerDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetail = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails) content.GetValueForProperty("LoadBalancerDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetail, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Subnet, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseSid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseSid = (string) content.GetValueForProperty("DatabaseSid",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseSid, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).IPAddress = (string) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).IPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("VMDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).VMDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails>) content.GetValueForProperty("VMDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).VMDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseVMDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerDetailId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetailId = (string) content.GetValueForProperty("LoadBalancerDetailId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetailId, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDatabaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SapDatabaseProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LoadBalancerDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetail = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails) content.GetValueForProperty("LoadBalancerDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetail, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Subnet, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseSid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseSid = (string) content.GetValueForProperty("DatabaseSid",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseSid, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).IPAddress = (string) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).IPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("VMDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).VMDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails>) content.GetValueForProperty("VMDetail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).VMDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseVMDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseVMDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerDetailId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetailId = (string) content.GetValueForProperty("LoadBalancerDetailId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).LoadBalancerDetailId, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ErrorDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDatabasePropertiesInternal)this).Message, global::System.Convert.ToString);
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
    /// Defines the Database properties.
    [System.ComponentModel.TypeConverter(typeof(SapDatabasePropertiesTypeConverter))]
    public partial interface ISapDatabaseProperties

    {

    }
}