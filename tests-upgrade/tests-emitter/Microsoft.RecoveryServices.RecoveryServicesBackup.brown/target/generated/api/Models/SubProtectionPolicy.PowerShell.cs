// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Sub-protection policy which includes schedule and retention</summary>
    [System.ComponentModel.TypeConverter(typeof(SubProtectionPolicyTypeConverter))]
    public partial class SubProtectionPolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SubProtectionPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SubProtectionPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SubProtectionPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SubProtectionPolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SubProtectionPolicy(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy) content.GetValueForProperty("SchedulePolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy) content.GetValueForProperty("RetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotBackupAdditionalDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails) content.GetValueForProperty("SnapshotBackupAdditionalDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotBackupAdditionalDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).PolicyType = (string) content.GetValueForProperty("PolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).PolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("TieringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).TieringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy) content.GetValueForProperty("TieringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).TieringPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicyTieringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SchedulePolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicyType = (string) content.GetValueForProperty("SchedulePolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicyType = (string) content.GetValueForProperty("RetentionPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails) content.GetValueForProperty("SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay = (int?) content.GetValueForProperty("SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SnapshotBackupAdditionalDetailInstantRpDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpDetail = (string) content.GetValueForProperty("SnapshotBackupAdditionalDetailInstantRpDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpDetail, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties) content.GetValueForProperty("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedIdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityArmId = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityArmId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityName = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityName, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyClientId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyClientId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyClientId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyPrincipalId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyPrincipalId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SubProtectionPolicy(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy) content.GetValueForProperty("SchedulePolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetentionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy) content.GetValueForProperty("RetentionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotBackupAdditionalDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails) content.GetValueForProperty("SnapshotBackupAdditionalDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotBackupAdditionalDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).PolicyType = (string) content.GetValueForProperty("PolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).PolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("TieringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).TieringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy) content.GetValueForProperty("TieringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).TieringPolicy, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicyTieringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SchedulePolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicyType = (string) content.GetValueForProperty("SchedulePolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SchedulePolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionPolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicyType = (string) content.GetValueForProperty("RetentionPolicyType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).RetentionPolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails) content.GetValueForProperty("SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay = (int?) content.GetValueForProperty("SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SnapshotBackupAdditionalDetailInstantRpDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpDetail = (string) content.GetValueForProperty("SnapshotBackupAdditionalDetailInstantRpDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).SnapshotBackupAdditionalDetailInstantRpDetail, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties) content.GetValueForProperty("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedIdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityArmId = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityArmId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityName = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedManagedIdentityDetailIdentityName, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyClientId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyClientId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyClientId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyPrincipalId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal)this).UserAssignedIdentityPropertyPrincipalId, global::System.Convert.ToString);
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
    /// Sub-protection policy which includes schedule and retention
    [System.ComponentModel.TypeConverter(typeof(SubProtectionPolicyTypeConverter))]
    public partial interface ISubProtectionPolicy

    {

    }
}