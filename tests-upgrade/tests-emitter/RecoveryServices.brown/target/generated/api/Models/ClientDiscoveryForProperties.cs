// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Class to represent shoebox properties in json client discovery.</summary>
    public partial class ClientDiscoveryForProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForPropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForPropertiesInternal.ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClientDiscoveryForServiceSpecification()); set { {_serviceSpecification = value;} } }

        /// <summary>Backing field for <see cref="ServiceSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecification _serviceSpecification;

        /// <summary>Operation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecification ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClientDiscoveryForServiceSpecification()); set => this._serviceSpecification = value; }

        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification> ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecificationInternal)ServiceSpecification).LogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecificationInternal)ServiceSpecification).LogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ClientDiscoveryForProperties" /> instance.</summary>
        public ClientDiscoveryForProperties()
        {

        }
    }
    /// Class to represent shoebox properties in json client discovery.
    public partial interface IClientDiscoveryForProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of log specifications of this operation.",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification> ServiceSpecificationLogSpecification { get; set; }

    }
    /// Class to represent shoebox properties in json client discovery.
    internal partial interface IClientDiscoveryForPropertiesInternal

    {
        /// <summary>Operation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecification ServiceSpecification { get; set; }
        /// <summary>List of log specifications of this operation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification> ServiceSpecificationLogSpecification { get; set; }

    }
}