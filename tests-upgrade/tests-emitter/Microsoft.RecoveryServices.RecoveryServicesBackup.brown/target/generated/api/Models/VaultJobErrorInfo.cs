// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Vault Job specific error information</summary>
    public partial class VaultJobErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfoInternal
    {

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private int? _errorCode;

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="ErrorString" /> property.</summary>
        private string _errorString;

        /// <summary>Localized error string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ErrorString { get => this._errorString; set => this._errorString = value; }

        /// <summary>Backing field for <see cref="Recommendation" /> property.</summary>
        private System.Collections.Generic.List<string> _recommendation;

        /// <summary>List of localized recommendations for above error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Recommendation { get => this._recommendation; set => this._recommendation = value; }

        /// <summary>Creates an new <see cref="VaultJobErrorInfo" /> instance.</summary>
        public VaultJobErrorInfo()
        {

        }
    }
    /// Vault Job specific error information
    public partial interface IVaultJobErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Error code.",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ErrorCode { get; set; }
        /// <summary>Localized error string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Localized error string.",
        SerializedName = @"errorString",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorString { get; set; }
        /// <summary>List of localized recommendations for above error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of localized recommendations for above error code.",
        SerializedName = @"recommendations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Recommendation { get; set; }

    }
    /// Vault Job specific error information
    internal partial interface IVaultJobErrorInfoInternal

    {
        /// <summary>Error code.</summary>
        int? ErrorCode { get; set; }
        /// <summary>Localized error string.</summary>
        string ErrorString { get; set; }
        /// <summary>List of localized recommendations for above error code.</summary>
        System.Collections.Generic.List<string> Recommendation { get; set; }

    }
}