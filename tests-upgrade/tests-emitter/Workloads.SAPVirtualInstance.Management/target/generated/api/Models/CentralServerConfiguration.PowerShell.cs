// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Gets or sets the central server configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(CentralServerConfigurationTypeConverter))]
    public partial class CentralServerConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CentralServerConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("VirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).InstanceCount = (long) content.GetValueForProperty("InstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).InstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("VirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("VirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("VirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CentralServerConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("VirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).InstanceCount = (long) content.GetValueForProperty("InstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).InstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("VirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("VirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("VirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).VirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CentralServerConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CentralServerConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CentralServerConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CentralServerConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Gets or sets the central server configuration.
    [System.ComponentModel.TypeConverter(typeof(CentralServerConfigurationTypeConverter))]
    public partial interface ICentralServerConfiguration

    {

    }
}