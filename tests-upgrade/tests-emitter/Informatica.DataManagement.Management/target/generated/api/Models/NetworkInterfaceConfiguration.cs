// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Informatica Serverless Runtime Network Interface configurations.</summary>
    public partial class NetworkInterfaceConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationInternal
    {

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="VnetId" /> property.</summary>
        private string _vnetId;

        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string VnetId { get => this._vnetId; set => this._vnetId = value; }

        /// <summary>Backing field for <see cref="VnetResourceGuid" /> property.</summary>
        private string _vnetResourceGuid;

        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string VnetResourceGuid { get => this._vnetResourceGuid; set => this._vnetResourceGuid = value; }

        /// <summary>Creates an new <see cref="NetworkInterfaceConfiguration" /> instance.</summary>
        public NetworkInterfaceConfiguration()
        {

        }
    }
    /// Informatica Serverless Runtime Network Interface configurations.
    public partial interface INetworkInterfaceConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network subnet resource id",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource id",
        SerializedName = @"vnetId",
        PossibleTypes = new [] { typeof(string) })]
        string VnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource guid",
        SerializedName = @"vnetResourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string VnetResourceGuid { get; set; }

    }
    /// Informatica Serverless Runtime Network Interface configurations.
    internal partial interface INetworkInterfaceConfigurationInternal

    {
        /// <summary>Virtual network subnet resource id</summary>
        string SubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        string VnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        string VnetResourceGuid { get; set; }

    }
}