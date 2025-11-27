// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.PowerShell;

    /// <summary>Parameters for creating or updating a secret</summary>
    [System.ComponentModel.TypeConverter(typeof(SecretCreateOrUpdateParametersTypeConverter))]
    public partial class SecretCreateOrUpdateParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecretCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecretCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecretCreateOrUpdateParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecretCreateOrUpdateParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecretCreateOrUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParametersTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("SecretUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUri = (string) content.GetValueForProperty("SecretUri",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUri, global::System.Convert.ToString);
            }
            if (content.Contains("SecretUriWithVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUriWithVersion = (string) content.GetValueForProperty("SecretUriWithVersion",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUriWithVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AttributeEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeEnabled = (bool?) content.GetValueForProperty("AttributeEnabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AttributeNotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeNotBefore = (global::System.DateTime?) content.GetValueForProperty("AttributeNotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeNotBefore, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeExpire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeExpire = (global::System.DateTime?) content.GetValueForProperty("AttributeExpire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeExpire, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeCreated = (global::System.DateTime?) content.GetValueForProperty("AttributeCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeCreated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeUpdated = (global::System.DateTime?) content.GetValueForProperty("AttributeUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeUpdated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecretCreateOrUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParametersTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("ContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).ContentType = (string) content.GetValueForProperty("ContentType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).ContentType, global::System.Convert.ToString);
            }
            if (content.Contains("SecretUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUri = (string) content.GetValueForProperty("SecretUri",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUri, global::System.Convert.ToString);
            }
            if (content.Contains("SecretUriWithVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUriWithVersion = (string) content.GetValueForProperty("SecretUriWithVersion",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).SecretUriWithVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AttributeEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeEnabled = (bool?) content.GetValueForProperty("AttributeEnabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AttributeNotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeNotBefore = (global::System.DateTime?) content.GetValueForProperty("AttributeNotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeNotBefore, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeExpire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeExpire = (global::System.DateTime?) content.GetValueForProperty("AttributeExpire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeExpire, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeCreated = (global::System.DateTime?) content.GetValueForProperty("AttributeCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeCreated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
            }
            if (content.Contains("AttributeUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeUpdated = (global::System.DateTime?) content.GetValueForProperty("AttributeUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal)this).AttributeUpdated, (__y)=> (global::System.DateTime) global::System.Convert.ChangeType(__y, typeof(global::System.DateTime)));
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
    /// Parameters for creating or updating a secret
    [System.ComponentModel.TypeConverter(typeof(SecretCreateOrUpdateParametersTypeConverter))]
    public partial interface ISecretCreateOrUpdateParameters

    {

    }
}