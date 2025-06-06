// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.PowerShell;

    /// <summary>Properties specific to Instance</summary>
    [System.ComponentModel.TypeConverter(typeof(InstancePropertiesTypeConverter))]
    public partial class InstanceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InstanceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InstanceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InstanceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstanceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InstanceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISingleSignOnPropertiesV2) content.GetValueForProperty("SingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.SingleSignOnPropertiesV2TypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertyRegion = (string) content.GetValueForProperty("PartnerPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertyRegion, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyUrl = (string) content.GetValueForProperty("SingleSignOnPropertyUrl",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertySubdomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertySubdomain = (string) content.GetValueForProperty("PartnerPropertySubdomain",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertySubdomain, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyType = (string) content.GetValueForProperty("SingleSignOnPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyState = (string) content.GetValueForProperty("SingleSignOnPropertyState",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.InstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InstanceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISingleSignOnPropertiesV2) content.GetValueForProperty("SingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.SingleSignOnPropertiesV2TypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertyRegion = (string) content.GetValueForProperty("PartnerPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertyRegion, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyUrl = (string) content.GetValueForProperty("SingleSignOnPropertyUrl",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertySubdomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertySubdomain = (string) content.GetValueForProperty("PartnerPropertySubdomain",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).PartnerPropertySubdomain, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyType = (string) content.GetValueForProperty("SingleSignOnPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyState = (string) content.GetValueForProperty("SingleSignOnPropertyState",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IInstancePropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
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
    /// Properties specific to Instance
    [System.ComponentModel.TypeConverter(typeof(InstancePropertiesTypeConverter))]
    public partial interface IInstanceProperties

    {

    }
}