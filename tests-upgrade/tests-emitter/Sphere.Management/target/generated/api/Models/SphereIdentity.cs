// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    public partial class SphereIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISphereIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISphereIdentityInternal
    {

        /// <summary>Backing field for <see cref="CatalogName" /> property.</summary>
        private string _catalogName;

        /// <summary>Name of catalog</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string CatalogName { get => this._catalogName; set => this._catalogName = value; }

        /// <summary>Backing field for <see cref="DeploymentName" /> property.</summary>
        private string _deploymentName;

        /// <summary>
        /// Deployment name. Use .default for deployment creation and to get the current deployment for the associated device group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeploymentName { get => this._deploymentName; set => this._deploymentName = value; }

        /// <summary>Backing field for <see cref="DeviceGroupName" /> property.</summary>
        private string _deviceGroupName;

        /// <summary>Name of device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceGroupName { get => this._deviceGroupName; set => this._deviceGroupName = value; }

        /// <summary>Backing field for <see cref="DeviceName" /> property.</summary>
        private string _deviceName;

        /// <summary>Device name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceName { get => this._deviceName; set => this._deviceName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ImageName" /> property.</summary>
        private string _imageName;

        /// <summary>Image name. Use an image GUID for GA versions of the API.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ImageName { get => this._imageName; set => this._imageName = value; }

        /// <summary>Backing field for <see cref="ProductName" /> property.</summary>
        private string _productName;

        /// <summary>Name of product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProductName { get => this._productName; set => this._productName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>
        /// Serial number of the certificate. Use '.default' to get current active certificate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="SphereIdentity" /> instance.</summary>
        public SphereIdentity()
        {

        }
    }
    public partial interface ISphereIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Name of catalog</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of catalog",
        SerializedName = @"catalogName",
        PossibleTypes = new [] { typeof(string) })]
        string CatalogName { get; set; }
        /// <summary>
        /// Deployment name. Use .default for deployment creation and to get the current deployment for the associated device group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Deployment name. Use .default for deployment creation and to get the current deployment for the associated device group.",
        SerializedName = @"deploymentName",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentName { get; set; }
        /// <summary>Name of device group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of device group.",
        SerializedName = @"deviceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceGroupName { get; set; }
        /// <summary>Device name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device name",
        SerializedName = @"deviceName",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Image name. Use an image GUID for GA versions of the API.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Image name. Use an image GUID for GA versions of the API.",
        SerializedName = @"imageName",
        PossibleTypes = new [] { typeof(string) })]
        string ImageName { get; set; }
        /// <summary>Name of product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of product.",
        SerializedName = @"productName",
        PossibleTypes = new [] { typeof(string) })]
        string ProductName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Serial number of the certificate. Use '.default' to get current active certificate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serial number of the certificate. Use '.default' to get current active certificate.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface ISphereIdentityInternal

    {
        /// <summary>Name of catalog</summary>
        string CatalogName { get; set; }
        /// <summary>
        /// Deployment name. Use .default for deployment creation and to get the current deployment for the associated device group.
        /// </summary>
        string DeploymentName { get; set; }
        /// <summary>Name of device group.</summary>
        string DeviceGroupName { get; set; }
        /// <summary>Device name</summary>
        string DeviceName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Image name. Use an image GUID for GA versions of the API.</summary>
        string ImageName { get; set; }
        /// <summary>Name of product.</summary>
        string ProductName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Serial number of the certificate. Use '.default' to get current active certificate.
        /// </summary>
        string SerialNumber { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}