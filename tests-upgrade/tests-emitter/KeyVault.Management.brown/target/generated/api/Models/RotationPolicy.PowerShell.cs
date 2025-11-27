// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.PowerShell;

    /// <summary>
    /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(RotationPolicyTypeConverter))]
    public partial class RotationPolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.RotationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RotationPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.RotationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RotationPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RotationPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RotationPolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.RotationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RotationPolicy(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyRotationPolicyAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LifetimeAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).LifetimeAction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>) content.GetValueForProperty("LifetimeAction",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).LifetimeAction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>(__y, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.LifetimeActionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AttributeUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeUpdated = (long?) content.GetValueForProperty("AttributeUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeUpdated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeCreated = (long?) content.GetValueForProperty("AttributeCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeCreated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeExpiryTime = (string) content.GetValueForProperty("AttributeExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeExpiryTime, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.RotationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RotationPolicy(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyRotationPolicyAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LifetimeAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).LifetimeAction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>) content.GetValueForProperty("LifetimeAction",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).LifetimeAction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>(__y, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.LifetimeActionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AttributeUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeUpdated = (long?) content.GetValueForProperty("AttributeUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeUpdated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeCreated = (long?) content.GetValueForProperty("AttributeCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeCreated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeExpiryTime = (string) content.GetValueForProperty("AttributeExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal)this).AttributeExpiryTime, global::System.Convert.ToString);
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
    /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
    [System.ComponentModel.TypeConverter(typeof(RotationPolicyTypeConverter))]
    public partial interface IRotationPolicy

    {

    }
}