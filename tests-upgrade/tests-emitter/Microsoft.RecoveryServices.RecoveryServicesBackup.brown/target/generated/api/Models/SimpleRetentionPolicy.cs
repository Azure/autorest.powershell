// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Simple policy retention.</summary>
    public partial class SimpleRetentionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy __retentionPolicy = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicy();

        /// <summary>Internal Acessors for RetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleRetentionPolicyInternal.RetentionDuration { get => (this._retentionDuration = this._retentionDuration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDuration()); set { {_retentionDuration = value;} } }

        /// <summary>Backing field for <see cref="RetentionDuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration _retentionDuration;

        /// <summary>Retention duration of the protection policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration RetentionDuration { get => (this._retentionDuration = this._retentionDuration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDuration()); set => this._retentionDuration = value; }

        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? RetentionDurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).Count; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).Count = value ?? default(int); }

        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RetentionDurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).DurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).DurationType = value ?? null; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "SimpleRetentionPolicy"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)__retentionPolicy).Type = "SimpleRetentionPolicy"; }

        /// <summary>Creates an new <see cref="SimpleRetentionPolicy" /> instance.</summary>
        public SimpleRetentionPolicy()
        {
            this.__retentionPolicy.Type = "SimpleRetentionPolicy";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__retentionPolicy), __retentionPolicy);
            await eventListener.AssertObjectIsValid(nameof(__retentionPolicy), __retentionPolicy);
        }
    }
    /// Simple policy retention.
    public partial interface ISimpleRetentionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy
    {
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention duration type of retention policy.",
        SerializedName = @"durationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string RetentionDurationType { get; set; }

    }
    /// Simple policy retention.
    internal partial interface ISimpleRetentionPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal
    {
        /// <summary>Retention duration of the protection policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration RetentionDuration { get; set; }
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        int? RetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string RetentionDurationType { get; set; }

    }
}