// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>A List of azure ad administrators.</summary>
    public partial class AdministratorListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAzureAdAdministrator> _value;

        /// <summary>The list of azure ad administrator of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAzureAdAdministrator> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AdministratorListResult" /> instance.</summary>
        public AdministratorListResult()
        {

        }
    }
    /// A List of azure ad administrators.
    public partial interface IAdministratorListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link used to get the next page of operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of azure ad administrator of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of azure ad administrator of a server.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAzureAdAdministrator) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAzureAdAdministrator> Value { get; set; }

    }
    /// A List of azure ad administrators.
    internal partial interface IAdministratorListResultInternal

    {
        /// <summary>The link used to get the next page of operations.</summary>
        string NextLink { get; set; }
        /// <summary>The list of azure ad administrator of a server.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAzureAdAdministrator> Value { get; set; }

    }
}