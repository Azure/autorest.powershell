// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>The response of a PolicyModel list operation.</summary>
    public partial class PolicyModelListResult :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModelListResult,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModelListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModel> _value;

        /// <summary>The PolicyModel items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModel> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PolicyModelListResult" /> instance.</summary>
        public PolicyModelListResult()
        {

        }
    }
    /// The response of a PolicyModel list operation.
    public partial interface IPolicyModelListResult :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The PolicyModel items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The PolicyModel items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModel> Value { get; set; }

    }
    /// The response of a PolicyModel list operation.
    internal partial interface IPolicyModelListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The PolicyModel items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPolicyModel> Value { get; set; }

    }
}