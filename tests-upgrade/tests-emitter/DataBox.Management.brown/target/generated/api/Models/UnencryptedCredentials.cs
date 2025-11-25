// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Unencrypted credentials for accessing device.</summary>
    public partial class UnencryptedCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal
    {

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Code; }

        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeForwardDcAccessCode; }

        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeReverseDcAccessCode; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Detail; }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>Name of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string JobName { get => this._jobName; }

        /// <summary>Backing field for <see cref="JobSecret" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets _jobSecret;

        /// <summary>Secrets related to this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets JobSecret { get => (this._jobSecret = this._jobSecret ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobSecrets()); }

        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string JobSecretJobSecretsType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Type; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Code = value ?? null; }

        /// <summary>Internal Acessors for DcAccessSecurityCodeForwardDcAccessCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeForwardDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeForwardDcAccessCode = value ?? null; }

        /// <summary>Internal Acessors for DcAccessSecurityCodeReverseDcAccessCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeReverseDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeReverseDcAccessCode = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for JobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.JobName { get => this._jobName; set { {_jobName = value;} } }

        /// <summary>Internal Acessors for JobSecret</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.JobSecret { get => (this._jobSecret = this._jobSecret ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobSecrets()); set { {_jobSecret = value;} } }

        /// <summary>Internal Acessors for JobSecretDcAccessSecurityCode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.JobSecretDcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).DcAccessSecurityCode = value ?? null /* model class */; }

        /// <summary>Internal Acessors for JobSecretError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.JobSecretError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for JobSecretJobSecretsType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.JobSecretJobSecretsType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Type = value ?? null; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Target = value ?? null; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)JobSecret).Target; }

        /// <summary>Creates an new <see cref="UnencryptedCredentials" /> instance.</summary>
        public UnencryptedCredentials()
        {

        }
    }
    /// Unencrypted credentials for accessing device.
    public partial interface IUnencryptedCredentials :
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
        /// <summary>Name of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the job.",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        string JobName { get;  }
        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used to indicate what type of job secrets object.",
        SerializedName = @"jobSecretsType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string JobSecretJobSecretsType { get;  }
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

    }
    /// Unencrypted credentials for accessing device.
    internal partial interface IUnencryptedCredentialsInternal

    {
        /// <summary>Gets or sets additional error info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Forward Dc access security code.</summary>
        string DcAccessSecurityCodeForwardDcAccessCode { get; set; }
        /// <summary>Reverse Dc access security code.</summary>
        string DcAccessSecurityCodeReverseDcAccessCode { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get; set; }
        /// <summary>Name of the job.</summary>
        string JobName { get; set; }
        /// <summary>Secrets related to this job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets JobSecret { get; set; }
        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode JobSecretDcAccessSecurityCode { get; set; }
        /// <summary>Error while fetching the secrets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError JobSecretError { get; set; }
        /// <summary>Used to indicate what type of job secrets object.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string JobSecretJobSecretsType { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }

    }
}