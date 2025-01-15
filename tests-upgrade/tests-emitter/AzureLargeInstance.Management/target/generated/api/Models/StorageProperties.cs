// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>described the storage properties of the azure large storage instance</summary>
    public partial class StorageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Generation" /> property.</summary>
        private string _generation;

        /// <summary>the kind of storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string Generation { get => this._generation; set => this._generation = value; }

        /// <summary>Backing field for <see cref="HardwareType" /> property.</summary>
        private string _hardwareType;

        /// <summary>the hardware type of the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string HardwareType { get => this._hardwareType; set => this._hardwareType = value; }

        /// <summary>Internal Acessors for StorageBillingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal.StorageBillingProperty { get => (this._storageBillingProperty = this._storageBillingProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingProperties()); set { {_storageBillingProperty = value;} } }

        /// <summary>Backing field for <see cref="OfferingType" /> property.</summary>
        private string _offeringType;

        /// <summary>the offering type for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string OfferingType { get => this._offeringType; set => this._offeringType = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="StorageBillingProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties _storageBillingProperty;

        /// <summary>the billing related information for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties StorageBillingProperty { get => (this._storageBillingProperty = this._storageBillingProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingProperties()); set => this._storageBillingProperty = value; }

        /// <summary>the billing mode for the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageBillingPropertyBillingMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingPropertiesInternal)StorageBillingProperty).BillingMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingPropertiesInternal)StorageBillingProperty).BillingMode = value ?? null; }

        /// <summary>the SKU type that is provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageBillingPropertySku { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingPropertiesInternal)StorageBillingProperty).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingPropertiesInternal)StorageBillingProperty).Sku = value ?? null; }

        /// <summary>Backing field for <see cref="StorageType" /> property.</summary>
        private string _storageType;

        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string StorageType { get => this._storageType; set => this._storageType = value; }

        /// <summary>Backing field for <see cref="WorkloadType" /> property.</summary>
        private string _workloadType;

        /// <summary>the workload for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string WorkloadType { get => this._workloadType; set => this._workloadType = value; }

        /// <summary>Creates an new <see cref="StorageProperties" /> instance.</summary>
        public StorageProperties()
        {

        }
    }
    /// described the storage properties of the azure large storage instance
    public partial interface IStorageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>the kind of storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the kind of storage instance",
        SerializedName = @"generation",
        PossibleTypes = new [] { typeof(string) })]
        string Generation { get; set; }
        /// <summary>the hardware type of the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the hardware type of the storage instance",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareType { get; set; }
        /// <summary>the offering type for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the offering type for which the resource is getting provisioned",
        SerializedName = @"offeringType",
        PossibleTypes = new [] { typeof(string) })]
        string OfferingType { get; set; }
        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of provisioning of the AzureLargeStorageInstance",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Canceled", "Migrating")]
        string ProvisioningState { get; set; }
        /// <summary>the billing mode for the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the billing mode for the storage instance",
        SerializedName = @"billingMode",
        PossibleTypes = new [] { typeof(string) })]
        string StorageBillingPropertyBillingMode { get; set; }
        /// <summary>the SKU type that is provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the SKU type that is provisioned",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string StorageBillingPropertySku { get; set; }
        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the storage protocol for which the resource is getting provisioned",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        string StorageType { get; set; }
        /// <summary>the workload for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the workload for which the resource is getting provisioned",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        string WorkloadType { get; set; }

    }
    /// described the storage properties of the azure large storage instance
    internal partial interface IStoragePropertiesInternal

    {
        /// <summary>the kind of storage instance</summary>
        string Generation { get; set; }
        /// <summary>the hardware type of the storage instance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareType { get; set; }
        /// <summary>the offering type for which the resource is getting provisioned</summary>
        string OfferingType { get; set; }
        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Canceled", "Migrating")]
        string ProvisioningState { get; set; }
        /// <summary>the billing related information for the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties StorageBillingProperty { get; set; }
        /// <summary>the billing mode for the storage instance</summary>
        string StorageBillingPropertyBillingMode { get; set; }
        /// <summary>the SKU type that is provisioned</summary>
        string StorageBillingPropertySku { get; set; }
        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        string StorageType { get; set; }
        /// <summary>the workload for which the resource is getting provisioned</summary>
        string WorkloadType { get; set; }

    }
}