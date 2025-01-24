// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>
    /// Gets or sets the single server configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(SingleServerConfigurationTypeConverter))]
    public partial class SingleServerConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SingleServerConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SingleServerConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SingleServerConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SingleServerConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SingleServerConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NetworkConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration) content.GetValueForProperty("NetworkConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("VirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DbDiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration) content.GetValueForProperty("DbDiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceName = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNames) content.GetValueForProperty("CustomResourceName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceName, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerCustomResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AppResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup = (string) content.GetValueForProperty("AppResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("VirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("VirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkConfigurationIsSecondaryIPEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled = (bool?) content.GetValueForProperty("NetworkConfigurationIsSecondaryIPEnabled",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("VirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DbDiskConfigurationDiskVolumeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfigurationDiskVolumeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurations) content.GetValueForProperty("DbDiskConfigurationDiskVolumeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfigurationDiskVolumeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceNameNamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceNameNamingPatternType = (string) content.GetValueForProperty("CustomResourceNameNamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceNameNamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SingleServerConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NetworkConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration) content.GetValueForProperty("NetworkConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("VirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DbDiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration) content.GetValueForProperty("DbDiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceName = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNames) content.GetValueForProperty("CustomResourceName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceName, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerCustomResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AppResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup = (string) content.GetValueForProperty("AppResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("VirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("VirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkConfigurationIsSecondaryIPEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled = (bool?) content.GetValueForProperty("NetworkConfigurationIsSecondaryIPEnabled",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("VirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).VirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileOsconfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileOsconfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("OSProfileOsconfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileOsconfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DbDiskConfigurationDiskVolumeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfigurationDiskVolumeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurations) content.GetValueForProperty("DbDiskConfigurationDiskVolumeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).DbDiskConfigurationDiskVolumeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceNameNamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceNameNamingPatternType = (string) content.GetValueForProperty("CustomResourceNameNamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).CustomResourceNameNamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminUsername = (string) content.GetValueForProperty("OSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("OSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("OSConfigurationOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSConfigurationOstype = (string) content.GetValueForProperty("OSConfigurationOstype",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerConfigurationInternal)this).OSConfigurationOstype, global::System.Convert.ToString);
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
    /// Gets or sets the single server configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    [System.ComponentModel.TypeConverter(typeof(SingleServerConfigurationTypeConverter))]
    public partial interface ISingleServerConfiguration

    {

    }
}