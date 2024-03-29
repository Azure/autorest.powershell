// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Security profile for the container service cluster.
    /// </summary>
    public partial class ManagedClusterSecurityProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterSecurityProfile
        /// class.
        /// </summary>
        public ManagedClusterSecurityProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterSecurityProfile
        /// class.
        /// </summary>
        /// <param name="defender">Microsoft Defender settings for the security
        /// profile.</param>
        /// <param name="azureKeyVaultKms">Azure Key Vault [key management
        /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/)
        /// settings for the security profile.</param>
        public ManagedClusterSecurityProfile(ManagedClusterSecurityProfileDefender defender = default(ManagedClusterSecurityProfileDefender), AzureKeyVaultKms azureKeyVaultKms = default(AzureKeyVaultKms))
        {
            this.Defender = defender;
            this.AzureKeyVaultKms = azureKeyVaultKms;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets microsoft Defender settings for the security profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defender")]
        public ManagedClusterSecurityProfileDefender Defender { get; set; }

        /// <summary>
        /// Gets or sets azure Key Vault [key management
        /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/)
        /// settings for the security profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "azureKeyVaultKms")]
        public AzureKeyVaultKms AzureKeyVaultKms { get; set; }

    }
}
