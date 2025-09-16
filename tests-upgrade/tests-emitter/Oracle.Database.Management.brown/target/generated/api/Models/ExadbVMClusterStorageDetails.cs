// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>Storage Details on the Exadata VM cluster.</summary>
    public partial class ExadbVMClusterStorageDetails :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IExadbVMClusterStorageDetails,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IExadbVMClusterStorageDetailsInternal
    {

        /// <summary>Backing field for <see cref="TotalSizeInGb" /> property.</summary>
        private int _totalSizeInGb;

        /// <summary>Total Capacity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public int TotalSizeInGb { get => this._totalSizeInGb; set => this._totalSizeInGb = value; }

        /// <summary>Creates an new <see cref="ExadbVMClusterStorageDetails" /> instance.</summary>
        public ExadbVMClusterStorageDetails()
        {

        }
    }
    /// Storage Details on the Exadata VM cluster.
    public partial interface IExadbVMClusterStorageDetails :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Total Capacity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Total Capacity",
        SerializedName = @"totalSizeInGbs",
        PossibleTypes = new [] { typeof(int) })]
        int TotalSizeInGb { get; set; }

    }
    /// Storage Details on the Exadata VM cluster.
    internal partial interface IExadbVMClusterStorageDetailsInternal

    {
        /// <summary>Total Capacity</summary>
        int TotalSizeInGb { get; set; }

    }
}