// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The secrets related to a DataBox.</summary>
    public partial class DataBoxSecret :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecret,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecretInternal
    {

        /// <summary>Backing field for <see cref="AccountCredentialDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails> _accountCredentialDetail;

        /// <summary>Per account level access credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails> AccountCredentialDetail { get => this._accountCredentialDetail; }

        /// <summary>Backing field for <see cref="DevicePassword" /> property.</summary>
        private string _devicePassword;

        /// <summary>Password for out of the box experience on device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DevicePassword { get => this._devicePassword; }

        /// <summary>Backing field for <see cref="DeviceSerialNumber" /> property.</summary>
        private string _deviceSerialNumber;

        /// <summary>Serial number of the assigned device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DeviceSerialNumber { get => this._deviceSerialNumber; }

        /// <summary>Backing field for <see cref="EncodedValidationCertPubKey" /> property.</summary>
        private string _encodedValidationCertPubKey;

        /// <summary>The base 64 encoded public key to authenticate with the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string EncodedValidationCertPubKey { get => this._encodedValidationCertPubKey; }

        /// <summary>Internal Acessors for AccountCredentialDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecretInternal.AccountCredentialDetail { get => this._accountCredentialDetail; set { {_accountCredentialDetail = value;} } }

        /// <summary>Internal Acessors for DevicePassword</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecretInternal.DevicePassword { get => this._devicePassword; set { {_devicePassword = value;} } }

        /// <summary>Internal Acessors for DeviceSerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecretInternal.DeviceSerialNumber { get => this._deviceSerialNumber; set { {_deviceSerialNumber = value;} } }

        /// <summary>Internal Acessors for EncodedValidationCertPubKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecretInternal.EncodedValidationCertPubKey { get => this._encodedValidationCertPubKey; set { {_encodedValidationCertPubKey = value;} } }

        /// <summary>Internal Acessors for NetworkConfiguration</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApplianceNetworkConfiguration> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxSecretInternal.NetworkConfiguration { get => this._networkConfiguration; set { {_networkConfiguration = value;} } }

        /// <summary>Backing field for <see cref="NetworkConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApplianceNetworkConfiguration> _networkConfiguration;

        /// <summary>Network configuration of the appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApplianceNetworkConfiguration> NetworkConfiguration { get => this._networkConfiguration; }

        /// <summary>Creates an new <see cref="DataBoxSecret" /> instance.</summary>
        public DataBoxSecret()
        {

        }
    }
    /// The secrets related to a DataBox.
    public partial interface IDataBoxSecret :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Per account level access credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Per account level access credentials.",
        SerializedName = @"accountCredentialDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails> AccountCredentialDetail { get;  }
        /// <summary>Password for out of the box experience on device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Password for out of the box experience on device.",
        SerializedName = @"devicePassword",
        PossibleTypes = new [] { typeof(string) })]
        string DevicePassword { get;  }
        /// <summary>Serial number of the assigned device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Serial number of the assigned device.",
        SerializedName = @"deviceSerialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceSerialNumber { get;  }
        /// <summary>The base 64 encoded public key to authenticate with the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The base 64 encoded public key to authenticate with the device",
        SerializedName = @"encodedValidationCertPubKey",
        PossibleTypes = new [] { typeof(string) })]
        string EncodedValidationCertPubKey { get;  }
        /// <summary>Network configuration of the appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Network configuration of the appliance.",
        SerializedName = @"networkConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApplianceNetworkConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApplianceNetworkConfiguration> NetworkConfiguration { get;  }

    }
    /// The secrets related to a DataBox.
    internal partial interface IDataBoxSecretInternal

    {
        /// <summary>Per account level access credentials.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails> AccountCredentialDetail { get; set; }
        /// <summary>Password for out of the box experience on device.</summary>
        string DevicePassword { get; set; }
        /// <summary>Serial number of the assigned device.</summary>
        string DeviceSerialNumber { get; set; }
        /// <summary>The base 64 encoded public key to authenticate with the device</summary>
        string EncodedValidationCertPubKey { get; set; }
        /// <summary>Network configuration of the appliance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IApplianceNetworkConfiguration> NetworkConfiguration { get; set; }

    }
}