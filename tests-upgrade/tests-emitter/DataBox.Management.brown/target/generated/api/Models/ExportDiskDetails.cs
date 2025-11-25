// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Export disk details</summary>
    public partial class ExportDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IExportDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IExportDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="BackupManifestCloudPath" /> property.</summary>
        private string _backupManifestCloudPath;

        /// <summary>Path to backed up manifest, only returned if enableManifestBackup is true.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string BackupManifestCloudPath { get => this._backupManifestCloudPath; }

        /// <summary>Backing field for <see cref="ManifestFile" /> property.</summary>
        private string _manifestFile;

        /// <summary>The relative path of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ManifestFile { get => this._manifestFile; }

        /// <summary>Backing field for <see cref="ManifestHash" /> property.</summary>
        private string _manifestHash;

        /// <summary>The Base16-encoded MD5 hash of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ManifestHash { get => this._manifestHash; }

        /// <summary>Internal Acessors for BackupManifestCloudPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IExportDiskDetailsInternal.BackupManifestCloudPath { get => this._backupManifestCloudPath; set { {_backupManifestCloudPath = value;} } }

        /// <summary>Internal Acessors for ManifestFile</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IExportDiskDetailsInternal.ManifestFile { get => this._manifestFile; set { {_manifestFile = value;} } }

        /// <summary>Internal Acessors for ManifestHash</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IExportDiskDetailsInternal.ManifestHash { get => this._manifestHash; set { {_manifestHash = value;} } }

        /// <summary>Creates an new <see cref="ExportDiskDetails" /> instance.</summary>
        public ExportDiskDetails()
        {

        }
    }
    /// Export disk details
    public partial interface IExportDiskDetails :
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
        /// <summary>The relative path of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The relative path of the manifest file on the disk.",
        SerializedName = @"manifestFile",
        PossibleTypes = new [] { typeof(string) })]
        string ManifestFile { get;  }
        /// <summary>The Base16-encoded MD5 hash of the manifest file on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Base16-encoded MD5 hash of the manifest file on the disk.",
        SerializedName = @"manifestHash",
        PossibleTypes = new [] { typeof(string) })]
        string ManifestHash { get;  }

    }
    /// Export disk details
    internal partial interface IExportDiskDetailsInternal

    {
        /// <summary>Path to backed up manifest, only returned if enableManifestBackup is true.</summary>
        string BackupManifestCloudPath { get; set; }
        /// <summary>The relative path of the manifest file on the disk.</summary>
        string ManifestFile { get; set; }
        /// <summary>The Base16-encoded MD5 hash of the manifest file on the disk.</summary>
        string ManifestHash { get; set; }

    }
}