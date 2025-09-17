// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;

    /// <summary>Properties specific to the grafana resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedGrafanaPropertiesTypeConverter))]
    public partial class ManagedGrafanaProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedGrafanaProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedGrafanaProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedGrafanaProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedGrafanaProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedGrafanaProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GrafanaIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaIntegrations) content.GetValueForProperty("GrafanaIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaIntegrationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnterpriseConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations) content.GetValueForProperty("EnterpriseConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations) content.GetValueForProperty("GrafanaConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaVersion = (string) content.GetValueForProperty("GrafanaVersion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Endpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).Endpoint, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("ZoneRedundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ZoneRedundancy = (string) content.GetValueForProperty("ZoneRedundancy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ZoneRedundancy, global::System.Convert.ToString);
            }
            if (content.Contains("ApiKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ApiKey = (string) content.GetValueForProperty("ApiKey",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ApiKey, global::System.Convert.ToString);
            }
            if (content.Contains("DeterministicOutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).DeterministicOutboundIP = (string) content.GetValueForProperty("DeterministicOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).DeterministicOutboundIP, global::System.Convert.ToString);
            }
            if (content.Contains("OutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).OutboundIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("OutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).OutboundIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AutoGeneratedDomainNameLabelScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).AutoGeneratedDomainNameLabelScope = (string) content.GetValueForProperty("AutoGeneratedDomainNameLabelScope",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).AutoGeneratedDomainNameLabelScope, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaPlugin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaPlugin = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPlugins) content.GetValueForProperty("GrafanaPlugin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaPlugin, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesGrafanaPluginsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaMajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaMajorVersion = (string) content.GetValueForProperty("GrafanaMajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaMajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationSmtp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSmtp = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp) content.GetValueForProperty("GrafanaConfigurationSmtp",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSmtp, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SmtpTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSnapshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSnapshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots) content.GetValueForProperty("GrafanaConfigurationSnapshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSnapshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SnapshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUser = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers) content.GetValueForProperty("GrafanaConfigurationUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUser, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UsersTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSecurity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSecurity = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity) content.GetValueForProperty("GrafanaConfigurationSecurity",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSecurity, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaIntegrationAzureMonitorWorkspaceIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>) content.GetValueForProperty("GrafanaIntegrationAzureMonitorWorkspaceIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>(__y, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.AzureMonitorWorkspaceIntegrationTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnterpriseConfigurationMarketplacePlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplacePlanId = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplacePlanId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplacePlanId, global::System.Convert.ToString);
            }
            if (content.Contains("EnterpriseConfigurationMarketplaceAutoRenew"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplaceAutoRenew = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplaceAutoRenew",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplaceAutoRenew, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationUnifiedAlertingScreenshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots) content.GetValueForProperty("GrafanaConfigurationUnifiedAlertingScreenshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmtpEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpEnabled = (bool?) content.GetValueForProperty("SmtpEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SmtpHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpHost = (string) content.GetValueForProperty("SmtpHost",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpHost, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpUser = (string) content.GetValueForProperty("SmtpUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpUser, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpPassword = (System.Security.SecureString) content.GetValueForProperty("SmtpPassword",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SmtpFromAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromAddress = (string) content.GetValueForProperty("SmtpFromAddress",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpFromName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromName = (string) content.GetValueForProperty("SmtpFromName",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromName, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpStartTlsPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpStartTlsPolicy = (string) content.GetValueForProperty("SmtpStartTlsPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpStartTlsPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpSkipVerify"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpSkipVerify = (bool?) content.GetValueForProperty("SmtpSkipVerify",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpSkipVerify, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotExternalEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SnapshotExternalEnabled = (bool?) content.GetValueForProperty("SnapshotExternalEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SnapshotExternalEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserViewersCanEdit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserViewersCanEdit = (bool?) content.GetValueForProperty("UserViewersCanEdit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserViewersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserEditorsCanAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserEditorsCanAdmin = (bool?) content.GetValueForProperty("UserEditorsCanAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserEditorsCanAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityCsrfAlwaysCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SecurityCsrfAlwaysCheck = (bool?) content.GetValueForProperty("SecurityCsrfAlwaysCheck",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SecurityCsrfAlwaysCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UnifiedAlertingScreenshotCaptureEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UnifiedAlertingScreenshotCaptureEnabled = (bool?) content.GetValueForProperty("UnifiedAlertingScreenshotCaptureEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UnifiedAlertingScreenshotCaptureEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedGrafanaProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GrafanaIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaIntegrations) content.GetValueForProperty("GrafanaIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaIntegrationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnterpriseConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations) content.GetValueForProperty("EnterpriseConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations) content.GetValueForProperty("GrafanaConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaVersion = (string) content.GetValueForProperty("GrafanaVersion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Endpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).Endpoint, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("ZoneRedundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ZoneRedundancy = (string) content.GetValueForProperty("ZoneRedundancy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ZoneRedundancy, global::System.Convert.ToString);
            }
            if (content.Contains("ApiKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ApiKey = (string) content.GetValueForProperty("ApiKey",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).ApiKey, global::System.Convert.ToString);
            }
            if (content.Contains("DeterministicOutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).DeterministicOutboundIP = (string) content.GetValueForProperty("DeterministicOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).DeterministicOutboundIP, global::System.Convert.ToString);
            }
            if (content.Contains("OutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).OutboundIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("OutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).OutboundIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AutoGeneratedDomainNameLabelScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).AutoGeneratedDomainNameLabelScope = (string) content.GetValueForProperty("AutoGeneratedDomainNameLabelScope",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).AutoGeneratedDomainNameLabelScope, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaPlugin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaPlugin = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesGrafanaPlugins) content.GetValueForProperty("GrafanaPlugin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaPlugin, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesGrafanaPluginsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaMajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaMajorVersion = (string) content.GetValueForProperty("GrafanaMajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaMajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationSmtp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSmtp = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp) content.GetValueForProperty("GrafanaConfigurationSmtp",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSmtp, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SmtpTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSnapshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSnapshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots) content.GetValueForProperty("GrafanaConfigurationSnapshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSnapshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SnapshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUser = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers) content.GetValueForProperty("GrafanaConfigurationUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUser, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UsersTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSecurity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSecurity = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity) content.GetValueForProperty("GrafanaConfigurationSecurity",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationSecurity, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaIntegrationAzureMonitorWorkspaceIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>) content.GetValueForProperty("GrafanaIntegrationAzureMonitorWorkspaceIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>(__y, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.AzureMonitorWorkspaceIntegrationTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnterpriseConfigurationMarketplacePlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplacePlanId = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplacePlanId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplacePlanId, global::System.Convert.ToString);
            }
            if (content.Contains("EnterpriseConfigurationMarketplaceAutoRenew"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplaceAutoRenew = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplaceAutoRenew",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).EnterpriseConfigurationMarketplaceAutoRenew, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationUnifiedAlertingScreenshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots) content.GetValueForProperty("GrafanaConfigurationUnifiedAlertingScreenshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmtpEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpEnabled = (bool?) content.GetValueForProperty("SmtpEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SmtpHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpHost = (string) content.GetValueForProperty("SmtpHost",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpHost, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpUser = (string) content.GetValueForProperty("SmtpUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpUser, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpPassword = (System.Security.SecureString) content.GetValueForProperty("SmtpPassword",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SmtpFromAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromAddress = (string) content.GetValueForProperty("SmtpFromAddress",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpFromName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromName = (string) content.GetValueForProperty("SmtpFromName",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpFromName, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpStartTlsPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpStartTlsPolicy = (string) content.GetValueForProperty("SmtpStartTlsPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpStartTlsPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpSkipVerify"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpSkipVerify = (bool?) content.GetValueForProperty("SmtpSkipVerify",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SmtpSkipVerify, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotExternalEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SnapshotExternalEnabled = (bool?) content.GetValueForProperty("SnapshotExternalEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SnapshotExternalEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserViewersCanEdit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserViewersCanEdit = (bool?) content.GetValueForProperty("UserViewersCanEdit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserViewersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserEditorsCanAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserEditorsCanAdmin = (bool?) content.GetValueForProperty("UserEditorsCanAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UserEditorsCanAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityCsrfAlwaysCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SecurityCsrfAlwaysCheck = (bool?) content.GetValueForProperty("SecurityCsrfAlwaysCheck",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).SecurityCsrfAlwaysCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UnifiedAlertingScreenshotCaptureEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UnifiedAlertingScreenshotCaptureEnabled = (bool?) content.GetValueForProperty("UnifiedAlertingScreenshotCaptureEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesInternal)this).UnifiedAlertingScreenshotCaptureEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties specific to the grafana resource.
    [System.ComponentModel.TypeConverter(typeof(ManagedGrafanaPropertiesTypeConverter))]
    public partial interface IManagedGrafanaProperties

    {

    }
}