// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Extensions;

    /// <summary>The paginated list of connected cluster API operations.</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperationListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperation> Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperationListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to fetch the next page of connected cluster API operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperation> _value;

        /// <summary>The list of connected cluster API operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperation> Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// The paginated list of connected cluster API operations.
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>The link to fetch the next page of connected cluster API operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to fetch the next page of connected cluster API operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of connected cluster API operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of connected cluster API operations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperation> Value { get;  }

    }
    /// The paginated list of connected cluster API operations.
    internal partial interface IOperationListInternal

    {
        /// <summary>The link to fetch the next page of connected cluster API operations.</summary>
        string NextLink { get; set; }
        /// <summary>The list of connected cluster API operations.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IOperation> Value { get; set; }

    }
}