// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.PowerShell;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(FileSystemResourceTypeConverter))]
    public partial class FileSystemResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FileSystemResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FileSystemResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FileSystemResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).StorageSku, global::System.Convert.ToString);
            }
            if (content.Contains("DelegatedSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).DelegatedSubnetId = (string) content.GetValueForProperty("DelegatedSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).DelegatedSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterLoginUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ClusterLoginUrl = (string) content.GetValueForProperty("ClusterLoginUrl",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ClusterLoginUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).PrivateIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("PrivateIP",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).PrivateIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AdminPassword = (string) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AdminPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPlanId = (string) content.GetValueForProperty("MarketplaceDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailOfferId = (string) content.GetValueForProperty("MarketplaceDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPublisherId = (string) content.GetValueForProperty("MarketplaceDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailTermUnit = (string) content.GetValueForProperty("MarketplaceDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetailEmail = (string) content.GetValueForProperty("UserDetailEmail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetailEmail, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FileSystemResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).StorageSku, global::System.Convert.ToString);
            }
            if (content.Contains("DelegatedSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).DelegatedSubnetId = (string) content.GetValueForProperty("DelegatedSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).DelegatedSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterLoginUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ClusterLoginUrl = (string) content.GetValueForProperty("ClusterLoginUrl",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).ClusterLoginUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).PrivateIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("PrivateIP",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).PrivateIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AdminPassword = (string) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AdminPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).AvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPlanId = (string) content.GetValueForProperty("MarketplaceDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailOfferId = (string) content.GetValueForProperty("MarketplaceDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPublisherId = (string) content.GetValueForProperty("MarketplaceDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailTermUnit = (string) content.GetValueForProperty("MarketplaceDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetailEmail = (string) content.GetValueForProperty("UserDetailEmail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceInternal)this).UserDetailEmail, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FileSystemResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FileSystemResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    [System.ComponentModel.TypeConverter(typeof(FileSystemResourceTypeConverter))]
    public partial interface IFileSystemResource

    {

    }
}