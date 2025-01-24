// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Gets or sets the HA software configuration.</summary>
    public partial class HighAvailabilitySoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfigurationInternal
    {

        /// <summary>Backing field for <see cref="FencingClientId" /> property.</summary>
        private string _fencingClientId;

        /// <summary>The fencing client id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string FencingClientId { get => this._fencingClientId; set => this._fencingClientId = value; }

        /// <summary>Backing field for <see cref="FencingClientPassword" /> property.</summary>
        private System.Security.SecureString _fencingClientPassword;

        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster
        /// VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Security.SecureString FencingClientPassword { get => this._fencingClientPassword; set => this._fencingClientPassword = value; }

        /// <summary>Creates an new <see cref="HighAvailabilitySoftwareConfiguration" /> instance.</summary>
        public HighAvailabilitySoftwareConfiguration()
        {

        }
    }
    /// Gets or sets the HA software configuration.
    public partial interface IHighAvailabilitySoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The fencing client id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fencing client id.",
        SerializedName = @"fencingClientId",
        PossibleTypes = new [] { typeof(string) })]
        string FencingClientId { get; set; }
        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster
        /// VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster VMs.",
        SerializedName = @"fencingClientPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString FencingClientPassword { get; set; }

    }
    /// Gets or sets the HA software configuration.
    internal partial interface IHighAvailabilitySoftwareConfigurationInternal

    {
        /// <summary>The fencing client id.</summary>
        string FencingClientId { get; set; }
        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster
        /// VMs.
        /// </summary>
        System.Security.SecureString FencingClientPassword { get; set; }

    }
}