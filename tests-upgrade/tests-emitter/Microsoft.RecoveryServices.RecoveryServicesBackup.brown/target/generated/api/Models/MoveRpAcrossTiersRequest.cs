// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    public partial class MoveRpAcrossTiersRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMoveRpAcrossTiersRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMoveRpAcrossTiersRequestInternal
    {

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        /// <summary>Gets the class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="SourceTierType" /> property.</summary>
        private string _sourceTierType;

        /// <summary>Source tier from where RP needs to be moved</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceTierType { get => this._sourceTierType; set => this._sourceTierType = value; }

        /// <summary>Backing field for <see cref="TargetTierType" /> property.</summary>
        private string _targetTierType;

        /// <summary>Target tier where RP needs to be moved</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TargetTierType { get => this._targetTierType; set => this._targetTierType = value; }

        /// <summary>Creates an new <see cref="MoveRpAcrossTiersRequest" /> instance.</summary>
        public MoveRpAcrossTiersRequest()
        {

        }
    }
    public partial interface IMoveRpAcrossTiersRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Gets the class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets the class type.",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }
        /// <summary>Source tier from where RP needs to be moved</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source tier from where RP needs to be moved",
        SerializedName = @"sourceTierType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string SourceTierType { get; set; }
        /// <summary>Target tier where RP needs to be moved</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target tier where RP needs to be moved",
        SerializedName = @"targetTierType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string TargetTierType { get; set; }

    }
    internal partial interface IMoveRpAcrossTiersRequestInternal

    {
        /// <summary>Gets the class type.</summary>
        string ObjectType { get; set; }
        /// <summary>Source tier from where RP needs to be moved</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string SourceTierType { get; set; }
        /// <summary>Target tier where RP needs to be moved</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string TargetTierType { get; set; }

    }
}