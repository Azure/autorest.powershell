// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;

    /// <summary>Server configurations of a Grafana instance</summary>
    [System.ComponentModel.TypeConverter(typeof(GrafanaConfigurationsTypeConverter))]
    public partial class GrafanaConfigurations
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurations"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GrafanaConfigurations(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurations"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GrafanaConfigurations(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GrafanaConfigurations" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="GrafanaConfigurations" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurations"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GrafanaConfigurations(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Smtp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Smtp = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp) content.GetValueForProperty("Smtp",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Smtp, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SmtpTypeConverter.ConvertFrom);
            }
            if (content.Contains("Snapshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Snapshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots) content.GetValueForProperty("Snapshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Snapshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SnapshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UsersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Security"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Security = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity) content.GetValueForProperty("Security",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Security, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("UnifiedAlertingScreenshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots) content.GetValueForProperty("UnifiedAlertingScreenshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmtpEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpEnabled = (bool?) content.GetValueForProperty("SmtpEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SmtpHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpHost = (string) content.GetValueForProperty("SmtpHost",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpHost, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpUser = (string) content.GetValueForProperty("SmtpUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpUser, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpPassword = (System.Security.SecureString) content.GetValueForProperty("SmtpPassword",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SmtpFromAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromAddress = (string) content.GetValueForProperty("SmtpFromAddress",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpFromName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromName = (string) content.GetValueForProperty("SmtpFromName",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromName, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpStartTlsPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpStartTlsPolicy = (string) content.GetValueForProperty("SmtpStartTlsPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpStartTlsPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpSkipVerify"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpSkipVerify = (bool?) content.GetValueForProperty("SmtpSkipVerify",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpSkipVerify, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotExternalEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SnapshotExternalEnabled = (bool?) content.GetValueForProperty("SnapshotExternalEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SnapshotExternalEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserViewersCanEdit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserViewersCanEdit = (bool?) content.GetValueForProperty("UserViewersCanEdit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserViewersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserEditorsCanAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserEditorsCanAdmin = (bool?) content.GetValueForProperty("UserEditorsCanAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserEditorsCanAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityCsrfAlwaysCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SecurityCsrfAlwaysCheck = (bool?) content.GetValueForProperty("SecurityCsrfAlwaysCheck",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SecurityCsrfAlwaysCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UnifiedAlertingScreenshotCaptureEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshotCaptureEnabled = (bool?) content.GetValueForProperty("UnifiedAlertingScreenshotCaptureEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshotCaptureEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.GrafanaConfigurations"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GrafanaConfigurations(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Smtp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Smtp = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp) content.GetValueForProperty("Smtp",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Smtp, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SmtpTypeConverter.ConvertFrom);
            }
            if (content.Contains("Snapshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Snapshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots) content.GetValueForProperty("Snapshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Snapshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SnapshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UsersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Security"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Security = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity) content.GetValueForProperty("Security",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).Security, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("UnifiedAlertingScreenshot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshot = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots) content.GetValueForProperty("UnifiedAlertingScreenshot",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshot, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshotsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmtpEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpEnabled = (bool?) content.GetValueForProperty("SmtpEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SmtpHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpHost = (string) content.GetValueForProperty("SmtpHost",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpHost, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpUser = (string) content.GetValueForProperty("SmtpUser",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpUser, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpPassword = (System.Security.SecureString) content.GetValueForProperty("SmtpPassword",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SmtpFromAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromAddress = (string) content.GetValueForProperty("SmtpFromAddress",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpFromName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromName = (string) content.GetValueForProperty("SmtpFromName",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpFromName, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpStartTlsPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpStartTlsPolicy = (string) content.GetValueForProperty("SmtpStartTlsPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpStartTlsPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SmtpSkipVerify"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpSkipVerify = (bool?) content.GetValueForProperty("SmtpSkipVerify",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SmtpSkipVerify, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotExternalEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SnapshotExternalEnabled = (bool?) content.GetValueForProperty("SnapshotExternalEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SnapshotExternalEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserViewersCanEdit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserViewersCanEdit = (bool?) content.GetValueForProperty("UserViewersCanEdit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserViewersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserEditorsCanAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserEditorsCanAdmin = (bool?) content.GetValueForProperty("UserEditorsCanAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UserEditorsCanAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityCsrfAlwaysCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SecurityCsrfAlwaysCheck = (bool?) content.GetValueForProperty("SecurityCsrfAlwaysCheck",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).SecurityCsrfAlwaysCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UnifiedAlertingScreenshotCaptureEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshotCaptureEnabled = (bool?) content.GetValueForProperty("UnifiedAlertingScreenshotCaptureEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal)this).UnifiedAlertingScreenshotCaptureEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
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
    /// Server configurations of a Grafana instance
    [System.ComponentModel.TypeConverter(typeof(GrafanaConfigurationsTypeConverter))]
    public partial interface IGrafanaConfigurations

    {

    }
}