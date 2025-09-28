// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Vault extended information.</summary>
    [System.ComponentModel.TypeConverter(typeof(VaultExtendedInfoTypeConverter))]
    public partial class VaultExtendedInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VaultExtendedInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VaultExtendedInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VaultExtendedInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VaultExtendedInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VaultExtendedInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IntegrityKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).IntegrityKey = (string) content.GetValueForProperty("IntegrityKey",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).IntegrityKey, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKey = (string) content.GetValueForProperty("EncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKey, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionKeyThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKeyThumbprint = (string) content.GetValueForProperty("EncryptionKeyThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKeyThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("Algorithm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).Algorithm = (string) content.GetValueForProperty("Algorithm",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).Algorithm, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VaultExtendedInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IntegrityKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).IntegrityKey = (string) content.GetValueForProperty("IntegrityKey",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).IntegrityKey, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKey = (string) content.GetValueForProperty("EncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKey, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionKeyThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKeyThumbprint = (string) content.GetValueForProperty("EncryptionKeyThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).EncryptionKeyThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("Algorithm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).Algorithm = (string) content.GetValueForProperty("Algorithm",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)this).Algorithm, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Vault extended information.
    [System.ComponentModel.TypeConverter(typeof(VaultExtendedInfoTypeConverter))]
    public partial interface IVaultExtendedInfo

    {

    }
}