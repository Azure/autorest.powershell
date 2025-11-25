// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Details to transfer all data.</summary>
    public partial class TransferAllDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetailsInternal
    {

        /// <summary>Backing field for <see cref="DataAccountType" /> property.</summary>
        private string _dataAccountType;

        /// <summary>Type of the account of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DataAccountType { get => this._dataAccountType; set => this._dataAccountType = value; }

        /// <summary>Backing field for <see cref="TransferAllBlob" /> property.</summary>
        private bool? _transferAllBlob;

        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? TransferAllBlob { get => this._transferAllBlob; set => this._transferAllBlob = value; }

        /// <summary>Backing field for <see cref="TransferAllFile" /> property.</summary>
        private bool? _transferAllFile;

        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? TransferAllFile { get => this._transferAllFile; set => this._transferAllFile = value; }

        /// <summary>Creates an new <see cref="TransferAllDetails" /> instance.</summary>
        public TransferAllDetails()
        {

        }
    }
    /// Details to transfer all data.
    public partial interface ITransferAllDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Type of the account of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the account of data",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To indicate if all Azure blobs have to be transferred",
        SerializedName = @"transferAllBlobs",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TransferAllBlob { get; set; }
        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To indicate if all Azure Files have to be transferred",
        SerializedName = @"transferAllFiles",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TransferAllFile { get; set; }

    }
    /// Details to transfer all data.
    internal partial interface ITransferAllDetailsInternal

    {
        /// <summary>Type of the account of data</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        bool? TransferAllBlob { get; set; }
        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        bool? TransferAllFile { get; set; }

    }
}