// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Azure workload specific protection intent item.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureWorkloadContainerAutoProtectionIntentTypeConverter))]
    public partial class AzureWorkloadContainerAutoProtectionIntent
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadContainerAutoProtectionIntent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureWorkloadContainerAutoProtectionIntent(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ItemType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemType = (string) content.GetValueForProperty("ItemType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemType, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ItemId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemId = (string) content.GetValueForProperty("ItemId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadContainerAutoProtectionIntent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureWorkloadContainerAutoProtectionIntent(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ItemType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemType = (string) content.GetValueForProperty("ItemType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemType, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ItemId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemId = (string) content.GetValueForProperty("ItemId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ItemId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionIntentInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadContainerAutoProtectionIntent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerAutoProtectionIntent"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerAutoProtectionIntent DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureWorkloadContainerAutoProtectionIntent(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadContainerAutoProtectionIntent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerAutoProtectionIntent"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerAutoProtectionIntent DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureWorkloadContainerAutoProtectionIntent(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureWorkloadContainerAutoProtectionIntent" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureWorkloadContainerAutoProtectionIntent" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadContainerAutoProtectionIntent FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Azure workload specific protection intent item.
    [System.ComponentModel.TypeConverter(typeof(AzureWorkloadContainerAutoProtectionIntentTypeConverter))]
    public partial interface IAzureWorkloadContainerAutoProtectionIntent

    {

    }
}