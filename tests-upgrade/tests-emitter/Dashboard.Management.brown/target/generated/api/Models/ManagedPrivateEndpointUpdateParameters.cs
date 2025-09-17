// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The parameters for a PATCH request to a managed private endpoint.</summary>
    public partial class ManagedPrivateEndpointUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParametersTags _tag;

        /// <summary>The new tags of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ManagedPrivateEndpointUpdateParameters" /> instance.</summary>
        public ManagedPrivateEndpointUpdateParameters()
        {

        }
    }
    /// The parameters for a PATCH request to a managed private endpoint.
    public partial interface IManagedPrivateEndpointUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The new tags of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The new tags of the managed private endpoint.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParametersTags Tag { get; set; }

    }
    /// The parameters for a PATCH request to a managed private endpoint.
    internal partial interface IManagedPrivateEndpointUpdateParametersInternal

    {
        /// <summary>The new tags of the managed private endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointUpdateParametersTags Tag { get; set; }

    }
}