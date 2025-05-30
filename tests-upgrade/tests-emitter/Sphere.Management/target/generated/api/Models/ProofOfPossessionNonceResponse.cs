// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Result of the action to generate a proof of possession nonce</summary>
    public partial class ProofOfPossessionNonceResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProofOfPossessionNonceResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProofOfPossessionNonceResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties __certificateProperties = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.CertificateProperties();

        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Certificate; }

        /// <summary>The certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? ExpiryUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).ExpiryUtc; }

        /// <summary>Internal Acessors for Certificate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Certificate = value ?? null; }

        /// <summary>Internal Acessors for ExpiryUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.ExpiryUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).ExpiryUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).ExpiryUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for NotBeforeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.NotBeforeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).NotBeforeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).NotBeforeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Status = value ?? null; }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Subject = value ?? null; }

        /// <summary>Internal Acessors for Thumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Thumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Thumbprint = value ?? null; }

        /// <summary>The certificate not before date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? NotBeforeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).NotBeforeUtc; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).ProvisioningState; }

        /// <summary>The certificate status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Status; }

        /// <summary>The certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Subject; }

        /// <summary>The certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)__certificateProperties).Thumbprint; }

        /// <summary>Creates an new <see cref="ProofOfPossessionNonceResponse" /> instance.</summary>
        public ProofOfPossessionNonceResponse()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__certificateProperties), __certificateProperties);
            await eventListener.AssertObjectIsValid(nameof(__certificateProperties), __certificateProperties);
        }
    }
    /// Result of the action to generate a proof of possession nonce
    public partial interface IProofOfPossessionNonceResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties
    {

    }
    /// Result of the action to generate a proof of possession nonce
    internal partial interface IProofOfPossessionNonceResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal
    {

    }
}