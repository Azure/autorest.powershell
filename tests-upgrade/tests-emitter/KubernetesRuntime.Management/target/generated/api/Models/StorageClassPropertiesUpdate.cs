// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The model for updating storageClass properties</summary>
    public partial class StorageClassPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal
    {

        /// <summary>Backing field for <see cref="AccessMode" /> property.</summary>
        private System.Collections.Generic.List<string> _accessMode;

        /// <summary>The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AccessMode { get => this._accessMode; set => this._accessMode = value; }

        /// <summary>Backing field for <see cref="AllowVolumeExpansion" /> property.</summary>
        private string _allowVolumeExpansion;

        /// <summary>Volume can be expanded or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string AllowVolumeExpansion { get => this._allowVolumeExpansion; set => this._allowVolumeExpansion = value; }

        /// <summary>Backing field for <see cref="DataResilience" /> property.</summary>
        private string _dataResilience;

        /// <summary>Allow single data node failure</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string DataResilience { get => this._dataResilience; set => this._dataResilience = value; }

        /// <summary>Backing field for <see cref="FailoverSpeed" /> property.</summary>
        private string _failoverSpeed;

        /// <summary>Failover speed: NA, Slow, Fast</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string FailoverSpeed { get => this._failoverSpeed; set => this._failoverSpeed = value; }

        /// <summary>Backing field for <see cref="Limitation" /> property.</summary>
        private System.Collections.Generic.List<string> _limitation;

        /// <summary>Limitations of the storage class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Limitation { get => this._limitation; set => this._limitation = value; }

        /// <summary>Internal Acessors for TypeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal.TypeProperty { get => (this._typeProperty = this._typeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypePropertiesUpdate()); set { {_typeProperty = value;} } }

        /// <summary>Backing field for <see cref="MountOption" /> property.</summary>
        private System.Collections.Generic.List<string> _mountOption;

        /// <summary>Additional mount options</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MountOption { get => this._mountOption; set => this._mountOption = value; }

        /// <summary>Backing field for <see cref="Performance" /> property.</summary>
        private string _performance;

        /// <summary>Performance tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Performance { get => this._performance; set => this._performance = value; }

        /// <summary>Backing field for <see cref="Priority" /> property.</summary>
        private long? _priority;

        /// <summary>
        /// Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public long? Priority { get => this._priority; set => this._priority = value; }

        /// <summary>Backing field for <see cref="TypeProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate _typeProperty;

        /// <summary>New storage class type of storageClass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate TypeProperty { get => (this._typeProperty = this._typeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypePropertiesUpdate()); set => this._typeProperty = value; }

        /// <summary>Azure Storage Account Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Security.SecureString TypePropertyAzureStorageAccountKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).AzureStorageAccountKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).AzureStorageAccountKey = value ?? null; }

        /// <summary>Azure Storage Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyAzureStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).AzureStorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).AzureStorageAccountName = value ?? null; }

        /// <summary>The backing storageclass used to create new storageclass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyBackingStorageClassName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).BackingStorageClassName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).BackingStorageClassName = value ?? null; }

        /// <summary>Server domain</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Domain; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Domain = value ?? null; }

        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyMountPermission { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).MountPermission; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).MountPermission = value ?? null; }

        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyOnDelete { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).OnDelete; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).OnDelete = value ?? null; }

        /// <summary>Server password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Security.SecureString TypePropertyPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Password = value ?? null; }

        /// <summary>NFS Server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyServer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Server; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Server = value ?? null; }

        /// <summary>NFS share</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Share; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Share = value ?? null; }

        /// <summary>SMB Source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Source; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Source = value ?? null; }

        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertySubDir { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).SubDir; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).SubDir = value ?? null; }

        /// <summary>Server username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Username; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdateInternal)TypeProperty).Username = value ?? null; }

        /// <summary>Creates an new <see cref="StorageClassPropertiesUpdate" /> instance.</summary>
        public StorageClassPropertiesUpdate()
        {

        }
    }
    /// The model for updating storageClass properties
    public partial interface IStorageClassPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable
    {
        /// <summary>The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]",
        SerializedName = @"accessModes",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("ReadWriteOnce", "ReadWriteMany")]
        System.Collections.Generic.List<string> AccessMode { get; set; }
        /// <summary>Volume can be expanded or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Volume can be expanded or not",
        SerializedName = @"allowVolumeExpansion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Allow", "Disallow")]
        string AllowVolumeExpansion { get; set; }
        /// <summary>Allow single data node failure</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Allow single data node failure",
        SerializedName = @"dataResilience",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("NotDataResilient", "DataResilient")]
        string DataResilience { get; set; }
        /// <summary>Failover speed: NA, Slow, Fast</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Failover speed: NA, Slow, Fast",
        SerializedName = @"failoverSpeed",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("NotAvailable", "Slow", "Fast", "Super")]
        string FailoverSpeed { get; set; }
        /// <summary>Limitations of the storage class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Limitations of the storage class",
        SerializedName = @"limitations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Limitation { get; set; }
        /// <summary>Additional mount options</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional mount options",
        SerializedName = @"mountOptions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> MountOption { get; set; }
        /// <summary>Performance tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Performance tier",
        SerializedName = @"performance",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Undefined", "Basic", "Standard", "Premium", "Ultra")]
        string Performance { get; set; }
        /// <summary>
        /// Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(long) })]
        long? Priority { get; set; }
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
        System.Security.SecureString TypePropertyAzureStorageAccountKey { get; set; }
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
        string TypePropertyAzureStorageAccountName { get; set; }
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
        string TypePropertyBackingStorageClassName { get; set; }
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
        string TypePropertyDomain { get; set; }
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
        string TypePropertyMountPermission { get; set; }
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
        string TypePropertyOnDelete { get; set; }
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
        System.Security.SecureString TypePropertyPassword { get; set; }
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
        string TypePropertyServer { get; set; }
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
        string TypePropertyShare { get; set; }
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
        string TypePropertySource { get; set; }
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
        string TypePropertySubDir { get; set; }
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
        string TypePropertyUsername { get; set; }

    }
    /// The model for updating storageClass properties
    internal partial interface IStorageClassPropertiesUpdateInternal

    {
        /// <summary>The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("ReadWriteOnce", "ReadWriteMany")]
        System.Collections.Generic.List<string> AccessMode { get; set; }
        /// <summary>Volume can be expanded or not</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Allow", "Disallow")]
        string AllowVolumeExpansion { get; set; }
        /// <summary>Allow single data node failure</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("NotDataResilient", "DataResilient")]
        string DataResilience { get; set; }
        /// <summary>Failover speed: NA, Slow, Fast</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("NotAvailable", "Slow", "Fast", "Super")]
        string FailoverSpeed { get; set; }
        /// <summary>Limitations of the storage class</summary>
        System.Collections.Generic.List<string> Limitation { get; set; }
        /// <summary>Additional mount options</summary>
        System.Collections.Generic.List<string> MountOption { get; set; }
        /// <summary>Performance tier</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Undefined", "Basic", "Standard", "Premium", "Ultra")]
        string Performance { get; set; }
        /// <summary>
        /// Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use
        /// </summary>
        long? Priority { get; set; }
        /// <summary>New storage class type of storageClass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate TypeProperty { get; set; }
        /// <summary>Azure Storage Account Key</summary>
        System.Security.SecureString TypePropertyAzureStorageAccountKey { get; set; }
        /// <summary>Azure Storage Account Name</summary>
        string TypePropertyAzureStorageAccountName { get; set; }
        /// <summary>The backing storageclass used to create new storageclass</summary>
        string TypePropertyBackingStorageClassName { get; set; }
        /// <summary>Server domain</summary>
        string TypePropertyDomain { get; set; }
        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        string TypePropertyMountPermission { get; set; }
        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Delete", "Retain")]
        string TypePropertyOnDelete { get; set; }
        /// <summary>Server password</summary>
        System.Security.SecureString TypePropertyPassword { get; set; }
        /// <summary>NFS Server</summary>
        string TypePropertyServer { get; set; }
        /// <summary>NFS share</summary>
        string TypePropertyShare { get; set; }
        /// <summary>SMB Source</summary>
        string TypePropertySource { get; set; }
        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        string TypePropertySubDir { get; set; }
        /// <summary>Server username</summary>
        string TypePropertyUsername { get; set; }

    }
}