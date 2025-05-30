// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>
    /// Parameters for listing in use storage accounts operation. If subscription list is null, it will check the user's all subscriptions.
    /// </summary>
    public partial class ListInUseStorageAccountsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IListInUseStorageAccountsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IListInUseStorageAccountsResponseInternal
    {

        /// <summary>Backing field for <see cref="StorageAccountList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo> _storageAccountList;

        /// <summary>The storage account list which in use in related reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo> StorageAccountList { get => this._storageAccountList; set => this._storageAccountList = value; }

        /// <summary>Creates an new <see cref="ListInUseStorageAccountsResponse" /> instance.</summary>
        public ListInUseStorageAccountsResponse()
        {

        }
    }
    /// Parameters for listing in use storage accounts operation. If subscription list is null, it will check the user's all subscriptions.
    public partial interface IListInUseStorageAccountsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The storage account list which in use in related reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The storage account list which in use in related reports.",
        SerializedName = @"storageAccountList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo> StorageAccountList { get; set; }

    }
    /// Parameters for listing in use storage accounts operation. If subscription list is null, it will check the user's all subscriptions.
    internal partial interface IListInUseStorageAccountsResponseInternal

    {
        /// <summary>The storage account list which in use in related reports.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo> StorageAccountList { get; set; }

    }
}