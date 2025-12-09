// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Additional information of DPM Protected item.</summary>
    [System.ComponentModel.TypeConverter(typeof(DpmProtectedItemExtendedInfoTypeConverter))]
    public partial class DpmProtectedItemExtendedInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DpmProtectedItemExtendedInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DpmProtectedItemExtendedInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DpmProtectedItemExtendedInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProtectableObjectLoadPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectableObjectLoadPath = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoProtectableObjectLoadPath) content.GetValueForProperty("ProtectableObjectLoadPath",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectableObjectLoadPath, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfoProtectableObjectLoadPathTypeConverter.ConvertFrom);
            }
            if (content.Contains("Protected"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).Protected = (bool?) content.GetValueForProperty("Protected",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).Protected, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsPresentOnCloud"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsPresentOnCloud = (bool?) content.GetValueForProperty("IsPresentOnCloud",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsPresentOnCloud, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("LastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("LastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("OldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).RecoveryPointCount = (int?) content.GetValueForProperty("RecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).RecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OnPremiseOldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseOldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("OnPremiseOldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseOldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OnPremiseLatestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseLatestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("OnPremiseLatestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseLatestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OnPremiseRecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseRecoveryPointCount = (int?) content.GetValueForProperty("OnPremiseRecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseRecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsCollocated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsCollocated = (bool?) content.GetValueForProperty("IsCollocated",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsCollocated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectionGroupName = (string) content.GetValueForProperty("ProtectionGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectionGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("DiskStorageUsedInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).DiskStorageUsedInByte = (string) content.GetValueForProperty("DiskStorageUsedInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).DiskStorageUsedInByte, global::System.Convert.ToString);
            }
            if (content.Contains("TotalDiskStorageSizeInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).TotalDiskStorageSizeInByte = (string) content.GetValueForProperty("TotalDiskStorageSizeInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).TotalDiskStorageSizeInByte, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DpmProtectedItemExtendedInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProtectableObjectLoadPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectableObjectLoadPath = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoProtectableObjectLoadPath) content.GetValueForProperty("ProtectableObjectLoadPath",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectableObjectLoadPath, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmProtectedItemExtendedInfoProtectableObjectLoadPathTypeConverter.ConvertFrom);
            }
            if (content.Contains("Protected"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).Protected = (bool?) content.GetValueForProperty("Protected",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).Protected, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsPresentOnCloud"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsPresentOnCloud = (bool?) content.GetValueForProperty("IsPresentOnCloud",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsPresentOnCloud, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("LastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("LastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).LastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("OldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).RecoveryPointCount = (int?) content.GetValueForProperty("RecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).RecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OnPremiseOldestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseOldestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("OnPremiseOldestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseOldestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OnPremiseLatestRecoveryPoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseLatestRecoveryPoint = (global::System.DateTime?) content.GetValueForProperty("OnPremiseLatestRecoveryPoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseLatestRecoveryPoint, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OnPremiseRecoveryPointCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseRecoveryPointCount = (int?) content.GetValueForProperty("OnPremiseRecoveryPointCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).OnPremiseRecoveryPointCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsCollocated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsCollocated = (bool?) content.GetValueForProperty("IsCollocated",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).IsCollocated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProtectionGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectionGroupName = (string) content.GetValueForProperty("ProtectionGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).ProtectionGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("DiskStorageUsedInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).DiskStorageUsedInByte = (string) content.GetValueForProperty("DiskStorageUsedInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).DiskStorageUsedInByte, global::System.Convert.ToString);
            }
            if (content.Contains("TotalDiskStorageSizeInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).TotalDiskStorageSizeInByte = (string) content.GetValueForProperty("TotalDiskStorageSizeInByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfoInternal)this).TotalDiskStorageSizeInByte, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DpmProtectedItemExtendedInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DpmProtectedItemExtendedInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmProtectedItemExtendedInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Additional information of DPM Protected item.
    [System.ComponentModel.TypeConverter(typeof(DpmProtectedItemExtendedInfoTypeConverter))]
    public partial interface IDpmProtectedItemExtendedInfo

    {

    }
}