// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Response parameters for tiering cost info for rehydration</summary>
    public partial class TieringCostRehydrationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostRehydrationInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostRehydrationInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfo"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfo __tieringCostInfo = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TieringCostInfo();

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "TieringCostRehydrationInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfoInternal)__tieringCostInfo).ObjectType = "TieringCostRehydrationInfo"; }

        /// <summary>Backing field for <see cref="RehydrationSizeInByte" /> property.</summary>
        private long _rehydrationSizeInByte;

        /// <summary>Rehydration size in bytes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public long RehydrationSizeInByte { get => this._rehydrationSizeInByte; set => this._rehydrationSizeInByte = value; }

        /// <summary>Backing field for <see cref="RetailRehydrationCostPerGbPerMonth" /> property.</summary>
        private double _retailRehydrationCostPerGbPerMonth;

        /// <summary>Source tier to target tier rehydration cost per GB per month</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public double RetailRehydrationCostPerGbPerMonth { get => this._retailRehydrationCostPerGbPerMonth; set => this._retailRehydrationCostPerGbPerMonth = value; }

        /// <summary>Creates an new <see cref="TieringCostRehydrationInfo" /> instance.</summary>
        public TieringCostRehydrationInfo()
        {
            this.__tieringCostInfo.ObjectType = "TieringCostRehydrationInfo";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__tieringCostInfo), __tieringCostInfo);
            await eventListener.AssertObjectIsValid(nameof(__tieringCostInfo), __tieringCostInfo);
        }
    }
    /// Response parameters for tiering cost info for rehydration
    public partial interface ITieringCostRehydrationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfo
    {
        /// <summary>Rehydration size in bytes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rehydration size in bytes",
        SerializedName = @"rehydrationSizeInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long RehydrationSizeInByte { get; set; }
        /// <summary>Source tier to target tier rehydration cost per GB per month</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source tier to target tier rehydration cost per GB per month",
        SerializedName = @"retailRehydrationCostPerGBPerMonth",
        PossibleTypes = new [] { typeof(double) })]
        double RetailRehydrationCostPerGbPerMonth { get; set; }

    }
    /// Response parameters for tiering cost info for rehydration
    internal partial interface ITieringCostRehydrationInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfoInternal
    {
        /// <summary>Rehydration size in bytes</summary>
        long RehydrationSizeInByte { get; set; }
        /// <summary>Source tier to target tier rehydration cost per GB per month</summary>
        double RetailRehydrationCostPerGbPerMonth { get; set; }

    }
}