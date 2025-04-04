// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output
    /// and Screenshot to diagnose VM status. You can easily view the output of your
    /// console log. Azure also enables you to see a screenshot of the VM from the
    /// hypervisor.
    /// </summary>
    public partial class BootDiagnostics :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnostics,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnosticsInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="StorageUri" /> property.</summary>
        private string _storageUri;

        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string StorageUri { get => this._storageUri; set => this._storageUri = value; }

        /// <summary>Creates an new <see cref="BootDiagnostics" /> instance.</summary>
        public BootDiagnostics()
        {

        }
    }
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output
    /// and Screenshot to diagnose VM status. You can easily view the output of your
    /// console log. Azure also enables you to see a screenshot of the VM from the
    /// hypervisor.
    public partial interface IBootDiagnostics :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether boot diagnostics should be enabled on the Virtual Machine.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Uri of the storage account to use for placing the console output and
        screenshot. If storageUri is not specified while enabling boot diagnostics,
        managed storage will be used.",
        SerializedName = @"storageUri",
        PossibleTypes = new [] { typeof(string) })]
        string StorageUri { get; set; }

    }
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output
    /// and Screenshot to diagnose VM status. You can easily view the output of your
    /// console log. Azure also enables you to see a screenshot of the VM from the
    /// hypervisor.
    internal partial interface IBootDiagnosticsInternal

    {
        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        string StorageUri { get; set; }

    }
}