// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Defines a GitHub organization</summary>
    public partial class GitHubOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganization,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganizationInternal
    {

        /// <summary>Backing field for <see cref="Repository" /> property.</summary>
        private System.Collections.Generic.List<string> _repository;

        /// <summary>Optional list of repositories in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Repository { get => this._repository; set => this._repository = value; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>The GitHub organization URL in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="GitHubOrganization" /> instance.</summary>
        public GitHubOrganization()
        {

        }
    }
    /// Defines a GitHub organization
    public partial interface IGitHubOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>Optional list of repositories in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional list of repositories in which the pool should be created.",
        SerializedName = @"repositories",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Repository { get; set; }
        /// <summary>The GitHub organization URL in which the pool should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The GitHub organization URL in which the pool should be created.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Defines a GitHub organization
    internal partial interface IGitHubOrganizationInternal

    {
        /// <summary>Optional list of repositories in which the pool should be created.</summary>
        System.Collections.Generic.List<string> Repository { get; set; }
        /// <summary>The GitHub organization URL in which the pool should be created.</summary>
        string Url { get; set; }

    }
}