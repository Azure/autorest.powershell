// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.PowerShell;

    /// <summary>The data product resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataProductTypeConverter))]
    public partial class DataProduct
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataProduct(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4TypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails) content.GetValueForProperty("CustomerEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Networkacl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Networkacl = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls) content.GetValueForProperty("Networkacl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Networkacl, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAclsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedResourceGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration) content.GetValueForProperty("ManagedResourceGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedResourceGroupConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConsumptionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties) content.GetValueForProperty("ConsumptionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpoint, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("Publisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Publisher, global::System.Convert.ToString);
            }
            if (content.Contains("Product"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Product = (string) content.GetValueForProperty("Product",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Product, global::System.Convert.ToString);
            }
            if (content.Contains("MajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).MajorVersion = (string) content.GetValueForProperty("MajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).MajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Owner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Owner = (System.Collections.Generic.List<string>) content.GetValueForProperty("Owner",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Owner, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Redundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Redundancy = (string) content.GetValueForProperty("Redundancy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Redundancy, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewAccount = (string) content.GetValueForProperty("PurviewAccount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewAccount, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewCollection = (string) content.GetValueForProperty("PurviewCollection",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewCollection, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinksEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PrivateLinksEnabled = (string) content.GetValueForProperty("PrivateLinksEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PrivateLinksEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerManagedKeyEncryptionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerManagedKeyEncryptionEnabled = (string) content.GetValueForProperty("CustomerManagedKeyEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerManagedKeyEncryptionEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("AvailableMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).AvailableMinorVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("AvailableMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).AvailableMinorVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CurrentMinorVersion = (string) content.GetValueForProperty("CurrentMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CurrentMinorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Documentation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Documentation = (string) content.GetValueForProperty("Documentation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Documentation, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).KeyVaultUrl = (string) content.GetValueForProperty("KeyVaultUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).KeyVaultUrl, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclDefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclDefaultAction = (string) content.GetValueForProperty("NetworkaclDefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclDefaultAction, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4UserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomerEncryptionKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVaultUri = (string) content.GetValueForProperty("CustomerEncryptionKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyName = (string) content.GetValueForProperty("CustomerEncryptionKeyName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyName, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVersion = (string) content.GetValueForProperty("CustomerEncryptionKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclVirtualNetworkRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>) content.GetValueForProperty("NetworkaclVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclVirtualNetworkRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclIPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclIPRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>) content.GetValueForProperty("NetworkaclIPRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclIPRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclAllowedQueryIPRangeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclAllowedQueryIPRangeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("NetworkaclAllowedQueryIPRangeList",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclAllowedQueryIPRangeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ManagedResourceGroupConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationName = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupConfigurationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationLocation = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionUrl = (string) content.GetValueForProperty("ConsumptionEndpointIngestionUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionResourceId = (string) content.GetValueForProperty("ConsumptionEndpointIngestionResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessUrl = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessResourceId = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryUrl = (string) content.GetValueForProperty("ConsumptionEndpointQueryUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryResourceId = (string) content.GetValueForProperty("ConsumptionEndpointQueryResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataProduct(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4TypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails) content.GetValueForProperty("CustomerEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Networkacl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Networkacl = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls) content.GetValueForProperty("Networkacl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Networkacl, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAclsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedResourceGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration) content.GetValueForProperty("ManagedResourceGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedResourceGroupConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConsumptionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties) content.GetValueForProperty("ConsumptionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpoint, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("Publisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Publisher, global::System.Convert.ToString);
            }
            if (content.Contains("Product"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Product = (string) content.GetValueForProperty("Product",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Product, global::System.Convert.ToString);
            }
            if (content.Contains("MajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).MajorVersion = (string) content.GetValueForProperty("MajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).MajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Owner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Owner = (System.Collections.Generic.List<string>) content.GetValueForProperty("Owner",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Owner, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Redundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Redundancy = (string) content.GetValueForProperty("Redundancy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Redundancy, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewAccount = (string) content.GetValueForProperty("PurviewAccount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewAccount, global::System.Convert.ToString);
            }
            if (content.Contains("PurviewCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewCollection = (string) content.GetValueForProperty("PurviewCollection",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PurviewCollection, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinksEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PrivateLinksEnabled = (string) content.GetValueForProperty("PrivateLinksEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PrivateLinksEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerManagedKeyEncryptionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerManagedKeyEncryptionEnabled = (string) content.GetValueForProperty("CustomerManagedKeyEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerManagedKeyEncryptionEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("AvailableMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).AvailableMinorVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("AvailableMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).AvailableMinorVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CurrentMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CurrentMinorVersion = (string) content.GetValueForProperty("CurrentMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CurrentMinorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Documentation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Documentation = (string) content.GetValueForProperty("Documentation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).Documentation, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).KeyVaultUrl = (string) content.GetValueForProperty("KeyVaultUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).KeyVaultUrl, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclDefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclDefaultAction = (string) content.GetValueForProperty("NetworkaclDefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclDefaultAction, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedServiceIdentityV4UserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedServiceIdentityV4UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomerEncryptionKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVaultUri = (string) content.GetValueForProperty("CustomerEncryptionKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyName = (string) content.GetValueForProperty("CustomerEncryptionKeyName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyName, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerEncryptionKeyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVersion = (string) content.GetValueForProperty("CustomerEncryptionKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).CustomerEncryptionKeyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkaclVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclVirtualNetworkRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>) content.GetValueForProperty("NetworkaclVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclVirtualNetworkRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclIPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclIPRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>) content.GetValueForProperty("NetworkaclIPRule",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclIPRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkaclAllowedQueryIPRangeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclAllowedQueryIPRangeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("NetworkaclAllowedQueryIPRangeList",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).NetworkaclAllowedQueryIPRangeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ManagedResourceGroupConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationName = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupConfigurationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationLocation = (string) content.GetValueForProperty("ManagedResourceGroupConfigurationLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ManagedResourceGroupConfigurationLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionUrl = (string) content.GetValueForProperty("ConsumptionEndpointIngestionUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointIngestionResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionResourceId = (string) content.GetValueForProperty("ConsumptionEndpointIngestionResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointIngestionResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessUrl = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointFileAccessResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessResourceId = (string) content.GetValueForProperty("ConsumptionEndpointFileAccessResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointFileAccessResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryUrl = (string) content.GetValueForProperty("ConsumptionEndpointQueryUrl",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumptionEndpointQueryResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryResourceId = (string) content.GetValueForProperty("ConsumptionEndpointQueryResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInternal)this).ConsumptionEndpointQueryResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataProduct(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataProduct(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataProduct" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataProduct" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProduct FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The data product resource.
    [System.ComponentModel.TypeConverter(typeof(DataProductTypeConverter))]
    public partial interface IDataProduct

    {

    }
}