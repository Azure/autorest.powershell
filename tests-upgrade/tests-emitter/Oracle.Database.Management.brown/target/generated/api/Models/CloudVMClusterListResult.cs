// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>The response of a CloudVmCluster list operation.</summary>
    public partial class CloudVMClusterListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMClusterListResult,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMClusterListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMCluster> _value;

        /// <summary>The CloudVmCluster items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMCluster> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CloudVMClusterListResult" /> instance.</summary>
        public CloudVMClusterListResult()
        {

        }
    }
    /// The response of a CloudVmCluster list operation.
    public partial interface ICloudVMClusterListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The CloudVmCluster items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The CloudVmCluster items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMCluster) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMCluster> Value { get; set; }

    }
    /// The response of a CloudVmCluster list operation.
    internal partial interface ICloudVMClusterListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The CloudVmCluster items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ICloudVMCluster> Value { get; set; }

    }
}