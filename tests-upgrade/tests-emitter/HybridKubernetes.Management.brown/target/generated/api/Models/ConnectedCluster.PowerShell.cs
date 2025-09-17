// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.PowerShell;

    /// <summary>Represents a connected cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConnectedClusterTypeConverter))]
    public partial class ConnectedCluster
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConnectedCluster(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedClusterIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AadProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IAadProfile) content.GetValueForProperty("AadProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.AadProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfile) content.GetValueForProperty("SecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Gateway"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Gateway = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IGateway) content.GetValueForProperty("Gateway",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Gateway, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.GatewayTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectivityStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ConnectivityStatus = (string) content.GetValueForProperty("ConnectivityStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ConnectivityStatus, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentProfile) content.GetValueForProperty("ArcAgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ArcAgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("OidcIssuerProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOidcIssuerProfile) content.GetValueForProperty("OidcIssuerProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.OidcIssuerProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentPublicKeyCertificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentPublicKeyCertificate = (string) content.GetValueForProperty("AgentPublicKeyCertificate",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentPublicKeyCertificate, global::System.Convert.ToString);
            }
            if (content.Contains("KubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).KubernetesVersion = (string) content.GetValueForProperty("KubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).KubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("TotalNodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalNodeCount = (int?) content.GetValueForProperty("TotalNodeCount",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalNodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TotalCoreCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalCoreCount = (int?) content.GetValueForProperty("TotalCoreCount",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalCoreCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Distribution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Distribution = (string) content.GetValueForProperty("Distribution",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Distribution, global::System.Convert.ToString);
            }
            if (content.Contains("DistributionVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).DistributionVersion = (string) content.GetValueForProperty("DistributionVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).DistributionVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Infrastructure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Infrastructure = (string) content.GetValueForProperty("Infrastructure",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Infrastructure, global::System.Convert.ToString);
            }
            if (content.Contains("Offering"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Offering = (string) content.GetValueForProperty("Offering",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Offering, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedIdentityCertificateExpirationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ManagedIdentityCertificateExpirationTime = (global::System.DateTime?) content.GetValueForProperty("ManagedIdentityCertificateExpirationTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ManagedIdentityCertificateExpirationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastConnectivityTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).LastConnectivityTime = (global::System.DateTime?) content.GetValueForProperty("LastConnectivityTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).LastConnectivityTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrivateLinkState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkState = (string) content.GetValueForProperty("PrivateLinkState",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkScopeResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureHybridBenefit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AzureHybridBenefit = (string) content.GetValueForProperty("AzureHybridBenefit",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AzureHybridBenefit, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentryConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentryConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurations>) content.GetValueForProperty("ArcAgentryConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentryConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurations>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ArcAgentryConfigurationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("MiscellaneousProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).MiscellaneousProperty = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterPropertiesMiscellaneousProperties) content.GetValueForProperty("MiscellaneousProperty",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).MiscellaneousProperty, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedClusterPropertiesMiscellaneousPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ArcAgentProfileSystemComponent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileSystemComponent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISystemComponent>) content.GetValueForProperty("ArcAgentProfileSystemComponent",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileSystemComponent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISystemComponent>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SystemComponentTypeConverter.ConvertFrom));
            }
            if (content.Contains("ArcAgentProfileAgentError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IAgentError>) content.GetValueForProperty("ArcAgentProfileAgentError",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IAgentError>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.AgentErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("SecurityProfileWorkloadIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfileWorkloadIdentity = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity) content.GetValueForProperty("SecurityProfileWorkloadIdentity",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfileWorkloadIdentity, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SecurityProfileWorkloadIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AadProfileEnableAzureRbac"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileEnableAzureRbac = (bool?) content.GetValueForProperty("AadProfileEnableAzureRbac",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileEnableAzureRbac, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AadProfileAdminGroupObjectID"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileAdminGroupObjectID = (System.Collections.Generic.List<string>) content.GetValueForProperty("AadProfileAdminGroupObjectID",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileAdminGroupObjectID, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AadProfileTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileTenantId = (string) content.GetValueForProperty("AadProfileTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfileDesiredAgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileDesiredAgentVersion = (string) content.GetValueForProperty("ArcAgentProfileDesiredAgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileDesiredAgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfileAgentAutoUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentAutoUpgrade = (string) content.GetValueForProperty("ArcAgentProfileAgentAutoUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentAutoUpgrade, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfileAgentState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentState = (string) content.GetValueForProperty("ArcAgentProfileAgentState",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentState, global::System.Convert.ToString);
            }
            if (content.Contains("OidcIssuerProfileEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileEnabled = (bool?) content.GetValueForProperty("OidcIssuerProfileEnabled",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OidcIssuerProfileIssuerUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileIssuerUrl = (string) content.GetValueForProperty("OidcIssuerProfileIssuerUrl",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileIssuerUrl, global::System.Convert.ToString);
            }
            if (content.Contains("OidcIssuerProfileSelfHostedIssuerUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileSelfHostedIssuerUrl = (string) content.GetValueForProperty("OidcIssuerProfileSelfHostedIssuerUrl",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileSelfHostedIssuerUrl, global::System.Convert.ToString);
            }
            if (content.Contains("GatewayEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).GatewayEnabled = (bool?) content.GetValueForProperty("GatewayEnabled",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).GatewayEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WorkloadIdentityEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).WorkloadIdentityEnabled = (bool?) content.GetValueForProperty("WorkloadIdentityEnabled",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).WorkloadIdentityEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConnectedCluster(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedClusterIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AadProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IAadProfile) content.GetValueForProperty("AadProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.AadProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfile) content.GetValueForProperty("SecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Gateway"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Gateway = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IGateway) content.GetValueForProperty("Gateway",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Gateway, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.GatewayTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectivityStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ConnectivityStatus = (string) content.GetValueForProperty("ConnectivityStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ConnectivityStatus, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentProfile) content.GetValueForProperty("ArcAgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ArcAgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("OidcIssuerProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOidcIssuerProfile) content.GetValueForProperty("OidcIssuerProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.OidcIssuerProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentPublicKeyCertificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentPublicKeyCertificate = (string) content.GetValueForProperty("AgentPublicKeyCertificate",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentPublicKeyCertificate, global::System.Convert.ToString);
            }
            if (content.Contains("KubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).KubernetesVersion = (string) content.GetValueForProperty("KubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).KubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("TotalNodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalNodeCount = (int?) content.GetValueForProperty("TotalNodeCount",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalNodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TotalCoreCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalCoreCount = (int?) content.GetValueForProperty("TotalCoreCount",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).TotalCoreCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Distribution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Distribution = (string) content.GetValueForProperty("Distribution",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Distribution, global::System.Convert.ToString);
            }
            if (content.Contains("DistributionVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).DistributionVersion = (string) content.GetValueForProperty("DistributionVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).DistributionVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Infrastructure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Infrastructure = (string) content.GetValueForProperty("Infrastructure",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Infrastructure, global::System.Convert.ToString);
            }
            if (content.Contains("Offering"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Offering = (string) content.GetValueForProperty("Offering",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).Offering, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedIdentityCertificateExpirationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ManagedIdentityCertificateExpirationTime = (global::System.DateTime?) content.GetValueForProperty("ManagedIdentityCertificateExpirationTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ManagedIdentityCertificateExpirationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastConnectivityTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).LastConnectivityTime = (global::System.DateTime?) content.GetValueForProperty("LastConnectivityTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).LastConnectivityTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrivateLinkState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkState = (string) content.GetValueForProperty("PrivateLinkState",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkScopeResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureHybridBenefit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AzureHybridBenefit = (string) content.GetValueForProperty("AzureHybridBenefit",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AzureHybridBenefit, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentryConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentryConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurations>) content.GetValueForProperty("ArcAgentryConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentryConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurations>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ArcAgentryConfigurationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("MiscellaneousProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).MiscellaneousProperty = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterPropertiesMiscellaneousProperties) content.GetValueForProperty("MiscellaneousProperty",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).MiscellaneousProperty, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedClusterPropertiesMiscellaneousPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ArcAgentProfileSystemComponent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileSystemComponent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISystemComponent>) content.GetValueForProperty("ArcAgentProfileSystemComponent",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileSystemComponent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISystemComponent>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SystemComponentTypeConverter.ConvertFrom));
            }
            if (content.Contains("ArcAgentProfileAgentError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IAgentError>) content.GetValueForProperty("ArcAgentProfileAgentError",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IAgentError>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.AgentErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("SecurityProfileWorkloadIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfileWorkloadIdentity = (Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity) content.GetValueForProperty("SecurityProfileWorkloadIdentity",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).SecurityProfileWorkloadIdentity, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SecurityProfileWorkloadIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AadProfileEnableAzureRbac"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileEnableAzureRbac = (bool?) content.GetValueForProperty("AadProfileEnableAzureRbac",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileEnableAzureRbac, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AadProfileAdminGroupObjectID"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileAdminGroupObjectID = (System.Collections.Generic.List<string>) content.GetValueForProperty("AadProfileAdminGroupObjectID",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileAdminGroupObjectID, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AadProfileTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileTenantId = (string) content.GetValueForProperty("AadProfileTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).AadProfileTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfileDesiredAgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileDesiredAgentVersion = (string) content.GetValueForProperty("ArcAgentProfileDesiredAgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileDesiredAgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfileAgentAutoUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentAutoUpgrade = (string) content.GetValueForProperty("ArcAgentProfileAgentAutoUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentAutoUpgrade, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAgentProfileAgentState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentState = (string) content.GetValueForProperty("ArcAgentProfileAgentState",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).ArcAgentProfileAgentState, global::System.Convert.ToString);
            }
            if (content.Contains("OidcIssuerProfileEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileEnabled = (bool?) content.GetValueForProperty("OidcIssuerProfileEnabled",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OidcIssuerProfileIssuerUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileIssuerUrl = (string) content.GetValueForProperty("OidcIssuerProfileIssuerUrl",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileIssuerUrl, global::System.Convert.ToString);
            }
            if (content.Contains("OidcIssuerProfileSelfHostedIssuerUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileSelfHostedIssuerUrl = (string) content.GetValueForProperty("OidcIssuerProfileSelfHostedIssuerUrl",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).OidcIssuerProfileSelfHostedIssuerUrl, global::System.Convert.ToString);
            }
            if (content.Contains("GatewayEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).GatewayEnabled = (bool?) content.GetValueForProperty("GatewayEnabled",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).GatewayEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WorkloadIdentityEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).WorkloadIdentityEnabled = (bool?) content.GetValueForProperty("WorkloadIdentityEnabled",((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedClusterInternal)this).WorkloadIdentityEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConnectedCluster(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ConnectedCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConnectedCluster(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConnectedCluster" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ConnectedCluster" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IConnectedCluster FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Represents a connected cluster.
    [System.ComponentModel.TypeConverter(typeof(ConnectedClusterTypeConverter))]
    public partial interface IConnectedCluster

    {

    }
}