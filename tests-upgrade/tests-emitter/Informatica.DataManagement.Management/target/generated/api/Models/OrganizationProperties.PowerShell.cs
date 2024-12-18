// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>Properties specific to the Informatica DataManagement Organization resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationPropertiesTypeConverter))]
    public partial class OrganizationProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OrganizationProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InformaticaProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties) content.GetValueForProperty("InformaticaProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinkOrganization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganization = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization) content.GetValueForProperty("LinkOrganization",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganization, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.LinkOrganizationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationId = (string) content.GetValueForProperty("InformaticaPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationName = (string) content.GetValueForProperty("InformaticaPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyInformaticaRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyInformaticaRegion = (string) content.GetValueForProperty("InformaticaPropertyInformaticaRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyInformaticaRegion, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertySingleSignOnUrl = (string) content.GetValueForProperty("InformaticaPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusiness"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailBusiness = (string) content.GetValueForProperty("CompanyDetailBusiness",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailBusiness, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailNumberOfEmployee = (int?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LinkOrganizationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganizationToken = (string) content.GetValueForProperty("LinkOrganizationToken",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganizationToken, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InformaticaProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties) content.GetValueForProperty("InformaticaProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CompanyDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails) content.GetValueForProperty("CompanyDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CompanyDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinkOrganization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganization = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization) content.GetValueForProperty("LinkOrganization",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganization, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.LinkOrganizationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOfferDetails) content.GetValueForProperty("MarketplaceDetailOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationId = (string) content.GetValueForProperty("InformaticaPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationName = (string) content.GetValueForProperty("InformaticaPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertyInformaticaRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyInformaticaRegion = (string) content.GetValueForProperty("InformaticaPropertyInformaticaRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertyInformaticaRegion, global::System.Convert.ToString);
            }
            if (content.Contains("InformaticaPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertySingleSignOnUrl = (string) content.GetValueForProperty("InformaticaPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).InformaticaPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailUpn = (string) content.GetValueForProperty("UserDetailUpn",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailPhoneNumber = (string) content.GetValueForProperty("UserDetailPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).UserDetailPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCompanyName = (string) content.GetValueForProperty("CompanyDetailCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailOfficeAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailOfficeAddress = (string) content.GetValueForProperty("CompanyDetailOfficeAddress",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailOfficeAddress, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCountry = (string) content.GetValueForProperty("CompanyDetailCountry",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailCountry, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailDomain = (string) content.GetValueForProperty("CompanyDetailDomain",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailDomain, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailBusiness"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailBusiness = (string) content.GetValueForProperty("CompanyDetailBusiness",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailBusiness, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyDetailNumberOfEmployee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailNumberOfEmployee = (int?) content.GetValueForProperty("CompanyDetailNumberOfEmployee",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).CompanyDetailNumberOfEmployee, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LinkOrganizationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganizationToken = (string) content.GetValueForProperty("LinkOrganizationToken",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).LinkOrganizationToken, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
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
    /// Properties specific to the Informatica DataManagement Organization resource.
    [System.ComponentModel.TypeConverter(typeof(OrganizationPropertiesTypeConverter))]
    public partial interface IOrganizationProperties

    {

    }
}