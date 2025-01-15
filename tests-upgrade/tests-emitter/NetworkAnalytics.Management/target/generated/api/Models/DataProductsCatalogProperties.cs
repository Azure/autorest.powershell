// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details for data catalog properties.</summary>
    public partial class DataProductsCatalogProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogPropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductsCatalogPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The data catalog provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformation> _publisher;

        /// <summary>The data product publisher information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformation> Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Creates an new <see cref="DataProductsCatalogProperties" /> instance.</summary>
        public DataProductsCatalogProperties()
        {

        }
    }
    /// Details for data catalog properties.
    public partial interface IDataProductsCatalogProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>The data catalog provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The data catalog provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>The data product publisher information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The data product publisher information.",
        SerializedName = @"publishers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformation> Publisher { get; set; }

    }
    /// Details for data catalog properties.
    internal partial interface IDataProductsCatalogPropertiesInternal

    {
        /// <summary>The data catalog provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>The data product publisher information.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformation> Publisher { get; set; }

    }
}