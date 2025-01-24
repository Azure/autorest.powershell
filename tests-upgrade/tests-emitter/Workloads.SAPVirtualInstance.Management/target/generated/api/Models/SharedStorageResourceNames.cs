// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The resource names object for shared storage.</summary>
    public partial class SharedStorageResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="SharedStorageAccountName" /> property.</summary>
        private string _sharedStorageAccountName;

        /// <summary>
        /// The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SharedStorageAccountName { get => this._sharedStorageAccountName; set => this._sharedStorageAccountName = value; }

        /// <summary>
        /// Backing field for <see cref="SharedStorageAccountPrivateEndPointName" /> property.
        /// </summary>
        private string _sharedStorageAccountPrivateEndPointName;

        /// <summary>
        /// The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SharedStorageAccountPrivateEndPointName { get => this._sharedStorageAccountPrivateEndPointName; set => this._sharedStorageAccountPrivateEndPointName = value; }

        /// <summary>Creates an new <see cref="SharedStorageResourceNames" /> instance.</summary>
        public SharedStorageResourceNames()
        {

        }
    }
    /// The resource names object for shared storage.
    public partial interface ISharedStorageResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.",
        SerializedName = @"sharedStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string SharedStorageAccountName { get; set; }
        /// <summary>
        /// The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe",
        SerializedName = @"sharedStorageAccountPrivateEndPointName",
        PossibleTypes = new [] { typeof(string) })]
        string SharedStorageAccountPrivateEndPointName { get; set; }

    }
    /// The resource names object for shared storage.
    internal partial interface ISharedStorageResourceNamesInternal

    {
        /// <summary>
        /// The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.
        /// </summary>
        string SharedStorageAccountName { get; set; }
        /// <summary>
        /// The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe
        /// </summary>
        string SharedStorageAccountPrivateEndPointName { get; set; }

    }
}