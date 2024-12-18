// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.PowerShell;

    /// <summary>The type used for update operations of the StandbyContainerGroupPoolResource.</summary>
    [System.ComponentModel.TypeConverter(typeof(StandbyContainerGroupPoolResourceUpdateTypeConverter))]
    public partial class StandbyContainerGroupPoolResourceUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StandbyContainerGroupPoolResourceUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StandbyContainerGroupPoolResourceUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StandbyContainerGroupPoolResourceUpdate" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="StandbyContainerGroupPoolResourceUpdate" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StandbyContainerGroupPoolResourceUpdate(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ElasticityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfile = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile) content.GetValueForProperty("ElasticityProfile",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfile, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolElasticityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContainerGroupProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProperty = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties) content.GetValueForProperty("ContainerGroupProperty",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProperty, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ElasticityProfileRefillPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileRefillPolicy = (string) content.GetValueForProperty("ElasticityProfileRefillPolicy",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileRefillPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerGroupPropertySubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertySubnetId = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet>) content.GetValueForProperty("ContainerGroupPropertySubnetId",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertySubnetId, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet>(__y, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.SubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("ElasticityProfileMaxReadyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileMaxReadyCapacity = (long) content.GetValueForProperty("ElasticityProfileMaxReadyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileMaxReadyCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ContainerGroupPropertyContainerGroupProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertyContainerGroupProfile = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile) content.GetValueForProperty("ContainerGroupPropertyContainerGroupProfile",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertyContainerGroupProfile, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContainerGroupProfileId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileId = (string) content.GetValueForProperty("ContainerGroupProfileId",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileId, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerGroupProfileRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileRevision = (long?) content.GetValueForProperty("ContainerGroupProfileRevision",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileRevision, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StandbyContainerGroupPoolResourceUpdate(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ElasticityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfile = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile) content.GetValueForProperty("ElasticityProfile",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfile, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolElasticityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContainerGroupProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProperty = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties) content.GetValueForProperty("ContainerGroupProperty",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProperty, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ElasticityProfileRefillPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileRefillPolicy = (string) content.GetValueForProperty("ElasticityProfileRefillPolicy",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileRefillPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerGroupPropertySubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertySubnetId = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet>) content.GetValueForProperty("ContainerGroupPropertySubnetId",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertySubnetId, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet>(__y, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.SubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("ElasticityProfileMaxReadyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileMaxReadyCapacity = (long) content.GetValueForProperty("ElasticityProfileMaxReadyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ElasticityProfileMaxReadyCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ContainerGroupPropertyContainerGroupProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertyContainerGroupProfile = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile) content.GetValueForProperty("ContainerGroupPropertyContainerGroupProfile",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupPropertyContainerGroupProfile, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContainerGroupProfileId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileId = (string) content.GetValueForProperty("ContainerGroupProfileId",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileId, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerGroupProfileRevision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileRevision = (long?) content.GetValueForProperty("ContainerGroupProfileRevision",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal)this).ContainerGroupProfileRevision, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The type used for update operations of the StandbyContainerGroupPoolResource.
    [System.ComponentModel.TypeConverter(typeof(StandbyContainerGroupPoolResourceUpdateTypeConverter))]
    public partial interface IStandbyContainerGroupPoolResourceUpdate

    {

    }
}