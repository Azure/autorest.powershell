// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The secrets related to a databox heavy job.</summary>
    public partial class DataBoxHeavyJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyJobSecrets,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyJobSecretsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets __jobSecrets = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobSecrets();

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).AdditionalInfo; }

        /// <summary>Backing field for <see cref="CabinetPodSecret" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavySecret> _cabinetPodSecret;

        /// <summary>Contains the list of secret objects for a databox heavy job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavySecret> CabinetPodSecret { get => this._cabinetPodSecret; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Code; }

        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode DcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode = value ?? null /* model class */; }

        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode; }

        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Detail; }

        /// <summary>Error while fetching the secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Error = value ?? null /* model class */; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Message; }

        /// <summary>Internal Acessors for CabinetPodSecret</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavySecret> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyJobSecretsInternal.CabinetPodSecret { get => this._cabinetPodSecret; set { {_cabinetPodSecret = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Code = value ?? null; }

        /// <summary>Internal Acessors for DcAccessSecurityCode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.DcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DcAccessSecurityCodeForwardDcAccessCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode = value ?? null; }

        /// <summary>Internal Acessors for DcAccessSecurityCodeReverseDcAccessCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Target = value ?? null; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Target; }

        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Type { get => "DataBoxHeavy"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)__jobSecrets).Type = "DataBoxHeavy"; }

        /// <summary>Creates an new <see cref="DataBoxHeavyJobSecrets" /> instance.</summary>
        public DataBoxHeavyJobSecrets()
        {
            this.__jobSecrets.Type = "DataBoxHeavy";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobSecrets), __jobSecrets);
            await eventListener.AssertObjectIsValid(nameof(__jobSecrets), __jobSecrets);
        }
    }
    /// The secrets related to a databox heavy job.
    public partial interface IDataBoxHeavyJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets
    {
        /// <summary>Contains the list of secret objects for a databox heavy job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Contains the list of secret objects for a databox heavy job.",
        SerializedName = @"cabinetPodSecrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavySecret) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavySecret> CabinetPodSecret { get;  }

    }
    /// The secrets related to a databox heavy job.
    internal partial interface IDataBoxHeavyJobSecretsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal
    {
        /// <summary>Contains the list of secret objects for a databox heavy job.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavySecret> CabinetPodSecret { get; set; }

    }
}