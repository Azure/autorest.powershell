// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>Specifies an IP configuration of the network interface.</summary>
    [System.ComponentModel.TypeConverter(typeof(IPConfigurationTypeConverter))]
    public partial class IPConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IPConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IPConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IPConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IPConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IPConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Subnet = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Subnet, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicIPAddressConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration) content.GetValueForProperty("PublicIPAddressConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PublicIPAddressConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationGatewayBackendAddressPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).ApplicationGatewayBackendAddressPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>) content.GetValueForProperty("ApplicationGatewayBackendAddressPool",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).ApplicationGatewayBackendAddressPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancerBackendAddressPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerBackendAddressPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>) content.GetValueForProperty("LoadBalancerBackendAddressPool",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerBackendAddressPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancerInboundNatPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerInboundNatPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>) content.GetValueForProperty("LoadBalancerInboundNatPool",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerInboundNatPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateIPAddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PrivateIPAddressVersion = (string) content.GetValueForProperty("PrivateIPAddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PrivateIPAddressVersion, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddressConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationName = (string) content.GetValueForProperty("PublicIPAddressConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddressConfigurationIptag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationIptag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>) content.GetValueForProperty("PublicIPAddressConfigurationIptag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationIptag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicIPAddressConfigurationPublicIpaddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationPublicIpaddressVersion = (string) content.GetValueForProperty("PublicIPAddressConfigurationPublicIpaddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationPublicIpaddressVersion, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IPConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Subnet = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Subnet, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicIPAddressConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration) content.GetValueForProperty("PublicIPAddressConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PublicIPAddressConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationGatewayBackendAddressPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).ApplicationGatewayBackendAddressPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>) content.GetValueForProperty("ApplicationGatewayBackendAddressPool",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).ApplicationGatewayBackendAddressPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancerBackendAddressPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerBackendAddressPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>) content.GetValueForProperty("LoadBalancerBackendAddressPool",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerBackendAddressPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancerInboundNatPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerInboundNatPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>) content.GetValueForProperty("LoadBalancerInboundNatPool",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).LoadBalancerInboundNatPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateIPAddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PrivateIPAddressVersion = (string) content.GetValueForProperty("PrivateIPAddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PrivateIPAddressVersion, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddressConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationName = (string) content.GetValueForProperty("PublicIPAddressConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddressConfigurationIptag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationIptag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>) content.GetValueForProperty("PublicIPAddressConfigurationIptag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationIptag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicIPAddressConfigurationPublicIpaddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationPublicIpaddressVersion = (string) content.GetValueForProperty("PublicIPAddressConfigurationPublicIpaddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal)this).PublicIPAddressConfigurationPublicIpaddressVersion, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Specifies an IP configuration of the network interface.
    [System.ComponentModel.TypeConverter(typeof(IPConfigurationTypeConverter))]
    public partial interface IIPConfiguration

    {

    }
}