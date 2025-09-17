// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>Status information for the fleet member</summary>
    public partial class FleetMemberStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal
    {

        /// <summary>Backing field for <see cref="LastOperationError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail _lastOperationError;

        /// <summary>The last operation error of the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail LastOperationError { get => (this._lastOperationError = this._lastOperationError ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetail()); }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Detail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Message; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Target; }

        /// <summary>Backing field for <see cref="LastOperationId" /> property.</summary>
        private string _lastOperationId;

        /// <summary>The last operation ID for the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string LastOperationId { get => this._lastOperationId; }

        /// <summary>Internal Acessors for LastOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationError { get => (this._lastOperationError = this._lastOperationError ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetail()); set { {_lastOperationError = value;} } }

        /// <summary>Internal Acessors for LastOperationErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Code = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Message = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastOperationError).Target = value ?? null; }

        /// <summary>Internal Acessors for LastOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal.LastOperationId { get => this._lastOperationId; set { {_lastOperationId = value;} } }

        /// <summary>Creates an new <see cref="FleetMemberStatus" /> instance.</summary>
        public FleetMemberStatus()
        {

        }
    }
    /// Status information for the fleet member
    public partial interface IFleetMemberStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorTarget { get;  }
        /// <summary>The last operation ID for the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The last operation ID for the fleet member",
        SerializedName = @"lastOperationId",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationId { get;  }

    }
    /// Status information for the fleet member
    internal partial interface IFleetMemberStatusInternal

    {
        /// <summary>The last operation error of the fleet member</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail LastOperationError { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string LastOperationErrorCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get; set; }
        /// <summary>The error message.</summary>
        string LastOperationErrorMessage { get; set; }
        /// <summary>The error target.</summary>
        string LastOperationErrorTarget { get; set; }
        /// <summary>The last operation ID for the fleet member</summary>
        string LastOperationId { get; set; }

    }
}