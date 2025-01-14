// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell;

    /// <summary>The data product properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataProductPropertiesTypeConverter))]
    public partial class DataProductProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataProductProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CustomerEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails) content.GetValueForProperty("CustomerEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Networkacl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Networkacl = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls) content.GetValueForProperty("Networkacl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Networkacl, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAclsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedResourceGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration) content.GetValueForProperty("ManagedResourceGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedResourceGroupConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConsumptionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties) content.GetValueForProperty("ConsumptionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpoint, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Publisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Publisher, global::System.Convert.ToString);
            }
            if (content.Contains("Product"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Product = (string) content.GetValueForProperty("Product",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Product, global::System.Convert.ToString);
            }
            if (content.Contains("MajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).MajorVersion = (string) content.GetValueForProperty("MajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).MajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Owner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Owner = (System.Collections.Generic.List<string>) content.GetValueForProperty("Owner",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Owner, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Redundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Redundancy = (string) content.GetValueForProperty("Redundancy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Redundancy, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewAccount = (string) content.GetValueForProperty("PurviewAccount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewAccount, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewCollection = (string) content.GetValueForProperty("PurviewCollection",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewCollection, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinksEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PrivateLinksEnabled = (string) content.GetValueForProperty("PrivateLinksEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PrivateLinksEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerManagedKeyEncryptionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerManagedKeyEncryptionEnabled = (string) content.GetValueForProperty("CustomerManagedKeyEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerManagedKeyEncryptionEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("AvailableMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).AvailableMinorVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("AvailableMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).AvailableMinorVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CurrentMinorVersion = (string) content.GetValueForProperty("CurrentMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CurrentMinorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Documentation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Documentation = (string) content.GetValueForProperty("Documentation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Documentation, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).KeyVaultUrl = (string) content.GetValueForProperty("KeyVaultUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).KeyVaultUrl, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclIPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclIPRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>) content.GetValueForProperty("NetworkaclIPRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclIPRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclDefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclDefaultAction = (string) content.GetValueForProperty("NetworkaclDefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclDefaultAction, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVaultUri = (string) content.GetValueForProperty("CustomerEncryptionKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyName = (string) content.GetValueForProperty("CustomerEncryptionKeyName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyName, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVersion = (string) content.GetValueForProperty("CustomerEncryptionKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclVirtualNetworkRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>) content.GetValueForProperty("NetworkaclVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclVirtualNetworkRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclAllowedQueryIPRangeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclAllowedQueryIPRangeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("NetworkaclAllowedQueryIPRangeList",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclAllowedQueryIPRangeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ManagedResourceGroupConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationName = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupConfigurationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationLocation = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionUrl = (string) content.GetValueForProperty("ConsumptionEndpointIngestionUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionResourceId = (string) content.GetValueForProperty("ConsumptionEndpointIngestionResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessUrl = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessResourceId = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryUrl = (string) content.GetValueForProperty("ConsumptionEndpointQueryUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryResourceId = (string) content.GetValueForProperty("ConsumptionEndpointQueryResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataProductProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CustomerEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails) content.GetValueForProperty("CustomerEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Networkacl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Networkacl = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls) content.GetValueForProperty("Networkacl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Networkacl, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAclsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedResourceGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration) content.GetValueForProperty("ManagedResourceGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedResourceGroupConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConsumptionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties) content.GetValueForProperty("ConsumptionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpoint, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Publisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Publisher, global::System.Convert.ToString);
            }
            if (content.Contains("Product"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Product = (string) content.GetValueForProperty("Product",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Product, global::System.Convert.ToString);
            }
            if (content.Contains("MajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).MajorVersion = (string) content.GetValueForProperty("MajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).MajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Owner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Owner = (System.Collections.Generic.List<string>) content.GetValueForProperty("Owner",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Owner, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Redundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Redundancy = (string) content.GetValueForProperty("Redundancy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Redundancy, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewAccount = (string) content.GetValueForProperty("PurviewAccount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewAccount, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewCollection = (string) content.GetValueForProperty("PurviewCollection",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PurviewCollection, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinksEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PrivateLinksEnabled = (string) content.GetValueForProperty("PrivateLinksEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PrivateLinksEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerManagedKeyEncryptionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerManagedKeyEncryptionEnabled = (string) content.GetValueForProperty("CustomerManagedKeyEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerManagedKeyEncryptionEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("AvailableMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).AvailableMinorVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("AvailableMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).AvailableMinorVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CurrentMinorVersion = (string) content.GetValueForProperty("CurrentMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CurrentMinorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Documentation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Documentation = (string) content.GetValueForProperty("Documentation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).Documentation, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).KeyVaultUrl = (string) content.GetValueForProperty("KeyVaultUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).KeyVaultUrl, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclIPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclIPRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>) content.GetValueForProperty("NetworkaclIPRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclIPRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclDefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclDefaultAction = (string) content.GetValueForProperty("NetworkaclDefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclDefaultAction, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVaultUri = (string) content.GetValueForProperty("CustomerEncryptionKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyName = (string) content.GetValueForProperty("CustomerEncryptionKeyName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyName, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVersion = (string) content.GetValueForProperty("CustomerEncryptionKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).CustomerEncryptionKeyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclVirtualNetworkRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>) content.GetValueForProperty("NetworkaclVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclVirtualNetworkRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclAllowedQueryIPRangeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclAllowedQueryIPRangeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("NetworkaclAllowedQueryIPRangeList",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).NetworkaclAllowedQueryIPRangeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ManagedResourceGroupConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationName = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupConfigurationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationLocation = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ManagedResourceGroupConfigurationLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionUrl = (string) content.GetValueForProperty("ConsumptionEndpointIngestionUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionResourceId = (string) content.GetValueForProperty("ConsumptionEndpointIngestionResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointIngestionResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessUrl = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessResourceId = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointFileAccessResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryUrl = (string) content.GetValueForProperty("ConsumptionEndpointQueryUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryResourceId = (string) content.GetValueForProperty("ConsumptionEndpointQueryResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal)this).ConsumptionEndpointQueryResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataProductProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataProductProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataProductProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataProductProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The data product properties.
    [System.ComponentModel.TypeConverter(typeof(DataProductPropertiesTypeConverter))]
    public partial interface IDataProductProperties

    {

    }
}