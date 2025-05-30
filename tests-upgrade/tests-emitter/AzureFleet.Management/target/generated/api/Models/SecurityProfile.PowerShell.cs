// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>
    /// Specifies the Security profile settings for the virtual machine or virtual
    /// machine scale set.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(SecurityProfileTypeConverter))]
    public partial class SecurityProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecurityProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecurityProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecurityProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecurityProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecurityProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UefiSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings) content.GetValueForProperty("UefiSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.UefiSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity) content.GetValueForProperty("EncryptionIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentity, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.EncryptionIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProxyAgentSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings) content.GetValueForProperty("ProxyAgentSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ProxyAgentSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionAtHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionAtHost = (bool?) content.GetValueForProperty("EncryptionAtHost",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionAtHost, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).SecurityType = (string) content.GetValueForProperty("SecurityType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).SecurityType, global::System.Convert.ToString);
            }
            if (content.Contains("ProxyAgentSettingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingMode = (string) content.GetValueForProperty("ProxyAgentSettingMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingMode, global::System.Convert.ToString);
            }
            if (content.Contains("UefiSettingSecureBootEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingSecureBootEnabled = (bool?) content.GetValueForProperty("UefiSettingSecureBootEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingSecureBootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UefiSettingVTpmEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingVTpmEnabled = (bool?) content.GetValueForProperty("UefiSettingVTpmEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingVTpmEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionIdentityUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentityUserAssignedIdentityResourceId = (string) content.GetValueForProperty("EncryptionIdentityUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentityUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ProxyAgentSettingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingEnabled = (bool?) content.GetValueForProperty("ProxyAgentSettingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProxyAgentSettingKeyIncarnationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingKeyIncarnationId = (int?) content.GetValueForProperty("ProxyAgentSettingKeyIncarnationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingKeyIncarnationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecurityProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UefiSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings) content.GetValueForProperty("UefiSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.UefiSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity) content.GetValueForProperty("EncryptionIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentity, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.EncryptionIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProxyAgentSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings) content.GetValueForProperty("ProxyAgentSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ProxyAgentSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionAtHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionAtHost = (bool?) content.GetValueForProperty("EncryptionAtHost",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionAtHost, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SecurityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).SecurityType = (string) content.GetValueForProperty("SecurityType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).SecurityType, global::System.Convert.ToString);
            }
            if (content.Contains("ProxyAgentSettingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingMode = (string) content.GetValueForProperty("ProxyAgentSettingMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingMode, global::System.Convert.ToString);
            }
            if (content.Contains("UefiSettingSecureBootEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingSecureBootEnabled = (bool?) content.GetValueForProperty("UefiSettingSecureBootEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingSecureBootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UefiSettingVTpmEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingVTpmEnabled = (bool?) content.GetValueForProperty("UefiSettingVTpmEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).UefiSettingVTpmEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionIdentityUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentityUserAssignedIdentityResourceId = (string) content.GetValueForProperty("EncryptionIdentityUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).EncryptionIdentityUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ProxyAgentSettingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingEnabled = (bool?) content.GetValueForProperty("ProxyAgentSettingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProxyAgentSettingKeyIncarnationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingKeyIncarnationId = (int?) content.GetValueForProperty("ProxyAgentSettingKeyIncarnationId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal)this).ProxyAgentSettingKeyIncarnationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Specifies the Security profile settings for the virtual machine or virtual
    /// machine scale set.
    [System.ComponentModel.TypeConverter(typeof(SecurityProfileTypeConverter))]
    public partial interface ISecurityProfile

    {

    }
}