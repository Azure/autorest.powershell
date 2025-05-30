// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Success. The response indicates given subscriptions has been onboarded.</summary>
    public partial class OnboardResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOnboardResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOnboardResponseInternal
    {

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private System.Collections.Generic.List<string> _subscriptionId;

        /// <summary>List of subscription ids that are onboarded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="OnboardResponse" /> instance.</summary>
        public OnboardResponse()
        {

        }
    }
    /// Success. The response indicates given subscriptions has been onboarded.
    public partial interface IOnboardResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of subscription ids that are onboarded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of subscription ids that are onboarded",
        SerializedName = @"subscriptionIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
    /// Success. The response indicates given subscriptions has been onboarded.
    internal partial interface IOnboardResponseInternal

    {
        /// <summary>List of subscription ids that are onboarded</summary>
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
}