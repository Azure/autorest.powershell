// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Request parameters for tiering cost info for policy</summary>
    public partial class FetchTieringCostSavingsInfoForPolicyRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostSavingsInfoForPolicyRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostSavingsInfoForPolicyRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequest __fetchTieringCostInfoRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.FetchTieringCostInfoRequest();

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "FetchTieringCostSavingsInfoForPolicyRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).ObjectType = "FetchTieringCostSavingsInfoForPolicyRequest"; }

        /// <summary>Backing field for <see cref="PolicyName" /> property.</summary>
        private string _policyName;

        /// <summary>Name of the backup policy for which the cost savings information is requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string PolicyName { get => this._policyName; set => this._policyName = value; }

        /// <summary>Source tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceTierType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).SourceTierType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).SourceTierType = value ; }

        /// <summary>target tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetTierType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).TargetTierType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).TargetTierType = value ; }

        /// <summary>
        /// Creates an new <see cref="FetchTieringCostSavingsInfoForPolicyRequest" /> instance.
        /// </summary>
        public FetchTieringCostSavingsInfoForPolicyRequest()
        {
            this.__fetchTieringCostInfoRequest.ObjectType = "FetchTieringCostSavingsInfoForPolicyRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fetchTieringCostInfoRequest), __fetchTieringCostInfoRequest);
            await eventListener.AssertObjectIsValid(nameof(__fetchTieringCostInfoRequest), __fetchTieringCostInfoRequest);
        }
    }
    /// Request parameters for tiering cost info for policy
    public partial interface IFetchTieringCostSavingsInfoForPolicyRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequest
    {
        /// <summary>Name of the backup policy for which the cost savings information is requested</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the backup policy for which the cost savings information is requested",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyName { get; set; }

    }
    /// Request parameters for tiering cost info for policy
    internal partial interface IFetchTieringCostSavingsInfoForPolicyRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal
    {
        /// <summary>Name of the backup policy for which the cost savings information is requested</summary>
        string PolicyName { get; set; }

    }
}