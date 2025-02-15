// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Link Organization</summary>
    public partial class LinkOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganization,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ILinkOrganizationInternal
    {

        /// <summary>Backing field for <see cref="Token" /> property.</summary>
        private string _token;

        /// <summary>Link organization token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Token { get => this._token; set => this._token = value; }

        /// <summary>Creates an new <see cref="LinkOrganization" /> instance.</summary>
        public LinkOrganization()
        {

        }
    }
    /// Link Organization
    public partial interface ILinkOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Link organization token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Link organization token",
        SerializedName = @"token",
        PossibleTypes = new [] { typeof(string) })]
        string Token { get; set; }

    }
    /// Link Organization
    internal partial interface ILinkOrganizationInternal

    {
        /// <summary>Link organization token</summary>
        string Token { get; set; }

    }
}