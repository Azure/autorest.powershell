// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Import source related properties.</summary>
    public partial class ImportSourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DataDirPath" /> property.</summary>
        private string _dataDirPath;

        /// <summary>Relative path of data directory in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string DataDirPath { get => this._dataDirPath; set => this._dataDirPath = value; }

        /// <summary>Backing field for <see cref="SasToken" /> property.</summary>
        private System.Security.SecureString _sasToken;

        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Security.SecureString SasToken { get => this._sasToken; set => this._sasToken = value; }

        /// <summary>Backing field for <see cref="StorageType" /> property.</summary>
        private string _storageType;

        /// <summary>Storage type of import source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string StorageType { get => this._storageType; set => this._storageType = value; }

        /// <summary>Backing field for <see cref="StorageUrl" /> property.</summary>
        private string _storageUrl;

        /// <summary>Uri of the import source storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string StorageUrl { get => this._storageUrl; set => this._storageUrl = value; }

        /// <summary>Creates an new <see cref="ImportSourceProperties" /> instance.</summary>
        public ImportSourceProperties()
        {

        }
    }
    /// Import source related properties.
    public partial interface IImportSourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Relative path of data directory in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Relative path of data directory in storage.",
        SerializedName = @"dataDirPath",
        PossibleTypes = new [] { typeof(string) })]
        string DataDirPath { get; set; }
        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Sas token for accessing source storage. Read and list permissions are required for sas token.",
        SerializedName = @"sasToken",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString SasToken { get; set; }
        /// <summary>Storage type of import source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Storage type of import source.",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureBlob")]
        string StorageType { get; set; }
        /// <summary>Uri of the import source storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Uri of the import source storage.",
        SerializedName = @"storageUrl",
        PossibleTypes = new [] { typeof(string) })]
        string StorageUrl { get; set; }

    }
    /// Import source related properties.
    internal partial interface IImportSourcePropertiesInternal

    {
        /// <summary>Relative path of data directory in storage.</summary>
        string DataDirPath { get; set; }
        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        System.Security.SecureString SasToken { get; set; }
        /// <summary>Storage type of import source.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureBlob")]
        string StorageType { get; set; }
        /// <summary>Uri of the import source storage.</summary>
        string StorageUrl { get; set; }

    }
}