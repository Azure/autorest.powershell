// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The details for role assignment common properties.</summary>
    public partial class RoleAssignmentCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentCommonPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DataTypeScope" /> property.</summary>
        private System.Collections.Generic.List<string> _dataTypeScope;

        /// <summary>Data Type Scope at which the role assignment is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DataTypeScope { get => this._dataTypeScope; set => this._dataTypeScope = value; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>Object ID of the AAD principal or security-group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalType" /> property.</summary>
        private string _principalType;

        /// <summary>Type of the principal Id: User, Group or ServicePrincipal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PrincipalType { get => this._principalType; set => this._principalType = value; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private string _role;

        /// <summary>Data Product role to be assigned to a user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Role { get => this._role; set => this._role = value; }

        /// <summary>Backing field for <see cref="RoleId" /> property.</summary>
        private string _roleId;

        /// <summary>Role Id of the Built-In Role</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string RoleId { get => this._roleId; set => this._roleId = value; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>User name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="RoleAssignmentCommonProperties" /> instance.</summary>
        public RoleAssignmentCommonProperties()
        {

        }
    }
    /// The details for role assignment common properties.
    public partial interface IRoleAssignmentCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Data Type Scope at which the role assignment is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data Type Scope at which the role assignment is created.",
        SerializedName = @"dataTypeScope",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DataTypeScope { get; set; }
        /// <summary>Object ID of the AAD principal or security-group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Object ID of the AAD principal or security-group.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>Type of the principal Id: User, Group or ServicePrincipal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the principal Id: User, Group or ServicePrincipal",
        SerializedName = @"principalType",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalType { get; set; }
        /// <summary>Data Product role to be assigned to a user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data Product role to be assigned to a user.",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Reader", "SensitiveReader")]
        string Role { get; set; }
        /// <summary>Role Id of the Built-In Role</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Role Id of the Built-In Role",
        SerializedName = @"roleId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleId { get; set; }
        /// <summary>User name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User name.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// The details for role assignment common properties.
    internal partial interface IRoleAssignmentCommonPropertiesInternal

    {
        /// <summary>Data Type Scope at which the role assignment is created.</summary>
        System.Collections.Generic.List<string> DataTypeScope { get; set; }
        /// <summary>Object ID of the AAD principal or security-group.</summary>
        string PrincipalId { get; set; }
        /// <summary>Type of the principal Id: User, Group or ServicePrincipal</summary>
        string PrincipalType { get; set; }
        /// <summary>Data Product role to be assigned to a user.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Reader", "SensitiveReader")]
        string Role { get; set; }
        /// <summary>Role Id of the Built-In Role</summary>
        string RoleId { get; set; }
        /// <summary>User name.</summary>
        string UserName { get; set; }

    }
}