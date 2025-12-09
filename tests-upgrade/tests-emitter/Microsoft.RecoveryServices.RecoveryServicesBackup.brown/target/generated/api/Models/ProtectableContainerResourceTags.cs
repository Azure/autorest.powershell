// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class ProtectableContainerResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectableContainerResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectableContainerResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ProtectableContainerResourceTags" /> instance.</summary>
        public ProtectableContainerResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IProtectableContainerResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IProtectableContainerResourceTagsInternal

    {

    }
}