// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Extensions;

    /// <summary>Details of the gateway used by the Arc router for connectivity.</summary>
    public partial class Gateway :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IGateway,
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IGatewayInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Indicates whether the gateway for arc router connectivity is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="Gateway" /> instance.</summary>
        public Gateway()
        {

        }
    }
    /// Details of the gateway used by the Arc router for connectivity.
    public partial interface IGateway :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether the gateway for arc router connectivity is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the gateway for arc router connectivity is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// Details of the gateway used by the Arc router for connectivity.
    internal partial interface IGatewayInternal

    {
        /// <summary>Indicates whether the gateway for arc router connectivity is enabled.</summary>
        bool? Enabled { get; set; }

    }
}