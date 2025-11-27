// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.PowerShell;

    /// <summary>Properties of the secret</summary>
    [System.ComponentModel.TypeConverter(typeof(SecretPatchPropertiesTypeConverter))]
    public partial class SecretPatchProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecretPatchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecretPatchProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecretPatchProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecretPatchProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecretPatchProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("AttributeEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeEnabled = (bool?) content.GetValueForProperty("AttributeEnabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AttributeNotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeNotBefore = (global::System.DateTime?) content.GetValueForProperty("AttributeNotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeNotBefore, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeExpire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeExpire = (global::System.DateTime?) content.GetValueForProperty("AttributeExpire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeExpire, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeCreated = (global::System.DateTime?) content.GetValueForProperty("AttributeCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeCreated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeUpdated = (global::System.DateTime?) content.GetValueForProperty("AttributeUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeUpdated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecretPatchProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("AttributeEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeEnabled = (bool?) content.GetValueForProperty("AttributeEnabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AttributeNotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeNotBefore = (global::System.DateTime?) content.GetValueForProperty("AttributeNotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeNotBefore, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeExpire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeExpire = (global::System.DateTime?) content.GetValueForProperty("AttributeExpire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeExpire, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeCreated = (global::System.DateTime?) content.GetValueForProperty("AttributeCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeCreated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeUpdated = (global::System.DateTime?) content.GetValueForProperty("AttributeUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)this).AttributeUpdated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the secret
    [System.ComponentModel.TypeConverter(typeof(SecretPatchPropertiesTypeConverter))]
    public partial interface ISecretPatchProperties

    {

    }
}