// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The JobResourceUpdateParameter.</summary>
    public partial class JobResourceUpdateParameter :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameter,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterInternal
    {

        /// <summary>Details of a job to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobPropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobPropertiesInternal)Property).Detail = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity _identity;

        /// <summary>Msi identity of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentity()); set => this._identity = value; }

        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).PrincipalId; }

        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).TenantId; }

        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobProperties _property;

        /// <summary>Properties of a job to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTags _tag;

        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobResourceUpdateParameterTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="JobResourceUpdateParameter" /> instance.</summary>
        public JobResourceUpdateParameter()
        {

        }
    }
    /// The JobResourceUpdateParameter.
    public partial interface IJobResourceUpdateParameter :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Details of a job to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of a job to be updated.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails Detail { get; set; }
        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Service Principal Id backing the Msi",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Home Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Assigned Identities",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTags Tag { get; set; }

    }
    /// The JobResourceUpdateParameter.
    internal partial interface IJobResourceUpdateParameterInternal

    {
        /// <summary>Details of a job to be updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails Detail { get; set; }
        /// <summary>Msi identity of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity Identity { get; set; }
        /// <summary>Service Principal Id backing the Msi</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>Home Tenant Id</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Identity type</summary>
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Properties of a job to be updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobProperties Property { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTags Tag { get; set; }

    }
}