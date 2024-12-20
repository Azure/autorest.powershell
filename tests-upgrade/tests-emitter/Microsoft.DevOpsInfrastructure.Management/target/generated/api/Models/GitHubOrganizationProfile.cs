// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>GitHub organization profile</summary>
    public partial class GitHubOrganizationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganizationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganizationProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile __organizationProfile = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfile();

        /// <summary>Discriminator property for OrganizationProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Kind { get => "GitHub"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfileInternal)__organizationProfile).Kind = "GitHub"; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganization> _organization;

        /// <summary>The list of GitHub organizations/repositories the pool should be present in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganization> Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Creates an new <see cref="GitHubOrganizationProfile" /> instance.</summary>
        public GitHubOrganizationProfile()
        {
            this.__organizationProfile.Kind = "GitHub";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__organizationProfile), __organizationProfile);
            await eventListener.AssertObjectIsValid(nameof(__organizationProfile), __organizationProfile);
        }
    }
    /// GitHub organization profile
    public partial interface IGitHubOrganizationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile
    {
        /// <summary>The list of GitHub organizations/repositories the pool should be present in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of GitHub organizations/repositories the pool should be present in.",
        SerializedName = @"organizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganization) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganization> Organization { get; set; }

    }
    /// GitHub organization profile
    internal partial interface IGitHubOrganizationProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfileInternal
    {
        /// <summary>The list of GitHub organizations/repositories the pool should be present in.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IGitHubOrganization> Organization { get; set; }

    }
}