// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Trigger DataMove Request</summary>
    public partial class TriggerDataMoveRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITriggerDataMoveRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITriggerDataMoveRequestInternal
    {

        /// <summary>Backing field for <see cref="CorrelationId" /> property.</summary>
        private string _correlationId;

        /// <summary>Correlation Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string CorrelationId { get => this._correlationId; set => this._correlationId = value; }

        /// <summary>Backing field for <see cref="DataMoveLevel" /> property.</summary>
        private string _dataMoveLevel;

        /// <summary>DataMove Level</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string DataMoveLevel { get => this._dataMoveLevel; set => this._dataMoveLevel = value; }

        /// <summary>Backing field for <see cref="PauseGc" /> property.</summary>
        private bool? _pauseGc;

        /// <summary>Pause GC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? PauseGc { get => this._pauseGc; set => this._pauseGc = value; }

        /// <summary>Backing field for <see cref="SourceContainerArmId" /> property.</summary>
        private System.Collections.Generic.List<string> _sourceContainerArmId;

        /// <summary>Source Container ArmIds</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SourceContainerArmId { get => this._sourceContainerArmId; set => this._sourceContainerArmId = value; }

        /// <summary>Backing field for <see cref="SourceRegion" /> property.</summary>
        private string _sourceRegion;

        /// <summary>Source Region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceRegion { get => this._sourceRegion; set => this._sourceRegion = value; }

        /// <summary>Backing field for <see cref="SourceResourceId" /> property.</summary>
        private string _sourceResourceId;

        /// <summary>ARM Id of source vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceResourceId { get => this._sourceResourceId; set => this._sourceResourceId = value; }

        /// <summary>Creates an new <see cref="TriggerDataMoveRequest" /> instance.</summary>
        public TriggerDataMoveRequest()
        {

        }
    }
    /// Trigger DataMove Request
    public partial interface ITriggerDataMoveRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Correlation Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Correlation Id",
        SerializedName = @"correlationId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationId { get; set; }
        /// <summary>DataMove Level</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DataMove Level",
        SerializedName = @"dataMoveLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Vault", "Container")]
        string DataMoveLevel { get; set; }
        /// <summary>Pause GC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Pause GC",
        SerializedName = @"pauseGC",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PauseGc { get; set; }
        /// <summary>Source Container ArmIds</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source Container ArmIds",
        SerializedName = @"sourceContainerArmIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SourceContainerArmId { get; set; }
        /// <summary>Source Region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source Region",
        SerializedName = @"sourceRegion",
        PossibleTypes = new [] { typeof(string) })]
        string SourceRegion { get; set; }
        /// <summary>ARM Id of source vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM Id of source vault",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceId { get; set; }

    }
    /// Trigger DataMove Request
    internal partial interface ITriggerDataMoveRequestInternal

    {
        /// <summary>Correlation Id</summary>
        string CorrelationId { get; set; }
        /// <summary>DataMove Level</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Vault", "Container")]
        string DataMoveLevel { get; set; }
        /// <summary>Pause GC</summary>
        bool? PauseGc { get; set; }
        /// <summary>Source Container ArmIds</summary>
        System.Collections.Generic.List<string> SourceContainerArmId { get; set; }
        /// <summary>Source Region</summary>
        string SourceRegion { get; set; }
        /// <summary>ARM Id of source vault</summary>
        string SourceResourceId { get; set; }

    }
}