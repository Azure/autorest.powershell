// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>The template for adding optional properties.</summary>
    public partial class DeidPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidPropertiesUpdateInternal
    {

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="DeidPropertiesUpdate" /> instance.</summary>
        public DeidPropertiesUpdate()
        {

        }
    }
    /// The template for adding optional properties.
    public partial interface IDeidPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets allow or disallow public network access to resource",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }

    }
    /// The template for adding optional properties.
    internal partial interface IDeidPropertiesUpdateInternal

    {
        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }

    }
}