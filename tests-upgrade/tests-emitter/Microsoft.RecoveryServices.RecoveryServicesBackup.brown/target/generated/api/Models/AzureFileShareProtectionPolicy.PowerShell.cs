// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>AzureStorage backup policy.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureFileShareProtectionPolicyTypeConverter))]
    public partial class AzureFileShareProtectionPolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureFileShareProtectionPolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SchedulePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy) content.GetValueForProperty("SchedulePolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy) content.GetValueForProperty("RetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("VaultRetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultRetentionPolicy) content.GetValueForProperty("VaultRetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.VaultRetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("WorkLoadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).WorkLoadType = (string) content.GetValueForProperty("WorkLoadType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).WorkLoadType, global::System.Convert.ToString);
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectedItemsCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ProtectedItemsCount = (int?) content.GetValueForProperty("ProtectedItemsCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ProtectedItemsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SchedulePolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicyType = (string) content.GetValueForProperty("SchedulePolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicyType = (string) content.GetValueForProperty("RetentionPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("VaultRetentionPolicyVaultRetention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyVaultRetention = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy) content.GetValueForProperty("VaultRetentionPolicyVaultRetention",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyVaultRetention, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("VaultRetentionPolicySnapshotRetentionInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicySnapshotRetentionInDay = (int?) content.GetValueForProperty("VaultRetentionPolicySnapshotRetentionInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicySnapshotRetentionInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VaultRetentionPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyType = (string) content.GetValueForProperty("VaultRetentionPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureFileShareProtectionPolicy(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SchedulePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy) content.GetValueForProperty("SchedulePolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy) content.GetValueForProperty("RetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("VaultRetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultRetentionPolicy) content.GetValueForProperty("VaultRetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.VaultRetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("WorkLoadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).WorkLoadType = (string) content.GetValueForProperty("WorkLoadType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).WorkLoadType, global::System.Convert.ToString);
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectedItemsCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ProtectedItemsCount = (int?) content.GetValueForProperty("ProtectedItemsCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ProtectedItemsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SchedulePolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicyType = (string) content.GetValueForProperty("SchedulePolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).SchedulePolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicyType = (string) content.GetValueForProperty("RetentionPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).RetentionPolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("VaultRetentionPolicyVaultRetention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyVaultRetention = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy) content.GetValueForProperty("VaultRetentionPolicyVaultRetention",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyVaultRetention, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("VaultRetentionPolicySnapshotRetentionInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicySnapshotRetentionInDay = (int?) content.GetValueForProperty("VaultRetentionPolicySnapshotRetentionInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicySnapshotRetentionInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VaultRetentionPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyType = (string) content.GetValueForProperty("VaultRetentionPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicyInternal)this).VaultRetentionPolicyType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicy"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureFileShareProtectionPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureFileShareProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicy"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureFileShareProtectionPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureFileShareProtectionPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureFileShareProtectionPolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareProtectionPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// AzureStorage backup policy.
    [System.ComponentModel.TypeConverter(typeof(AzureFileShareProtectionPolicyTypeConverter))]
    public partial interface IAzureFileShareProtectionPolicy

    {

    }
}