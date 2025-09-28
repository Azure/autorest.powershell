// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Replication usages for vault.</summary>
    public partial class ReplicationUsageList :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsageList,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsageListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsage> _value;

        /// <summary>The list of replication usages for the given vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsage> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ReplicationUsageList" /> instance.</summary>
        public ReplicationUsageList()
        {

        }
    }
    /// Replication usages for vault.
    public partial interface IReplicationUsageList :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of replication usages for the given vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of replication usages for the given vault.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsage> Value { get; set; }

    }
    /// Replication usages for vault.
    internal partial interface IReplicationUsageListInternal

    {
        string NextLink { get; set; }
        /// <summary>The list of replication usages for the given vault.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IReplicationUsage> Value { get; set; }

    }
}