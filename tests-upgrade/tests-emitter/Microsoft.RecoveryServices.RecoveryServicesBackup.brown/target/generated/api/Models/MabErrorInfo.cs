// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>MAB workload-specific error information.</summary>
    public partial class MabErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfoInternal
    {

        /// <summary>Backing field for <see cref="ErrorString" /> property.</summary>
        private string _errorString;

        /// <summary>Localized error string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ErrorString { get => this._errorString; }

        /// <summary>Internal Acessors for ErrorString</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfoInternal.ErrorString { get => this._errorString; set { {_errorString = value;} } }

        /// <summary>Internal Acessors for Recommendation</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfoInternal.Recommendation { get => this._recommendation; set { {_recommendation = value;} } }

        /// <summary>Backing field for <see cref="Recommendation" /> property.</summary>
        private System.Collections.Generic.List<string> _recommendation;

        /// <summary>List of localized recommendations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Recommendation { get => this._recommendation; }

        /// <summary>Creates an new <see cref="MabErrorInfo" /> instance.</summary>
        public MabErrorInfo()
        {

        }
    }
    /// MAB workload-specific error information.
    public partial interface IMabErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Localized error string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Localized error string.",
        SerializedName = @"errorString",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorString { get;  }
        /// <summary>List of localized recommendations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of localized recommendations.",
        SerializedName = @"recommendations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Recommendation { get;  }

    }
    /// MAB workload-specific error information.
    internal partial interface IMabErrorInfoInternal

    {
        /// <summary>Localized error string.</summary>
        string ErrorString { get; set; }
        /// <summary>List of localized recommendations.</summary>
        System.Collections.Generic.List<string> Recommendation { get; set; }

    }
}