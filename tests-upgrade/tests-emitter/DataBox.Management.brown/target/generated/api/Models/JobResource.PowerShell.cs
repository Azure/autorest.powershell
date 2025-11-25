// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Job Resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(JobResourceTypeConverter))]
    public partial class JobResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).TransferType = (string) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).TransferType, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeliveryInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDeliveryInfo) content.GetValueForProperty("DeliveryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfo, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobDeliveryInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsCancellable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellable = (bool?) content.GetValueForProperty("IsCancellable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDeletable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsDeletable = (bool?) content.GetValueForProperty("IsDeletable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsDeletable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsShippingAddressEditable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsShippingAddressEditable = (bool?) content.GetValueForProperty("IsShippingAddressEditable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsShippingAddressEditable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseShippingDetailsUpdate = (string) content.GetValueForProperty("ReverseShippingDetailsUpdate",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseShippingDetailsUpdate, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseTransportPreferenceUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseTransportPreferenceUpdate = (string) content.GetValueForProperty("ReverseTransportPreferenceUpdate",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseTransportPreferenceUpdate, global::System.Convert.ToString);
            }
            if (content.Contains("IsPrepareToShipEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsPrepareToShipEnabled = (bool?) content.GetValueForProperty("IsPrepareToShipEnabled",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsPrepareToShipEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("DelayedStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DelayedStage = (string) content.GetValueForProperty("DelayedStage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DelayedStage, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CancellationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).CancellationReason = (string) content.GetValueForProperty("CancellationReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).CancellationReason, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryType = (string) content.GetValueForProperty("DeliveryType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryType, global::System.Convert.ToString);
            }
            if (content.Contains("IsCancellableWithoutFee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellableWithoutFee = (bool?) content.GetValueForProperty("IsCancellableWithoutFee",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellableWithoutFee, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AllDevicesLost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AllDevicesLost = (bool?) content.GetValueForProperty("AllDevicesLost",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AllDevicesLost, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Detail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuDisplayName = (string) content.GetValueForProperty("SkuDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuModel = (string) content.GetValueForProperty("SkuModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuModel, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryInfoScheduledDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfoScheduledDateTime = (global::System.DateTime?) content.GetValueForProperty("DeliveryInfoScheduledDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfoScheduledDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).TransferType = (string) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).TransferType, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeliveryInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDeliveryInfo) content.GetValueForProperty("DeliveryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfo, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobDeliveryInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsCancellable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellable = (bool?) content.GetValueForProperty("IsCancellable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDeletable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsDeletable = (bool?) content.GetValueForProperty("IsDeletable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsDeletable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsShippingAddressEditable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsShippingAddressEditable = (bool?) content.GetValueForProperty("IsShippingAddressEditable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsShippingAddressEditable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseShippingDetailsUpdate = (string) content.GetValueForProperty("ReverseShippingDetailsUpdate",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseShippingDetailsUpdate, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseTransportPreferenceUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseTransportPreferenceUpdate = (string) content.GetValueForProperty("ReverseTransportPreferenceUpdate",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ReverseTransportPreferenceUpdate, global::System.Convert.ToString);
            }
            if (content.Contains("IsPrepareToShipEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsPrepareToShipEnabled = (bool?) content.GetValueForProperty("IsPrepareToShipEnabled",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsPrepareToShipEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("DelayedStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DelayedStage = (string) content.GetValueForProperty("DelayedStage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DelayedStage, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CancellationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).CancellationReason = (string) content.GetValueForProperty("CancellationReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).CancellationReason, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryType = (string) content.GetValueForProperty("DeliveryType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryType, global::System.Convert.ToString);
            }
            if (content.Contains("IsCancellableWithoutFee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellableWithoutFee = (bool?) content.GetValueForProperty("IsCancellableWithoutFee",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IsCancellableWithoutFee, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AllDevicesLost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AllDevicesLost = (bool?) content.GetValueForProperty("AllDevicesLost",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AllDevicesLost, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Detail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuDisplayName = (string) content.GetValueForProperty("SkuDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuModel = (string) content.GetValueForProperty("SkuModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).SkuModel, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryInfoScheduledDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfoScheduledDateTime = (global::System.DateTime?) content.GetValueForProperty("DeliveryInfoScheduledDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal)this).DeliveryInfoScheduledDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Job Resource.
    [System.ComponentModel.TypeConverter(typeof(JobResourceTypeConverter))]
    public partial interface IJobResource

    {

    }
}