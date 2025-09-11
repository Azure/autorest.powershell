// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>
    /// Gets or sets the three tier SAP configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ThreeTierConfigurationTypeConverter))]
    public partial class ThreeTierConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ThreeTierConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ThreeTierConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ThreeTierConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ThreeTierConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ThreeTierConfiguration(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration) content.GetValueForProperty("NetworkConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration) content.GetValueForProperty("CentralServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfiguration) content.GetValueForProperty("ApplicationServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration) content.GetValueForProperty("DatabaseServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailabilityConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfig = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration) content.GetValueForProperty("HighAvailabilityConfig",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfig, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilityConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration) content.GetValueForProperty("StorageConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.StorageConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceName = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames) content.GetValueForProperty("CustomResourceName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceName, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierCustomResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AppResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup = (string) content.GetValueForProperty("AppResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerInstanceCount = (long) content.GetValueForProperty("CentralServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ApplicationServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerInstanceCount = (long) content.GetValueForProperty("ApplicationServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DatabaseServerDiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration) content.GetValueForProperty("DatabaseServerDiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerInstanceCount = (long) content.GetValueForProperty("DatabaseServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("NetworkConfigurationIsSecondaryIPEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled = (bool?) content.GetValueForProperty("NetworkConfigurationIsSecondaryIPEnabled",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CentralServerVirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("CentralServerVirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServerSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerSubnetId = (string) content.GetValueForProperty("CentralServerSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("ApplicationServerVirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerSubnetId = (string) content.GetValueForProperty("ApplicationServerSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("DatabaseServerVirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerDatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDatabaseType = (string) content.GetValueForProperty("DatabaseServerDatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerSubnetId = (string) content.GetValueForProperty("DatabaseServerSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailabilityConfigHighAvailabilityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfigHighAvailabilityType = (string) content.GetValueForProperty("HighAvailabilityConfigHighAvailabilityType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfigHighAvailabilityType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageConfigurationTransportFileShareConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfigurationTransportFileShareConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration) content.GetValueForProperty("StorageConfigurationTransportFileShareConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfigurationTransportFileShareConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.FileShareConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceNameNamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceNameNamingPatternType = (string) content.GetValueForProperty("CustomResourceNameNamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceNameNamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceId = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileOSConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileOSConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceId = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceId = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskConfigurationDiskVolumeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfigurationDiskVolumeConfigurations) content.GetValueForProperty("DiskConfigurationDiskVolumeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationDiskVolumeConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransportFileShareConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).TransportFileShareConfigurationType = (string) content.GetValueForProperty("TransportFileShareConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).TransportFileShareConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferencePublisher = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceOffer = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceSku = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceVersion = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminUsername = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferencePublisher = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceOffer = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceSku = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceVersion = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferencePublisher = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceOffer = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceSku = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceVersion = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ThreeTierConfiguration(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration) content.GetValueForProperty("NetworkConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration) content.GetValueForProperty("CentralServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfiguration) content.GetValueForProperty("ApplicationServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration) content.GetValueForProperty("DatabaseServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailabilityConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfig = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration) content.GetValueForProperty("HighAvailabilityConfig",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfig, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilityConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration) content.GetValueForProperty("StorageConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.StorageConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceName = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames) content.GetValueForProperty("CustomResourceName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceName, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierCustomResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AppResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup = (string) content.GetValueForProperty("AppResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).AppResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerInstanceCount = (long) content.GetValueForProperty("CentralServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ApplicationServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerInstanceCount = (long) content.GetValueForProperty("ApplicationServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DatabaseServerDiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration) content.GetValueForProperty("DatabaseServerDiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerInstanceCount = (long) content.GetValueForProperty("DatabaseServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("NetworkConfigurationIsSecondaryIPEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled = (bool?) content.GetValueForProperty("NetworkConfigurationIsSecondaryIPEnabled",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).NetworkConfigurationIsSecondaryIPEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CentralServerVirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("CentralServerVirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServerSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerSubnetId = (string) content.GetValueForProperty("CentralServerSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("ApplicationServerVirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerSubnetId = (string) content.GetValueForProperty("ApplicationServerSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration) content.GetValueForProperty("DatabaseServerVirtualMachineConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerDatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDatabaseType = (string) content.GetValueForProperty("DatabaseServerDatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerDatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerSubnetId = (string) content.GetValueForProperty("DatabaseServerSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReference = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReference",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReference, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfile = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfile",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfile, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailabilityConfigHighAvailabilityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfigHighAvailabilityType = (string) content.GetValueForProperty("HighAvailabilityConfigHighAvailabilityType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).HighAvailabilityConfigHighAvailabilityType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageConfigurationTransportFileShareConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfigurationTransportFileShareConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration) content.GetValueForProperty("StorageConfigurationTransportFileShareConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).StorageConfigurationTransportFileShareConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.FileShareConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomResourceNameNamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceNameNamingPatternType = (string) content.GetValueForProperty("CustomResourceNameNamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CustomResourceNameNamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceId = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileOSConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileOSConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceId = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationVMSize = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationVMSize",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceId = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskConfigurationDiskVolumeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfigurationDiskVolumeConfigurations) content.GetValueForProperty("DiskConfigurationDiskVolumeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DiskConfigurationDiskVolumeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskConfigurationDiskVolumeConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransportFileShareConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).TransportFileShareConfigurationType = (string) content.GetValueForProperty("TransportFileShareConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).TransportFileShareConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferencePublisher = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceOffer = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceSku = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceVersion = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminUsername = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType = (string) content.GetValueForProperty("CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferencePublisher = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceOffer = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceSku = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceVersion = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType = (string) content.GetValueForProperty("ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferencePublisher = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceOffer = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceSku = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceVersion = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword = (System.Security.SecureString) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType = (string) content.GetValueForProperty("DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal)this).DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType, global::System.Convert.ToString);
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
    /// Gets or sets the three tier SAP configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    [System.ComponentModel.TypeConverter(typeof(ThreeTierConfigurationTypeConverter))]
    public partial interface IThreeTierConfiguration

    {

    }
}