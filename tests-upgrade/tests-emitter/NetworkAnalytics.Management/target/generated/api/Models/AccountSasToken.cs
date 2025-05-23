// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details of storage account sas token .</summary>
    public partial class AccountSasToken :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasToken,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IAccountSasTokenInternal
    {

        /// <summary>Backing field for <see cref="StorageAccountSasToken" /> property.</summary>
        private System.Security.SecureString _storageAccountSasToken;

        /// <summary>Field to specify storage account sas token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Security.SecureString StorageAccountSasToken { get => this._storageAccountSasToken; set => this._storageAccountSasToken = value; }

        /// <summary>Creates an new <see cref="AccountSasToken" /> instance.</summary>
        public AccountSasToken()
        {

        }
    }
    /// Details of storage account sas token .
    public partial interface IAccountSasToken :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Field to specify storage account sas token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field to specify storage account sas token.",
        SerializedName = @"storageAccountSasToken",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString StorageAccountSasToken { get; set; }

    }
    /// Details of storage account sas token .
    internal partial interface IAccountSasTokenInternal

    {
        /// <summary>Field to specify storage account sas token.</summary>
        System.Security.SecureString StorageAccountSasToken { get; set; }

    }
}