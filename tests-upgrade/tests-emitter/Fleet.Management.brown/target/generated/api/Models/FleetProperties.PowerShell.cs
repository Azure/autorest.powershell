// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.PowerShell;

    /// <summary>Fleet properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(FleetPropertiesTypeConverter))]
    public partial class FleetProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FleetProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FleetProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FleetProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HubProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile) content.GetValueForProperty("HubProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileAgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileAgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile) content.GetValueForProperty("HubProfileAgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileAgentProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileApiServerAccessProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileApiServerAccessProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile) content.GetValueForProperty("HubProfileApiServerAccessProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileApiServerAccessProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileDnsPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileDnsPrefix = (string) content.GetValueForProperty("HubProfileDnsPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileDnsPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileFqdn = (string) content.GetValueForProperty("HubProfileFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileKubernetesVersion = (string) content.GetValueForProperty("HubProfileKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfilePortalFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfilePortalFqdn = (string) content.GetValueForProperty("HubProfilePortalFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfilePortalFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileSubnetId = (string) content.GetValueForProperty("ApiServerAccessProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileSubnetId = (string) content.GetValueForProperty("AgentProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusLastOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("StatusLastOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusLastOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationId = (string) content.GetValueForProperty("StatusLastOperationId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileEnablePrivateCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnablePrivateCluster = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnablePrivateCluster",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnablePrivateCluster, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApiServerAccessProfileEnableVnetIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnableVnetIntegration = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnableVnetIntegration",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnableVnetIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentProfileVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileVMSize = (string) content.GetValueForProperty("AgentProfileVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorCode = (string) content.GetValueForProperty("LastOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorMessage = (string) content.GetValueForProperty("LastOperationErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorTarget = (string) content.GetValueForProperty("LastOperationErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("LastOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastOperationErrorAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorAdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("LastOperationErrorAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorAdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FleetProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HubProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile) content.GetValueForProperty("HubProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileAgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileAgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile) content.GetValueForProperty("HubProfileAgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileAgentProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileApiServerAccessProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileApiServerAccessProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile) content.GetValueForProperty("HubProfileApiServerAccessProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileApiServerAccessProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileDnsPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileDnsPrefix = (string) content.GetValueForProperty("HubProfileDnsPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileDnsPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileFqdn = (string) content.GetValueForProperty("HubProfileFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileKubernetesVersion = (string) content.GetValueForProperty("HubProfileKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfileKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfilePortalFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfilePortalFqdn = (string) content.GetValueForProperty("HubProfilePortalFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).HubProfilePortalFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileSubnetId = (string) content.GetValueForProperty("ApiServerAccessProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileSubnetId = (string) content.GetValueForProperty("AgentProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusLastOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("StatusLastOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusLastOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationId = (string) content.GetValueForProperty("StatusLastOperationId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).StatusLastOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileEnablePrivateCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnablePrivateCluster = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnablePrivateCluster",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnablePrivateCluster, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApiServerAccessProfileEnableVnetIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnableVnetIntegration = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnableVnetIntegration",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).ApiServerAccessProfileEnableVnetIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentProfileVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileVMSize = (string) content.GetValueForProperty("AgentProfileVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).AgentProfileVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorCode = (string) content.GetValueForProperty("LastOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorMessage = (string) content.GetValueForProperty("LastOperationErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorTarget = (string) content.GetValueForProperty("LastOperationErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("LastOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastOperationErrorAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorAdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("LastOperationErrorAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)this).LastOperationErrorAdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FleetProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FleetProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Fleet properties.
    [System.ComponentModel.TypeConverter(typeof(FleetPropertiesTypeConverter))]
    public partial interface IFleetProperties

    {

    }
}