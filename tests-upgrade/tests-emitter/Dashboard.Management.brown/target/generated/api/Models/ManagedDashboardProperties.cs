// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Properties specific to the grafana resource.</summary>
    public partial class ManagedDashboardProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardPropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="ManagedDashboardProperties" /> instance.</summary>
        public ManagedDashboardProperties()
        {

        }
    }
    /// Properties specific to the grafana resource.
    public partial interface IManagedDashboardProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get;  }

    }
    /// Properties specific to the grafana resource.
    internal partial interface IManagedDashboardPropertiesInternal

    {
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }

    }
}