// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Target details for file / folder restore.</summary>
    public partial class InstantItemRecoveryTarget :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTarget,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantItemRecoveryTargetInternal
    {

        /// <summary>Backing field for <see cref="ClientScript" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> _clientScript;

        /// <summary>List of client scripts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> ClientScript { get => this._clientScript; set => this._clientScript = value; }

        /// <summary>Creates an new <see cref="InstantItemRecoveryTarget" /> instance.</summary>
        public InstantItemRecoveryTarget()
        {

        }
    }
    /// Target details for file / folder restore.
    public partial interface IInstantItemRecoveryTarget :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of client scripts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of client scripts.",
        SerializedName = @"clientScripts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> ClientScript { get; set; }

    }
    /// Target details for file / folder restore.
    internal partial interface IInstantItemRecoveryTargetInternal

    {
        /// <summary>List of client scripts.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientScriptForConnect> ClientScript { get; set; }

    }
}