// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>An error response from Azure Backup.</summary>
    public partial class CloudError :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudError,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError _error;

        /// <summary>The resource management error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Error()); set => this._error = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Error()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICloudErrorInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Target = value ?? null; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Target; }

        /// <summary>Creates an new <see cref="CloudError" /> instance.</summary>
        public CloudError()
        {

        }
    }
    /// An error response from Azure Backup.
    public partial interface ICloudError :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Detail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// An error response from Azure Backup.
    internal partial interface ICloudErrorInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Detail { get; set; }
        /// <summary>The resource management error response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError Error { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}