// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a simple target filter.</summary>
    public partial class ChaosTargetSimpleFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilter,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter __chaosTargetFilter = new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ChaosTargetFilter();

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal)__chaosTargetFilter).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal)__chaosTargetFilter).Type = value ; }

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterParameters Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ChaosTargetSimpleFilterParameters()); set { {_parameter = value;} } }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterParameters _parameter;

        /// <summary>Model that represents the Simple filter parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ChaosTargetSimpleFilterParameters()); set => this._parameter = value; }

        /// <summary>List of Azure availability zones to filter targets by.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ParameterZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterParametersInternal)Parameter).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterParametersInternal)Parameter).Zone = value ?? null /* arrayOf */; }

        /// <summary>Chaos target filter discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Type { get => "Simple"; }

        /// <summary>Creates an new <see cref="ChaosTargetSimpleFilter" /> instance.</summary>
        public ChaosTargetSimpleFilter()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__chaosTargetFilter), __chaosTargetFilter);
            await eventListener.AssertObjectIsValid(nameof(__chaosTargetFilter), __chaosTargetFilter);
        }
    }
    /// Model that represents a simple target filter.
    public partial interface IChaosTargetSimpleFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilter
    {
        /// <summary>List of Azure availability zones to filter targets by.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Azure availability zones to filter targets by.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ParameterZone { get; set; }

    }
    /// Model that represents a simple target filter.
    internal partial interface IChaosTargetSimpleFilterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetFilterInternal
    {
        /// <summary>Model that represents the Simple filter parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosTargetSimpleFilterParameters Parameter { get; set; }
        /// <summary>List of Azure availability zones to filter targets by.</summary>
        System.Collections.Generic.List<string> ParameterZone { get; set; }

    }
}