// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The public IP address configuration of the network interface.</summary>
    public partial class PublicIPAddressConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal
    {

        /// <summary>Backing field for <see cref="IPTag" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> _iPTag;

        /// <summary>Specifies the list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get => this._iPTag; set => this._iPTag = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PublicIPAddressVersion" /> property.</summary>
        private string _publicIPAddressVersion;

        /// <summary>
        /// Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PublicIPAddressVersion { get => this._publicIPAddressVersion; set => this._publicIPAddressVersion = value; }

        /// <summary>Creates an new <see cref="PublicIPAddressConfiguration" /> instance.</summary>
        public PublicIPAddressConfiguration()
        {

        }
    }
    /// The public IP address configuration of the network interface.
    public partial interface IPublicIPAddressConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the list of IP tags associated with the public IP address.",
        SerializedName = @"ipTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get; set; }
        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the network interface.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.",
        SerializedName = @"publicIPAddressVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressVersion { get; set; }

    }
    /// The public IP address configuration of the network interface.
    internal partial interface IPublicIPAddressConfigurationInternal

    {
        /// <summary>Specifies the list of IP tags associated with the public IP address.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> IPTag { get; set; }
        /// <summary>Name of the network interface.</summary>
        string Name { get; set; }
        /// <summary>
        /// Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressVersion { get; set; }

    }
}