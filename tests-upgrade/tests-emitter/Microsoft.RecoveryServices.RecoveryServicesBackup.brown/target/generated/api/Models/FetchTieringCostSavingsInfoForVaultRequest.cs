// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Request parameters for tiering cost info for vault</summary>
    public partial class FetchTieringCostSavingsInfoForVaultRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostSavingsInfoForVaultRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostSavingsInfoForVaultRequestInternal,
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
        public string ObjectType { get => "FetchTieringCostSavingsInfoForVaultRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).ObjectType = "FetchTieringCostSavingsInfoForVaultRequest"; }

        /// <summary>Source tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceTierType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).SourceTierType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).SourceTierType = value ; }

        /// <summary>target tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetTierType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).TargetTierType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal)__fetchTieringCostInfoRequest).TargetTierType = value ; }

        /// <summary>
        /// Creates an new <see cref="FetchTieringCostSavingsInfoForVaultRequest" /> instance.
        /// </summary>
        public FetchTieringCostSavingsInfoForVaultRequest()
        {
            this.__fetchTieringCostInfoRequest.ObjectType = "FetchTieringCostSavingsInfoForVaultRequest";
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
    /// Request parameters for tiering cost info for vault
    public partial interface IFetchTieringCostSavingsInfoForVaultRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequest
    {

    }
    /// Request parameters for tiering cost info for vault
    internal partial interface IFetchTieringCostSavingsInfoForVaultRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal
    {

    }
}