// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;

    /// <summary>The managed private endpoint resource type.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedPrivateEndpointModelTypeConverter))]
    public partial class ManagedPrivateEndpointModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedPrivateEndpointModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedPrivateEndpointModel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedPrivateEndpointModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedPrivateEndpointModel" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedPrivateEndpointModel(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState) content.GetValueForProperty("ConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionState, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointConnectionStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrivateLinkResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceId = (string) content.GetValueForProperty("PrivateLinkResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkResourceRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceRegion = (string) content.GetValueForProperty("PrivateLinkResourceRegion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceRegion, global::System.Convert.ToString);
            }
            if (content.Contains("GroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).GroupId = (System.Collections.Generic.List<string>) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).GroupId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RequestMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).RequestMessage = (string) content.GetValueForProperty("RequestMessage",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).RequestMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServiceUrl = (string) content.GetValueForProperty("PrivateLinkServiceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServiceUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServicePrivateIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServicePrivateIP = (string) content.GetValueForProperty("PrivateLinkServicePrivateIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServicePrivateIP, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionStateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateStatus = (string) content.GetValueForProperty("ConnectionStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateDescription = (string) content.GetValueForProperty("ConnectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateDescription, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedPrivateEndpointModel(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState) content.GetValueForProperty("ConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionState, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointConnectionStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrivateLinkResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceId = (string) content.GetValueForProperty("PrivateLinkResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkResourceRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceRegion = (string) content.GetValueForProperty("PrivateLinkResourceRegion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkResourceRegion, global::System.Convert.ToString);
            }
            if (content.Contains("GroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).GroupId = (System.Collections.Generic.List<string>) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).GroupId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RequestMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).RequestMessage = (string) content.GetValueForProperty("RequestMessage",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).RequestMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServiceUrl = (string) content.GetValueForProperty("PrivateLinkServiceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServiceUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServicePrivateIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServicePrivateIP = (string) content.GetValueForProperty("PrivateLinkServicePrivateIP",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).PrivateLinkServicePrivateIP, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionStateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateStatus = (string) content.GetValueForProperty("ConnectionStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateDescription = (string) content.GetValueForProperty("ConnectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal)this).ConnectionStateDescription, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The managed private endpoint resource type.
    [System.ComponentModel.TypeConverter(typeof(ManagedPrivateEndpointModelTypeConverter))]
    public partial interface IManagedPrivateEndpointModel

    {

    }
}