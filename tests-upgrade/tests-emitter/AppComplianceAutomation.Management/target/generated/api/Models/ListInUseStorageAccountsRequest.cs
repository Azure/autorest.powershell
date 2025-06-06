// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>
    /// Parameters for listing in use storage accounts operation. If subscription list is null, it will check the user's all subscriptions.
    /// </summary>
    public partial class ListInUseStorageAccountsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IListInUseStorageAccountsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IListInUseStorageAccountsRequestInternal
    {

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private System.Collections.Generic.List<string> _subscriptionId;

        /// <summary>
        /// List of subscription ids to be query. If the list is null or empty, the API will query all the subscriptions of the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="ListInUseStorageAccountsRequest" /> instance.</summary>
        public ListInUseStorageAccountsRequest()
        {

        }
    }
    /// Parameters for listing in use storage accounts operation. If subscription list is null, it will check the user's all subscriptions.
    public partial interface IListInUseStorageAccountsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of subscription ids to be query. If the list is null or empty, the API will query all the subscriptions of the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of subscription ids to be query. If the list is null or empty, the API will query all the subscriptions of the user.",
        SerializedName = @"subscriptionIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
    /// Parameters for listing in use storage accounts operation. If subscription list is null, it will check the user's all subscriptions.
    internal partial interface IListInUseStorageAccountsRequestInternal

    {
        /// <summary>
        /// List of subscription ids to be query. If the list is null or empty, the API will query all the subscriptions of the user.
        /// </summary>
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
}