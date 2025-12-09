// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of an administrator.</summary>
    public partial class AdministratorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdministratorType" /> property.</summary>
        private string _administratorType;

        /// <summary>Type of the sever administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string AdministratorType { get => this._administratorType; set => this._administratorType = value; }

        /// <summary>Backing field for <see cref="IdentityResourceId" /> property.</summary>
        private string _identityResourceId;

        /// <summary>The resource id of the identity used for AAD Authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string IdentityResourceId { get => this._identityResourceId; set => this._identityResourceId = value; }

        /// <summary>Backing field for <see cref="Login" /> property.</summary>
        private string _login;

        /// <summary>Login name of the server administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Login { get => this._login; set => this._login = value; }

        /// <summary>Backing field for <see cref="Sid" /> property.</summary>
        private string _sid;

        /// <summary>SID (object ID) of the server administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Sid { get => this._sid; set => this._sid = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Tenant ID of the administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="AdministratorProperties" /> instance.</summary>
        public AdministratorProperties()
        {

        }
    }
    /// The properties of an administrator.
    public partial interface IAdministratorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Type of the sever administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the sever administrator.",
        SerializedName = @"administratorType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("ActiveDirectory")]
        string AdministratorType { get; set; }
        /// <summary>The resource id of the identity used for AAD Authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the identity used for AAD Authentication.",
        SerializedName = @"identityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityResourceId { get; set; }
        /// <summary>Login name of the server administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Login name of the server administrator.",
        SerializedName = @"login",
        PossibleTypes = new [] { typeof(string) })]
        string Login { get; set; }
        /// <summary>SID (object ID) of the server administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SID (object ID) of the server administrator.",
        SerializedName = @"sid",
        PossibleTypes = new [] { typeof(string) })]
        string Sid { get; set; }
        /// <summary>Tenant ID of the administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant ID of the administrator.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// The properties of an administrator.
    internal partial interface IAdministratorPropertiesInternal

    {
        /// <summary>Type of the sever administrator.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("ActiveDirectory")]
        string AdministratorType { get; set; }
        /// <summary>The resource id of the identity used for AAD Authentication.</summary>
        string IdentityResourceId { get; set; }
        /// <summary>Login name of the server administrator.</summary>
        string Login { get; set; }
        /// <summary>SID (object ID) of the server administrator.</summary>
        string Sid { get; set; }
        /// <summary>Tenant ID of the administrator.</summary>
        string TenantId { get; set; }

    }
}