// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes Windows Remote Management configuration of the VM</summary>
    public partial class WinRmConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Listener" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> _listener;

        /// <summary>The list of Windows Remote Management listeners</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> Listener { get => this._listener; set => this._listener = value; }

        /// <summary>Creates an new <see cref="WinRmConfiguration" /> instance.</summary>
        public WinRmConfiguration()
        {

        }
    }
    /// Describes Windows Remote Management configuration of the VM
    public partial interface IWinRmConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The list of Windows Remote Management listeners</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of Windows Remote Management listeners",
        SerializedName = @"listeners",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> Listener { get; set; }

    }
    /// Describes Windows Remote Management configuration of the VM
    internal partial interface IWinRmConfigurationInternal

    {
        /// <summary>The list of Windows Remote Management listeners</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> Listener { get; set; }

    }
}