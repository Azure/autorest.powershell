// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure IaaS VM workload-specific Health Details.</summary>
    public partial class AzureIaaSvmHealthDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmHealthDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmHealthDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails __resourceHealthDetails = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ResourceHealthDetails();

        /// <summary>Health Code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Code; }

        /// <summary>Health Message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Message; }

        /// <summary>Internal Acessors for Code</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Code = value ?? default(int); }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Message = value ?? null; }

        /// <summary>Internal Acessors for Recommendation</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal.Recommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Recommendation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Recommendation = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal.Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Title = value ?? null; }

        /// <summary>Health Recommended Actions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Recommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Recommendation; }

        /// <summary>Health Title</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal)__resourceHealthDetails).Title; }

        /// <summary>Creates an new <see cref="AzureIaaSvmHealthDetails" /> instance.</summary>
        public AzureIaaSvmHealthDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceHealthDetails), __resourceHealthDetails);
            await eventListener.AssertObjectIsValid(nameof(__resourceHealthDetails), __resourceHealthDetails);
        }
    }
    /// Azure IaaS VM workload-specific Health Details.
    public partial interface IAzureIaaSvmHealthDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails
    {

    }
    /// Azure IaaS VM workload-specific Health Details.
    internal partial interface IAzureIaaSvmHealthDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetailsInternal
    {

    }
}