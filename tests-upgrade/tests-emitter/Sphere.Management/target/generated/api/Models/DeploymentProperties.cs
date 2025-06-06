// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of deployment</summary>
    public partial class DeploymentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DeployedImage" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> _deployedImage;

        /// <summary>Images deployed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> DeployedImage { get => this._deployedImage; set => this._deployedImage = value; }

        /// <summary>Backing field for <see cref="DeploymentDateUtc" /> property.</summary>
        private global::System.DateTime? _deploymentDateUtc;

        /// <summary>Deployment date UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? DeploymentDateUtc { get => this._deploymentDateUtc; }

        /// <summary>Backing field for <see cref="DeploymentId" /> property.</summary>
        private string _deploymentId;

        /// <summary>Deployment ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeploymentId { get => this._deploymentId; set => this._deploymentId = value; }

        /// <summary>Internal Acessors for DeploymentDateUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentPropertiesInternal.DeploymentDateUtc { get => this._deploymentDateUtc; set { {_deploymentDateUtc = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeploymentPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="DeploymentProperties" /> instance.</summary>
        public DeploymentProperties()
        {

        }
    }
    /// The properties of deployment
    public partial interface IDeploymentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Images deployed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Images deployed",
        SerializedName = @"deployedImages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> DeployedImage { get; set; }
        /// <summary>Deployment date UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Deployment date UTC",
        SerializedName = @"deploymentDateUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DeploymentDateUtc { get;  }
        /// <summary>Deployment ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Deployment ID",
        SerializedName = @"deploymentId",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentId { get; set; }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }

    }
    /// The properties of deployment
    internal partial interface IDeploymentPropertiesInternal

    {
        /// <summary>Images deployed</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> DeployedImage { get; set; }
        /// <summary>Deployment date UTC</summary>
        global::System.DateTime? DeploymentDateUtc { get; set; }
        /// <summary>Deployment ID</summary>
        string DeploymentId { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

    }
}