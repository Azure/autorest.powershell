// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Import disk details</summary>
    public partial class ImportDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IImportDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IImportDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="BackupManifestCloudPath" /> property.</summary>
        private string _backupManifestCloudPath;

        /// <summary>Path to backed up manifest, only returned if enableManifestBackup is true.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string BackupManifestCloudPath { get => this._backupManifestCloudPath; }

        /// <summary>Backing field for <see cref="BitLockerKey" /> property.</summary>
        private System.Security.SecureString _bitLockerKey;

        /// <summary>BitLocker key used to encrypt the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Security.SecureString BitLockerKey { get => this._bitLockerKey; set => this._bitLockerKey = value; }

        /// <summary>Backing field for <see cref="ManifestFile" /> property.</summary>
        private string _manifestFile;

        /// <summary>The relative path of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ManifestFile { get => this._manifestFile; set => this._manifestFile = value; }

        /// <summary>Backing field for <see cref="ManifestHash" /> property.</summary>
        private string _manifestHash;

        /// <summary>The Base16-encoded MD5 hash of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ManifestHash { get => this._manifestHash; set => this._manifestHash = value; }

        /// <summary>Internal Acessors for BackupManifestCloudPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IImportDiskDetailsInternal.BackupManifestCloudPath { get => this._backupManifestCloudPath; set { {_backupManifestCloudPath = value;} } }

        /// <summary>Creates an new <see cref="ImportDiskDetails" /> instance.</summary>
        public ImportDiskDetails()
        {

        }
    }
    /// Import disk details
    public partial interface IImportDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Path to backed up manifest, only returned if enableManifestBackup is true.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Path to backed up manifest, only returned if enableManifestBackup is true.",
        SerializedName = @"backupManifestCloudPath",
        PossibleTypes = new [] { typeof(string) })]
        string BackupManifestCloudPath { get;  }
        /// <summary>BitLocker key used to encrypt the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"BitLocker key used to encrypt the disk.",
        SerializedName = @"bitLockerKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString BitLockerKey { get; set; }
        /// <summary>The relative path of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The relative path of the manifest file on the disk.",
        SerializedName = @"manifestFile",
        PossibleTypes = new [] { typeof(string) })]
        string ManifestFile { get; set; }
        /// <summary>The Base16-encoded MD5 hash of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Base16-encoded MD5 hash of the manifest file on the disk.",
        SerializedName = @"manifestHash",
        PossibleTypes = new [] { typeof(string) })]
        string ManifestHash { get; set; }

    }
    /// Import disk details
    internal partial interface IImportDiskDetailsInternal

    {
        /// <summary>Path to backed up manifest, only returned if enableManifestBackup is true.</summary>
        string BackupManifestCloudPath { get; set; }
        /// <summary>BitLocker key used to encrypt the disk.</summary>
        System.Security.SecureString BitLockerKey { get; set; }
        /// <summary>The relative path of the manifest file on the disk.</summary>
        string ManifestFile { get; set; }
        /// <summary>The Base16-encoded MD5 hash of the manifest file on the disk.</summary>
        string ManifestHash { get; set; }

    }
}