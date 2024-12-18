// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>Details of the HealthDataAIServices DeidService.</summary>
    public partial class DeidServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidServiceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidServicePropertiesInternal
    {

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection> Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidServicePropertiesInternal.PrivateEndpointConnection { get => this._privateEndpointConnection; set { {_privateEndpointConnection = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidServicePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServiceUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IDeidServicePropertiesInternal.ServiceUrl { get => this._serviceUrl; set { {_serviceUrl = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection> _privateEndpointConnection;

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => this._privateEndpointConnection; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private double? _publicNetworkAccess;

        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public double? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="ServiceUrl" /> property.</summary>
        private string _serviceUrl;

        /// <summary>Deid service url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string ServiceUrl { get => this._serviceUrl; }

        /// <summary>Creates an new <see cref="DeidServiceProperties" /> instance.</summary>
        public DeidServiceProperties()
        {

        }
    }
    /// Details of the HealthDataAIServices DeidService.
    public partial interface IDeidServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
    {
        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of private endpoint connections.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets allow or disallow public network access to resource",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(double) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        double? PublicNetworkAccess { get; set; }
        /// <summary>Deid service url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Deid service url.",
        SerializedName = @"serviceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceUrl { get;  }

    }
    /// Details of the HealthDataAIServices DeidService.
    internal partial interface IDeidServicePropertiesInternal

    {
        /// <summary>List of private endpoint connections.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets allow or disallow public network access to resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        double? PublicNetworkAccess { get; set; }
        /// <summary>Deid service url.</summary>
        string ServiceUrl { get; set; }

    }
}