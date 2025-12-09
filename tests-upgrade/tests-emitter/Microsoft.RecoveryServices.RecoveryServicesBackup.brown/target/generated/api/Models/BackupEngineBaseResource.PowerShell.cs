// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>
    /// The base backup engine class. All workload specific backup engines derive from this class.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(BackupEngineBaseResourceTypeConverter))]
    public partial class BackupEngineBaseResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupEngineBaseResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBase) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).RegistrationStatus = (string) content.GetValueForProperty("RegistrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).RegistrationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEngineState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineState = (string) content.GetValueForProperty("BackupEngineState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineState, global::System.Convert.ToString);
            }
            if (content.Contains("HealthStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).HealthStatus, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEngineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineType = (string) content.GetValueForProperty("BackupEngineType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineType, global::System.Convert.ToString);
            }
            if (content.Contains("CanReRegister"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).CanReRegister = (bool?) content.GetValueForProperty("CanReRegister",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).CanReRegister, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BackupEngineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineId = (string) content.GetValueForProperty("BackupEngineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineId, global::System.Convert.ToString);
            }
            if (content.Contains("DpmVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).DpmVersion = (string) content.GetValueForProperty("DpmVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).DpmVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBackupAgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).AzureBackupAgentVersion = (string) content.GetValueForProperty("AzureBackupAgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).AzureBackupAgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("IsAzureBackupAgentUpgradeAvailable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsAzureBackupAgentUpgradeAvailable = (bool?) content.GetValueForProperty("IsAzureBackupAgentUpgradeAvailable",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsAzureBackupAgentUpgradeAvailable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDpmUpgradeAvailable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsDpmUpgradeAvailable = (bool?) content.GetValueForProperty("IsDpmUpgradeAvailable",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsDpmUpgradeAvailable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoDatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDatabaseName = (string) content.GetValueForProperty("ExtendedInfoDatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoProtectedItemsCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedItemsCount = (int?) content.GetValueForProperty("ExtendedInfoProtectedItemsCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedItemsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoProtectedServersCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedServersCount = (int?) content.GetValueForProperty("ExtendedInfoProtectedServersCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedServersCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDiskCount = (int?) content.GetValueForProperty("ExtendedInfoDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDiskCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoUsedDiskSpace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoUsedDiskSpace = (double?) content.GetValueForProperty("ExtendedInfoUsedDiskSpace",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoUsedDiskSpace, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ExtendedInfoAvailableDiskSpace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAvailableDiskSpace = (double?) content.GetValueForProperty("ExtendedInfoAvailableDiskSpace",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAvailableDiskSpace, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ExtendedInfoRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoAzureProtectedInstance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAzureProtectedInstance = (int?) content.GetValueForProperty("ExtendedInfoAzureProtectedInstance",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAzureProtectedInstance, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupEngineBaseResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBase) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).RegistrationStatus = (string) content.GetValueForProperty("RegistrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).RegistrationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEngineState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineState = (string) content.GetValueForProperty("BackupEngineState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineState, global::System.Convert.ToString);
            }
            if (content.Contains("HealthStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).HealthStatus, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEngineType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineType = (string) content.GetValueForProperty("BackupEngineType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineType, global::System.Convert.ToString);
            }
            if (content.Contains("CanReRegister"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).CanReRegister = (bool?) content.GetValueForProperty("CanReRegister",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).CanReRegister, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BackupEngineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineId = (string) content.GetValueForProperty("BackupEngineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).BackupEngineId, global::System.Convert.ToString);
            }
            if (content.Contains("DpmVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).DpmVersion = (string) content.GetValueForProperty("DpmVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).DpmVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBackupAgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).AzureBackupAgentVersion = (string) content.GetValueForProperty("AzureBackupAgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).AzureBackupAgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("IsAzureBackupAgentUpgradeAvailable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsAzureBackupAgentUpgradeAvailable = (bool?) content.GetValueForProperty("IsAzureBackupAgentUpgradeAvailable",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsAzureBackupAgentUpgradeAvailable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDpmUpgradeAvailable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsDpmUpgradeAvailable = (bool?) content.GetValueForProperty("IsDpmUpgradeAvailable",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).IsDpmUpgradeAvailable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedInfoDatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDatabaseName = (string) content.GetValueForProperty("ExtendedInfoDatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoProtectedItemsCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedItemsCount = (int?) content.GetValueForProperty("ExtendedInfoProtectedItemsCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedItemsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoProtectedServersCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedServersCount = (int?) content.GetValueForProperty("ExtendedInfoProtectedServersCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoProtectedServersCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDiskCount = (int?) content.GetValueForProperty("ExtendedInfoDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoDiskCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ExtendedInfoUsedDiskSpace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoUsedDiskSpace = (double?) content.GetValueForProperty("ExtendedInfoUsedDiskSpace",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoUsedDiskSpace, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ExtendedInfoAvailableDiskSpace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAvailableDiskSpace = (double?) content.GetValueForProperty("ExtendedInfoAvailableDiskSpace",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAvailableDiskSpace, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ExtendedInfoRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoAzureProtectedInstance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAzureProtectedInstance = (int?) content.GetValueForProperty("ExtendedInfoAzureProtectedInstance",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal)this).ExtendedInfoAzureProtectedInstance, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupEngineBaseResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupEngineBaseResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupEngineBaseResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BackupEngineBaseResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The base backup engine class. All workload specific backup engines derive from this class.
    [System.ComponentModel.TypeConverter(typeof(BackupEngineBaseResourceTypeConverter))]
    public partial interface IBackupEngineBaseResource

    {

    }
}