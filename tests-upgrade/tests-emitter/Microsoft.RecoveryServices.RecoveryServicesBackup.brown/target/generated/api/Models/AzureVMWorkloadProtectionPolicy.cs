// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure VM (Mercury) workload-specific backup policy.</summary>
    public partial class AzureVMWorkloadProtectionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectionPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectionPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicy __protectionPolicy = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ProtectionPolicy();

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => "AzureWorkload"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).BackupManagementType = "AzureWorkload"; }

        /// <summary>Backing field for <see cref="MakePolicyConsistent" /> property.</summary>
        private bool? _makePolicyConsistent;

        /// <summary>Fix the policy inconsistency</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? MakePolicyConsistent { get => this._makePolicyConsistent; set => this._makePolicyConsistent = value; }

        /// <summary>Internal Acessors for Setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectionPolicyInternal.Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Settings()); set { {_setting = value;} } }

        /// <summary>Number of items associated with this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? ProtectedItemsCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ProtectedItemsCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ProtectedItemsCount = value ?? default(int); }

        /// <summary>ResourceGuard Operation Requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettings _setting;

        /// <summary>Common settings for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettings Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Settings()); set => this._setting = value; }

        /// <summary>
        /// Workload compression flag. This has been added so that 'isSqlCompression'
        /// will be deprecated once clients upgrade to consider this flag.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? SettingIsCompression { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettingsInternal)Setting).IsCompression; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettingsInternal)Setting).IsCompression = value ?? default(bool); }

        /// <summary>SQL compression flag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? SettingIssqlcompression { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettingsInternal)Setting).Issqlcompression; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettingsInternal)Setting).Issqlcompression = value ?? default(bool); }

        /// <summary>
        /// TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string SettingTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettingsInternal)Setting).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettingsInternal)Setting).TimeZone = value ?? null; }

        /// <summary>Backing field for <see cref="SubProtectionPolicy" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy> _subProtectionPolicy;

        /// <summary>List of sub-protection policies which includes schedule and retention</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy> SubProtectionPolicy { get => this._subProtectionPolicy; set => this._subProtectionPolicy = value; }

        /// <summary>Backing field for <see cref="WorkLoadType" /> property.</summary>
        private string _workLoadType;

        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string WorkLoadType { get => this._workLoadType; set => this._workLoadType = value; }

        /// <summary>Creates an new <see cref="AzureVMWorkloadProtectionPolicy" /> instance.</summary>
        public AzureVMWorkloadProtectionPolicy()
        {
            this.__protectionPolicy.BackupManagementType = "AzureWorkload";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectionPolicy), __protectionPolicy);
            await eventListener.AssertObjectIsValid(nameof(__protectionPolicy), __protectionPolicy);
        }
    }
    /// Azure VM (Mercury) workload-specific backup policy.
    public partial interface IAzureVMWorkloadProtectionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicy
    {
        /// <summary>Fix the policy inconsistency</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fix the policy inconsistency",
        SerializedName = @"makePolicyConsistent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MakePolicyConsistent { get; set; }
        /// <summary>
        /// Workload compression flag. This has been added so that 'isSqlCompression'
        /// will be deprecated once clients upgrade to consider this flag.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workload compression flag. This has been added so that 'isSqlCompression'
        will be deprecated once clients upgrade to consider this flag.",
        SerializedName = @"isCompression",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SettingIsCompression { get; set; }
        /// <summary>SQL compression flag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SQL compression flag",
        SerializedName = @"issqlcompression",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SettingIssqlcompression { get; set; }
        /// <summary>
        /// TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"TimeZone optional input as string. For example: TimeZone = ""Pacific Standard Time"".",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string SettingTimeZone { get; set; }
        /// <summary>List of sub-protection policies which includes schedule and retention</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of sub-protection policies which includes schedule and retention",
        SerializedName = @"subProtectionPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy> SubProtectionPolicy { get; set; }
        /// <summary>Type of workload for the backup management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of workload for the backup management",
        SerializedName = @"workLoadType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkLoadType { get; set; }

    }
    /// Azure VM (Mercury) workload-specific backup policy.
    internal partial interface IAzureVMWorkloadProtectionPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal
    {
        /// <summary>Fix the policy inconsistency</summary>
        bool? MakePolicyConsistent { get; set; }
        /// <summary>Common settings for the backup management</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISettings Setting { get; set; }
        /// <summary>
        /// Workload compression flag. This has been added so that 'isSqlCompression'
        /// will be deprecated once clients upgrade to consider this flag.
        /// </summary>
        bool? SettingIsCompression { get; set; }
        /// <summary>SQL compression flag</summary>
        bool? SettingIssqlcompression { get; set; }
        /// <summary>
        /// TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time".
        /// </summary>
        string SettingTimeZone { get; set; }
        /// <summary>List of sub-protection policies which includes schedule and retention</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy> SubProtectionPolicy { get; set; }
        /// <summary>Type of workload for the backup management</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkLoadType { get; set; }

    }
}