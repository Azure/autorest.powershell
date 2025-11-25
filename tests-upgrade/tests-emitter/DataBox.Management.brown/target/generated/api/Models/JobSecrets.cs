// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The base class for the secrets</summary>
    public partial class JobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal
    {

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code; }

        /// <summary>Backing field for <see cref="DcAccessSecurityCode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode _dcAccessSecurityCode;

        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode DcAccessSecurityCode { get => (this._dcAccessSecurityCode = this._dcAccessSecurityCode ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DcAccessSecurityCode()); }

        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCodeInternal)DcAccessSecurityCode).ForwardDcAccessCode; }

        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCodeInternal)DcAccessSecurityCode).ReverseDcAccessCode; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError _error;

        /// <summary>Error while fetching the secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudError()); }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for DcAccessSecurityCode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.DcAccessSecurityCode { get => (this._dcAccessSecurityCode = this._dcAccessSecurityCode ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DcAccessSecurityCode()); set { {_dcAccessSecurityCode = value;} } }

        /// <summary>Internal Acessors for DcAccessSecurityCodeForwardDcAccessCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCodeInternal)DcAccessSecurityCode).ForwardDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCodeInternal)DcAccessSecurityCode).ForwardDcAccessCode = value ?? null; }

        /// <summary>Internal Acessors for DcAccessSecurityCodeReverseDcAccessCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCodeInternal)DcAccessSecurityCode).ReverseDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCodeInternal)DcAccessSecurityCode).ReverseDcAccessCode = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target = value ?? null; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="JobSecrets" /> instance.</summary>
        public JobSecrets()
        {

        }
    }
    /// The base class for the secrets
    public partial interface IJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets additional error info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get;  }
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Forward Dc access security code.",
        SerializedName = @"forwardDCAccessCode",
        PossibleTypes = new [] { typeof(string) })]
        string DcAccessSecurityCodeForwardDcAccessCode { get;  }
        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Reverse Dc access security code.",
        SerializedName = @"reverseDCAccessCode",
        PossibleTypes = new [] { typeof(string) })]
        string DcAccessSecurityCodeReverseDcAccessCode { get;  }
        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets details for the error.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get;  }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message parsed from the body of the http error response.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }
        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Used to indicate what type of job secrets object.",
        SerializedName = @"jobSecretsType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string Type { get; set; }

    }
    /// The base class for the secrets
    internal partial interface IJobSecretsInternal

    {
        /// <summary>Gets or sets additional error info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode DcAccessSecurityCode { get; set; }
        /// <summary>Forward Dc access security code.</summary>
        string DcAccessSecurityCodeForwardDcAccessCode { get; set; }
        /// <summary>Reverse Dc access security code.</summary>
        string DcAccessSecurityCodeReverseDcAccessCode { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get; set; }
        /// <summary>Error while fetching the secrets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }
        /// <summary>Used to indicate what type of job secrets object.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string Type { get; set; }

    }
}