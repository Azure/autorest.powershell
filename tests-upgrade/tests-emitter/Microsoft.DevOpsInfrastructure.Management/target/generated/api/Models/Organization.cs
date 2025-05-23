// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Defines an Azure DevOps organization.</summary>
    public partial class Organization :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganization,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationInternal
    {

        /// <summary>Backing field for <see cref="OpenAccess" /> property.</summary>
        private bool? _openAccess;

        /// <summary>
        /// Determines if the pool should have open access to all projects in this organization.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public bool? OpenAccess { get => this._openAccess; set => this._openAccess = value; }

        /// <summary>Backing field for <see cref="Parallelism" /> property.</summary>
        private int? _parallelism;

        /// <summary>
        /// How many machines can be created at maximum in this organization out of the maximumConcurrency of the pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public int? Parallelism { get => this._parallelism; set => this._parallelism = value; }

        /// <summary>Backing field for <see cref="Project" /> property.</summary>
        private System.Collections.Generic.List<string> _project;

        /// <summary>Optional list of projects in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Project { get => this._project; set => this._project = value; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>The Azure DevOps organization URL in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="Organization" /> instance.</summary>
        public Organization()
        {

        }
    }
    /// Defines an Azure DevOps organization.
    public partial interface IOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Determines if the pool should have open access to all projects in this organization.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines if the pool should have open access to all projects in this organization.",
        SerializedName = @"openAccess",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OpenAccess { get; set; }
        /// <summary>
        /// How many machines can be created at maximum in this organization out of the maximumConcurrency of the pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How many machines can be created at maximum in this organization out of the maximumConcurrency of the pool.",
        SerializedName = @"parallelism",
        PossibleTypes = new [] { typeof(int) })]
        int? Parallelism { get; set; }
        /// <summary>Optional list of projects in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional list of projects in which the pool should be created.",
        SerializedName = @"projects",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Project { get; set; }
        /// <summary>The Azure DevOps organization URL in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure DevOps organization URL in which the pool should be created.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Defines an Azure DevOps organization.
    internal partial interface IOrganizationInternal

    {
        /// <summary>
        /// Determines if the pool should have open access to all projects in this organization.
        /// </summary>
        bool? OpenAccess { get; set; }
        /// <summary>
        /// How many machines can be created at maximum in this organization out of the maximumConcurrency of the pool.
        /// </summary>
        int? Parallelism { get; set; }
        /// <summary>Optional list of projects in which the pool should be created.</summary>
        System.Collections.Generic.List<string> Project { get; set; }
        /// <summary>The Azure DevOps organization URL in which the pool should be created.</summary>
        string Url { get; set; }

    }
}