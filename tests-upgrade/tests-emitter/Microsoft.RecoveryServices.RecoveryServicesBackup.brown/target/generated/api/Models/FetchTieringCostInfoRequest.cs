// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// Base class for tiering cost request.
    /// Specific cost request types are derived from this class.
    /// </summary>
    public partial class FetchTieringCostInfoRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFetchTieringCostInfoRequestInternal
    {

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="SourceTierType" /> property.</summary>
        private string _sourceTierType;

        /// <summary>Source tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SourceTierType { get => this._sourceTierType; set => this._sourceTierType = value; }

        /// <summary>Backing field for <see cref="TargetTierType" /> property.</summary>
        private string _targetTierType;

        /// <summary>target tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TargetTierType { get => this._targetTierType; set => this._targetTierType = value; }

        /// <summary>Creates an new <see cref="FetchTieringCostInfoRequest" /> instance.</summary>
        public FetchTieringCostInfoRequest()
        {

        }
    }
    /// Base class for tiering cost request.
    /// Specific cost request types are derived from this class.
    public partial interface IFetchTieringCostInfoRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }
        /// <summary>Source tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Source tier for the request",
        SerializedName = @"sourceTierType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string SourceTierType { get; set; }
        /// <summary>target tier for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"target tier for the request",
        SerializedName = @"targetTierType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string TargetTierType { get; set; }

    }
    /// Base class for tiering cost request.
    /// Specific cost request types are derived from this class.
    internal partial interface IFetchTieringCostInfoRequestInternal

    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        string ObjectType { get; set; }
        /// <summary>Source tier for the request</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string SourceTierType { get; set; }
        /// <summary>target tier for the request</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "InstantRP", "HardenedRP", "ArchivedRP")]
        string TargetTierType { get; set; }

    }
}