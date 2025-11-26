// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Request body of Suspend backup when MUA is Enabled</summary>
    public partial class SuspendBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISuspendBackupRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISuspendBackupRequestInternal
    {

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Creates an new <see cref="SuspendBackupRequest" /> instance.</summary>
        public SuspendBackupRequest()
        {

        }
    }
    /// Request body of Suspend backup when MUA is Enabled
    public partial interface ISuspendBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }

    }
    /// Request body of Suspend backup when MUA is Enabled
    internal partial interface ISuspendBackupRequestInternal

    {
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }

    }
}