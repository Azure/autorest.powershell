// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.PowerShell;

    /// <summary>The object attributes managed by the Azure Key Vault service.</summary>
    [System.ComponentModel.TypeConverter(typeof(KeyAttributesTypeConverter))]
    public partial class KeyAttributes
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new KeyAttributes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new KeyAttributes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="KeyAttributes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="KeyAttributes" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal KeyAttributes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).NotBefore = (long?) content.GetValueForProperty("NotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).NotBefore, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Expire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Expire = (long?) content.GetValueForProperty("Expire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Expire, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Created"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Created = (long?) content.GetValueForProperty("Created",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Created, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Updated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Updated = (long?) content.GetValueForProperty("Updated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Updated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).RecoveryLevel = (string) content.GetValueForProperty("RecoveryLevel",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).RecoveryLevel, global::System.Convert.ToString);
            }
            if (content.Contains("Exportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Exportable = (bool?) content.GetValueForProperty("Exportable",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Exportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal KeyAttributes(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).NotBefore = (long?) content.GetValueForProperty("NotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).NotBefore, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Expire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Expire = (long?) content.GetValueForProperty("Expire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Expire, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Created"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Created = (long?) content.GetValueForProperty("Created",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Created, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Updated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Updated = (long?) content.GetValueForProperty("Updated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Updated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).RecoveryLevel = (string) content.GetValueForProperty("RecoveryLevel",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).RecoveryLevel, global::System.Convert.ToString);
            }
            if (content.Contains("Exportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Exportable = (bool?) content.GetValueForProperty("Exportable",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal)this).Exportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
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
    /// The object attributes managed by the Azure Key Vault service.
    [System.ComponentModel.TypeConverter(typeof(KeyAttributesTypeConverter))]
    public partial interface IKeyAttributes

    {

    }
}