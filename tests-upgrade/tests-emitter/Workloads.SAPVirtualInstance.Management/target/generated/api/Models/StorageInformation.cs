// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Storage details of all the Storage accounts attached to the VM. For e.g. NFS on AFS Shared Storage.
    /// </summary>
    public partial class StorageInformation :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformationInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified resource ID for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformationInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Creates an new <see cref="StorageInformation" /> instance.</summary>
        public StorageInformation()
        {

        }
    }
    /// Storage details of all the Storage accounts attached to the VM. For e.g. NFS on AFS Shared Storage.
    public partial interface IStorageInformation :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Fully qualified resource ID for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Fully qualified resource ID for the storage account.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }

    }
    /// Storage details of all the Storage accounts attached to the VM. For e.g. NFS on AFS Shared Storage.
    internal partial interface IStorageInformationInternal

    {
        /// <summary>Fully qualified resource ID for the storage account.</summary>
        string Id { get; set; }

    }
}