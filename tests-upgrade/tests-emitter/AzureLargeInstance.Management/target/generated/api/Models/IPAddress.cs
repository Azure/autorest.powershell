// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Specifies the IP address of the network interface.</summary>
    public partial class IPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddressInternal
    {

        /// <summary>Backing field for <see cref="IPAddress1" /> property.</summary>
        private string _iPAddress1;

        /// <summary>Specifies the IP address of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string IPAddress1 { get => this._iPAddress1; set => this._iPAddress1 = value; }

        /// <summary>Creates an new <see cref="IPAddress" /> instance.</summary>
        public IPAddress()
        {

        }
    }
    /// Specifies the IP address of the network interface.
    public partial interface IIPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the IP address of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the IP address of the network interface.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress1 { get; set; }

    }
    /// Specifies the IP address of the network interface.
    internal partial interface IIPAddressInternal

    {
        /// <summary>Specifies the IP address of the network interface.</summary>
        string IPAddress1 { get; set; }

    }
}