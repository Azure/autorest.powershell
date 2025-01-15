// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Specifies the storage settings for the Azure Large Instance disks.</summary>
    public partial class StorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfileInternal
    {

        /// <summary>Backing field for <see cref="NfsIPAddress" /> property.</summary>
        private string _nfsIPAddress;

        /// <summary>IP Address to connect to storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string NfsIPAddress { get => this._nfsIPAddress; set => this._nfsIPAddress = value; }

        /// <summary>Backing field for <see cref="OSDisk" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> _oSDisk;

        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> OSDisk { get => this._oSDisk; set => this._oSDisk = value; }

        /// <summary>Creates an new <see cref="StorageProfile" /> instance.</summary>
        public StorageProfile()
        {

        }
    }
    /// Specifies the storage settings for the Azure Large Instance disks.
    public partial interface IStorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>IP Address to connect to storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Address to connect to storage.",
        SerializedName = @"nfsIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string NfsIPAddress { get; set; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies information about the operating system disk used by Azure Large
        Instance.",
        SerializedName = @"osDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> OSDisk { get; set; }

    }
    /// Specifies the storage settings for the Azure Large Instance disks.
    internal partial interface IStorageProfileInternal

    {
        /// <summary>IP Address to connect to storage.</summary>
        string NfsIPAddress { get; set; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> OSDisk { get; set; }

    }
}