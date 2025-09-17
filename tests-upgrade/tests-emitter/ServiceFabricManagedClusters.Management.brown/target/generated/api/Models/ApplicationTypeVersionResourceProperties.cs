// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The properties of the application type version resource.</summary>
    public partial class ApplicationTypeVersionResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AppPackageUrl" /> property.</summary>
        private string _appPackageUrl;

        /// <summary>The URL to the application package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string AppPackageUrl { get => this._appPackageUrl; set => this._appPackageUrl = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Creates an new <see cref="ApplicationTypeVersionResourceProperties" /> instance.
        /// </summary>
        public ApplicationTypeVersionResourceProperties()
        {

        }
    }
    /// The properties of the application type version resource.
    public partial interface IApplicationTypeVersionResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The URL to the application package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to the application package",
        SerializedName = @"appPackageUrl",
        PossibleTypes = new [] { typeof(string) })]
        string AppPackageUrl { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The current deployment or provisioning state, which only appears in the response",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// The properties of the application type version resource.
    internal partial interface IApplicationTypeVersionResourcePropertiesInternal

    {
        /// <summary>The URL to the application package</summary>
        string AppPackageUrl { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        string ProvisioningState { get; set; }

    }
}