// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>The updatable properties of the ExadbVmCluster.</summary>
    public partial class ExadbVMClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IExadbVMClusterUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IExadbVMClusterUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="NodeCount" /> property.</summary>
        private int? _nodeCount;

        /// <summary>The number of nodes in the Exadata VM cluster on Exascale Infrastructure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public int? NodeCount { get => this._nodeCount; set => this._nodeCount = value; }

        /// <summary>Creates an new <see cref="ExadbVMClusterUpdateProperties" /> instance.</summary>
        public ExadbVMClusterUpdateProperties()
        {

        }
    }
    /// The updatable properties of the ExadbVmCluster.
    public partial interface IExadbVMClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>The number of nodes in the Exadata VM cluster on Exascale Infrastructure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of nodes in the Exadata VM cluster on Exascale Infrastructure.",
        SerializedName = @"nodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? NodeCount { get; set; }

    }
    /// The updatable properties of the ExadbVmCluster.
    internal partial interface IExadbVMClusterUpdatePropertiesInternal

    {
        /// <summary>The number of nodes in the Exadata VM cluster on Exascale Infrastructure.</summary>
        int? NodeCount { get; set; }

    }
}