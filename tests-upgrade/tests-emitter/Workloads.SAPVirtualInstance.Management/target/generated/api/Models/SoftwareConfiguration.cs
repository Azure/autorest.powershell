// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP Software configuration Input.</summary>
    public partial class SoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal
    {

        /// <summary>Backing field for <see cref="SoftwareInstallationType" /> property.</summary>
        private string _softwareInstallationType;

        /// <summary>The SAP software installation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SoftwareInstallationType { get => this._softwareInstallationType; set => this._softwareInstallationType = value; }

        /// <summary>Creates an new <see cref="SoftwareConfiguration" /> instance.</summary>
        public SoftwareConfiguration()
        {

        }
    }
    /// The SAP Software configuration Input.
    public partial interface ISoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The SAP software installation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAP software installation type.",
        SerializedName = @"softwareInstallationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ServiceInitiated", "SAPInstallWithoutOSConfig", "External")]
        string SoftwareInstallationType { get; set; }

    }
    /// The SAP Software configuration Input.
    internal partial interface ISoftwareConfigurationInternal

    {
        /// <summary>The SAP software installation type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ServiceInitiated", "SAPInstallWithoutOSConfig", "External")]
        string SoftwareInstallationType { get; set; }

    }
}