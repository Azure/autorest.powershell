// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Encapsulates information regarding data directory</summary>
    public partial class SqlDataDirectoryMapping :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMapping,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectoryMappingInternal
    {

        /// <summary>Backing field for <see cref="MappingType" /> property.</summary>
        private string _mappingType;

        /// <summary>Type of data directory mapping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string MappingType { get => this._mappingType; set => this._mappingType = value; }

        /// <summary>Backing field for <see cref="SourceLogicalName" /> property.</summary>
        private string _sourceLogicalName;

        /// <summary>Restore source logical name path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceLogicalName { get => this._sourceLogicalName; set => this._sourceLogicalName = value; }

        /// <summary>Backing field for <see cref="SourcePath" /> property.</summary>
        private string _sourcePath;

        /// <summary>Restore source path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourcePath { get => this._sourcePath; set => this._sourcePath = value; }

        /// <summary>Backing field for <see cref="TargetPath" /> property.</summary>
        private string _targetPath;

        /// <summary>Target path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TargetPath { get => this._targetPath; set => this._targetPath = value; }

        /// <summary>Creates an new <see cref="SqlDataDirectoryMapping" /> instance.</summary>
        public SqlDataDirectoryMapping()
        {

        }
    }
    /// Encapsulates information regarding data directory
    public partial interface ISqlDataDirectoryMapping :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Type of data directory mapping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of data directory mapping",
        SerializedName = @"mappingType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Data", "Log")]
        string MappingType { get; set; }
        /// <summary>Restore source logical name path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Restore source logical name path",
        SerializedName = @"sourceLogicalName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceLogicalName { get; set; }
        /// <summary>Restore source path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Restore source path",
        SerializedName = @"sourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string SourcePath { get; set; }
        /// <summary>Target path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target path",
        SerializedName = @"targetPath",
        PossibleTypes = new [] { typeof(string) })]
        string TargetPath { get; set; }

    }
    /// Encapsulates information regarding data directory
    internal partial interface ISqlDataDirectoryMappingInternal

    {
        /// <summary>Type of data directory mapping</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Data", "Log")]
        string MappingType { get; set; }
        /// <summary>Restore source logical name path</summary>
        string SourceLogicalName { get; set; }
        /// <summary>Restore source path</summary>
        string SourcePath { get; set; }
        /// <summary>Target path</summary>
        string TargetPath { get; set; }

    }
}