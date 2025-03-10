// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a single
    /// server SAP system.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(SingleServerFullResourceNamesTypeConverter))]
    public partial class SingleServerFullResourceNames
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNames"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNames DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SingleServerFullResourceNames(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNames"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNames DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SingleServerFullResourceNames(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SingleServerFullResourceNames" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SingleServerFullResourceNames" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNames FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SingleServerFullResourceNames(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachine = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames) content.GetValueForProperty("VirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachine, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal)this).NamingPatternType = (string) content.GetValueForProperty("NamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal)this).NamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames>) content.GetValueForProperty("VirtualMachineNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkInterfaceResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualMachineVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineVMName = (string) content.GetValueForProperty("VirtualMachineVMName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineVMName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineHostName = (string) content.GetValueForProperty("VirtualMachineHostName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineHostName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineOSDiskName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineOSDiskName = (string) content.GetValueForProperty("VirtualMachineOSDiskName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineOSDiskName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineDataDiskName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineDataDiskName = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames) content.GetValueForProperty("VirtualMachineDataDiskName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineDataDiskName, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DataDiskNamesTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SingleServerFullResourceNames(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachine = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames) content.GetValueForProperty("VirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachine, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal)this).NamingPatternType = (string) content.GetValueForProperty("NamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal)this).NamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineNetworkInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineNetworkInterface = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames>) content.GetValueForProperty("VirtualMachineNetworkInterface",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineNetworkInterface, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkInterfaceResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualMachineVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineVMName = (string) content.GetValueForProperty("VirtualMachineVMName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineVMName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineHostName = (string) content.GetValueForProperty("VirtualMachineHostName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineHostName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineOSDiskName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineOSDiskName = (string) content.GetValueForProperty("VirtualMachineOSDiskName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineOSDiskName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineDataDiskName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineDataDiskName = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames) content.GetValueForProperty("VirtualMachineDataDiskName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal)this).VirtualMachineDataDiskName, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DataDiskNamesTypeConverter.ConvertFrom);
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
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a single
    /// server SAP system.
    [System.ComponentModel.TypeConverter(typeof(SingleServerFullResourceNamesTypeConverter))]
    public partial interface ISingleServerFullResourceNames

    {

    }
}