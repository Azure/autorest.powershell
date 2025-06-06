// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>Details of the StorageClass StorageClass.</summary>
    public partial class StorageClassProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesInternal
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

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for TypeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesInternal.TypeProperty { get => (this._typeProperty = this._typeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties()); set { {_typeProperty = value;} } }

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

        /// <summary>Backing field for <see cref="Provisioner" /> property.</summary>
        private string _provisioner;

        /// <summary>Provisioner name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Provisioner { get => this._provisioner; set => this._provisioner = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Resource provision state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="TypeProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties _typeProperty;

        /// <summary>Properties of the StorageClass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties TypeProperty { get => (this._typeProperty = this._typeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties()); set => this._typeProperty = value; }

        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inlined)]
        public string TypePropertyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)TypeProperty).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)TypeProperty).Type = value ?? null; }

        /// <summary>Backing field for <see cref="VolumeBindingMode" /> property.</summary>
        private string _volumeBindingMode;

        /// <summary>Binding mode of volumes: Immediate, WaitForFirstConsumer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string VolumeBindingMode { get => this._volumeBindingMode; set => this._volumeBindingMode = value; }

        /// <summary>Creates an new <see cref="StorageClassProperties" /> instance.</summary>
        public StorageClassProperties()
        {

        }
    }
    /// Details of the StorageClass StorageClass.
    public partial interface IStorageClassProperties :
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
        /// <summary>Provisioner name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Provisioner name",
        SerializedName = @"provisioner",
        PossibleTypes = new [] { typeof(string) })]
        string Provisioner { get; set; }
        /// <summary>Resource provision state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource provision state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Type of the storage class.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Native", "RWX", "Blob", "NFS", "SMB")]
        string TypePropertyType { get; set; }
        /// <summary>Binding mode of volumes: Immediate, WaitForFirstConsumer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Binding mode of volumes: Immediate, WaitForFirstConsumer",
        SerializedName = @"volumeBindingMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Immediate", "WaitForFirstConsumer")]
        string VolumeBindingMode { get; set; }

    }
    /// Details of the StorageClass StorageClass.
    internal partial interface IStorageClassPropertiesInternal

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
        /// <summary>Provisioner name</summary>
        string Provisioner { get; set; }
        /// <summary>Resource provision state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Properties of the StorageClass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties TypeProperty { get; set; }
        /// <summary>Type of the storage class.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Native", "RWX", "Blob", "NFS", "SMB")]
        string TypePropertyType { get; set; }
        /// <summary>Binding mode of volumes: Immediate, WaitForFirstConsumer</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Immediate", "WaitForFirstConsumer")]
        string VolumeBindingMode { get; set; }

    }
}