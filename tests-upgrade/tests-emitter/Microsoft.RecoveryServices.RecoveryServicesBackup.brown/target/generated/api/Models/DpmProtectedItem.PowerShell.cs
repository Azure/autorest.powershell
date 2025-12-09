// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Additional information on Backup engine specific backup item.</summary>
    [System.ComponentModel.TypeConverter(typeof(DpmProtectedItemTypeConverter))]
    public partial class DpmProtectedItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItem" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DpmProtectedItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItem" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItem DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DpmProtectedItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DpmProtectedItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEngineName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).BackupEngineName = (string) content.GetValueForProperty("BackupEngineName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).BackupEngineName, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).WorkloadType = (string) content.GetValueForProperty("WorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).WorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ContainerName = (string) content.GetValueForProperty("ContainerName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ContainerName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("LastRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).LastRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("LastRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).LastRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BackupSetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupSetName = (string) content.GetValueForProperty("BackupSetName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupSetName, global::System.Convert.ToString);
            }
            if (content.Contains("CreateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).CreateMode = (string) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).CreateMode, global::System.Convert.ToString);
            }
            if (content.Contains("DeferredDeleteTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("DeferredDeleteTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("IsScheduledForDeferredDelete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsScheduledForDeferredDelete = (bool?) content.GetValueForProperty("IsScheduledForDeferredDelete",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsScheduledForDeferredDelete, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DeferredDeleteTimeRemaining"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeRemaining = (string) content.GetValueForProperty("DeferredDeleteTimeRemaining",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeRemaining, global::System.Convert.ToString);
            }
            if (content.Contains("IsDeferredDeleteScheduleUpcoming"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsDeferredDeleteScheduleUpcoming = (bool?) content.GetValueForProperty("IsDeferredDeleteScheduleUpcoming",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsDeferredDeleteScheduleUpcoming, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsRehydrate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsRehydrate = (bool?) content.GetValueForProperty("IsRehydrate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsRehydrate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsArchiveEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsArchiveEnabled = (bool?) content.GetValueForProperty("IsArchiveEnabled",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsArchiveEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteRetentionPeriodInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SoftDeleteRetentionPeriodInDay = (int?) content.GetValueForProperty("SoftDeleteRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SoftDeleteRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).VaultId = (string) content.GetValueForProperty("VaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).VaultId, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoProtectableObjectLoadPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectableObjectLoadPath = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoProtectableObjectLoadPath) content.GetValueForProperty("ExtendedInfoProtectableObjectLoadPath",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectableObjectLoadPath, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfoProtectableObjectLoadPathTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedInfoProtected"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtected = (bool?) content.GetValueForProperty("ExtendedInfoProtected",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtected, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoIsPresentOnCloud"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsPresentOnCloud = (bool?) content.GetValueForProperty("ExtendedInfoIsPresentOnCloud",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsPresentOnCloud, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoLastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastBackupStatus = (string) content.GetValueForProperty("ExtendedInfoLastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoLastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoLastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoOldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoOldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoRecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoRecoveryPointCount = (int?) content.GetValueForProperty("ExtendedInfoRecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoRecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoOnPremiseOldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseOldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoOnPremiseOldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseOldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoOnPremiseLatestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseLatestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoOnPremiseLatestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseLatestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoOnPremiseRecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseRecoveryPointCount = (int?) content.GetValueForProperty("ExtendedInfoOnPremiseRecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseRecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoIsCollocated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsCollocated = (bool?) content.GetValueForProperty("ExtendedInfoIsCollocated",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsCollocated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoProtectionGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectionGroupName = (string) content.GetValueForProperty("ExtendedInfoProtectionGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectionGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoDiskStorageUsedInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoDiskStorageUsedInByte = (string) content.GetValueForProperty("ExtendedInfoDiskStorageUsedInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoDiskStorageUsedInByte, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoTotalDiskStorageSizeInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoTotalDiskStorageSizeInByte = (string) content.GetValueForProperty("ExtendedInfoTotalDiskStorageSizeInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoTotalDiskStorageSizeInByte, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DpmProtectedItem(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEngineName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).BackupEngineName = (string) content.GetValueForProperty("BackupEngineName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).BackupEngineName, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).WorkloadType = (string) content.GetValueForProperty("WorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).WorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ContainerName = (string) content.GetValueForProperty("ContainerName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ContainerName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("LastRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).LastRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("LastRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).LastRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BackupSetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupSetName = (string) content.GetValueForProperty("BackupSetName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).BackupSetName, global::System.Convert.ToString);
            }
            if (content.Contains("CreateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).CreateMode = (string) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).CreateMode, global::System.Convert.ToString);
            }
            if (content.Contains("DeferredDeleteTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("DeferredDeleteTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("IsScheduledForDeferredDelete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsScheduledForDeferredDelete = (bool?) content.GetValueForProperty("IsScheduledForDeferredDelete",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsScheduledForDeferredDelete, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DeferredDeleteTimeRemaining"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeRemaining = (string) content.GetValueForProperty("DeferredDeleteTimeRemaining",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).DeferredDeleteTimeRemaining, global::System.Convert.ToString);
            }
            if (content.Contains("IsDeferredDeleteScheduleUpcoming"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsDeferredDeleteScheduleUpcoming = (bool?) content.GetValueForProperty("IsDeferredDeleteScheduleUpcoming",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsDeferredDeleteScheduleUpcoming, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsRehydrate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsRehydrate = (bool?) content.GetValueForProperty("IsRehydrate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsRehydrate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsArchiveEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsArchiveEnabled = (bool?) content.GetValueForProperty("IsArchiveEnabled",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).IsArchiveEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteRetentionPeriodInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SoftDeleteRetentionPeriodInDay = (int?) content.GetValueForProperty("SoftDeleteRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).SoftDeleteRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).VaultId = (string) content.GetValueForProperty("VaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectedItemInternal)this).VaultId, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoProtectableObjectLoadPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectableObjectLoadPath = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoProtectableObjectLoadPath) content.GetValueForProperty("ExtendedInfoProtectableObjectLoadPath",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectableObjectLoadPath, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfoProtectableObjectLoadPathTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedInfoProtected"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtected = (bool?) content.GetValueForProperty("ExtendedInfoProtected",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtected, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoIsPresentOnCloud"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsPresentOnCloud = (bool?) content.GetValueForProperty("ExtendedInfoIsPresentOnCloud",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsPresentOnCloud, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoLastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastBackupStatus = (string) content.GetValueForProperty("ExtendedInfoLastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoLastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoLastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoLastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoOldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoOldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoRecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoRecoveryPointCount = (int?) content.GetValueForProperty("ExtendedInfoRecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoRecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoOnPremiseOldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseOldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoOnPremiseOldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseOldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoOnPremiseLatestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseLatestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoOnPremiseLatestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseLatestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoOnPremiseRecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseRecoveryPointCount = (int?) content.GetValueForProperty("ExtendedInfoOnPremiseRecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoOnPremiseRecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoIsCollocated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsCollocated = (bool?) content.GetValueForProperty("ExtendedInfoIsCollocated",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoIsCollocated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoProtectionGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectionGroupName = (string) content.GetValueForProperty("ExtendedInfoProtectionGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoProtectionGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoDiskStorageUsedInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoDiskStorageUsedInByte = (string) content.GetValueForProperty("ExtendedInfoDiskStorageUsedInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoDiskStorageUsedInByte, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoTotalDiskStorageSizeInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoTotalDiskStorageSizeInByte = (string) content.GetValueForProperty("ExtendedInfoTotalDiskStorageSizeInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemInternal)this).ExtendedInfoTotalDiskStorageSizeInByte, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DpmProtectedItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DpmProtectedItem" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItem FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Additional information on Backup engine specific backup item.
    [System.ComponentModel.TypeConverter(typeof(DpmProtectedItemTypeConverter))]
    public partial interface IDpmProtectedItem

    {

    }
}