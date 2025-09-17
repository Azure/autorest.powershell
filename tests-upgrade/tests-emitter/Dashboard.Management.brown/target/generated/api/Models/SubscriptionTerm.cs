// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The current billing term of the SaaS Subscription.</summary>
    public partial class SubscriptionTerm :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal
    {

        /// <summary>Backing field for <see cref="EndDate" /> property.</summary>
        private global::System.DateTime? _endDate;

        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public global::System.DateTime? EndDate { get => this._endDate; set => this._endDate = value; }

        /// <summary>Backing field for <see cref="StartDate" /> property.</summary>
        private global::System.DateTime? _startDate;

        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDate { get => this._startDate; set => this._startDate = value; }

        /// <summary>Backing field for <see cref="TermUnit" /> property.</summary>
        private string _termUnit;

        /// <summary>The unit of the billing term.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string TermUnit { get => this._termUnit; set => this._termUnit = value; }

        /// <summary>Creates an new <see cref="SubscriptionTerm" /> instance.</summary>
        public SubscriptionTerm()
        {

        }
    }
    /// The current billing term of the SaaS Subscription.
    public partial interface ISubscriptionTerm :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
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
        global::System.DateTime? EndDate { get; set; }
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
        global::System.DateTime? StartDate { get; set; }
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
    /// The current billing term of the SaaS Subscription.
    internal partial interface ISubscriptionTermInternal

    {
        /// <summary>The date and time in UTC of when the billing term ends.</summary>
        global::System.DateTime? EndDate { get; set; }
        /// <summary>The date and time in UTC of when the billing term starts.</summary>
        global::System.DateTime? StartDate { get; set; }
        /// <summary>The unit of the billing term.</summary>
        string TermUnit { get; set; }

    }
}