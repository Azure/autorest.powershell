// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>
    /// Device erasure details with erasure completion status, secure erasure sas key and erasureordestructionlog sas key
    /// </summary>
    public partial class DeviceErasureDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal
    {

        /// <summary>Backing field for <see cref="DeviceErasureStatus" /> property.</summary>
        private string _deviceErasureStatus;

        /// <summary>Holds the device erasure completion status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DeviceErasureStatus { get => this._deviceErasureStatus; }

        /// <summary>
        /// Backing field for <see cref="ErasureOrDestructionCertificateSasKey" /> property.
        /// </summary>
        private string _erasureOrDestructionCertificateSasKey;

        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ErasureOrDestructionCertificateSasKey { get => this._erasureOrDestructionCertificateSasKey; }

        /// <summary>Internal Acessors for DeviceErasureStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal.DeviceErasureStatus { get => this._deviceErasureStatus; set { {_deviceErasureStatus = value;} } }

        /// <summary>Internal Acessors for ErasureOrDestructionCertificateSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal.ErasureOrDestructionCertificateSasKey { get => this._erasureOrDestructionCertificateSasKey; set { {_erasureOrDestructionCertificateSasKey = value;} } }

        /// <summary>Internal Acessors for SecureErasureCertificateSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal.SecureErasureCertificateSasKey { get => this._secureErasureCertificateSasKey; set { {_secureErasureCertificateSasKey = value;} } }

        /// <summary>Backing field for <see cref="SecureErasureCertificateSasKey" /> property.</summary>
        private string _secureErasureCertificateSasKey;

        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SecureErasureCertificateSasKey { get => this._secureErasureCertificateSasKey; }

        /// <summary>Creates an new <see cref="DeviceErasureDetails" /> instance.</summary>
        public DeviceErasureDetails()
        {

        }
    }
    /// Device erasure details with erasure completion status, secure erasure sas key and erasureordestructionlog sas key
    public partial interface IDeviceErasureDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Holds the device erasure completion status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Holds the device erasure completion status",
        SerializedName = @"deviceErasureStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling", "SucceededWithErrors", "WaitingForCustomerAction", "SucceededWithWarnings", "WaitingForCustomerActionForKek", "WaitingForCustomerActionForCleanUp", "CustomerActionPerformedForCleanUp", "CustomerActionPerformed")]
        string DeviceErasureStatus { get;  }
        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Shared access key to download cleanup or destruction certificate for device",
        SerializedName = @"erasureOrDestructionCertificateSasKey",
        PossibleTypes = new [] { typeof(string) })]
        string ErasureOrDestructionCertificateSasKey { get;  }
        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Shared access key to download secure erasure certificate for the device",
        SerializedName = @"secureErasureCertificateSasKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecureErasureCertificateSasKey { get;  }

    }
    /// Device erasure details with erasure completion status, secure erasure sas key and erasureordestructionlog sas key
    internal partial interface IDeviceErasureDetailsInternal

    {
        /// <summary>Holds the device erasure completion status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling", "SucceededWithErrors", "WaitingForCustomerAction", "SucceededWithWarnings", "WaitingForCustomerActionForKek", "WaitingForCustomerActionForCleanUp", "CustomerActionPerformedForCleanUp", "CustomerActionPerformed")]
        string DeviceErasureStatus { get; set; }
        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        string ErasureOrDestructionCertificateSasKey { get; set; }
        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        string SecureErasureCertificateSasKey { get; set; }

    }
}