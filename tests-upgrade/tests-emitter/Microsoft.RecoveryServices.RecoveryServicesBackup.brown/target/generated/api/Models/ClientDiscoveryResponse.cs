// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Operations List response which contains list of available APIs.</summary>
    public partial class ClientDiscoveryResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next chunk of Response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryValueForSingleApi> _value;

        /// <summary>List of available operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryValueForSingleApi> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ClientDiscoveryResponse" /> instance.</summary>
        public ClientDiscoveryResponse()
        {

        }
    }
    /// Operations List response which contains list of available APIs.
    public partial interface IClientDiscoveryResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next chunk of Response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Link to the next chunk of Response.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of available operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of available operations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryValueForSingleApi) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryValueForSingleApi> Value { get; set; }

    }
    /// Operations List response which contains list of available APIs.
    internal partial interface IClientDiscoveryResponseInternal

    {
        /// <summary>Link to the next chunk of Response.</summary>
        string NextLink { get; set; }
        /// <summary>List of available operations.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IClientDiscoveryValueForSingleApi> Value { get; set; }

    }
}