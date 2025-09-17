// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>SaaS subscription details of a Grafana instance</summary>
    public partial class SaasSubscriptionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal
    {

        /// <summary>Internal Acessors for Term</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISaasSubscriptionDetailsInternal.Term { get => (this._term = this._term ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTerm()); set { {_term = value;} } }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>The offer Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        /// <summary>The plan Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>The publisher Id of the SaaS subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; set => this._publisherId = value; }

        /// <summary>Backing field for <see cref="Term" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm _term;

        /// <summary>The billing term of the SaaS Subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm Term { get => (this._term = this._term ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTerm()); set => this._term = value; }

        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public global::System.DateTime? TermEndDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)Term).EndDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)Term).EndDate = value ?? default(global::System.DateTime); }

        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public global::System.DateTime? TermStartDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)Term).StartDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)Term).StartDate = value ?? default(global::System.DateTime); }

        /// <summary>The unit of the billing term.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string TermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)Term).TermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)Term).TermUnit = value ?? null; }

        /// <summary>Creates an new <see cref="SaasSubscriptionDetails" /> instance.</summary>
        public SaasSubscriptionDetails()
        {

        }
    }
    /// SaaS subscription details of a Grafana instance
    public partial interface ISaasSubscriptionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
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
        string OfferId { get; set; }
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
        string PlanId { get; set; }
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
        string PublisherId { get; set; }
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
    /// SaaS subscription details of a Grafana instance
    internal partial interface ISaasSubscriptionDetailsInternal

    {
        /// <summary>The offer Id of the SaaS subscription.</summary>
        string OfferId { get; set; }
        /// <summary>The plan Id of the SaaS subscription.</summary>
        string PlanId { get; set; }
        /// <summary>The publisher Id of the SaaS subscription.</summary>
        string PublisherId { get; set; }
        /// <summary>The billing term of the SaaS Subscription.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm Term { get; set; }
        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        global::System.DateTime? TermEndDate { get; set; }
        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        global::System.DateTime? TermStartDate { get; set; }
        /// <summary>The unit of the billing term.</summary>
        string TermUnit { get; set; }

    }
}