// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Properties of the Informatica organization.</summary>
    public partial class InformaticaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaPropertiesInternal
    {

        /// <summary>Backing field for <see cref="InformaticaRegion" /> property.</summary>
        private string _informaticaRegion;

        /// <summary>Informatica organization region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string InformaticaRegion { get => this._informaticaRegion; set => this._informaticaRegion = value; }

        /// <summary>Backing field for <see cref="OrganizationId" /> property.</summary>
        private string _organizationId;

        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string OrganizationId { get => this._organizationId; set => this._organizationId = value; }

        /// <summary>Backing field for <see cref="OrganizationName" /> property.</summary>
        private string _organizationName;

        /// <summary>Organization name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string OrganizationName { get => this._organizationName; set => this._organizationName = value; }

        /// <summary>Backing field for <see cref="SingleSignOnUrl" /> property.</summary>
        private string _singleSignOnUrl;

        /// <summary>Single sing on URL for informatica organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string SingleSignOnUrl { get => this._singleSignOnUrl; set => this._singleSignOnUrl = value; }

        /// <summary>Creates an new <see cref="InformaticaProperties" /> instance.</summary>
        public InformaticaProperties()
        {

        }
    }
    /// Properties of the Informatica organization.
    public partial interface IInformaticaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Informatica organization region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Informatica organization region",
        SerializedName = @"informaticaRegion",
        PossibleTypes = new [] { typeof(string) })]
        string InformaticaRegion { get; set; }
        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization id",
        SerializedName = @"organizationId",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationId { get; set; }
        /// <summary>Organization name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Organization name",
        SerializedName = @"organizationName",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationName { get; set; }
        /// <summary>Single sing on URL for informatica organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Single sing on URL for informatica organization",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnUrl { get; set; }

    }
    /// Properties of the Informatica organization.
    internal partial interface IInformaticaPropertiesInternal

    {
        /// <summary>Informatica organization region</summary>
        string InformaticaRegion { get; set; }
        /// <summary>Organization id</summary>
        string OrganizationId { get; set; }
        /// <summary>Organization name</summary>
        string OrganizationName { get; set; }
        /// <summary>Single sing on URL for informatica organization</summary>
        string SingleSignOnUrl { get; set; }

    }
}