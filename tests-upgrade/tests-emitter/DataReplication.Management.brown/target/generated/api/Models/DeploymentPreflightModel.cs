// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Deployment preflight model.</summary>
    public partial class DeploymentPreflightModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightModel,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightModelInternal
    {

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightResource> _resource;

        /// <summary>Gets or sets the list of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightResource> Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Creates an new <see cref="DeploymentPreflightModel" /> instance.</summary>
        public DeploymentPreflightModel()
        {

        }
    }
    /// Deployment preflight model.
    public partial interface IDeploymentPreflightModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the list of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of resources.",
        SerializedName = @"resources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightResource> Resource { get; set; }

    }
    /// Deployment preflight model.
    internal partial interface IDeploymentPreflightModelInternal

    {
        /// <summary>Gets or sets the list of resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IDeploymentPreflightResource> Resource { get; set; }

    }
}