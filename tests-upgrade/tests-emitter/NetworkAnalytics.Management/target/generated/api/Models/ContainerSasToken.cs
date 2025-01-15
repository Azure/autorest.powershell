// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details of storage container account sas token .</summary>
    public partial class ContainerSasToken :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasToken,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSasTokenInternal
    {

        /// <summary>Backing field for <see cref="StorageContainerSasToken" /> property.</summary>
        private System.Security.SecureString _storageContainerSasToken;

        /// <summary>Field to specify storage container sas token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Security.SecureString StorageContainerSasToken { get => this._storageContainerSasToken; set => this._storageContainerSasToken = value; }

        /// <summary>Creates an new <see cref="ContainerSasToken" /> instance.</summary>
        public ContainerSasToken()
        {

        }
    }
    /// Details of storage container account sas token .
    public partial interface IContainerSasToken :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Field to specify storage container sas token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field to specify storage container sas token.",
        SerializedName = @"storageContainerSasToken",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString StorageContainerSasToken { get; set; }

    }
    /// Details of storage container account sas token .
    internal partial interface IContainerSasTokenInternal

    {
        /// <summary>Field to specify storage container sas token.</summary>
        System.Security.SecureString StorageContainerSasToken { get; set; }

    }
}