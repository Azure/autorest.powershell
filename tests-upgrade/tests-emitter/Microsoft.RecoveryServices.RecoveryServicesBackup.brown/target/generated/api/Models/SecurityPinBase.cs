// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Base class for get security pin request body</summary>
    public partial class SecurityPinBase :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISecurityPinBase,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISecurityPinBaseInternal
    {

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuard Operation Requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Creates an new <see cref="SecurityPinBase" /> instance.</summary>
        public SecurityPinBase()
        {

        }
    }
    /// Base class for get security pin request body
    public partial interface ISecurityPinBase :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>ResourceGuard Operation Requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuard Operation Requests",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }

    }
    /// Base class for get security pin request body
    internal partial interface ISecurityPinBaseInternal

    {
        /// <summary>ResourceGuard Operation Requests</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }

    }
}