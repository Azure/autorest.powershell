// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace
    /// images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure
    /// portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started. Enter
    /// any required information and then click Save.
    /// </summary>
    public partial class VMImagePlan :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlanInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The plan ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Product" /> property.</summary>
        private string _product;

        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Product { get => this._product; set => this._product = value; }

        /// <summary>Backing field for <see cref="PromotionCode" /> property.</summary>
        private string _promotionCode;

        /// <summary>The promotion code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PromotionCode { get => this._promotionCode; set => this._promotionCode = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Creates an new <see cref="VMImagePlan" /> instance.</summary>
        public VMImagePlan()
        {

        }
    }
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace
    /// images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure
    /// portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started. Enter
    /// any required information and then click Save.
    public partial interface IVMImagePlan :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The plan ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The plan ID.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string Product { get; set; }
        /// <summary>The promotion code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The promotion code.",
        SerializedName = @"promotionCode",
        PossibleTypes = new [] { typeof(string) })]
        string PromotionCode { get; set; }
        /// <summary>The publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The publisher ID.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }

    }
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace
    /// images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure
    /// portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started. Enter
    /// any required information and then click Save.
    internal partial interface IVMImagePlanInternal

    {
        /// <summary>The plan ID.</summary>
        string Name { get; set; }
        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        string Product { get; set; }
        /// <summary>The promotion code.</summary>
        string PromotionCode { get; set; }
        /// <summary>The publisher ID.</summary>
        string Publisher { get; set; }

    }
}