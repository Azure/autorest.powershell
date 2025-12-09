// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Class to represent shoebox service specification in json client discovery.</summary>
    public partial class ClientDiscoveryForServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForServiceSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForServiceSpecificationInternal
    {

        /// <summary>Backing field for <see cref="LogSpecification" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForLogSpecification> _logSpecification;

        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForLogSpecification> LogSpecification { get => this._logSpecification; set => this._logSpecification = value; }

        /// <summary>Creates an new <see cref="ClientDiscoveryForServiceSpecification" /> instance.</summary>
        public ClientDiscoveryForServiceSpecification()
        {

        }
    }
    /// Class to represent shoebox service specification in json client discovery.
    public partial interface IClientDiscoveryForServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of log specifications of this operation.",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForLogSpecification) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForLogSpecification> LogSpecification { get; set; }

    }
    /// Class to represent shoebox service specification in json client discovery.
    internal partial interface IClientDiscoveryForServiceSpecificationInternal

    {
        /// <summary>List of log specifications of this operation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryForLogSpecification> LogSpecification { get; set; }

    }
}