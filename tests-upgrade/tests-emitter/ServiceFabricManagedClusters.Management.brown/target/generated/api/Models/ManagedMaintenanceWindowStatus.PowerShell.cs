// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>Describes the maintenance window status of the Service Fabric Managed Cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedMaintenanceWindowStatusTypeConverter))]
    public partial class ManagedMaintenanceWindowStatus
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedMaintenanceWindowStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatus"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatus DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedMaintenanceWindowStatus(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedMaintenanceWindowStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatus"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatus DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedMaintenanceWindowStatus(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedMaintenanceWindowStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedMaintenanceWindowStatus" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatus FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedMaintenanceWindowStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedMaintenanceWindowStatus(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IsWindowEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowEnabled = (bool?) content.GetValueForProperty("IsWindowEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsRegionReady"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsRegionReady = (bool?) content.GetValueForProperty("IsRegionReady",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsRegionReady, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsWindowActive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowActive = (bool?) content.GetValueForProperty("IsWindowActive",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CanApplyUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).CanApplyUpdate = (bool?) content.GetValueForProperty("CanApplyUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).CanApplyUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastWindowStatusUpdateAtUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStatusUpdateAtUtc = (global::System.DateTime?) content.GetValueForProperty("LastWindowStatusUpdateAtUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStatusUpdateAtUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastWindowStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("LastWindowStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastWindowEndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("LastWindowEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedMaintenanceWindowStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedMaintenanceWindowStatus(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IsWindowEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowEnabled = (bool?) content.GetValueForProperty("IsWindowEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsRegionReady"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsRegionReady = (bool?) content.GetValueForProperty("IsRegionReady",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsRegionReady, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsWindowActive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowActive = (bool?) content.GetValueForProperty("IsWindowActive",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).IsWindowActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CanApplyUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).CanApplyUpdate = (bool?) content.GetValueForProperty("CanApplyUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).CanApplyUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastWindowStatusUpdateAtUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStatusUpdateAtUtc = (global::System.DateTime?) content.GetValueForProperty("LastWindowStatusUpdateAtUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStatusUpdateAtUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastWindowStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("LastWindowStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastWindowEndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("LastWindowEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal)this).LastWindowEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Describes the maintenance window status of the Service Fabric Managed Cluster.
    [System.ComponentModel.TypeConverter(typeof(ManagedMaintenanceWindowStatusTypeConverter))]
    public partial interface IManagedMaintenanceWindowStatus

    {

    }
}