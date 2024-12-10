// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.PowerShell;

    /// <summary>Represents a mongo cluster resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(MongoClusterTypeConverter))]
    public partial class MongoCluster
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MongoCluster(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MongoCluster(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MongoCluster" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MongoCluster" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MongoCluster(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("CreateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).CreateMode = (string) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).CreateMode, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PreviewFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PreviewFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreviewFeature",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PreviewFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RestoreParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameter = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters) content.GetValueForProperty("RestoreParameter",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameter, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterRestoreParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReplicaParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameter = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters) content.GetValueForProperty("ReplicaParameter",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameter, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterReplicaParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Administrator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Administrator = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties) content.GetValueForProperty("Administrator",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Administrator, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Storage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StoragePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sharding"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Sharding = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties) content.GetValueForProperty("Sharding",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Sharding, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Compute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Compute = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties) content.GetValueForProperty("Compute",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Compute, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Backup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Replica"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Replica = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties) content.GetValueForProperty("Replica",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Replica, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ReplicationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ServerVersion = (string) content.GetValueForProperty("ServerVersion",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ServerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ConnectionString = (string) content.GetValueForProperty("ConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ConnectionString, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ClusterStatus = (string) content.GetValueForProperty("ClusterStatus",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ClusterStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("InfrastructureVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).InfrastructureVersion = (string) content.GetValueForProperty("InfrastructureVersion",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).InfrastructureVersion, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).StorageSizeGb = (long?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).StorageSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ShardingShardCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ShardingShardCount = (int?) content.GetValueForProperty("ShardingShardCount",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ShardingShardCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ReplicaReplicationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaReplicationState = (string) content.GetValueForProperty("ReplicaReplicationState",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaReplicationState, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreParameterPointInTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterPointInTimeUtc = (global::System.DateTime?) content.GetValueForProperty("RestoreParameterPointInTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterPointInTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RestoreParameterSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterSourceResourceId = (string) content.GetValueForProperty("RestoreParameterSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaParameterSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceResourceId = (string) content.GetValueForProperty("ReplicaParameterSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaParameterSourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceLocation = (string) content.GetValueForProperty("ReplicaParameterSourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorUserName = (string) content.GetValueForProperty("AdministratorUserName",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorUserName, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorPassword = (string) content.GetValueForProperty("AdministratorPassword",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorPassword, global::System.Convert.ToString);
            }
            if (content.Contains("HighAvailabilityTargetMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailabilityTargetMode = (string) content.GetValueForProperty("HighAvailabilityTargetMode",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailabilityTargetMode, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ComputeTier = (string) content.GetValueForProperty("ComputeTier",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ComputeTier, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEarliestRestoreTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).BackupEarliestRestoreTime = (string) content.GetValueForProperty("BackupEarliestRestoreTime",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).BackupEarliestRestoreTime, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaSourceResourceId = (string) content.GetValueForProperty("ReplicaSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaRole"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaRole = (string) content.GetValueForProperty("ReplicaRole",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaRole, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoCluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MongoCluster(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("CreateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).CreateMode = (string) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).CreateMode, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PreviewFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PreviewFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreviewFeature",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PreviewFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RestoreParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameter = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters) content.GetValueForProperty("RestoreParameter",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameter, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterRestoreParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReplicaParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameter = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters) content.GetValueForProperty("ReplicaParameter",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameter, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterReplicaParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Administrator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Administrator = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties) content.GetValueForProperty("Administrator",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Administrator, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Storage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StoragePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sharding"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Sharding = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties) content.GetValueForProperty("Sharding",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Sharding, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Compute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Compute = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties) content.GetValueForProperty("Compute",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Compute, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Backup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Replica"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Replica = (Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties) content.GetValueForProperty("Replica",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).Replica, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ReplicationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ServerVersion = (string) content.GetValueForProperty("ServerVersion",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ServerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ConnectionString = (string) content.GetValueForProperty("ConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ConnectionString, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ClusterStatus = (string) content.GetValueForProperty("ClusterStatus",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ClusterStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("InfrastructureVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).InfrastructureVersion = (string) content.GetValueForProperty("InfrastructureVersion",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).InfrastructureVersion, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).StorageSizeGb = (long?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).StorageSizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ShardingShardCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ShardingShardCount = (int?) content.GetValueForProperty("ShardingShardCount",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ShardingShardCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ReplicaReplicationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaReplicationState = (string) content.GetValueForProperty("ReplicaReplicationState",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaReplicationState, global::System.Convert.ToString);
            }
            if (content.Contains("RestoreParameterPointInTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterPointInTimeUtc = (global::System.DateTime?) content.GetValueForProperty("RestoreParameterPointInTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterPointInTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RestoreParameterSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterSourceResourceId = (string) content.GetValueForProperty("RestoreParameterSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RestoreParameterSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaParameterSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceResourceId = (string) content.GetValueForProperty("ReplicaParameterSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaParameterSourceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceLocation = (string) content.GetValueForProperty("ReplicaParameterSourceLocation",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaParameterSourceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorUserName = (string) content.GetValueForProperty("AdministratorUserName",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorUserName, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorPassword = (string) content.GetValueForProperty("AdministratorPassword",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).AdministratorPassword, global::System.Convert.ToString);
            }
            if (content.Contains("HighAvailabilityTargetMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailabilityTargetMode = (string) content.GetValueForProperty("HighAvailabilityTargetMode",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).HighAvailabilityTargetMode, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ComputeTier = (string) content.GetValueForProperty("ComputeTier",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ComputeTier, global::System.Convert.ToString);
            }
            if (content.Contains("BackupEarliestRestoreTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).BackupEarliestRestoreTime = (string) content.GetValueForProperty("BackupEarliestRestoreTime",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).BackupEarliestRestoreTime, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaSourceResourceId = (string) content.GetValueForProperty("ReplicaSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaRole"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaRole = (string) content.GetValueForProperty("ReplicaRole",((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).ReplicaRole, global::System.Convert.ToString);
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
    /// Represents a mongo cluster resource.
    [System.ComponentModel.TypeConverter(typeof(MongoClusterTypeConverter))]
    public partial interface IMongoCluster

    {

    }
}