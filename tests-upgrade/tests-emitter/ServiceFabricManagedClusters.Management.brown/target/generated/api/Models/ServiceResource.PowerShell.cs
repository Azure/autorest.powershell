// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>The service resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceResourceTypeConverter))]
    public partial class ServiceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ServiceResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PartitionDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescription = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition) content.GetValueForProperty("PartitionDescription",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescription, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PartitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServiceKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceKind = (string) content.GetValueForProperty("ServiceKind",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceKind, global::System.Convert.ToString);
            }
            if (content.Contains("PlacementConstraint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PlacementConstraint = (string) content.GetValueForProperty("PlacementConstraint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PlacementConstraint, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).CorrelationScheme = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>) content.GetValueForProperty("CorrelationScheme",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).CorrelationScheme, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceCorrelationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceLoadMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceLoadMetric = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>) content.GetValueForProperty("ServiceLoadMetric",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceLoadMetric, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceLoadMetricTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServicePlacementPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePlacementPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>) content.GetValueForProperty("ServicePlacementPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePlacementPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServicePlacementPolicyTypeConverter.ConvertFrom));
            }
            if (content.Contains("DefaultMoveCost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).DefaultMoveCost = (string) content.GetValueForProperty("DefaultMoveCost",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).DefaultMoveCost, global::System.Convert.ToString);
            }
            if (content.Contains("ScalingPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ScalingPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>) content.GetValueForProperty("ScalingPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ScalingPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ScalingPolicyTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceTypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceTypeName = (string) content.GetValueForProperty("ServiceTypeName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("ServicePackageActivationMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePackageActivationMode = (string) content.GetValueForProperty("ServicePackageActivationMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePackageActivationMode, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceDnsName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceDnsName = (string) content.GetValueForProperty("ServiceDnsName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceDnsName, global::System.Convert.ToString);
            }
            if (content.Contains("PartitionDescriptionPartitionScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescriptionPartitionScheme = (string) content.GetValueForProperty("PartitionDescriptionPartitionScheme",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescriptionPartitionScheme, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PartitionDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescription = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition) content.GetValueForProperty("PartitionDescription",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescription, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PartitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServiceKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceKind = (string) content.GetValueForProperty("ServiceKind",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceKind, global::System.Convert.ToString);
            }
            if (content.Contains("PlacementConstraint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PlacementConstraint = (string) content.GetValueForProperty("PlacementConstraint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PlacementConstraint, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).CorrelationScheme = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>) content.GetValueForProperty("CorrelationScheme",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).CorrelationScheme, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceCorrelationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceLoadMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceLoadMetric = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>) content.GetValueForProperty("ServiceLoadMetric",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceLoadMetric, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceLoadMetricTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServicePlacementPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePlacementPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>) content.GetValueForProperty("ServicePlacementPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePlacementPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServicePlacementPolicyTypeConverter.ConvertFrom));
            }
            if (content.Contains("DefaultMoveCost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).DefaultMoveCost = (string) content.GetValueForProperty("DefaultMoveCost",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).DefaultMoveCost, global::System.Convert.ToString);
            }
            if (content.Contains("ScalingPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ScalingPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>) content.GetValueForProperty("ScalingPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ScalingPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ScalingPolicyTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceTypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceTypeName = (string) content.GetValueForProperty("ServiceTypeName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("ServicePackageActivationMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePackageActivationMode = (string) content.GetValueForProperty("ServicePackageActivationMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServicePackageActivationMode, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceDnsName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceDnsName = (string) content.GetValueForProperty("ServiceDnsName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).ServiceDnsName, global::System.Convert.ToString);
            }
            if (content.Contains("PartitionDescriptionPartitionScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescriptionPartitionScheme = (string) content.GetValueForProperty("PartitionDescriptionPartitionScheme",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceInternal)this).PartitionDescriptionPartitionScheme, global::System.Convert.ToString);
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
    /// The service resource.
    [System.ComponentModel.TypeConverter(typeof(ServiceResourceTypeConverter))]
    public partial interface IServiceResource

    {

    }
}