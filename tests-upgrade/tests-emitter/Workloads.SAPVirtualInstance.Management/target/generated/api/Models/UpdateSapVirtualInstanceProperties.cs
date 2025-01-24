// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Defines the update request body properties for updating Virtual Instance for SAP.
    /// </summary>
    public partial class UpdateSapVirtualInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstancePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ManagedResourcesNetworkAccessType" /> property.</summary>
        private string _managedResourcesNetworkAccessType;

        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ManagedResourcesNetworkAccessType { get => this._managedResourcesNetworkAccessType; set => this._managedResourcesNetworkAccessType = value; }

        /// <summary>Creates an new <see cref="UpdateSapVirtualInstanceProperties" /> instance.</summary>
        public UpdateSapVirtualInstanceProperties()
        {

        }
    }
    /// Defines the update request body properties for updating Virtual Instance for SAP.
    public partial interface IUpdateSapVirtualInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here https://go.microsoft.com/fwlink/?linkid=2247228",
        SerializedName = @"managedResourcesNetworkAccessType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Public", "Private")]
        string ManagedResourcesNetworkAccessType { get; set; }

    }
    /// Defines the update request body properties for updating Virtual Instance for SAP.
    internal partial interface IUpdateSapVirtualInstancePropertiesInternal

    {
        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Public", "Private")]
        string ManagedResourcesNetworkAccessType { get; set; }

    }
}