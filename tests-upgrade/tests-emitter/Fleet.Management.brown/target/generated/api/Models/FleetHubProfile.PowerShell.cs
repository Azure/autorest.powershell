// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.PowerShell;

    /// <summary>The FleetHubProfile configures the fleet hub.</summary>
    [System.ComponentModel.TypeConverter(typeof(FleetHubProfileTypeConverter))]
    public partial class FleetHubProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FleetHubProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FleetHubProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FleetHubProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApiServerAccessProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile) content.GetValueForProperty("ApiServerAccessProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile) content.GetValueForProperty("AgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).DnsPrefix = (string) content.GetValueForProperty("DnsPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).DnsPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("Fqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).Fqdn, global::System.Convert.ToString);
            }
            if (content.Contains("KubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).KubernetesVersion = (string) content.GetValueForProperty("KubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).KubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PortalFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).PortalFqdn = (string) content.GetValueForProperty("PortalFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).PortalFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileSubnetId = (string) content.GetValueForProperty("ApiServerAccessProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileSubnetId = (string) content.GetValueForProperty("AgentProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileEnablePrivateCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnablePrivateCluster = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnablePrivateCluster",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnablePrivateCluster, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApiServerAccessProfileEnableVnetIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnableVnetIntegration = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnableVnetIntegration",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnableVnetIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentProfileVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileVMSize = (string) content.GetValueForProperty("AgentProfileVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileVMSize, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FleetHubProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApiServerAccessProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile) content.GetValueForProperty("ApiServerAccessProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile) content.GetValueForProperty("AgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).DnsPrefix = (string) content.GetValueForProperty("DnsPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).DnsPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("Fqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).Fqdn, global::System.Convert.ToString);
            }
            if (content.Contains("KubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).KubernetesVersion = (string) content.GetValueForProperty("KubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).KubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PortalFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).PortalFqdn = (string) content.GetValueForProperty("PortalFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).PortalFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileSubnetId = (string) content.GetValueForProperty("ApiServerAccessProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileSubnetId = (string) content.GetValueForProperty("AgentProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileEnablePrivateCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnablePrivateCluster = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnablePrivateCluster",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnablePrivateCluster, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApiServerAccessProfileEnableVnetIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnableVnetIntegration = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnableVnetIntegration",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).ApiServerAccessProfileEnableVnetIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentProfileVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileVMSize = (string) content.GetValueForProperty("AgentProfileVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfileInternal)this).AgentProfileVMSize, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FleetHubProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FleetHubProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The FleetHubProfile configures the fleet hub.
    [System.ComponentModel.TypeConverter(typeof(FleetHubProfileTypeConverter))]
    public partial interface IFleetHubProfile

    {

    }
}