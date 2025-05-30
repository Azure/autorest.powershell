// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>The template for adding optional properties.</summary>
    public partial class InformaticaOrganizationResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaOrganizationResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate _property;

        /// <summary>
        /// Patchable PropertieInformaticaOrganizationPropertiesUpdates of the Organization observability resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.OrganizationPropertiesCustomUpdate()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="InformaticaOrganizationResourceUpdate" /> instance.</summary>
        public InformaticaOrganizationResourceUpdate()
        {

        }
    }
    /// The template for adding optional properties.
    public partial interface IInformaticaOrganizationResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Patchable PropertieInformaticaOrganizationPropertiesUpdates of the Organization observability resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Patchable PropertieInformaticaOrganizationPropertiesUpdates of the Organization observability resource",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate) })]
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate Property { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags Tag { get; set; }

    }
    /// The template for adding optional properties.
    internal partial interface IInformaticaOrganizationResourceUpdateInternal

    {
        /// <summary>
        /// Patchable PropertieInformaticaOrganizationPropertiesUpdates of the Organization observability resource
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IOrganizationPropertiesCustomUpdate Property { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ITags Tag { get; set; }

    }
}