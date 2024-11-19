// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>The CheckNameAvailability operation response.</summary>
    public partial class CheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailabilityResult,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailabilityResultInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>An error message explaining the Reason value in more detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailabilityResultInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Internal Acessors for NameAvailable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailabilityResultInternal.NameAvailable { get => this._nameAvailable; set { {_nameAvailable = value;} } }

        /// <summary>Internal Acessors for Reason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailabilityResultInternal.Reason { get => this._reason; set { {_reason = value;} } }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>
        /// A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false,
        /// the name has already been taken or is invalid and cannot be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>
        /// The reason that a trusted signing account name could not be used. The Reason element is only returned if nameAvailable
        /// is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResult" /> instance.</summary>
        public CheckNameAvailabilityResult()
        {

        }
    }
    /// The CheckNameAvailability operation response.
    public partial interface ICheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>An error message explaining the Reason value in more detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"An error message explaining the Reason value in more detail.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>
        /// A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false,
        /// the name has already been taken or is invalid and cannot be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or is invalid and cannot be used.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get;  }
        /// <summary>
        /// The reason that a trusted signing account name could not be used. The Reason element is only returned if nameAvailable
        /// is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The reason that a trusted signing account name could not be used. The Reason element is only returned if nameAvailable is false.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("AccountNameInvalid", "AlreadyExists")]
        string Reason { get;  }

    }
    /// The CheckNameAvailability operation response.
    internal partial interface ICheckNameAvailabilityResultInternal

    {
        /// <summary>An error message explaining the Reason value in more detail.</summary>
        string Message { get; set; }
        /// <summary>
        /// A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false,
        /// the name has already been taken or is invalid and cannot be used.
        /// </summary>
        bool? NameAvailable { get; set; }
        /// <summary>
        /// The reason that a trusted signing account name could not be used. The Reason element is only returned if nameAvailable
        /// is false.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("AccountNameInvalid", "AlreadyExists")]
        string Reason { get; set; }

    }
}