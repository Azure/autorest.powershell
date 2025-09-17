// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The service endpoint properties.</summary>
    public partial class ServiceEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpointInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private System.Collections.Generic.List<string> _location;

        /// <summary>A list of locations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="NetworkIdentifier" /> property.</summary>
        private string _networkIdentifier;

        /// <summary>Specifies the resource id of the service endpoint to be used in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string NetworkIdentifier { get => this._networkIdentifier; set => this._networkIdentifier = value; }

        /// <summary>Backing field for <see cref="Service" /> property.</summary>
        private string _service;

        /// <summary>The type of the endpoint service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Service { get => this._service; set => this._service = value; }

        /// <summary>Creates an new <see cref="ServiceEndpoint" /> instance.</summary>
        public ServiceEndpoint()
        {

        }
    }
    /// The service endpoint properties.
    public partial interface IServiceEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>A list of locations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of locations.",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Location { get; set; }
        /// <summary>Specifies the resource id of the service endpoint to be used in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the resource id of the service endpoint to be used in the cluster.",
        SerializedName = @"networkIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkIdentifier { get; set; }
        /// <summary>The type of the endpoint service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the endpoint service.",
        SerializedName = @"service",
        PossibleTypes = new [] { typeof(string) })]
        string Service { get; set; }

    }
    /// The service endpoint properties.
    internal partial interface IServiceEndpointInternal

    {
        /// <summary>A list of locations.</summary>
        System.Collections.Generic.List<string> Location { get; set; }
        /// <summary>Specifies the resource id of the service endpoint to be used in the cluster.</summary>
        string NetworkIdentifier { get; set; }
        /// <summary>The type of the endpoint service.</summary>
        string Service { get; set; }

    }
}