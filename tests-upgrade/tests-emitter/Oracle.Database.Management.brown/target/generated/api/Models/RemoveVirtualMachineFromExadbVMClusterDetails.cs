// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>
    /// Details of removing Virtual Machines from the Exadata VM cluster on Exascale Infrastructure. Applies to Exadata Database
    /// Service on Exascale Infrastructure only.
    /// </summary>
    public partial class RemoveVirtualMachineFromExadbVMClusterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IRemoveVirtualMachineFromExadbVMClusterDetails,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IRemoveVirtualMachineFromExadbVMClusterDetailsInternal
    {

        /// <summary>Backing field for <see cref="DbNode" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeDetails> _dbNode;

        /// <summary>
        /// The list of ExaCS DB nodes for the Exadata VM cluster on Exascale Infrastructure to be removed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeDetails> DbNode { get => this._dbNode; set => this._dbNode = value; }

        /// <summary>
        /// Creates an new <see cref="RemoveVirtualMachineFromExadbVMClusterDetails" /> instance.
        /// </summary>
        public RemoveVirtualMachineFromExadbVMClusterDetails()
        {

        }
    }
    /// Details of removing Virtual Machines from the Exadata VM cluster on Exascale Infrastructure. Applies to Exadata Database
    /// Service on Exascale Infrastructure only.
    public partial interface IRemoveVirtualMachineFromExadbVMClusterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of ExaCS DB nodes for the Exadata VM cluster on Exascale Infrastructure to be removed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of ExaCS DB nodes for the Exadata VM cluster on Exascale Infrastructure to be removed.",
        SerializedName = @"dbNodes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeDetails> DbNode { get; set; }

    }
    /// Details of removing Virtual Machines from the Exadata VM cluster on Exascale Infrastructure. Applies to Exadata Database
    /// Service on Exascale Infrastructure only.
    internal partial interface IRemoveVirtualMachineFromExadbVMClusterDetailsInternal

    {
        /// <summary>
        /// The list of ExaCS DB nodes for the Exadata VM cluster on Exascale Infrastructure to be removed.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeDetails> DbNode { get; set; }

    }
}