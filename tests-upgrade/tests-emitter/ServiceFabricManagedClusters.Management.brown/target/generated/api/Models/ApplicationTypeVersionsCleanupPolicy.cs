// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// The policy used to clean up unused versions. When the policy is not specified explicitly, the default unused application
    /// versions to keep will be 3.
    /// </summary>
    public partial class ApplicationTypeVersionsCleanupPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicyInternal
    {

        /// <summary>Backing field for <see cref="MaxUnusedVersionsToKeep" /> property.</summary>
        private int _maxUnusedVersionsToKeep;

        /// <summary>Number of unused versions per application type to keep.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxUnusedVersionsToKeep { get => this._maxUnusedVersionsToKeep; set => this._maxUnusedVersionsToKeep = value; }

        /// <summary>Creates an new <see cref="ApplicationTypeVersionsCleanupPolicy" /> instance.</summary>
        public ApplicationTypeVersionsCleanupPolicy()
        {

        }
    }
    /// The policy used to clean up unused versions. When the policy is not specified explicitly, the default unused application
    /// versions to keep will be 3.
    public partial interface IApplicationTypeVersionsCleanupPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Number of unused versions per application type to keep.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of unused versions per application type to keep.",
        SerializedName = @"maxUnusedVersionsToKeep",
        PossibleTypes = new [] { typeof(int) })]
        int MaxUnusedVersionsToKeep { get; set; }

    }
    /// The policy used to clean up unused versions. When the policy is not specified explicitly, the default unused application
    /// versions to keep will be 3.
    internal partial interface IApplicationTypeVersionsCleanupPolicyInternal

    {
        /// <summary>Number of unused versions per application type to keep.</summary>
        int MaxUnusedVersionsToKeep { get; set; }

    }
}