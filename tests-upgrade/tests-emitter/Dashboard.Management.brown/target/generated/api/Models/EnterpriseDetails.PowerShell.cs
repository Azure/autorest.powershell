// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;

    /// <summary>Enterprise details of a Grafana instance</summary>
    [System.ComponentModel.TypeConverter(typeof(EnterpriseDetailsTypeConverter))]
    public partial class EnterpriseDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EnterpriseDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EnterpriseDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EnterpriseDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SaasSubscriptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaasSubscriptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails) content.GetValueForProperty("SaasSubscriptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaasSubscriptionDetail, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SaasSubscriptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceTrialQuota"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuota = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota) content.GetValueForProperty("MarketplaceTrialQuota",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuota, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.MarketplaceTrialQuotaTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceTrialQuotaAvailablePromotion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaAvailablePromotion = (string) content.GetValueForProperty("MarketplaceTrialQuotaAvailablePromotion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaAvailablePromotion, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSubscriptionDetailTerm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailTerm = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm) content.GetValueForProperty("SaaSubscriptionDetailTerm",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailTerm, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTermTypeConverter.ConvertFrom);
            }
            if (content.Contains("SaaSubscriptionDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPlanId = (string) content.GetValueForProperty("SaaSubscriptionDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSubscriptionDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailOfferId = (string) content.GetValueForProperty("SaaSubscriptionDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSubscriptionDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPublisherId = (string) content.GetValueForProperty("SaaSubscriptionDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceTrialQuotaGrafanaResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaGrafanaResourceId = (string) content.GetValueForProperty("MarketplaceTrialQuotaGrafanaResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaGrafanaResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceTrialQuotaTrialStartAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialStartAt = (global::System.DateTime?) content.GetValueForProperty("MarketplaceTrialQuotaTrialStartAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialStartAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MarketplaceTrialQuotaTrialEndAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialEndAt = (global::System.DateTime?) content.GetValueForProperty("MarketplaceTrialQuotaTrialEndAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialEndAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermUnit = (string) content.GetValueForProperty("TermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("TermStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermStartDate = (global::System.DateTime?) content.GetValueForProperty("TermStartDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermStartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TermEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermEndDate = (global::System.DateTime?) content.GetValueForProperty("TermEndDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermEndDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.EnterpriseDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EnterpriseDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SaasSubscriptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaasSubscriptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails) content.GetValueForProperty("SaasSubscriptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaasSubscriptionDetail, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SaasSubscriptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceTrialQuota"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuota = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota) content.GetValueForProperty("MarketplaceTrialQuota",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuota, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.MarketplaceTrialQuotaTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceTrialQuotaAvailablePromotion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaAvailablePromotion = (string) content.GetValueForProperty("MarketplaceTrialQuotaAvailablePromotion",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaAvailablePromotion, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSubscriptionDetailTerm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailTerm = (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm) content.GetValueForProperty("SaaSubscriptionDetailTerm",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailTerm, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTermTypeConverter.ConvertFrom);
            }
            if (content.Contains("SaaSubscriptionDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPlanId = (string) content.GetValueForProperty("SaaSubscriptionDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSubscriptionDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailOfferId = (string) content.GetValueForProperty("SaaSubscriptionDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSubscriptionDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPublisherId = (string) content.GetValueForProperty("SaaSubscriptionDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).SaaSubscriptionDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceTrialQuotaGrafanaResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaGrafanaResourceId = (string) content.GetValueForProperty("MarketplaceTrialQuotaGrafanaResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaGrafanaResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceTrialQuotaTrialStartAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialStartAt = (global::System.DateTime?) content.GetValueForProperty("MarketplaceTrialQuotaTrialStartAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialStartAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MarketplaceTrialQuotaTrialEndAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialEndAt = (global::System.DateTime?) content.GetValueForProperty("MarketplaceTrialQuotaTrialEndAt",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).MarketplaceTrialQuotaTrialEndAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermUnit = (string) content.GetValueForProperty("TermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("TermStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermStartDate = (global::System.DateTime?) content.GetValueForProperty("TermStartDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermStartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("TermEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermEndDate = (global::System.DateTime?) content.GetValueForProperty("TermEndDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal)this).TermEndDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EnterpriseDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EnterpriseDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Enterprise details of a Grafana instance
    [System.ComponentModel.TypeConverter(typeof(EnterpriseDetailsTypeConverter))]
    public partial interface IEnterpriseDetails

    {

    }
}