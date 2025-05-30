// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The model for updating a storageClass</summary>
    public partial class StorageClassResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResourceUpdateInternal
    {

        /// <summary>The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AccessMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).AccessMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).AccessMode = value ?? null /* arrayOf */; }

        /// <summary>Volume can be expanded or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string AllowVolumeExpansion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).AllowVolumeExpansion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).AllowVolumeExpansion = value ?? null; }

        /// <summary>Allow single data node failure</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string DataResilience { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).DataResilience; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).DataResilience = value ?? null; }

        /// <summary>Failover speed: NA, Slow, Fast</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string FailoverSpeed { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).FailoverSpeed; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).FailoverSpeed = value ?? null; }

        /// <summary>Limitations of the storage class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Limitation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).Limitation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).Limitation = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResourceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassPropertiesUpdate()); set { {_property = value;} } }

        /// <summary>Internal Acessors for TypeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassResourceUpdateInternal.TypeProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypeProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypeProperty = value ?? null /* model class */; }

        /// <summary>Additional mount options</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> MountOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).MountOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).MountOption = value ?? null /* arrayOf */; }

        /// <summary>Performance tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string Performance { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).Performance; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).Performance = value ?? null; }

        /// <summary>
        /// Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public long? Priority { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).Priority; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).Priority = value ?? default(long); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate _property;

        /// <summary>The properties of StorageClass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassPropertiesUpdate()); set => this._property = value; }

        /// <summary>Azure Storage Account Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Security.SecureString TypePropertyAzureStorageAccountKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyAzureStorageAccountKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyAzureStorageAccountKey = value ?? null; }

        /// <summary>Azure Storage Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyAzureStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyAzureStorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyAzureStorageAccountName = value ?? null; }

        /// <summary>The backing storageclass used to create new storageclass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyBackingStorageClassName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyBackingStorageClassName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyBackingStorageClassName = value ?? null; }

        /// <summary>Server domain</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyDomain = value ?? null; }

        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyMountPermission { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyMountPermission; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyMountPermission = value ?? null; }

        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyOnDelete { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyOnDelete; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyOnDelete = value ?? null; }

        /// <summary>Server password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public System.Security.SecureString TypePropertyPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyPassword = value ?? null; }

        /// <summary>NFS Server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyServer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyServer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyServer = value ?? null; }

        /// <summary>NFS share</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyShare; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyShare = value ?? null; }

        /// <summary>SMB Source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertySource = value ?? null; }

        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertySubDir { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertySubDir; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertySubDir = value ?? null; }

        /// <summary>Server username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)Property).TypePropertyUsername = value ?? null; }

        /// <summary>Creates an new <see cref="StorageClassResourceUpdate" /> instance.</summary>
        public StorageClassResourceUpdate()
        {

        }
    }
    /// The model for updating a storageClass
    public partial interface IStorageClassResourceUpdate :
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
    /// The model for updating a storageClass
    internal partial interface IStorageClassResourceUpdateInternal

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
        /// <summary>The properties of StorageClass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate Property { get; set; }
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