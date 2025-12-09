// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>BackupStatus request.</summary>
    public partial class BackupStatusRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupStatusRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupStatusRequestInternal
    {

        /// <summary>Backing field for <see cref="PoLogicalName" /> property.</summary>
        private string _poLogicalName;

        /// <summary>Protectable Item Logical Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string PoLogicalName { get => this._poLogicalName; set => this._poLogicalName = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Entire ARM resource id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>Container Type - VM, SQLPaaS, DPM, AzureFileShare...</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Creates an new <see cref="BackupStatusRequest" /> instance.</summary>
        public BackupStatusRequest()
        {

        }
    }
    /// BackupStatus request.
    public partial interface IBackupStatusRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Protectable Item Logical Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Protectable Item Logical Name",
        SerializedName = @"poLogicalName",
        PossibleTypes = new [] { typeof(string) })]
        string PoLogicalName { get; set; }
        /// <summary>Entire ARM resource id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Entire ARM resource id of the resource",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>Container Type - VM, SQLPaaS, DPM, AzureFileShare...</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Container Type - VM, SQLPaaS, DPM, AzureFileShare...",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string ResourceType { get; set; }

    }
    /// BackupStatus request.
    internal partial interface IBackupStatusRequestInternal

    {
        /// <summary>Protectable Item Logical Name</summary>
        string PoLogicalName { get; set; }
        /// <summary>Entire ARM resource id of the resource</summary>
        string ResourceId { get; set; }
        /// <summary>Container Type - VM, SQLPaaS, DPM, AzureFileShare...</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string ResourceType { get; set; }

    }
}