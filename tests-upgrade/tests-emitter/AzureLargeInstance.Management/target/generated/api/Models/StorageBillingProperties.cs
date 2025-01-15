// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Describes the billing related details of the AzureLargeStorageInstance.</summary>
    public partial class StorageBillingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingPropertiesInternal
    {

        /// <summary>Backing field for <see cref="BillingMode" /> property.</summary>
        private string _billingMode;

        /// <summary>the billing mode for the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string BillingMode { get => this._billingMode; set => this._billingMode = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>the SKU type that is provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Creates an new <see cref="StorageBillingProperties" /> instance.</summary>
        public StorageBillingProperties()
        {

        }
    }
    /// Describes the billing related details of the AzureLargeStorageInstance.
    public partial interface IStorageBillingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
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
        string BillingMode { get; set; }
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
        string Sku { get; set; }

    }
    /// Describes the billing related details of the AzureLargeStorageInstance.
    internal partial interface IStorageBillingPropertiesInternal

    {
        /// <summary>the billing mode for the storage instance</summary>
        string BillingMode { get; set; }
        /// <summary>the SKU type that is provisioned</summary>
        string Sku { get; set; }

    }
}