// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell;

    /// <summary>The type used for update operations of the MongoCluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(MongoClusterUpdateTypeConverter))]
    public partial class MongoClusterUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MongoClusterUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MongoClusterUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MongoClusterUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MongoClusterUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MongoClusterUpdate(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreviewFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PreviewFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreviewFeature",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PreviewFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Administrator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Administrator = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties) content.GetValueForProperty("Administrator",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Administrator, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Storage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StoragePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sharding"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Sharding = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties) content.GetValueForProperty("Sharding",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Sharding, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Compute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Compute = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties) content.GetValueForProperty("Compute",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Compute, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Backup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ServerVersion = (string) content.GetValueForProperty("ServerVersion",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ServerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).StorageSizeGb = (long?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).StorageSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ShardingShardCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ShardingShardCount = (int?) content.GetValueForProperty("ShardingShardCount",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ShardingShardCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AdministratorUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorUserName = (string) content.GetValueForProperty("AdministratorUserName",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorUserName, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorPassword = (string) content.GetValueForProperty("AdministratorPassword",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorPassword, global::System.Convert.ToString);
            }
            if (content.Contains("HighAvailabilityTargetMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailabilityTargetMode = (string) content.GetValueForProperty("HighAvailabilityTargetMode",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailabilityTargetMode, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ComputeTier = (string) content.GetValueForProperty("ComputeTier",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ComputeTier, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEarliestRestoreTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).BackupEarliestRestoreTime = (string) content.GetValueForProperty("BackupEarliestRestoreTime",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).BackupEarliestRestoreTime, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MongoClusterUpdate(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreviewFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PreviewFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreviewFeature",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PreviewFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Administrator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Administrator = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties) content.GetValueForProperty("Administrator",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Administrator, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Storage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StoragePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sharding"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Sharding = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties) content.GetValueForProperty("Sharding",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Sharding, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Compute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Compute = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties) content.GetValueForProperty("Compute",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Compute, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Backup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ServerVersion = (string) content.GetValueForProperty("ServerVersion",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ServerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).StorageSizeGb = (long?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).StorageSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ShardingShardCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ShardingShardCount = (int?) content.GetValueForProperty("ShardingShardCount",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ShardingShardCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AdministratorUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorUserName = (string) content.GetValueForProperty("AdministratorUserName",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorUserName, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorPassword = (string) content.GetValueForProperty("AdministratorPassword",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).AdministratorPassword, global::System.Convert.ToString);
            }
            if (content.Contains("HighAvailabilityTargetMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailabilityTargetMode = (string) content.GetValueForProperty("HighAvailabilityTargetMode",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).HighAvailabilityTargetMode, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ComputeTier = (string) content.GetValueForProperty("ComputeTier",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).ComputeTier, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEarliestRestoreTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).BackupEarliestRestoreTime = (string) content.GetValueForProperty("BackupEarliestRestoreTime",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal)this).BackupEarliestRestoreTime, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The type used for update operations of the MongoCluster.
    [System.ComponentModel.TypeConverter(typeof(MongoClusterUpdateTypeConverter))]
    public partial interface IMongoClusterUpdate

    {

    }
}