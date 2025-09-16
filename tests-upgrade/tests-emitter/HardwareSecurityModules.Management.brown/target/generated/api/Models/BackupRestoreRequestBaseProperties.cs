// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Backup and Restore Common properties</summary>
    public partial class BackupRestoreRequestBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBasePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AzureStorageBlobContainerUri" /> property.</summary>
        private string _azureStorageBlobContainerUri;

        /// <summary>The Azure blob storage container Uri which contains the backup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string AzureStorageBlobContainerUri { get => this._azureStorageBlobContainerUri; set => this._azureStorageBlobContainerUri = value; }

        /// <summary>Backing field for <see cref="Token" /> property.</summary>
        private System.Security.SecureString _token;

        /// <summary>
        /// The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public System.Security.SecureString Token { get => this._token; set => this._token = value; }

        /// <summary>Creates an new <see cref="BackupRestoreRequestBaseProperties" /> instance.</summary>
        public BackupRestoreRequestBaseProperties()
        {

        }
    }
    /// Backup and Restore Common properties
    public partial interface IBackupRestoreRequestBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>The Azure blob storage container Uri which contains the backup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure blob storage container Uri which contains the backup",
        SerializedName = @"azureStorageBlobContainerUri",
        PossibleTypes = new [] { typeof(string) })]
        string AzureStorageBlobContainerUri { get; set; }
        /// <summary>
        /// The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service.",
        SerializedName = @"token",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString Token { get; set; }

    }
    /// Backup and Restore Common properties
    internal partial interface IBackupRestoreRequestBasePropertiesInternal

    {
        /// <summary>The Azure blob storage container Uri which contains the backup</summary>
        string AzureStorageBlobContainerUri { get; set; }
        /// <summary>
        /// The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service.
        /// </summary>
        System.Security.SecureString Token { get; set; }

    }
}