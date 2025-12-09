// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>DPM workload-specific error information.</summary>
    public partial class DpmErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfoInternal
    {

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

        /// <summary>Creates an new <see cref="DpmErrorInfo" /> instance.</summary>
        public DpmErrorInfo()
        {

        }
    }
    /// DPM workload-specific error information.
    public partial interface IDpmErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
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
    /// DPM workload-specific error information.
    internal partial interface IDpmErrorInfoInternal

    {
        /// <summary>Localized error string.</summary>
        string ErrorString { get; set; }
        /// <summary>List of localized recommendations for above error code.</summary>
        System.Collections.Generic.List<string> Recommendation { get; set; }

    }
}