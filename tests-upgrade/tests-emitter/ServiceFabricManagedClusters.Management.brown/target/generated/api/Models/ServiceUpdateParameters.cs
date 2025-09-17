// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Service update request</summary>
    public partial class ServiceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParametersTags _tag;

        /// <summary>Service update parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ServiceUpdateParameters" /> instance.</summary>
        public ServiceUpdateParameters()
        {

        }
    }
    /// Service update request
    public partial interface IServiceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Service update parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Service update parameters",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParametersTags Tag { get; set; }

    }
    /// Service update request
    internal partial interface IServiceUpdateParametersInternal

    {
        /// <summary>Service update parameters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceUpdateParametersTags Tag { get; set; }

    }
}