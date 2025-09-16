// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Parameters for Resume Upgrade action. The upgrade domain name must be specified.
    /// </summary>
    public partial class RuntimeResumeApplicationUpgradeParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRuntimeResumeApplicationUpgradeParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRuntimeResumeApplicationUpgradeParametersInternal
    {

        /// <summary>Backing field for <see cref="UpgradeDomainName" /> property.</summary>
        private string _upgradeDomainName;

        /// <summary>
        /// The upgrade domain name. Expected to be the next upgrade domain if the application is upgrading.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeDomainName { get => this._upgradeDomainName; set => this._upgradeDomainName = value; }

        /// <summary>
        /// Creates an new <see cref="RuntimeResumeApplicationUpgradeParameters" /> instance.
        /// </summary>
        public RuntimeResumeApplicationUpgradeParameters()
        {

        }
    }
    /// Parameters for Resume Upgrade action. The upgrade domain name must be specified.
    public partial interface IRuntimeResumeApplicationUpgradeParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The upgrade domain name. Expected to be the next upgrade domain if the application is upgrading.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The upgrade domain name. Expected to be the next upgrade domain if the application is upgrading.",
        SerializedName = @"upgradeDomainName",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDomainName { get; set; }

    }
    /// Parameters for Resume Upgrade action. The upgrade domain name must be specified.
    internal partial interface IRuntimeResumeApplicationUpgradeParametersInternal

    {
        /// <summary>
        /// The upgrade domain name. Expected to be the next upgrade domain if the application is upgrading.
        /// </summary>
        string UpgradeDomainName { get; set; }

    }
}