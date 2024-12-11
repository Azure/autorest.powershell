// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the Managed Identity used by ADE to get access token for keyvault
    /// operations.
    /// </summary>
    public partial class EncryptionIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentityInternal
    {

        /// <summary>Backing field for <see cref="UserAssignedIdentityResourceId" /> property.</summary>
        private string _userAssignedIdentityResourceId;

        /// <summary>Specifies ARM Resource ID of one of the user identities associated with the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string UserAssignedIdentityResourceId { get => this._userAssignedIdentityResourceId; set => this._userAssignedIdentityResourceId = value; }

        /// <summary>Creates an new <see cref="EncryptionIdentity" /> instance.</summary>
        public EncryptionIdentity()
        {

        }
    }
    /// Specifies the Managed Identity used by ADE to get access token for keyvault
    /// operations.
    public partial interface IEncryptionIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specifies ARM Resource ID of one of the user identities associated with the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies ARM Resource ID of one of the user identities associated with the VM.",
        SerializedName = @"userAssignedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityResourceId { get; set; }

    }
    /// Specifies the Managed Identity used by ADE to get access token for keyvault
    /// operations.
    internal partial interface IEncryptionIdentityInternal

    {
        /// <summary>Specifies ARM Resource ID of one of the user identities associated with the VM.</summary>
        string UserAssignedIdentityResourceId { get; set; }

    }
}