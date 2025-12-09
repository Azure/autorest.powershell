// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Simple policy retention.</summary>
    [System.ComponentModel.TypeConverter(typeof(SimpleRetentionPolicyTypeConverter))]
    public partial class SimpleRetentionPolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SimpleRetentionPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SimpleRetentionPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleRetentionPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SimpleRetentionPolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SimpleRetentionPolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("RetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationCount = (int?) content.GetValueForProperty("RetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationType = (string) content.GetValueForProperty("RetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SimpleRetentionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SimpleRetentionPolicy(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDuration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration) content.GetValueForProperty("RetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDuration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionDurationCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationCount = (int?) content.GetValueForProperty("RetentionDurationCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RetentionDurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationType = (string) content.GetValueForProperty("RetentionDurationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal)this).RetentionDurationType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Simple policy retention.
    [System.ComponentModel.TypeConverter(typeof(SimpleRetentionPolicyTypeConverter))]
    public partial interface ISimpleRetentionPolicy

    {

    }
}