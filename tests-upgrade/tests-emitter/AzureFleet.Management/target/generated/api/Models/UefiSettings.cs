// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the security settings like secure boot and vTPM used while creating
    /// the virtual machine. Minimum api-version: 2020-12-01.
    /// </summary>
    public partial class UefiSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettingsInternal
    {

        /// <summary>Backing field for <see cref="SecureBootEnabled" /> property.</summary>
        private bool? _secureBootEnabled;

        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? SecureBootEnabled { get => this._secureBootEnabled; set => this._secureBootEnabled = value; }

        /// <summary>Backing field for <see cref="VTpmEnabled" /> property.</summary>
        private bool? _vTpmEnabled;

        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? VTpmEnabled { get => this._vTpmEnabled; set => this._vTpmEnabled = value; }

        /// <summary>Creates an new <see cref="UefiSettings" /> instance.</summary>
        public UefiSettings()
        {

        }
    }
    /// Specifies the security settings like secure boot and vTPM used while creating
    /// the virtual machine. Minimum api-version: 2020-12-01.
    public partial interface IUefiSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether secure boot should be enabled on the virtual machine. Minimum
        api-version: 2020-12-01.",
        SerializedName = @"secureBootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecureBootEnabled { get; set; }
        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether vTPM should be enabled on the virtual machine. Minimum
        api-version: 2020-12-01.",
        SerializedName = @"vTpmEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? VTpmEnabled { get; set; }

    }
    /// Specifies the security settings like secure boot and vTPM used while creating
    /// the virtual machine. Minimum api-version: 2020-12-01.
    internal partial interface IUefiSettingsInternal

    {
        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        bool? SecureBootEnabled { get; set; }
        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        bool? VTpmEnabled { get; set; }

    }
}