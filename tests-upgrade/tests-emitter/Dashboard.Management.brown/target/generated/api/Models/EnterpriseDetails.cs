// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Enterprise details of a Grafana instance</summary>
    public partial class EnterpriseDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal
    {

        /// <summary>Backing field for <see cref="MarketplaceTrialQuota" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota _marketplaceTrialQuota;

        /// <summary>
        /// The allocation details of the per subscription free trial slot of the subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota MarketplaceTrialQuota { get => (this._marketplaceTrialQuota = this._marketplaceTrialQuota ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.MarketplaceTrialQuota()); set => this._marketplaceTrialQuota = value; }

        /// <summary>Available enterprise promotion for the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string MarketplaceTrialQuotaAvailablePromotion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).AvailablePromotion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).AvailablePromotion = value ?? null; }

        /// <summary>Resource Id of the Grafana resource which is doing the trial.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string MarketplaceTrialQuotaGrafanaResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).GrafanaResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).GrafanaResourceId = value ?? null; }

        /// <summary>The date and time in UTC of when the trial ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public global::System.DateTime? MarketplaceTrialQuotaTrialEndAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).TrialEndAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).TrialEndAt = value ?? default(global::System.DateTime); }

        /// <summary>The date and time in UTC of when the trial starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public global::System.DateTime? MarketplaceTrialQuotaTrialStartAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).TrialStartAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal)MarketplaceTrialQuota).TrialStartAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for MarketplaceTrialQuota</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal.MarketplaceTrialQuota { get => (this._marketplaceTrialQuota = this._marketplaceTrialQuota ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.MarketplaceTrialQuota()); set { {_marketplaceTrialQuota = value;} } }

        /// <summary>Internal Acessors for SaaSubscriptionDetailTerm</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal.SaaSubscriptionDetailTerm { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).Term; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).Term = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SaasSubscriptionDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseDetailsInternal.SaasSubscriptionDetail { get => (this._saasSubscriptionDetail = this._saasSubscriptionDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SaasSubscriptionDetails()); set { {_saasSubscriptionDetail = value;} } }

        /// <summary>The offer Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SaaSubscriptionDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).OfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).OfferId = value ?? null; }

        /// <summary>The plan Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SaaSubscriptionDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).PlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).PlanId = value ?? null; }

        /// <summary>The publisher Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SaaSubscriptionDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).PublisherId = value ?? null; }

        /// <summary>Backing field for <see cref="SaasSubscriptionDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails _saasSubscriptionDetail;

        /// <summary>SaaS subscription details of a Grafana instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails SaasSubscriptionDetail { get => (this._saasSubscriptionDetail = this._saasSubscriptionDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SaasSubscriptionDetails()); set => this._saasSubscriptionDetail = value; }

        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public global::System.DateTime? TermEndDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).TermEndDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).TermEndDate = value ?? default(global::System.DateTime); }

        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public global::System.DateTime? TermStartDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).TermStartDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).TermStartDate = value ?? default(global::System.DateTime); }

        /// <summary>The unit of the billing term.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string TermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).TermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal)SaasSubscriptionDetail).TermUnit = value ?? null; }

        /// <summary>Creates an new <see cref="EnterpriseDetails" /> instance.</summary>
        public EnterpriseDetails()
        {

        }
    }
    /// Enterprise details of a Grafana instance
    public partial interface IEnterpriseDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Available enterprise promotion for the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Available enterprise promotion for the subscription",
        SerializedName = @"availablePromotion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("None", "FreeTrial")]
        string MarketplaceTrialQuotaAvailablePromotion { get; set; }
        /// <summary>Resource Id of the Grafana resource which is doing the trial.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id of the Grafana resource which is doing the trial.",
        SerializedName = @"grafanaResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceTrialQuotaGrafanaResourceId { get; set; }
        /// <summary>The date and time in UTC of when the trial ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The date and time in UTC of when the trial ends.",
        SerializedName = @"trialEndAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MarketplaceTrialQuotaTrialEndAt { get; set; }
        /// <summary>The date and time in UTC of when the trial starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The date and time in UTC of when the trial starts.",
        SerializedName = @"trialStartAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MarketplaceTrialQuotaTrialStartAt { get; set; }
        /// <summary>The offer Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The offer Id of the SaaS subscription.",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string SaaSubscriptionDetailOfferId { get; set; }
        /// <summary>The plan Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The plan Id of the SaaS subscription.",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string SaaSubscriptionDetailPlanId { get; set; }
        /// <summary>The publisher Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The publisher Id of the SaaS subscription.",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string SaaSubscriptionDetailPublisherId { get; set; }
        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The date and time in UTC of when the billing term ends.",
        SerializedName = @"endDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TermEndDate { get; set; }
        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The date and time in UTC of when the billing term starts.",
        SerializedName = @"startDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TermStartDate { get; set; }
        /// <summary>The unit of the billing term.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The unit of the billing term.",
        SerializedName = @"termUnit",
        PossibleTypes = new [] { typeof(string) })]
        string TermUnit { get; set; }

    }
    /// Enterprise details of a Grafana instance
    internal partial interface IEnterpriseDetailsInternal

    {
        /// <summary>
        /// The allocation details of the per subscription free trial slot of the subscription.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota MarketplaceTrialQuota { get; set; }
        /// <summary>Available enterprise promotion for the subscription</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("None", "FreeTrial")]
        string MarketplaceTrialQuotaAvailablePromotion { get; set; }
        /// <summary>Resource Id of the Grafana resource which is doing the trial.</summary>
        string MarketplaceTrialQuotaGrafanaResourceId { get; set; }
        /// <summary>The date and time in UTC of when the trial ends.</summary>
        global::System.DateTime? MarketplaceTrialQuotaTrialEndAt { get; set; }
        /// <summary>The date and time in UTC of when the trial starts.</summary>
        global::System.DateTime? MarketplaceTrialQuotaTrialStartAt { get; set; }
        /// <summary>The offer Id of the SaaS subscription.</summary>
        string SaaSubscriptionDetailOfferId { get; set; }
        /// <summary>The plan Id of the SaaS subscription.</summary>
        string SaaSubscriptionDetailPlanId { get; set; }
        /// <summary>The publisher Id of the SaaS subscription.</summary>
        string SaaSubscriptionDetailPublisherId { get; set; }
        /// <summary>The billing term of the SaaS Subscription.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm SaaSubscriptionDetailTerm { get; set; }
        /// <summary>SaaS subscription details of a Grafana instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails SaasSubscriptionDetail { get; set; }
        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        global::System.DateTime? TermEndDate { get; set; }
        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        global::System.DateTime? TermStartDate { get; set; }
        /// <summary>The unit of the billing term.</summary>
        string TermUnit { get; set; }

    }
}