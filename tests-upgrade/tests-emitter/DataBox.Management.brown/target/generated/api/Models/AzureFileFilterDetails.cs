// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Filter details to transfer Azure files</summary>
    public partial class AzureFileFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal
    {

        /// <summary>Backing field for <see cref="FilePathList" /> property.</summary>
        private System.Collections.Generic.List<string> _filePathList;

        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> FilePathList { get => this._filePathList; set => this._filePathList = value; }

        /// <summary>Backing field for <see cref="FilePrefixList" /> property.</summary>
        private System.Collections.Generic.List<string> _filePrefixList;

        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> FilePrefixList { get => this._filePrefixList; set => this._filePrefixList = value; }

        /// <summary>Backing field for <see cref="FileShareList" /> property.</summary>
        private System.Collections.Generic.List<string> _fileShareList;

        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> FileShareList { get => this._fileShareList; set => this._fileShareList = value; }

        /// <summary>Creates an new <see cref="AzureFileFilterDetails" /> instance.</summary>
        public AzureFileFilterDetails()
        {

        }
    }
    /// Filter details to transfer Azure files
    public partial interface IAzureFileFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of full path of the files to be transferred.",
        SerializedName = @"filePathList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> FilePathList { get; set; }
        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Prefix list of the Azure files to be transferred.",
        SerializedName = @"filePrefixList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> FilePrefixList { get; set; }
        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of file shares to be transferred.",
        SerializedName = @"fileShareList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> FileShareList { get; set; }

    }
    /// Filter details to transfer Azure files
    internal partial interface IAzureFileFilterDetailsInternal

    {
        /// <summary>List of full path of the files to be transferred.</summary>
        System.Collections.Generic.List<string> FilePathList { get; set; }
        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        System.Collections.Generic.List<string> FilePrefixList { get; set; }
        /// <summary>List of file shares to be transferred.</summary>
        System.Collections.Generic.List<string> FileShareList { get; set; }

    }
}