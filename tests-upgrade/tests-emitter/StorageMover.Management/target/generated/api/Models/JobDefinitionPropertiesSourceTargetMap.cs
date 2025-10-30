// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    /// <summary>The list of cloud endpoints to migrate.</summary>
    public partial class JobDefinitionPropertiesSourceTargetMap :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IJobDefinitionPropertiesSourceTargetMap,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IJobDefinitionPropertiesSourceTargetMapInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.ISourceTargetMap> Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IJobDefinitionPropertiesSourceTargetMapInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.ISourceTargetMap> _value;

        /// <summary>Array of SourceTargetMap</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.ISourceTargetMap> Value { get => this._value; }

        /// <summary>Creates an new <see cref="JobDefinitionPropertiesSourceTargetMap" /> instance.</summary>
        public JobDefinitionPropertiesSourceTargetMap()
        {

        }
    }
    /// The list of cloud endpoints to migrate.
    public partial interface IJobDefinitionPropertiesSourceTargetMap :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable
    {
        /// <summary>Array of SourceTargetMap</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of SourceTargetMap",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.ISourceTargetMap) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.ISourceTargetMap> Value { get;  }

    }
    /// The list of cloud endpoints to migrate.
    internal partial interface IJobDefinitionPropertiesSourceTargetMapInternal

    {
        /// <summary>Array of SourceTargetMap</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.ISourceTargetMap> Value { get; set; }

    }
}