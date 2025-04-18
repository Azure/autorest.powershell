// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>An Organization Resource by Informatica.</summary>
    [System.ComponentModel.TypeConverter(typeof(InformaticaOrganizationResourceTypeConverter))]
    public partial class InformaticaOrganizationResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InformaticaOrganizationResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InformaticaOrganizationResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InformaticaOrganizationResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InformaticaOrganizationResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InformaticaOrganizationResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties) content.GetValueForProperty("InformaticaProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinkOrganization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganization = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization) content.GetValueForProperty("LinkOrganization",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganization, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.LinkOrganizationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationId = (string) content.GetValueForProperty("InformaticaPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationName = (string) content.GetValueForProperty("InformaticaPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyInformaticaRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyInformaticaRegion = (string) content.GetValueForProperty("InformaticaPropertyInformaticaRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyInformaticaRegion, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertySingleSignOnUrl = (string) content.GetValueForProperty("InformaticaPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusiness"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailBusiness = (string) content.GetValueForProperty("CompanyDetailBusiness",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailBusiness, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee = (int?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LinkOrganizationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganizationToken = (string) content.GetValueForProperty("LinkOrganizationToken",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganizationToken, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InformaticaOrganizationResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties) content.GetValueForProperty("InformaticaProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinkOrganization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganization = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization) content.GetValueForProperty("LinkOrganization",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganization, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.LinkOrganizationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationId = (string) content.GetValueForProperty("InformaticaPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationName = (string) content.GetValueForProperty("InformaticaPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyInformaticaRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyInformaticaRegion = (string) content.GetValueForProperty("InformaticaPropertyInformaticaRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertyInformaticaRegion, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertySingleSignOnUrl = (string) content.GetValueForProperty("InformaticaPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).InformaticaPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusiness"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailBusiness = (string) content.GetValueForProperty("CompanyDetailBusiness",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailBusiness, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee = (int?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LinkOrganizationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganizationToken = (string) content.GetValueForProperty("LinkOrganizationToken",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).LinkOrganizationToken, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// An Organization Resource by Informatica.
    [System.ComponentModel.TypeConverter(typeof(InformaticaOrganizationResourceTypeConverter))]
    public partial interface IInformaticaOrganizationResource

    {

    }
}