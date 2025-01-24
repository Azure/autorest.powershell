// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the url and storage account ID where deployer VM packages are uploaded</summary>
    public partial class DeployerVMPackages :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackagesInternal
    {

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string _storageAccountId;

        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string StorageAccountId { get => this._storageAccountId; set => this._storageAccountId = value; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="DeployerVMPackages" /> instance.</summary>
        public DeployerVMPackages()
        {

        }
    }
    /// Defines the url and storage account ID where deployer VM packages are uploaded
    public partial interface IDeployerVMPackages :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deployer VM packages storage account id",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to the deployer VM packages file.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Defines the url and storage account ID where deployer VM packages are uploaded
    internal partial interface IDeployerVMPackagesInternal

    {
        /// <summary>The deployer VM packages storage account id</summary>
        string StorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        string Url { get; set; }

    }
}