// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Usages of a vault.</summary>
    [System.ComponentModel.TypeConverter(typeof(VaultUsageTypeConverter))]
    public partial class VaultUsage
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsage" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsage DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VaultUsage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsage" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsage DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VaultUsage(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VaultUsage" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VaultUsage" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsage FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VaultUsage(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.INameInfo) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.NameInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("QuotaPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).QuotaPeriod = (string) content.GetValueForProperty("QuotaPeriod",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).QuotaPeriod, global::System.Convert.ToString);
            }
            if (content.Contains("NextResetTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NextResetTime = (global::System.DateTime?) content.GetValueForProperty("NextResetTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NextResetTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).CurrentValue = (long?) content.GetValueForProperty("CurrentValue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).CurrentValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Limit = (long?) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Limit, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VaultUsage(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.INameInfo) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.NameInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("QuotaPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).QuotaPeriod = (string) content.GetValueForProperty("QuotaPeriod",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).QuotaPeriod, global::System.Convert.ToString);
            }
            if (content.Contains("NextResetTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NextResetTime = (global::System.DateTime?) content.GetValueForProperty("NextResetTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NextResetTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).CurrentValue = (long?) content.GetValueForProperty("CurrentValue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).CurrentValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Limit = (long?) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).Limit, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultUsageInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Usages of a vault.
    [System.ComponentModel.TypeConverter(typeof(VaultUsageTypeConverter))]
    public partial interface IVaultUsage

    {

    }
}