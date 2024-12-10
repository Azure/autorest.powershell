// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The storage profile of the VMSS.</summary>
    public partial class StorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfileInternal
    {

        /// <summary>Backing field for <see cref="DataDisk" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> _dataDisk;

        /// <summary>A list of empty data disks to attach.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> DataDisk { get => this._dataDisk; set => this._dataDisk = value; }

        /// <summary>Backing field for <see cref="OSDiskStorageAccountType" /> property.</summary>
        private string _oSDiskStorageAccountType;

        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string OSDiskStorageAccountType { get => this._oSDiskStorageAccountType; set => this._oSDiskStorageAccountType = value; }

        /// <summary>Creates an new <see cref="StorageProfile" /> instance.</summary>
        public StorageProfile()
        {

        }
    }
    /// The storage profile of the VMSS.
    public partial interface IStorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>A list of empty data disks to attach.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of empty data disks to attach.",
        SerializedName = @"dataDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> DataDisk { get; set; }
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure SKU name of the machines in the pool.",
        SerializedName = @"osDiskStorageAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Standard", "Premium", "StandardSSD")]
        string OSDiskStorageAccountType { get; set; }

    }
    /// The storage profile of the VMSS.
    internal partial interface IStorageProfileInternal

    {
        /// <summary>A list of empty data disks to attach.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> DataDisk { get; set; }
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Standard", "Premium", "StandardSSD")]
        string OSDiskStorageAccountType { get; set; }

    }
}