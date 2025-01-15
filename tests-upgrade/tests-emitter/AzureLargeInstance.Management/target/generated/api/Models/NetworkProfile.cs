// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Specifies the network settings for the Azure Large Instance disks.</summary>
    public partial class NetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfileInternal
    {

        /// <summary>Backing field for <see cref="CircuitId" /> property.</summary>
        private string _circuitId;

        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string CircuitId { get => this._circuitId; set => this._circuitId = value; }

        /// <summary>Backing field for <see cref="NetworkInterface" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> _networkInterface;

        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkInterface { get => this._networkInterface; set => this._networkInterface = value; }

        /// <summary>Creates an new <see cref="NetworkProfile" /> instance.</summary>
        public NetworkProfile()
        {

        }
    }
    /// Specifies the network settings for the Azure Large Instance disks.
    public partial interface INetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the circuit id for connecting to express route.",
        SerializedName = @"circuitId",
        PossibleTypes = new [] { typeof(string) })]
        string CircuitId { get; set; }
        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the network interfaces for the Azure Large Instance.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkInterface { get; set; }

    }
    /// Specifies the network settings for the Azure Large Instance disks.
    internal partial interface INetworkProfileInternal

    {
        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        string CircuitId { get; set; }
        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkInterface { get; set; }

    }
}