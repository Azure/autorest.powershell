// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>Deployment Configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(DeploymentConfigurationTypeConverter))]
    public partial class DeploymentConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DeploymentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeploymentConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InfrastructureConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration) content.GetValueForProperty("InfrastructureConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.InfrastructureConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftwareConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration) content.GetValueForProperty("SoftwareConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AppLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).AppLocation = (string) content.GetValueForProperty("AppLocation",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).AppLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)this).ConfigurationType = (string) content.GetValueForProperty("ConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)this).ConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("InfrastructureConfigurationAppResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationAppResourceGroup = (string) content.GetValueForProperty("InfrastructureConfigurationAppResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationAppResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("InfrastructureConfigurationDeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationDeploymentType = (string) content.GetValueForProperty("InfrastructureConfigurationDeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationDeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("SoftwareConfigurationSoftwareInstallationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfigurationSoftwareInstallationType = (string) content.GetValueForProperty("SoftwareConfigurationSoftwareInstallationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfigurationSoftwareInstallationType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DeploymentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeploymentConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InfrastructureConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration) content.GetValueForProperty("InfrastructureConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.InfrastructureConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftwareConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration) content.GetValueForProperty("SoftwareConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AppLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).AppLocation = (string) content.GetValueForProperty("AppLocation",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).AppLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)this).ConfigurationType = (string) content.GetValueForProperty("ConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)this).ConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("InfrastructureConfigurationAppResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationAppResourceGroup = (string) content.GetValueForProperty("InfrastructureConfigurationAppResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationAppResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("InfrastructureConfigurationDeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationDeploymentType = (string) content.GetValueForProperty("InfrastructureConfigurationDeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).InfrastructureConfigurationDeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("SoftwareConfigurationSoftwareInstallationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfigurationSoftwareInstallationType = (string) content.GetValueForProperty("SoftwareConfigurationSoftwareInstallationType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfigurationInternal)this).SoftwareConfigurationSoftwareInstallationType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DeploymentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeploymentConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DeploymentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeploymentConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeploymentConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DeploymentConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Deployment Configuration.
    [System.ComponentModel.TypeConverter(typeof(DeploymentConfigurationTypeConverter))]
    public partial interface IDeploymentConfiguration

    {

    }
}