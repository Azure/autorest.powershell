// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>ListRecoveryPointsRecommendedForMoveRequest Request</summary>
    public partial class ListRecoveryPointsRecommendedForMoveRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IListRecoveryPointsRecommendedForMoveRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IListRecoveryPointsRecommendedForMoveRequestInternal
    {

        /// <summary>Backing field for <see cref="ExcludedRpList" /> property.</summary>
        private System.Collections.Generic.List<string> _excludedRpList;

        /// <summary>List of Recovery Points excluded from Move</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ExcludedRpList { get => this._excludedRpList; set => this._excludedRpList = value; }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        /// <summary>Gets the class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>
        /// Creates an new <see cref="ListRecoveryPointsRecommendedForMoveRequest" /> instance.
        /// </summary>
        public ListRecoveryPointsRecommendedForMoveRequest()
        {

        }
    }
    /// ListRecoveryPointsRecommendedForMoveRequest Request
    public partial interface IListRecoveryPointsRecommendedForMoveRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of Recovery Points excluded from Move</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Recovery Points excluded from Move",
        SerializedName = @"excludedRPList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ExcludedRpList { get; set; }
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

    }
    /// ListRecoveryPointsRecommendedForMoveRequest Request
    internal partial interface IListRecoveryPointsRecommendedForMoveRequestInternal

    {
        /// <summary>List of Recovery Points excluded from Move</summary>
        System.Collections.Generic.List<string> ExcludedRpList { get; set; }
        /// <summary>Gets the class type.</summary>
        string ObjectType { get; set; }

    }
}