// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Maintenance policy of a server.</summary>
    public partial class MaintenancePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicyInternal
    {

        /// <summary>Backing field for <see cref="PatchStrategy" /> property.</summary>
        private string _patchStrategy;

        /// <summary>The patch strategy of this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string PatchStrategy { get => this._patchStrategy; set => this._patchStrategy = value; }

        /// <summary>Creates an new <see cref="MaintenancePolicy" /> instance.</summary>
        public MaintenancePolicy()
        {

        }
    }
    /// Maintenance policy of a server.
    public partial interface IMaintenancePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The patch strategy of this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The patch strategy of this server",
        SerializedName = @"patchStrategy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Regular", "VirtualCanary")]
        string PatchStrategy { get; set; }

    }
    /// Maintenance policy of a server.
    internal partial interface IMaintenancePolicyInternal

    {
        /// <summary>The patch strategy of this server</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Regular", "VirtualCanary")]
        string PatchStrategy { get; set; }

    }
}