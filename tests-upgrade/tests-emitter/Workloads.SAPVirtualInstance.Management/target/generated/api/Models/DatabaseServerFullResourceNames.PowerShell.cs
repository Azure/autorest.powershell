// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(DatabaseServerFullResourceNamesTypeConverter))]
    public partial class DatabaseServerFullResourceNames
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DatabaseServerFullResourceNames(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames) content.GetValueForProperty("LoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).VirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("VirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).VirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("AvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).AvailabilitySetName = (string) content.GetValueForProperty("AvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).AvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerName = (string) content.GetValueForProperty("LoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerFrontendIPConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerFrontendIPConfigurationName = (System.Collections.Generic.List<string>) content.GetValueForProperty("LoadBalancerFrontendIPConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerFrontendIPConfigurationName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LoadBalancerBackendPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerBackendPoolName = (System.Collections.Generic.List<string>) content.GetValueForProperty("LoadBalancerBackendPoolName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerBackendPoolName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LoadBalancerHealthProbeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerHealthProbeName = (System.Collections.Generic.List<string>) content.GetValueForProperty("LoadBalancerHealthProbeName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerHealthProbeName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DatabaseServerFullResourceNames(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames) content.GetValueForProperty("LoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).VirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("VirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).VirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("AvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).AvailabilitySetName = (string) content.GetValueForProperty("AvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).AvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerName = (string) content.GetValueForProperty("LoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerFrontendIPConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerFrontendIPConfigurationName = (System.Collections.Generic.List<string>) content.GetValueForProperty("LoadBalancerFrontendIPConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerFrontendIPConfigurationName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LoadBalancerBackendPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerBackendPoolName = (System.Collections.Generic.List<string>) content.GetValueForProperty("LoadBalancerBackendPoolName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerBackendPoolName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LoadBalancerHealthProbeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerHealthProbeName = (System.Collections.Generic.List<string>) content.GetValueForProperty("LoadBalancerHealthProbeName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)this).LoadBalancerHealthProbeName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DatabaseServerFullResourceNames(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DatabaseServerFullResourceNames(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DatabaseServerFullResourceNames" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DatabaseServerFullResourceNames" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    [System.ComponentModel.TypeConverter(typeof(DatabaseServerFullResourceNamesTypeConverter))]
    public partial interface IDatabaseServerFullResourceNames

    {

    }
}