// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Response parameters for tiering cost info for savings</summary>
    public partial class TieringCostSavingInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostSavingInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostSavingInfoInternal,
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
        public string ObjectType { get => "TieringCostSavingInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfoInternal)__tieringCostInfo).ObjectType = "TieringCostSavingInfo"; }

        /// <summary>Backing field for <see cref="RetailSourceTierCostPerGbPerMonth" /> property.</summary>
        private double _retailSourceTierCostPerGbPerMonth;

        /// <summary>Source tier retail cost per GB per month</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public double RetailSourceTierCostPerGbPerMonth { get => this._retailSourceTierCostPerGbPerMonth; set => this._retailSourceTierCostPerGbPerMonth = value; }

        /// <summary>Backing field for <see cref="RetailTargetTierCostPerGbPerMonth" /> property.</summary>
        private double _retailTargetTierCostPerGbPerMonth;

        /// <summary>Target tier retail cost per GB per month</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public double RetailTargetTierCostPerGbPerMonth { get => this._retailTargetTierCostPerGbPerMonth; set => this._retailTargetTierCostPerGbPerMonth = value; }

        /// <summary>Backing field for <see cref="SourceTierSizeReductionInByte" /> property.</summary>
        private long _sourceTierSizeReductionInByte;

        /// <summary>
        /// Source tier size reduction in bytes after moving all the recommended backup points to target tier
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public long SourceTierSizeReductionInByte { get => this._sourceTierSizeReductionInByte; set => this._sourceTierSizeReductionInByte = value; }

        /// <summary>Backing field for <see cref="TargetTierSizeIncreaseInByte" /> property.</summary>
        private long _targetTierSizeIncreaseInByte;

        /// <summary>
        /// Target tier size increase in bytes after moving all the recommended backup points to target tier
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public long TargetTierSizeIncreaseInByte { get => this._targetTierSizeIncreaseInByte; set => this._targetTierSizeIncreaseInByte = value; }

        /// <summary>Creates an new <see cref="TieringCostSavingInfo" /> instance.</summary>
        public TieringCostSavingInfo()
        {
            this.__tieringCostInfo.ObjectType = "TieringCostSavingInfo";
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
    /// Response parameters for tiering cost info for savings
    public partial interface ITieringCostSavingInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfo
    {
        /// <summary>Source tier retail cost per GB per month</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source tier retail cost per GB per month",
        SerializedName = @"retailSourceTierCostPerGBPerMonth",
        PossibleTypes = new [] { typeof(double) })]
        double RetailSourceTierCostPerGbPerMonth { get; set; }
        /// <summary>Target tier retail cost per GB per month</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target tier retail cost per GB per month",
        SerializedName = @"retailTargetTierCostPerGBPerMonth",
        PossibleTypes = new [] { typeof(double) })]
        double RetailTargetTierCostPerGbPerMonth { get; set; }
        /// <summary>
        /// Source tier size reduction in bytes after moving all the recommended backup points to target tier
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source tier size reduction in bytes after moving all the recommended backup points to target tier",
        SerializedName = @"sourceTierSizeReductionInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long SourceTierSizeReductionInByte { get; set; }
        /// <summary>
        /// Target tier size increase in bytes after moving all the recommended backup points to target tier
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target tier size increase in bytes after moving all the recommended backup points to target tier",
        SerializedName = @"targetTierSizeIncreaseInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long TargetTierSizeIncreaseInByte { get; set; }

    }
    /// Response parameters for tiering cost info for savings
    internal partial interface ITieringCostSavingInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringCostInfoInternal
    {
        /// <summary>Source tier retail cost per GB per month</summary>
        double RetailSourceTierCostPerGbPerMonth { get; set; }
        /// <summary>Target tier retail cost per GB per month</summary>
        double RetailTargetTierCostPerGbPerMonth { get; set; }
        /// <summary>
        /// Source tier size reduction in bytes after moving all the recommended backup points to target tier
        /// </summary>
        long SourceTierSizeReductionInByte { get; set; }
        /// <summary>
        /// Target tier size increase in bytes after moving all the recommended backup points to target tier
        /// </summary>
        long TargetTierSizeIncreaseInByte { get; set; }

    }
}