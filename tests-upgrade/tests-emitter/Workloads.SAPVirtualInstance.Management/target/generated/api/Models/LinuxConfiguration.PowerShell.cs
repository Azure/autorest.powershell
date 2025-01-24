// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see
    /// [Linux on Azure-Endorsed Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(LinuxConfigurationTypeConverter))]
    public partial class LinuxConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LinuxConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LinuxConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LinuxConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="LinuxConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LinuxConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Ssh"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).Ssh = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfiguration) content.GetValueForProperty("Ssh",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).Ssh, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SshKeyPair"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPair = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair) content.GetValueForProperty("SshKeyPair",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPair, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshKeyPairTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisablePasswordAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication = (bool?) content.GetValueForProperty("DisablePasswordAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("SshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshPublicKey = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey>) content.GetValueForProperty("SshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshPublicKey, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshPublicKeyTypeConverter.ConvertFrom));
            }
            if (content.Contains("SshKeyPairPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPublicKey = (string) content.GetValueForProperty("SshKeyPairPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPublicKey, global::System.Convert.ToString);
            }
            if (content.Contains("SshKeyPairPrivateKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPrivateKey = (System.Security.SecureString) content.GetValueForProperty("SshKeyPairPrivateKey",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPrivateKey, (object ss) => (System.Security.SecureString)ss);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LinuxConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Ssh"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).Ssh = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfiguration) content.GetValueForProperty("Ssh",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).Ssh, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SshKeyPair"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPair = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair) content.GetValueForProperty("SshKeyPair",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPair, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshKeyPairTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisablePasswordAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication = (bool?) content.GetValueForProperty("DisablePasswordAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("SshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshPublicKey = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey>) content.GetValueForProperty("SshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshPublicKey, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshPublicKeyTypeConverter.ConvertFrom));
            }
            if (content.Contains("SshKeyPairPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPublicKey = (string) content.GetValueForProperty("SshKeyPairPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPublicKey, global::System.Convert.ToString);
            }
            if (content.Contains("SshKeyPairPrivateKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPrivateKey = (System.Security.SecureString) content.GetValueForProperty("SshKeyPairPrivateKey",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal)this).SshKeyPairPrivateKey, (object ss) => (System.Security.SecureString)ss);
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
    /// Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see
    /// [Linux on Azure-Endorsed Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    [System.ComponentModel.TypeConverter(typeof(LinuxConfigurationTypeConverter))]
    public partial interface ILinuxConfiguration

    {

    }
}