// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;

    /// <summary>The properties parameters for a PATCH request to a grafana resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedGrafanaPropertiesUpdateParametersTypeConverter))]
    public partial class ManagedGrafanaPropertiesUpdateParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedGrafanaPropertiesUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedGrafanaPropertiesUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedGrafanaPropertiesUpdateParameters" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ManagedGrafanaPropertiesUpdateParameters" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedGrafanaPropertiesUpdateParameters(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaIntegrations) content.GetValueForProperty("GrafanaIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaIntegrationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnterpriseConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations) content.GetValueForProperty("EnterpriseConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations) content.GetValueForProperty("GrafanaConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ZoneRedundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ZoneRedundancy = (string) content.GetValueForProperty("ZoneRedundancy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ZoneRedundancy, global::System.Convert.ToString);
            }
            if (content.Contains("ApiKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ApiKey = (string) content.GetValueForProperty("ApiKey",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ApiKey, global::System.Convert.ToString);
            }
            if (content.Contains("DeterministicOutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).DeterministicOutboundIP = (string) content.GetValueForProperty("DeterministicOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).DeterministicOutboundIP, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaPlugin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaPlugin = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins) content.GetValueForProperty("GrafanaPlugin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaPlugin, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParametersGrafanaPluginsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaMajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaMajorVersion = (string) content.GetValueForProperty("GrafanaMajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaMajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationSmtp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSmtp = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp) content.GetValueForProperty("GrafanaConfigurationSmtp",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSmtp, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SmtpTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSnapshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSnapshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots) content.GetValueForProperty("GrafanaConfigurationSnapshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSnapshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SnapshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUser = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers) content.GetValueForProperty("GrafanaConfigurationUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUser, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UsersTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSecurity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSecurity = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity) content.GetValueForProperty("GrafanaConfigurationSecurity",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSecurity, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaIntegrationAzureMonitorWorkspaceIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>) content.GetValueForProperty("GrafanaIntegrationAzureMonitorWorkspaceIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>(__y, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.AzureMonitorWorkspaceIntegrationTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnterpriseConfigurationMarketplacePlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplacePlanId = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplacePlanId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplacePlanId, global::System.Convert.ToString);
            }
            if (content.Contains("EnterpriseConfigurationMarketplaceAutoRenew"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplaceAutoRenew = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplaceAutoRenew",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplaceAutoRenew, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationUnifiedAlertingScreenshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots) content.GetValueForProperty("GrafanaConfigurationUnifiedAlertingScreenshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmtpEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpEnabled = (bool?) content.GetValueForProperty("SmtpEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SmtpHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpHost = (string) content.GetValueForProperty("SmtpHost",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpHost, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpUser = (string) content.GetValueForProperty("SmtpUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpUser, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpPassword = (System.Security.SecureString) content.GetValueForProperty("SmtpPassword",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SmtpFromAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromAddress = (string) content.GetValueForProperty("SmtpFromAddress",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpFromName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromName = (string) content.GetValueForProperty("SmtpFromName",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromName, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpStartTlsPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpStartTlsPolicy = (string) content.GetValueForProperty("SmtpStartTlsPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpStartTlsPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpSkipVerify"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpSkipVerify = (bool?) content.GetValueForProperty("SmtpSkipVerify",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpSkipVerify, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotExternalEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SnapshotExternalEnabled = (bool?) content.GetValueForProperty("SnapshotExternalEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SnapshotExternalEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserViewersCanEdit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserViewersCanEdit = (bool?) content.GetValueForProperty("UserViewersCanEdit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserViewersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserEditorsCanAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserEditorsCanAdmin = (bool?) content.GetValueForProperty("UserEditorsCanAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserEditorsCanAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityCsrfAlwaysCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SecurityCsrfAlwaysCheck = (bool?) content.GetValueForProperty("SecurityCsrfAlwaysCheck",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SecurityCsrfAlwaysCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UnifiedAlertingScreenshotCaptureEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UnifiedAlertingScreenshotCaptureEnabled = (bool?) content.GetValueForProperty("UnifiedAlertingScreenshotCaptureEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UnifiedAlertingScreenshotCaptureEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedGrafanaPropertiesUpdateParameters(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaIntegrations) content.GetValueForProperty("GrafanaIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaIntegrationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnterpriseConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations) content.GetValueForProperty("EnterpriseConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations) content.GetValueForProperty("GrafanaConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurationsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ZoneRedundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ZoneRedundancy = (string) content.GetValueForProperty("ZoneRedundancy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ZoneRedundancy, global::System.Convert.ToString);
            }
            if (content.Contains("ApiKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ApiKey = (string) content.GetValueForProperty("ApiKey",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).ApiKey, global::System.Convert.ToString);
            }
            if (content.Contains("DeterministicOutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).DeterministicOutboundIP = (string) content.GetValueForProperty("DeterministicOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).DeterministicOutboundIP, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaPlugin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaPlugin = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersGrafanaPlugins) content.GetValueForProperty("GrafanaPlugin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaPlugin, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedGrafanaPropertiesUpdateParametersGrafanaPluginsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaMajorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaMajorVersion = (string) content.GetValueForProperty("GrafanaMajorVersion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaMajorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationSmtp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSmtp = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp) content.GetValueForProperty("GrafanaConfigurationSmtp",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSmtp, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SmtpTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSnapshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSnapshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots) content.GetValueForProperty("GrafanaConfigurationSnapshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSnapshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SnapshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUser = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers) content.GetValueForProperty("GrafanaConfigurationUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUser, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UsersTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaConfigurationSecurity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSecurity = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity) content.GetValueForProperty("GrafanaConfigurationSecurity",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationSecurity, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("GrafanaIntegrationAzureMonitorWorkspaceIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>) content.GetValueForProperty("GrafanaIntegrationAzureMonitorWorkspaceIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaIntegrationAzureMonitorWorkspaceIntegration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration>(__y, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.AzureMonitorWorkspaceIntegrationTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnterpriseConfigurationMarketplacePlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplacePlanId = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplacePlanId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplacePlanId, global::System.Convert.ToString);
            }
            if (content.Contains("EnterpriseConfigurationMarketplaceAutoRenew"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplaceAutoRenew = (string) content.GetValueForProperty("EnterpriseConfigurationMarketplaceAutoRenew",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).EnterpriseConfigurationMarketplaceAutoRenew, global::System.Convert.ToString);
            }
            if (content.Contains("GrafanaConfigurationUnifiedAlertingScreenshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots) content.GetValueForProperty("GrafanaConfigurationUnifiedAlertingScreenshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).GrafanaConfigurationUnifiedAlertingScreenshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmtpEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpEnabled = (bool?) content.GetValueForProperty("SmtpEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SmtpHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpHost = (string) content.GetValueForProperty("SmtpHost",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpHost, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpUser = (string) content.GetValueForProperty("SmtpUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpUser, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpPassword = (System.Security.SecureString) content.GetValueForProperty("SmtpPassword",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SmtpFromAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromAddress = (string) content.GetValueForProperty("SmtpFromAddress",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpFromName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromName = (string) content.GetValueForProperty("SmtpFromName",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpFromName, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpStartTlsPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpStartTlsPolicy = (string) content.GetValueForProperty("SmtpStartTlsPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpStartTlsPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpSkipVerify"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpSkipVerify = (bool?) content.GetValueForProperty("SmtpSkipVerify",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SmtpSkipVerify, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotExternalEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SnapshotExternalEnabled = (bool?) content.GetValueForProperty("SnapshotExternalEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SnapshotExternalEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserViewersCanEdit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserViewersCanEdit = (bool?) content.GetValueForProperty("UserViewersCanEdit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserViewersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserEditorsCanAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserEditorsCanAdmin = (bool?) content.GetValueForProperty("UserEditorsCanAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UserEditorsCanAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityCsrfAlwaysCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SecurityCsrfAlwaysCheck = (bool?) content.GetValueForProperty("SecurityCsrfAlwaysCheck",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).SecurityCsrfAlwaysCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UnifiedAlertingScreenshotCaptureEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UnifiedAlertingScreenshotCaptureEnabled = (bool?) content.GetValueForProperty("UnifiedAlertingScreenshotCaptureEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaPropertiesUpdateParametersInternal)this).UnifiedAlertingScreenshotCaptureEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
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
    /// The properties parameters for a PATCH request to a grafana resource.
    [System.ComponentModel.TypeConverter(typeof(ManagedGrafanaPropertiesUpdateParametersTypeConverter))]
    public partial interface IManagedGrafanaPropertiesUpdateParameters

    {

    }
}