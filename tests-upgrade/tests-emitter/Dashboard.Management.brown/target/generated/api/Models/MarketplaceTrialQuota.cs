// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// The allocation details of the per subscription free trial slot of the subscription.
    /// </summary>
    public partial class MarketplaceTrialQuota :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuotaInternal
    {

        /// <summary>Backing field for <see cref="AvailablePromotion" /> property.</summary>
        private string _availablePromotion;

        /// <summary>Available enterprise promotion for the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string AvailablePromotion { get => this._availablePromotion; set => this._availablePromotion = value; }

        /// <summary>Backing field for <see cref="GrafanaResourceId" /> property.</summary>
        private string _grafanaResourceId;

        /// <summary>Resource Id of the Grafana resource which is doing the trial.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string GrafanaResourceId { get => this._grafanaResourceId; set => this._grafanaResourceId = value; }

        /// <summary>Backing field for <see cref="TrialEndAt" /> property.</summary>
        private global::System.DateTime? _trialEndAt;

        /// <summary>The date and time in UTC of when the trial ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public global::System.DateTime? TrialEndAt { get => this._trialEndAt; set => this._trialEndAt = value; }

        /// <summary>Backing field for <see cref="TrialStartAt" /> property.</summary>
        private global::System.DateTime? _trialStartAt;

        /// <summary>The date and time in UTC of when the trial starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public global::System.DateTime? TrialStartAt { get => this._trialStartAt; set => this._trialStartAt = value; }

        /// <summary>Creates an new <see cref="MarketplaceTrialQuota" /> instance.</summary>
        public MarketplaceTrialQuota()
        {

        }
    }
    /// The allocation details of the per subscription free trial slot of the subscription.
    public partial interface IMarketplaceTrialQuota :
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
        string AvailablePromotion { get; set; }
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
        string GrafanaResourceId { get; set; }
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
        global::System.DateTime? TrialEndAt { get; set; }
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
        global::System.DateTime? TrialStartAt { get; set; }

    }
    /// The allocation details of the per subscription free trial slot of the subscription.
    internal partial interface IMarketplaceTrialQuotaInternal

    {
        /// <summary>Available enterprise promotion for the subscription</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("None", "FreeTrial")]
        string AvailablePromotion { get; set; }
        /// <summary>Resource Id of the Grafana resource which is doing the trial.</summary>
        string GrafanaResourceId { get; set; }
        /// <summary>The date and time in UTC of when the trial ends.</summary>
        global::System.DateTime? TrialEndAt { get; set; }
        /// <summary>The date and time in UTC of when the trial starts.</summary>
        global::System.DateTime? TrialStartAt { get; set; }

    }
}