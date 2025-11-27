// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.PowerShell;

    /// <summary>The key resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(KeyTypeConverter))]
    public partial class Key
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.Key"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKey" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKey DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Key(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.Key"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKey" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKey DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Key(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Key" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Key" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKey FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.Key"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Key(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RotationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicy = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy) content.GetValueForProperty("RotationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicy, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.RotationPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReleasePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicy = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyReleasePolicy) content.GetValueForProperty("ReleasePolicy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicy, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyReleasePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Kty = (string) content.GetValueForProperty("Kty",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Kty, global::System.Convert.ToString);
            }
            if (content.Contains("Op"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Op = (System.Collections.Generic.List<string>) content.GetValueForProperty("Op",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Op, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Size = (int?) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Size, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CurveName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).CurveName = (string) content.GetValueForProperty("CurveName",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).CurveName, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("UriWithVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).UriWithVersion = (string) content.GetValueForProperty("UriWithVersion",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).UriWithVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AttributesUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesUpdated = (long?) content.GetValueForProperty("AttributesUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesUpdated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RotationPolicyLifetimeAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyLifetimeAction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>) content.GetValueForProperty("RotationPolicyLifetimeAction",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyLifetimeAction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>(__y, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.LifetimeActionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AttributeEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeEnabled = (bool?) content.GetValueForProperty("AttributeEnabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AttributeNotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeNotBefore = (long?) content.GetValueForProperty("AttributeNotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeNotBefore, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeExpire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpire = (long?) content.GetValueForProperty("AttributeExpire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpire, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributesCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesCreated = (long?) content.GetValueForProperty("AttributesCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesCreated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeRecoveryLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeRecoveryLevel = (string) content.GetValueForProperty("AttributeRecoveryLevel",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeRecoveryLevel, global::System.Convert.ToString);
            }
            if (content.Contains("AttributeExportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExportable = (bool?) content.GetValueForProperty("AttributeExportable",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RotationPolicyAttribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes) content.GetValueForProperty("RotationPolicyAttribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyRotationPolicyAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RotationPolicyAttributesUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesUpdated = (long?) content.GetValueForProperty("RotationPolicyAttributesUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesUpdated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ReleasePolicyContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyContentType = (string) content.GetValueForProperty("ReleasePolicyContentType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyContentType, global::System.Convert.ToString);
            }
            if (content.Contains("ReleasePolicyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyData = (byte[]) content.GetValueForProperty("ReleasePolicyData",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyData, i => i);
            }
            if (content.Contains("RotationPolicyAttributesCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesCreated = (long?) content.GetValueForProperty("RotationPolicyAttributesCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesCreated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpiryTime = (string) content.GetValueForProperty("AttributeExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpiryTime, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.Key"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Key(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RotationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicy = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy) content.GetValueForProperty("RotationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicy, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.RotationPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Attribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Attribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes) content.GetValueForProperty("Attribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Attribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReleasePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicy = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyReleasePolicy) content.GetValueForProperty("ReleasePolicy",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicy, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyReleasePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Kty = (string) content.GetValueForProperty("Kty",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Kty, global::System.Convert.ToString);
            }
            if (content.Contains("Op"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Op = (System.Collections.Generic.List<string>) content.GetValueForProperty("Op",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Op, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Size = (int?) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Size, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CurveName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).CurveName = (string) content.GetValueForProperty("CurveName",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).CurveName, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("UriWithVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).UriWithVersion = (string) content.GetValueForProperty("UriWithVersion",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).UriWithVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AttributesUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesUpdated = (long?) content.GetValueForProperty("AttributesUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesUpdated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RotationPolicyLifetimeAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyLifetimeAction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>) content.GetValueForProperty("RotationPolicyLifetimeAction",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyLifetimeAction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction>(__y, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.LifetimeActionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AttributeEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeEnabled = (bool?) content.GetValueForProperty("AttributeEnabled",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AttributeNotBefore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeNotBefore = (long?) content.GetValueForProperty("AttributeNotBefore",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeNotBefore, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeExpire"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpire = (long?) content.GetValueForProperty("AttributeExpire",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpire, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributesCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesCreated = (long?) content.GetValueForProperty("AttributesCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributesCreated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeRecoveryLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeRecoveryLevel = (string) content.GetValueForProperty("AttributeRecoveryLevel",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeRecoveryLevel, global::System.Convert.ToString);
            }
            if (content.Contains("AttributeExportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExportable = (bool?) content.GetValueForProperty("AttributeExportable",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RotationPolicyAttribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttribute = (Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes) content.GetValueForProperty("RotationPolicyAttribute",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttribute, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyRotationPolicyAttributesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RotationPolicyAttributesUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesUpdated = (long?) content.GetValueForProperty("RotationPolicyAttributesUpdated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesUpdated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ReleasePolicyContentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyContentType = (string) content.GetValueForProperty("ReleasePolicyContentType",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyContentType, global::System.Convert.ToString);
            }
            if (content.Contains("ReleasePolicyData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyData = (byte[]) content.GetValueForProperty("ReleasePolicyData",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).ReleasePolicyData, i => i);
            }
            if (content.Contains("RotationPolicyAttributesCreated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesCreated = (long?) content.GetValueForProperty("RotationPolicyAttributesCreated",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).RotationPolicyAttributesCreated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AttributeExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpiryTime = (string) content.GetValueForProperty("AttributeExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyInternal)this).AttributeExpiryTime, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The key resource.
    [System.ComponentModel.TypeConverter(typeof(KeyTypeConverter))]
    public partial interface IKey

    {

    }
}