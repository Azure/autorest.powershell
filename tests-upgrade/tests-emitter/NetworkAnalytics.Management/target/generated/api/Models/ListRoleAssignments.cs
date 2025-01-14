// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>list role assignments.</summary>
    public partial class ListRoleAssignments :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignments,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IListRoleAssignmentsInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int _count;

        /// <summary>Count of role assignments.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="RoleAssignmentResponse" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> _roleAssignmentResponse;

        /// <summary>list of role assignments</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> RoleAssignmentResponse { get => this._roleAssignmentResponse; set => this._roleAssignmentResponse = value; }

        /// <summary>Creates an new <see cref="ListRoleAssignments" /> instance.</summary>
        public ListRoleAssignments()
        {

        }
    }
    /// list role assignments.
    public partial interface IListRoleAssignments :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Count of role assignments.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Count of role assignments.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int Count { get; set; }
        /// <summary>list of role assignments</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"list of role assignments",
        SerializedName = @"roleAssignmentResponse",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> RoleAssignmentResponse { get; set; }

    }
    /// list role assignments.
    internal partial interface IListRoleAssignmentsInternal

    {
        /// <summary>Count of role assignments.</summary>
        int Count { get; set; }
        /// <summary>list of role assignments</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail> RoleAssignmentResponse { get; set; }

    }
}