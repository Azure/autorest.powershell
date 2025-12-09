// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The date encryption for cmk.</summary>
    public partial class DataEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal
    {

        /// <summary>Backing field for <see cref="GeoBackupKeyUri" /> property.</summary>
        private string _geoBackupKeyUri;

        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string GeoBackupKeyUri { get => this._geoBackupKeyUri; set => this._geoBackupKeyUri = value; }

        /// <summary>Backing field for <see cref="GeoBackupUserAssignedIdentityId" /> property.</summary>
        private string _geoBackupUserAssignedIdentityId;

        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string GeoBackupUserAssignedIdentityId { get => this._geoBackupUserAssignedIdentityId; set => this._geoBackupUserAssignedIdentityId = value; }

        /// <summary>Backing field for <see cref="PrimaryKeyUri" /> property.</summary>
        private string _primaryKeyUri;

        /// <summary>Primary key uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string PrimaryKeyUri { get => this._primaryKeyUri; set => this._primaryKeyUri = value; }

        /// <summary>Backing field for <see cref="PrimaryUserAssignedIdentityId" /> property.</summary>
        private string _primaryUserAssignedIdentityId;

        /// <summary>Primary user identity resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string PrimaryUserAssignedIdentityId { get => this._primaryUserAssignedIdentityId; set => this._primaryUserAssignedIdentityId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="DataEncryption" /> instance.</summary>
        public DataEncryption()
        {

        }
    }
    /// The date encryption for cmk.
    public partial interface IDataEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup",
        SerializedName = @"geoBackupKeyURI",
        PossibleTypes = new [] { typeof(string) })]
        string GeoBackupKeyUri { get; set; }
        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup",
        SerializedName = @"geoBackupUserAssignedIdentityId",
        PossibleTypes = new [] { typeof(string) })]
        string GeoBackupUserAssignedIdentityId { get; set; }
        /// <summary>Primary key uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Primary key uri",
        SerializedName = @"primaryKeyURI",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKeyUri { get; set; }
        /// <summary>Primary user identity resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Primary user identity resource id",
        SerializedName = @"primaryUserAssignedIdentityId",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryUserAssignedIdentityId { get; set; }
        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureKeyVault", "SystemManaged")]
        string Type { get; set; }

    }
    /// The date encryption for cmk.
    internal partial interface IDataEncryptionInternal

    {
        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        string GeoBackupKeyUri { get; set; }
        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        string GeoBackupUserAssignedIdentityId { get; set; }
        /// <summary>Primary key uri</summary>
        string PrimaryKeyUri { get; set; }
        /// <summary>Primary user identity resource id</summary>
        string PrimaryUserAssignedIdentityId { get; set; }
        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureKeyVault", "SystemManaged")]
        string Type { get; set; }

    }
}