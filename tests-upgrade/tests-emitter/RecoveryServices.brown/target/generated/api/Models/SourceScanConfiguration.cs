// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Source scan configuration of vault</summary>
    public partial class SourceScanConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal
    {

        /// <summary>Internal Acessors for SourceScanIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal.SourceScanIdentity { get => (this._sourceScanIdentity = this._sourceScanIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AssociatedIdentity()); set { {_sourceScanIdentity = value;} } }

        /// <summary>Backing field for <see cref="SourceScanIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity _sourceScanIdentity;

        /// <summary>Identity details to be used for an operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity SourceScanIdentity { get => (this._sourceScanIdentity = this._sourceScanIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AssociatedIdentity()); set => this._sourceScanIdentity = value; }

        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityOperationIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentityInternal)SourceScanIdentity).OperationIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentityInternal)SourceScanIdentity).OperationIdentityType = value ?? null; }

        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentityInternal)SourceScanIdentity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentityInternal)SourceScanIdentity).UserAssignedIdentity = value ?? null; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="SourceScanConfiguration" /> instance.</summary>
        public SourceScanConfiguration()
        {

        }
    }
    /// Source scan configuration of vault
    public partial interface ISourceScanConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type that should be used for an operation.",
        SerializedName = @"operationIdentityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string SourceScanIdentityOperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity to be used for an operation if operationIdentityType is UserAssigned.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string SourceScanIdentityUserAssignedIdentity { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string State { get; set; }

    }
    /// Source scan configuration of vault
    internal partial interface ISourceScanConfigurationInternal

    {
        /// <summary>Identity details to be used for an operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity SourceScanIdentity { get; set; }
        /// <summary>Identity type that should be used for an operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string SourceScanIdentityOperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        string SourceScanIdentityUserAssignedIdentity { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string State { get; set; }

    }
}