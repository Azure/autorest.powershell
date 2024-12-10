// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Informatica Serverless Runtime Application type Metadata</summary>
    public partial class ComputeUnitsMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadataInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>ComputeUnit name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<string> _value;

        /// <summary>ComputeUnit value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ComputeUnitsMetadata" /> instance.</summary>
        public ComputeUnitsMetadata()
        {

        }
    }
    /// Informatica Serverless Runtime Application type Metadata
    public partial interface IComputeUnitsMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>ComputeUnit name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ComputeUnit name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>ComputeUnit value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ComputeUnit value",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Value { get; set; }

    }
    /// Informatica Serverless Runtime Application type Metadata
    internal partial interface IComputeUnitsMetadataInternal

    {
        /// <summary>ComputeUnit name</summary>
        string Name { get; set; }
        /// <summary>ComputeUnit value</summary>
        System.Collections.Generic.List<string> Value { get; set; }

    }
}