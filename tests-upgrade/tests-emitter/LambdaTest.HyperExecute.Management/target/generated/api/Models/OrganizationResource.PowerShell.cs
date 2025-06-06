// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.PowerShell;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceTypeConverter))]
    public partial class OrganizationResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OrganizationResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISingleSignOnPropertiesV2) content.GetValueForProperty("SingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.SingleSignOnPropertiesV2TypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyLicensesSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerPropertyLicensesSubscribed = (int?) content.GetValueForProperty("PartnerPropertyLicensesSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerPropertyLicensesSubscribed, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SingleSignOnPropertyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyUrl = (string) content.GetValueForProperty("SingleSignOnPropertyUrl",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyType = (string) content.GetValueForProperty("SingleSignOnPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyState = (string) content.GetValueForProperty("SingleSignOnPropertyState",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.ISingleSignOnPropertiesV2) content.GetValueForProperty("SingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.SingleSignOnPropertiesV2TypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyLicensesSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerPropertyLicensesSubscribed = (int?) content.GetValueForProperty("PartnerPropertyLicensesSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).PartnerPropertyLicensesSubscribed, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SingleSignOnPropertyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyUrl = (string) content.GetValueForProperty("SingleSignOnPropertyUrl",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyType = (string) content.GetValueForProperty("SingleSignOnPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyState = (string) content.GetValueForProperty("SingleSignOnPropertyState",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceTypeConverter))]
    public partial interface IOrganizationResource

    {

    }
}