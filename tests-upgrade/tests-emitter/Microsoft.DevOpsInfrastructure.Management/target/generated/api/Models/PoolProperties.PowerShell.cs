// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.PowerShell;

    /// <summary>Pool properties</summary>
    [System.ComponentModel.TypeConverter(typeof(PoolPropertiesTypeConverter))]
    public partial class PoolProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PoolProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PoolProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PoolProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PoolProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PoolProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OrganizationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile) content.GetValueForProperty("OrganizationProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile) content.GetValueForProperty("AgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile) content.GetValueForProperty("FabricProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MaximumConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).MaximumConcurrency = (int) content.GetValueForProperty("MaximumConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).MaximumConcurrency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DevCenterProjectResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).DevCenterProjectResourceId = (string) content.GetValueForProperty("DevCenterProjectResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).DevCenterProjectResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePrediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePrediction = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) content.GetValueForProperty("AgentProfileResourcePrediction",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePrediction, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfileKind = (string) content.GetValueForProperty("OrganizationProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePredictionsProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePredictionsProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile) content.GetValueForProperty("AgentProfileResourcePredictionsProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePredictionsProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileKind = (string) content.GetValueForProperty("AgentProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("FabricProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfileKind = (string) content.GetValueForProperty("FabricProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ResourcePredictionProfileKind = (string) content.GetValueForProperty("ResourcePredictionProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ResourcePredictionProfileKind, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PoolProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OrganizationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile) content.GetValueForProperty("OrganizationProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile) content.GetValueForProperty("AgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile) content.GetValueForProperty("FabricProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MaximumConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).MaximumConcurrency = (int) content.GetValueForProperty("MaximumConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).MaximumConcurrency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DevCenterProjectResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).DevCenterProjectResourceId = (string) content.GetValueForProperty("DevCenterProjectResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).DevCenterProjectResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePrediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePrediction = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) content.GetValueForProperty("AgentProfileResourcePrediction",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePrediction, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfileKind = (string) content.GetValueForProperty("OrganizationProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).OrganizationProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePredictionsProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePredictionsProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile) content.GetValueForProperty("AgentProfileResourcePredictionsProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileResourcePredictionsProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileKind = (string) content.GetValueForProperty("AgentProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).AgentProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("FabricProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfileKind = (string) content.GetValueForProperty("FabricProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).FabricProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ResourcePredictionProfileKind = (string) content.GetValueForProperty("ResourcePredictionProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)this).ResourcePredictionProfileKind, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Pool properties
    [System.ComponentModel.TypeConverter(typeof(PoolPropertiesTypeConverter))]
    public partial interface IPoolProperties

    {

    }
}