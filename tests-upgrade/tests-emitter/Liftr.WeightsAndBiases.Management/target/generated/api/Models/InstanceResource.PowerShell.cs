// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(InstanceResourceTypeConverter))]
    public partial class InstanceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InstanceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InstanceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InstanceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InstanceResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InstanceResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstancePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertyRegion = (string) content.GetValueForProperty("PartnerPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertyRegion, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertySubdomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertySubdomain = (string) content.GetValueForProperty("PartnerPropertySubdomain",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertySubdomain, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InstanceResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstancePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertyRegion = (string) content.GetValueForProperty("PartnerPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertyRegion, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertySubdomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertySubdomain = (string) content.GetValueForProperty("PartnerPropertySubdomain",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).PartnerPropertySubdomain, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    [System.ComponentModel.TypeConverter(typeof(InstanceResourceTypeConverter))]
    public partial interface IInstanceResource

    {

    }
}