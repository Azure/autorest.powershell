// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The agents will run on Virtual Machine Scale Sets.</summary>
    public partial class VmssFabricProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile __fabricProfile = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.FabricProfile();

        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage> _image;

        /// <summary>The VM images of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage> Image { get => this._image; set => this._image = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind= @"Vmss";

        /// <summary>Virtual Machine Scale Sets</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal.Kind { get => this._kind; set { {_kind = value;} } }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal.NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.NetworkProfile()); set { {_networkProfile = value;} } }

        /// <summary>Internal Acessors for OSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal.OSProfile { get => (this._oSProfile = this._oSProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfile()); set { {_oSProfile = value;} } }

        /// <summary>Internal Acessors for OSProfileSecretsManagementSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal.OSProfileSecretsManagementSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretsManagementSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretsManagementSetting = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.DevOpsAzureSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for StorageProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal.StorageProfile { get => (this._storageProfile = this._storageProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.StorageProfile()); set { {_storageProfile = value;} } }

        /// <summary>Backing field for <see cref="NetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfile _networkProfile;

        /// <summary>The network profile of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfile NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.NetworkProfile()); set => this._networkProfile = value; }

        /// <summary>The subnet id on which to put all machines created in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string NetworkProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfileInternal)NetworkProfile).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfileInternal)NetworkProfile).SubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="OSProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile _oSProfile;

        /// <summary>The OS profile of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile OSProfile { get => (this._oSProfile = this._oSProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfile()); set => this._oSProfile = value; }

        /// <summary>
        /// Determines how the service should be run. By default, this will be set to Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string OSProfileLogonType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).LogonType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).LogonType = value ?? null; }

        /// <summary>Where to store certificates on the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string SecretManagementSettingCertificateStoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretManagementSettingCertificateStoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretManagementSettingCertificateStoreLocation = value ?? null; }

        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public bool? SecretManagementSettingKeyExportable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretManagementSettingKeyExportable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretManagementSettingKeyExportable = value ?? default(bool); }

        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SecretManagementSettingObservedCertificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretManagementSettingObservedCertificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)OSProfile).SecretManagementSettingObservedCertificate = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku _sku;

        /// <summary>The Azure SKU of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.DevOpsAzureSku()); set => this._sku = value; }

        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSkuInternal)Sku).Name = value ; }

        /// <summary>Backing field for <see cref="StorageProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile _storageProfile;

        /// <summary>The storage profile of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile StorageProfile { get => (this._storageProfile = this._storageProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.StorageProfile()); set => this._storageProfile = value; }

        /// <summary>A list of empty data disks to attach.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> StorageProfileDataDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfileInternal)StorageProfile).DataDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfileInternal)StorageProfile).DataDisk = value ?? null /* arrayOf */; }

        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string StorageProfileOSDiskStorageAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfileInternal)StorageProfile).OSDiskStorageAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfileInternal)StorageProfile).OSDiskStorageAccountType = value ?? null; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fabricProfile), __fabricProfile);
            await eventListener.AssertObjectIsValid(nameof(__fabricProfile), __fabricProfile);
        }

        /// <summary>Creates an new <see cref="VmssFabricProfile" /> instance.</summary>
        public VmssFabricProfile()
        {

        }
    }
    /// The agents will run on Virtual Machine Scale Sets.
    public partial interface IVmssFabricProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile
    {
        /// <summary>The VM images of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VM images of the machines in the pool.",
        SerializedName = @"images",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage> Image { get; set; }
        /// <summary>Virtual Machine Scale Sets</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual Machine Scale Sets",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get;  }
        /// <summary>The subnet id on which to put all machines created in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subnet id on which to put all machines created in the pool.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileSubnetId { get; set; }
        /// <summary>
        /// Determines how the service should be run. By default, this will be set to Service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines how the service should be run. By default, this will be set to Service.",
        SerializedName = @"logonType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Service", "Interactive")]
        string OSProfileLogonType { get; set; }
        /// <summary>Where to store certificates on the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Where to store certificates on the machine.",
        SerializedName = @"certificateStoreLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SecretManagementSettingCertificateStoreLocation { get; set; }
        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines if the key of the certificates should be exportable.",
        SerializedName = @"keyExportable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecretManagementSettingKeyExportable { get; set; }
        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of certificates to install on all machines in the pool.",
        SerializedName = @"observedCertificates",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SecretManagementSettingObservedCertificate { get; set; }
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure SKU name of the machines in the pool.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>A list of empty data disks to attach.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of empty data disks to attach.",
        SerializedName = @"dataDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> StorageProfileDataDisk { get; set; }
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure SKU name of the machines in the pool.",
        SerializedName = @"osDiskStorageAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Standard", "Premium", "StandardSSD")]
        string StorageProfileOSDiskStorageAccountType { get; set; }

    }
    /// The agents will run on Virtual Machine Scale Sets.
    internal partial interface IVmssFabricProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal
    {
        /// <summary>The VM images of the machines in the pool.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage> Image { get; set; }
        /// <summary>Virtual Machine Scale Sets</summary>
        string Kind { get; set; }
        /// <summary>The network profile of the machines in the pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfile NetworkProfile { get; set; }
        /// <summary>The subnet id on which to put all machines created in the pool.</summary>
        string NetworkProfileSubnetId { get; set; }
        /// <summary>The OS profile of the machines in the pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile OSProfile { get; set; }
        /// <summary>
        /// Determines how the service should be run. By default, this will be set to Service.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Service", "Interactive")]
        string OSProfileLogonType { get; set; }
        /// <summary>The secret management settings of the machines in the pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings OSProfileSecretsManagementSetting { get; set; }
        /// <summary>Where to store certificates on the machine.</summary>
        string SecretManagementSettingCertificateStoreLocation { get; set; }
        /// <summary>Defines if the key of the certificates should be exportable.</summary>
        bool? SecretManagementSettingKeyExportable { get; set; }
        /// <summary>The list of certificates to install on all machines in the pool.</summary>
        System.Collections.Generic.List<string> SecretManagementSettingObservedCertificate { get; set; }
        /// <summary>The Azure SKU of the machines in the pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku Sku { get; set; }
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        string SkuName { get; set; }
        /// <summary>The storage profile of the machines in the pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile StorageProfile { get; set; }
        /// <summary>A list of empty data disks to attach.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk> StorageProfileDataDisk { get; set; }
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Standard", "Premium", "StandardSSD")]
        string StorageProfileOSDiskStorageAccountType { get; set; }

    }
}