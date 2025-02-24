// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Describes The zonal capabilities of a SKU.</summary>
    public partial class ResourceSkuZoneDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuZoneDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuZoneDetailsInternal
    {

        /// <summary>Backing field for <see cref="Capability" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities> _capability;

        /// <summary>
        /// A list of capabilities that are available for the SKU in the specified list of zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities> Capability { get => this._capability; set => this._capability = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private System.Collections.Generic.List<string> _name;

        /// <summary>
        /// Gets the set of zones that the SKU is available in with the specified capabilities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ResourceSkuZoneDetails" /> instance.</summary>
        public ResourceSkuZoneDetails()
        {

        }
    }
    /// Describes The zonal capabilities of a SKU.
    public partial interface IResourceSkuZoneDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list of capabilities that are available for the SKU in the specified list of zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of capabilities that are available for the SKU in the specified list of zones.",
        SerializedName = @"capabilities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities> Capability { get; set; }
        /// <summary>
        /// Gets the set of zones that the SKU is available in with the specified capabilities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets the set of zones that the SKU is available in with the specified capabilities.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Name { get; set; }

    }
    /// Describes The zonal capabilities of a SKU.
    internal partial interface IResourceSkuZoneDetailsInternal

    {
        /// <summary>
        /// A list of capabilities that are available for the SKU in the specified list of zones.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuCapabilities> Capability { get; set; }
        /// <summary>
        /// Gets the set of zones that the SKU is available in with the specified capabilities.
        /// </summary>
        System.Collections.Generic.List<string> Name { get; set; }

    }
}