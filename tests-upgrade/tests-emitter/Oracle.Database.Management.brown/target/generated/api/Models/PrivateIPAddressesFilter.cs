// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>Private Ip Addresses filter</summary>
    public partial class PrivateIPAddressesFilter :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IPrivateIPAddressesFilter,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IPrivateIPAddressesFilterInternal
    {

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>Subnet OCID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="VnicId" /> property.</summary>
        private string _vnicId;

        /// <summary>VCN OCID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string VnicId { get => this._vnicId; set => this._vnicId = value; }

        /// <summary>Creates an new <see cref="PrivateIPAddressesFilter" /> instance.</summary>
        public PrivateIPAddressesFilter()
        {

        }
    }
    /// Private Ip Addresses filter
    public partial interface IPrivateIPAddressesFilter :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Subnet OCID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subnet OCID",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>VCN OCID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VCN OCID",
        SerializedName = @"vnicId",
        PossibleTypes = new [] { typeof(string) })]
        string VnicId { get; set; }

    }
    /// Private Ip Addresses filter
    internal partial interface IPrivateIPAddressesFilterInternal

    {
        /// <summary>Subnet OCID</summary>
        string SubnetId { get; set; }
        /// <summary>VCN OCID</summary>
        string VnicId { get; set; }

    }
}