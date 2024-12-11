// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Parameters for onboard operation</summary>
    public partial class OnboardRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOnboardRequest,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IOnboardRequestInternal
    {

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private System.Collections.Generic.List<string> _subscriptionId;

        /// <summary>List of subscription ids to be onboarded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="OnboardRequest" /> instance.</summary>
        public OnboardRequest()
        {

        }
    }
    /// Parameters for onboard operation
    public partial interface IOnboardRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of subscription ids to be onboarded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of subscription ids to be onboarded",
        SerializedName = @"subscriptionIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
    /// Parameters for onboard operation
    internal partial interface IOnboardRequestInternal

    {
        /// <summary>List of subscription ids to be onboarded</summary>
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
}