// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>Patchable Properties of the Informatica Organization resource</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationPropertiesCustomUpdateTypeConverter))]
    public partial class OrganizationPropertiesCustomUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesCustomUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationPropertiesCustomUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesCustomUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationPropertiesCustomUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationPropertiesCustomUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="OrganizationPropertiesCustomUpdate" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesCustomUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationPropertiesCustomUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdate) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("InformaticaOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).InformaticaOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate) content.GetValueForProperty("InformaticaOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).InformaticaOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResourceUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExistingResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).ExistingResourceId = (string) content.GetValueForProperty("ExistingResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).ExistingResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusiness"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailBusiness = (string) content.GetValueForProperty("CompanyDetailBusiness",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailBusiness, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailNumberOfEmployee = (int?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesCustomUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationPropertiesCustomUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetailsUpdate) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsUpdate) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("InformaticaOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).InformaticaOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate) content.GetValueForProperty("InformaticaOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).InformaticaOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaOrganizationResourceUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExistingResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).ExistingResourceId = (string) content.GetValueForProperty("ExistingResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).ExistingResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetailsUpdate) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusiness"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailBusiness = (string) content.GetValueForProperty("CompanyDetailBusiness",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailBusiness, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailNumberOfEmployee = (int?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdateInternal)this).OfferDetailTermId, global::System.Convert.ToString);
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
    /// Patchable Properties of the Informatica Organization resource
    [System.ComponentModel.TypeConverter(typeof(OrganizationPropertiesCustomUpdateTypeConverter))]
    public partial interface IOrganizationPropertiesCustomUpdate

    {

    }
}