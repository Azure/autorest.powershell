// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Gets or sets the database configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(DatabaseConfigurationTypeConverter))]
    public partial class DatabaseConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DatabaseConfiguration(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("VirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration) content.GetValueForProperty("DiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).InstanceCount = (long) content.GetValueForProperty("InstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).InstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("VirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("VirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("VirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskConfigurationDiskVolumeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurations) content.GetValueForProperty("DiskConfigurationDiskVolumeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DatabaseConfiguration(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("VirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration) content.GetValueForProperty("DiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).InstanceCount = (long) content.GetValueForProperty("InstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).InstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("VirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("VirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("VirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).VirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskConfigurationDiskVolumeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurations) content.GetValueForProperty("DiskConfigurationDiskVolumeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DatabaseConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DatabaseConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DatabaseConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DatabaseConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Gets or sets the database configuration.
    [System.ComponentModel.TypeConverter(typeof(DatabaseConfigurationTypeConverter))]
    public partial interface IDatabaseConfiguration

    {

    }
}