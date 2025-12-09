// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class BackupResourceEncryptionConfigResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigResourceTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="BackupResourceEncryptionConfigResourceTags" /> instance.
        /// </summary>
        public BackupResourceEncryptionConfigResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IBackupResourceEncryptionConfigResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IBackupResourceEncryptionConfigResourceTagsInternal

    {

    }
}