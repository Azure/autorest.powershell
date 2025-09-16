// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>The key vault server error.</summary>
    public partial class Error :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Innererror" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError _innererror;

        /// <summary>Contains more specific error that narrows down the cause. May be null.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError Innererror { get => (this._innererror = this._innererror ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.Error()); }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Innererror</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorInternal.Innererror { get => (this._innererror = this._innererror ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.Error()); set { {_innererror = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="Error" /> instance.</summary>
        public Error()
        {

        }
    }
    /// The key vault server error.
    public partial interface IError :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Contains more specific error that narrows down the cause. May be null.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Contains more specific error that narrows down the cause. May be null.",
        SerializedName = @"innererror",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError) })]
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError Innererror { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// The key vault server error.
    internal partial interface IErrorInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>Contains more specific error that narrows down the cause. May be null.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IError Innererror { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }

    }
}