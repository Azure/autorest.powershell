// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Describes the properties of an AzureLargeStorageInstance.</summary>
    public partial class AzureLargeStorageInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal
    {

        /// <summary>
        /// Backing field for <see cref="AzureLargeStorageInstanceUniqueIdentifier" /> property.
        /// </summary>
        private string _azureLargeStorageInstanceUniqueIdentifier;

        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string AzureLargeStorageInstanceUniqueIdentifier { get => this._azureLargeStorageInstanceUniqueIdentifier; set => this._azureLargeStorageInstanceUniqueIdentifier = value; }

        /// <summary>Internal Acessors for StorageProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal.StorageProperty { get => (this._storageProperty = this._storageProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProperties()); set { {_storageProperty = value;} } }

        /// <summary>Internal Acessors for StoragePropertyStorageBillingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal.StoragePropertyStorageBillingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageBillingProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageBillingProperty = value; }

        /// <summary>the billing mode for the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageBillingPropertyBillingMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageBillingPropertyBillingMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageBillingPropertyBillingMode = value ?? null; }

        /// <summary>the SKU type that is provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageBillingPropertySku { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageBillingPropertySku; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageBillingPropertySku = value ?? null; }

        /// <summary>Backing field for <see cref="StorageProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties _storageProperty;

        /// <summary>Specifies the storage properties for the AzureLargeStorage instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties StorageProperty { get => (this._storageProperty = this._storageProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProperties()); set => this._storageProperty = value; }

        /// <summary>the kind of storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyGeneration { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).Generation; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).Generation = value ?? null; }

        /// <summary>the hardware type of the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyHardwareType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).HardwareType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).HardwareType = value ?? null; }

        /// <summary>the offering type for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyOfferingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).OfferingType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).OfferingType = value ?? null; }

        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).ProvisioningState = value ?? null; }

        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyStorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).StorageType = value ?? null; }

        /// <summary>the workload for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyWorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).WorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)StorageProperty).WorkloadType = value ?? null; }

        /// <summary>Creates an new <see cref="AzureLargeStorageInstanceProperties" /> instance.</summary>
        public AzureLargeStorageInstanceProperties()
        {

        }
    }
    /// Describes the properties of an AzureLargeStorageInstance.
    public partial interface IAzureLargeStorageInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the AzureLargeStorageInstance unique ID.",
        SerializedName = @"azureLargeStorageInstanceUniqueIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string AzureLargeStorageInstanceUniqueIdentifier { get; set; }
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
        string StoragePropertyGeneration { get; set; }
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
        string StoragePropertyHardwareType { get; set; }
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
        string StoragePropertyOfferingType { get; set; }
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
        string StoragePropertyProvisioningState { get; set; }
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
        string StoragePropertyStorageType { get; set; }
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
        string StoragePropertyWorkloadType { get; set; }

    }
    /// Describes the properties of an AzureLargeStorageInstance.
    internal partial interface IAzureLargeStorageInstancePropertiesInternal

    {
        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        string AzureLargeStorageInstanceUniqueIdentifier { get; set; }
        /// <summary>the billing mode for the storage instance</summary>
        string StorageBillingPropertyBillingMode { get; set; }
        /// <summary>the SKU type that is provisioned</summary>
        string StorageBillingPropertySku { get; set; }
        /// <summary>Specifies the storage properties for the AzureLargeStorage instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties StorageProperty { get; set; }
        /// <summary>the kind of storage instance</summary>
        string StoragePropertyGeneration { get; set; }
        /// <summary>the hardware type of the storage instance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string StoragePropertyHardwareType { get; set; }
        /// <summary>the offering type for which the resource is getting provisioned</summary>
        string StoragePropertyOfferingType { get; set; }
        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Canceled", "Migrating")]
        string StoragePropertyProvisioningState { get; set; }
        /// <summary>the billing related information for the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties StoragePropertyStorageBillingProperty { get; set; }
        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        string StoragePropertyStorageType { get; set; }
        /// <summary>the workload for which the resource is getting provisioned</summary>
        string StoragePropertyWorkloadType { get; set; }

    }
}