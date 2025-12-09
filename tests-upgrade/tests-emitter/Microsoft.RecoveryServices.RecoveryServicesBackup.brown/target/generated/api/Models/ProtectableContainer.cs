// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Protectable Container Class.</summary>
    public partial class ProtectableContainer :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectableContainer,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectableContainerInternal
    {

        /// <summary>Backing field for <see cref="BackupManagementType" /> property.</summary>
        private string _backupManagementType;

        /// <summary>Type of backup management for the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string BackupManagementType { get => this._backupManagementType; set => this._backupManagementType = value; }

        /// <summary>Backing field for <see cref="ContainerId" /> property.</summary>
        private string _containerId;

        /// <summary>Fabric Id of the container such as ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ContainerId { get => this._containerId; set => this._containerId = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="HealthStatus" /> property.</summary>
        private string _healthStatus;

        /// <summary>Status of health of the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string HealthStatus { get => this._healthStatus; set => this._healthStatus = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// Type of the container. The value of this property for
        /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
        /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ProtectableContainer" /> instance.</summary>
        public ProtectableContainer()
        {

        }
    }
    /// Protectable Container Class.
    public partial interface IProtectableContainer :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Type of backup management for the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup management for the container.",
        SerializedName = @"backupManagementType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "AzureIaasVM", "MAB", "DPM", "AzureBackupServer", "AzureSql", "AzureStorage", "AzureWorkload", "DefaultBackup")]
        string BackupManagementType { get; set; }
        /// <summary>Fabric Id of the container such as ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fabric Id of the container such as ARM Id.",
        SerializedName = @"containerId",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerId { get; set; }
        /// <summary>Friendly name of the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Friendly name of the container.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>Status of health of the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of health of the container.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get; set; }
        /// <summary>
        /// Type of the container. The value of this property for
        /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
        /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the container. The value of this property for
        1. Compute Azure VM is Microsoft.Compute/virtualMachines
        2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines",
        SerializedName = @"protectableContainerType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Unknown", "IaasVMContainer", "IaasVMServiceContainer", "DPMContainer", "AzureBackupServerContainer", "MABContainer", "Cluster", "AzureSqlContainer", "Windows", "VCenter", "VMAppContainer", "SQLAGWorkLoadContainer", "StorageContainer", "GenericContainer", "Microsoft.ClassicCompute/virtualMachines", "Microsoft.Compute/virtualMachines", "AzureWorkloadContainer")]
        string Type { get; set; }

    }
    /// Protectable Container Class.
    internal partial interface IProtectableContainerInternal

    {
        /// <summary>Type of backup management for the container.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "AzureIaasVM", "MAB", "DPM", "AzureBackupServer", "AzureSql", "AzureStorage", "AzureWorkload", "DefaultBackup")]
        string BackupManagementType { get; set; }
        /// <summary>Fabric Id of the container such as ARM Id.</summary>
        string ContainerId { get; set; }
        /// <summary>Friendly name of the container.</summary>
        string FriendlyName { get; set; }
        /// <summary>Status of health of the container.</summary>
        string HealthStatus { get; set; }
        /// <summary>
        /// Type of the container. The value of this property for
        /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
        /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Unknown", "IaasVMContainer", "IaasVMServiceContainer", "DPMContainer", "AzureBackupServerContainer", "MABContainer", "Cluster", "AzureSqlContainer", "Windows", "VCenter", "VMAppContainer", "SQLAGWorkLoadContainer", "StorageContainer", "GenericContainer", "Microsoft.ClassicCompute/virtualMachines", "Microsoft.Compute/virtualMachines", "AzureWorkloadContainer")]
        string Type { get; set; }

    }
}