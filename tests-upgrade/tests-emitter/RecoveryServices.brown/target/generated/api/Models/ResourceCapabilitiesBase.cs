// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>
    /// Base class for request and response capabilities information for Microsoft.RecoveryServices
    /// </summary>
    public partial class ResourceCapabilitiesBase :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Describes the Resource type: Microsoft.RecoveryServices/Vaults</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ResourceCapabilitiesBase" /> instance.</summary>
        public ResourceCapabilitiesBase()
        {

        }
    }
    /// Base class for request and response capabilities information for Microsoft.RecoveryServices
    public partial interface IResourceCapabilitiesBase :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Describes the Resource type: Microsoft.RecoveryServices/Vaults</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the Resource type: Microsoft.RecoveryServices/Vaults",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Base class for request and response capabilities information for Microsoft.RecoveryServices
    internal partial interface IResourceCapabilitiesBaseInternal

    {
        /// <summary>Describes the Resource type: Microsoft.RecoveryServices/Vaults</summary>
        string Type { get; set; }

    }
}