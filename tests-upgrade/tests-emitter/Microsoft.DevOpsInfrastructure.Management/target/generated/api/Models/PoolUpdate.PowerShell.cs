// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.PowerShell;

    /// <summary>The type used for update operations of the Pool.</summary>
    [System.ComponentModel.TypeConverter(typeof(PoolUpdateTypeConverter))]
    public partial class PoolUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PoolUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PoolUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PoolUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PoolUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PoolUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile) content.GetValueForProperty("OrganizationProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile) content.GetValueForProperty("AgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile) content.GetValueForProperty("FabricProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MaximumConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).MaximumConcurrency = (int?) content.GetValueForProperty("MaximumConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).MaximumConcurrency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DevCenterProjectResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).DevCenterProjectResourceId = (string) content.GetValueForProperty("DevCenterProjectResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).DevCenterProjectResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePrediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePrediction = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) content.GetValueForProperty("AgentProfileResourcePrediction",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePrediction, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfileKind = (string) content.GetValueForProperty("OrganizationProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePredictionsProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePredictionsProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile) content.GetValueForProperty("AgentProfileResourcePredictionsProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePredictionsProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileKind = (string) content.GetValueForProperty("AgentProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("FabricProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfileKind = (string) content.GetValueForProperty("FabricProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ResourcePredictionProfileKind = (string) content.GetValueForProperty("ResourcePredictionProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ResourcePredictionProfileKind, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PoolUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile) content.GetValueForProperty("OrganizationProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile) content.GetValueForProperty("AgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile) content.GetValueForProperty("FabricProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MaximumConcurrency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).MaximumConcurrency = (int?) content.GetValueForProperty("MaximumConcurrency",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).MaximumConcurrency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DevCenterProjectResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).DevCenterProjectResourceId = (string) content.GetValueForProperty("DevCenterProjectResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).DevCenterProjectResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePrediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePrediction = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) content.GetValueForProperty("AgentProfileResourcePrediction",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePrediction, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfileKind = (string) content.GetValueForProperty("OrganizationProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).OrganizationProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileResourcePredictionsProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePredictionsProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile) content.GetValueForProperty("AgentProfileResourcePredictionsProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileResourcePredictionsProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileKind = (string) content.GetValueForProperty("AgentProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).AgentProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("FabricProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfileKind = (string) content.GetValueForProperty("FabricProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).FabricProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ResourcePredictionProfileKind = (string) content.GetValueForProperty("ResourcePredictionProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal)this).ResourcePredictionProfileKind, global::System.Convert.ToString);
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
    /// The type used for update operations of the Pool.
    [System.ComponentModel.TypeConverter(typeof(PoolUpdateTypeConverter))]
    public partial interface IPoolUpdate

    {

    }
}