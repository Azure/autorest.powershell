// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Defines the virtual machine configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineConfigurationTypeConverter))]
    public partial class VirtualMachineConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachineConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("ImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).VMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("ImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).VMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Defines the virtual machine configuration.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineConfigurationTypeConverter))]
    public partial interface IVirtualMachineConfiguration

    {

    }
}