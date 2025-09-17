// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a selector in the Experiment resource.</summary>
    public partial class ChaosTargetSelector :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSelector,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSelectorInternal
    {

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter _filter;

        /// <summary>
        /// Model that represents available filter types that can be applied to a targets list.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter Filter { get => (this._filter = this._filter ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ChaosTargetFilter()); set => this._filter = value; }

        /// <summary>Chaos target filter discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string FilterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal)Filter).Type; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>String of the selector ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Filter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSelectorInternal.Filter { get => (this._filter = this._filter ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ChaosTargetFilter()); set { {_filter = value;} } }

        /// <summary>Internal Acessors for FilterType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSelectorInternal.FilterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal)Filter).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal)Filter).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Chaos target selector discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ChaosTargetSelector" /> instance.</summary>
        public ChaosTargetSelector()
        {

        }
    }
    /// Model that represents a selector in the Experiment resource.
    public partial interface IChaosTargetSelector :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>Chaos target filter discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Chaos target filter discriminator type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string FilterType { get;  }
        /// <summary>String of the selector ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String of the selector ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Chaos target selector discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Chaos target selector discriminator type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Chaos.PSArgumentCompleterAttribute("List", "Query")]
        string Type { get; set; }

    }
    /// Model that represents a selector in the Experiment resource.
    internal partial interface IChaosTargetSelectorInternal

    {
        /// <summary>
        /// Model that represents available filter types that can be applied to a targets list.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter Filter { get; set; }
        /// <summary>Chaos target filter discriminator type</summary>
        string FilterType { get; set; }
        /// <summary>String of the selector ID.</summary>
        string Id { get; set; }
        /// <summary>Chaos target selector discriminator type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Chaos.PSArgumentCompleterAttribute("List", "Query")]
        string Type { get; set; }

    }
}