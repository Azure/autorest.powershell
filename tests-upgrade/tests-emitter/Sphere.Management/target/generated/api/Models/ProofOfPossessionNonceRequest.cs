// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Request for the proof of possession nonce</summary>
    public partial class ProofOfPossessionNonceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProofOfPossessionNonceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProofOfPossessionNonceRequestInternal
    {

        /// <summary>Backing field for <see cref="ProofOfPossessionNonce" /> property.</summary>
        private string _proofOfPossessionNonce;

        /// <summary>The proof of possession nonce</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProofOfPossessionNonce { get => this._proofOfPossessionNonce; set => this._proofOfPossessionNonce = value; }

        /// <summary>Creates an new <see cref="ProofOfPossessionNonceRequest" /> instance.</summary>
        public ProofOfPossessionNonceRequest()
        {

        }
    }
    /// Request for the proof of possession nonce
    public partial interface IProofOfPossessionNonceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The proof of possession nonce</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The proof of possession nonce",
        SerializedName = @"proofOfPossessionNonce",
        PossibleTypes = new [] { typeof(string) })]
        string ProofOfPossessionNonce { get; set; }

    }
    /// Request for the proof of possession nonce
    internal partial interface IProofOfPossessionNonceRequestInternal

    {
        /// <summary>The proof of possession nonce</summary>
        string ProofOfPossessionNonce { get; set; }

    }
}