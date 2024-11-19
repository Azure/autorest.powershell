// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell;

    /// <summary>Organization Resource by Neon</summary>
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OrganizationResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationResource"
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
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.CompanyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties) content.GetValueForProperty("PartnerOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.PartnerOrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOfferDetails) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusinessPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailBusinessPhone = (string) content.GetValueForProperty("CompanyDetailBusinessPhone",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailBusinessPhone, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee = (long?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PartnerOrganizationPropertySingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertySingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties) content.GetValueForProperty("PartnerOrganizationPropertySingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertySingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.SingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationId = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationName = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationResource"
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
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.CompanyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IPartnerOrganizationProperties) content.GetValueForProperty("PartnerOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.PartnerOrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOfferDetails) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).MarketplaceDetailSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusinessPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailBusinessPhone = (string) content.GetValueForProperty("CompanyDetailBusinessPhone",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailBusinessPhone, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee = (long?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PartnerOrganizationPropertySingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertySingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISingleSignOnProperties) content.GetValueForProperty("PartnerOrganizationPropertySingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertySingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.SingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationId = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationName = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).PartnerOrganizationPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Organization Resource by Neon
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceTypeConverter))]
    public partial interface IOrganizationResource

    {

    }
}