// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the request body for updating Virtual Instance for SAP.</summary>
    public partial class UpdateSapVirtualInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceRequestInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1 _identity;

        /// <summary>Managed service identity (user assigned identities)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1 Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceIdentity1()); set => this._identity = value; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1Internal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1Internal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1Internal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1Internal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ManagedResourcesNetworkAccessType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstancePropertiesInternal)Property).ManagedResourcesNetworkAccessType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstancePropertiesInternal)Property).ManagedResourcesNetworkAccessType = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1 Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceRequestInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceIdentity1()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.UpdateSapVirtualInstanceProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceProperties _property;

        /// <summary>The update properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.UpdateSapVirtualInstanceProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags _tag;

        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="UpdateSapVirtualInstanceRequest" /> instance.</summary>
        public UpdateSapVirtualInstanceRequest()
        {

        }
    }
    /// Defines the request body for updating Virtual Instance for SAP.
    public partial interface IUpdateSapVirtualInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("None", "UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags Tag { get; set; }

    }
    /// Defines the request body for updating Virtual Instance for SAP.
    internal partial interface IUpdateSapVirtualInstanceRequestInternal

    {
        /// <summary>Managed service identity (user assigned identities)</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity1 Identity { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("None", "UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Public", "Private")]
        string ManagedResourcesNetworkAccessType { get; set; }
        /// <summary>The update properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceProperties Property { get; set; }
        /// <summary>Gets or sets the Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags Tag { get; set; }

    }
}