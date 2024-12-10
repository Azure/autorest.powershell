// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>
    /// The storage properties of the cluster. This includes the data storage size and scaling applied to servers in the cluster.
    /// </summary>
    public partial class StorageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStoragePropertiesInternal
    {

        /// <summary>Backing field for <see cref="SizeGb" /> property.</summary>
        private long? _sizeGb;

        /// <summary>The size of the data disk assigned to each server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public long? SizeGb { get => this._sizeGb; set => this._sizeGb = value; }

        /// <summary>Creates an new <see cref="StorageProperties" /> instance.</summary>
        public StorageProperties()
        {

        }
    }
    /// The storage properties of the cluster. This includes the data storage size and scaling applied to servers in the cluster.
    public partial interface IStorageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IJsonSerializable
    {
        /// <summary>The size of the data disk assigned to each server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The size of the data disk assigned to each server.",
        SerializedName = @"sizeGb",
        PossibleTypes = new [] { typeof(long) })]
        long? SizeGb { get; set; }

    }
    /// The storage properties of the cluster. This includes the data storage size and scaling applied to servers in the cluster.
    internal partial interface IStoragePropertiesInternal

    {
        /// <summary>The size of the data disk assigned to each server.</summary>
        long? SizeGb { get; set; }

    }
}