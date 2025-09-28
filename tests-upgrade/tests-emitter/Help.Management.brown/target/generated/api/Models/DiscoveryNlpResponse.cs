// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Successfully fetched list of solution metadata.</summary>
    public partial class DiscoveryNlpResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResource> _value;

        /// <summary>The list of solution metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DiscoveryNlpResponse" /> instance.</summary>
        public DiscoveryNlpResponse()
        {

        }
    }
    /// Successfully fetched list of solution metadata.
    public partial interface IDiscoveryNlpResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>The list of solution metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of solution metadata.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResource> Value { get; set; }

    }
    /// Successfully fetched list of solution metadata.
    internal partial interface IDiscoveryNlpResponseInternal

    {
        /// <summary>The list of solution metadata.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResource> Value { get; set; }

    }
}