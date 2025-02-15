// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The model for update a storageClass</summary>
    public partial class StorageClassTypePropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal
    {

        /// <summary>Backing field for <see cref="AzureStorageAccountKey" /> property.</summary>
        private System.Security.SecureString _azureStorageAccountKey;

        /// <summary>Azure Storage Account Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Security.SecureString AzureStorageAccountKey { get => this._azureStorageAccountKey; set => this._azureStorageAccountKey = value; }

        /// <summary>Backing field for <see cref="AzureStorageAccountName" /> property.</summary>
        private string _azureStorageAccountName;

        /// <summary>Azure Storage Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string AzureStorageAccountName { get => this._azureStorageAccountName; set => this._azureStorageAccountName = value; }

        /// <summary>Backing field for <see cref="BackingStorageClassName" /> property.</summary>
        private string _backingStorageClassName;

        /// <summary>The backing storageclass used to create new storageclass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string BackingStorageClassName { get => this._backingStorageClassName; set => this._backingStorageClassName = value; }

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Server domain</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Backing field for <see cref="MountPermission" /> property.</summary>
        private string _mountPermission;

        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string MountPermission { get => this._mountPermission; set => this._mountPermission = value; }

        /// <summary>Backing field for <see cref="OnDelete" /> property.</summary>
        private string _onDelete;

        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string OnDelete { get => this._onDelete; set => this._onDelete = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private System.Security.SecureString _password;

        /// <summary>Server password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Security.SecureString Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private string _server;

        /// <summary>NFS Server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Server { get => this._server; set => this._server = value; }

        /// <summary>Backing field for <see cref="Share" /> property.</summary>
        private string _share;

        /// <summary>NFS share</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Share { get => this._share; set => this._share = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>SMB Source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Backing field for <see cref="SubDir" /> property.</summary>
        private string _subDir;

        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string SubDir { get => this._subDir; set => this._subDir = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>Server username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="StorageClassTypePropertiesUpdate" /> instance.</summary>
        public StorageClassTypePropertiesUpdate()
        {

        }
    }
    /// The model for update a storageClass
    public partial interface IStorageClassTypePropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable
    {
        /// <summary>Azure Storage Account Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure Storage Account Key",
        SerializedName = @"azureStorageAccountKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AzureStorageAccountKey { get; set; }
        /// <summary>Azure Storage Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure Storage Account Name",
        SerializedName = @"azureStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string AzureStorageAccountName { get; set; }
        /// <summary>The backing storageclass used to create new storageclass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The backing storageclass used to create new storageclass",
        SerializedName = @"backingStorageClassName",
        PossibleTypes = new [] { typeof(string) })]
        string BackingStorageClassName { get; set; }
        /// <summary>Server domain</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server domain",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get; set; }
        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount",
        SerializedName = @"mountPermissions",
        PossibleTypes = new [] { typeof(string) })]
        string MountPermission { get; set; }
        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The action to take when a NFS volume is deleted. Default is Delete",
        SerializedName = @"onDelete",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Delete", "Retain")]
        string OnDelete { get; set; }
        /// <summary>Server password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server password",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString Password { get; set; }
        /// <summary>NFS Server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"NFS Server",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        string Server { get; set; }
        /// <summary>NFS share</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"NFS share",
        SerializedName = @"share",
        PossibleTypes = new [] { typeof(string) })]
        string Share { get; set; }
        /// <summary>SMB Source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SMB Source",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sub directory under share. If the sub directory doesn't exist, driver will create it",
        SerializedName = @"subDir",
        PossibleTypes = new [] { typeof(string) })]
        string SubDir { get; set; }
        /// <summary>Server username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server username",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// The model for update a storageClass
    internal partial interface IStorageClassTypePropertiesUpdateInternal

    {
        /// <summary>Azure Storage Account Key</summary>
        System.Security.SecureString AzureStorageAccountKey { get; set; }
        /// <summary>Azure Storage Account Name</summary>
        string AzureStorageAccountName { get; set; }
        /// <summary>The backing storageclass used to create new storageclass</summary>
        string BackingStorageClassName { get; set; }
        /// <summary>Server domain</summary>
        string Domain { get; set; }
        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        string MountPermission { get; set; }
        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Delete", "Retain")]
        string OnDelete { get; set; }
        /// <summary>Server password</summary>
        System.Security.SecureString Password { get; set; }
        /// <summary>NFS Server</summary>
        string Server { get; set; }
        /// <summary>NFS share</summary>
        string Share { get; set; }
        /// <summary>SMB Source</summary>
        string Source { get; set; }
        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        string SubDir { get; set; }
        /// <summary>Server username</summary>
        string Username { get; set; }

    }
}