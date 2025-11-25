// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Filter details to transfer Azure Blobs</summary>
    public partial class BlobFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal
    {

        /// <summary>Backing field for <see cref="BlobPathList" /> property.</summary>
        private System.Collections.Generic.List<string> _blobPathList;

        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> BlobPathList { get => this._blobPathList; set => this._blobPathList = value; }

        /// <summary>Backing field for <see cref="BlobPrefixList" /> property.</summary>
        private System.Collections.Generic.List<string> _blobPrefixList;

        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> BlobPrefixList { get => this._blobPrefixList; set => this._blobPrefixList = value; }

        /// <summary>Backing field for <see cref="ContainerList" /> property.</summary>
        private System.Collections.Generic.List<string> _containerList;

        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ContainerList { get => this._containerList; set => this._containerList = value; }

        /// <summary>Creates an new <see cref="BlobFilterDetails" /> instance.</summary>
        public BlobFilterDetails()
        {

        }
    }
    /// Filter details to transfer Azure Blobs
    public partial interface IBlobFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of full path of the blobs to be transferred.",
        SerializedName = @"blobPathList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Prefix list of the Azure blobs to be transferred.",
        SerializedName = @"blobPrefixList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of blob containers to be transferred.",
        SerializedName = @"containerList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ContainerList { get; set; }

    }
    /// Filter details to transfer Azure Blobs
    internal partial interface IBlobFilterDetailsInternal

    {
        /// <summary>List of full path of the blobs to be transferred.</summary>
        System.Collections.Generic.List<string> BlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        System.Collections.Generic.List<string> BlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        System.Collections.Generic.List<string> ContainerList { get; set; }

    }
}