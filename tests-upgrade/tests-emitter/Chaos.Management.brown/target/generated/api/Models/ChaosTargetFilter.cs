// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>
    /// Model that represents available filter types that can be applied to a targets list.
    /// </summary>
    public partial class ChaosTargetFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal
    {

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Simple";

        /// <summary>Chaos target filter discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ChaosTargetFilter" /> instance.</summary>
        public ChaosTargetFilter()
        {

        }
    }
    /// Model that represents available filter types that can be applied to a targets list.
    public partial interface IChaosTargetFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>Chaos target filter discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Chaos target filter discriminator type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Model that represents available filter types that can be applied to a targets list.
    internal partial interface IChaosTargetFilterInternal

    {
        /// <summary>Chaos target filter discriminator type</summary>
        string Type { get; set; }

    }
}