// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Describes an available Compute SKU Restriction Information.</summary>
    public partial class ResourceSkuRestrictionInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfoInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private System.Collections.Generic.List<string> _location;

        /// <summary>Locations where the SKU is restricted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private System.Collections.Generic.List<string> _zone;

        /// <summary>List of availability zones where the SKU is restricted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="ResourceSkuRestrictionInfo" /> instance.</summary>
        public ResourceSkuRestrictionInfo()
        {

        }
    }
    /// Describes an available Compute SKU Restriction Information.
    public partial interface IResourceSkuRestrictionInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>Locations where the SKU is restricted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Locations where the SKU is restricted",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Location { get; set; }
        /// <summary>List of availability zones where the SKU is restricted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of availability zones where the SKU is restricted.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Zone { get; set; }

    }
    /// Describes an available Compute SKU Restriction Information.
    internal partial interface IResourceSkuRestrictionInfoInternal

    {
        /// <summary>Locations where the SKU is restricted</summary>
        System.Collections.Generic.List<string> Location { get; set; }
        /// <summary>List of availability zones where the SKU is restricted.</summary>
        System.Collections.Generic.List<string> Zone { get; set; }

    }
}