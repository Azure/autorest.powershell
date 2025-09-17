// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Backup properties</summary>
    public partial class BackupRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRequestPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBaseProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBaseProperties __backupRestoreRequestBaseProperties = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupRestoreRequestBaseProperties();

        /// <summary>The Azure blob storage container Uri which contains the backup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string AzureStorageBlobContainerUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBasePropertiesInternal)__backupRestoreRequestBaseProperties).AzureStorageBlobContainerUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBasePropertiesInternal)__backupRestoreRequestBaseProperties).AzureStorageBlobContainerUri = value ; }

        /// <summary>
        /// The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public System.Security.SecureString Token { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBasePropertiesInternal)__backupRestoreRequestBaseProperties).Token; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBasePropertiesInternal)__backupRestoreRequestBaseProperties).Token = value ?? null; }

        /// <summary>Creates an new <see cref="BackupRequestProperties" /> instance.</summary>
        public BackupRequestProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__backupRestoreRequestBaseProperties), __backupRestoreRequestBaseProperties);
            await eventListener.AssertObjectIsValid(nameof(__backupRestoreRequestBaseProperties), __backupRestoreRequestBaseProperties);
        }
    }
    /// Backup properties
    public partial interface IBackupRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBaseProperties
    {

    }
    /// Backup properties
    internal partial interface IBackupRequestPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreRequestBasePropertiesInternal
    {

    }
}