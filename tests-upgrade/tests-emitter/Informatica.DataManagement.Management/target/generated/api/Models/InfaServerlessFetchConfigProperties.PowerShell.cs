// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>
    /// InfaServerlessFetchConfigProperties for the fetch all serverless API as received from informatica API response
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(InfaServerlessFetchConfigPropertiesTypeConverter))]
    public partial class InfaServerlessFetchConfigProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InfaServerlessFetchConfigProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InfaServerlessFetchConfigProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InfaServerlessFetchConfigProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="InfaServerlessFetchConfigProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InfaServerlessFetchConfigProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Subnet, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ApplicationType = (string) content.GetValueForProperty("ApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ApplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("AdvancedCustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).AdvancedCustomProperty = (string) content.GetValueForProperty("AdvancedCustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).AdvancedCustomProperty, global::System.Convert.ToString);
            }
            if (content.Contains("SupplementaryFileLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SupplementaryFileLocation = (string) content.GetValueForProperty("SupplementaryFileLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SupplementaryFileLocation, global::System.Convert.ToString);
            }
            if (content.Contains("Platform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Platform = (string) content.GetValueForProperty("Platform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Platform, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Tag = (string) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Tag, global::System.Convert.ToString);
            }
            if (content.Contains("Vnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Vnet = (string) content.GetValueForProperty("Vnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Vnet, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ExecutionTimeout = (string) content.GetValueForProperty("ExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ComputeUnit = (string) content.GetValueForProperty("ComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ComputeUnit, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessArmResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ServerlessArmResourceId = (string) content.GetValueForProperty("ServerlessArmResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ServerlessArmResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InfaServerlessFetchConfigProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Subnet, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ApplicationType = (string) content.GetValueForProperty("ApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ApplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("AdvancedCustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).AdvancedCustomProperty = (string) content.GetValueForProperty("AdvancedCustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).AdvancedCustomProperty, global::System.Convert.ToString);
            }
            if (content.Contains("SupplementaryFileLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SupplementaryFileLocation = (string) content.GetValueForProperty("SupplementaryFileLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SupplementaryFileLocation, global::System.Convert.ToString);
            }
            if (content.Contains("Platform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Platform = (string) content.GetValueForProperty("Platform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Platform, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Tag = (string) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Tag, global::System.Convert.ToString);
            }
            if (content.Contains("Vnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Vnet = (string) content.GetValueForProperty("Vnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Vnet, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ExecutionTimeout = (string) content.GetValueForProperty("ExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ComputeUnit = (string) content.GetValueForProperty("ComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ComputeUnit, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessArmResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ServerlessArmResourceId = (string) content.GetValueForProperty("ServerlessArmResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)this).ServerlessArmResourceId, global::System.Convert.ToString);
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
    /// InfaServerlessFetchConfigProperties for the fetch all serverless API as received from informatica API response
    [System.ComponentModel.TypeConverter(typeof(InfaServerlessFetchConfigPropertiesTypeConverter))]
    public partial interface IInfaServerlessFetchConfigProperties

    {

    }
}