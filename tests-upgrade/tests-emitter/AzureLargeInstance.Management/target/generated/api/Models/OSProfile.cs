// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Specifies the operating system settings for the Azure Large Instance.</summary>
    public partial class OSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal
    {

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; set => this._computerName = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>This property allows you to specify the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="SshPublicKey" /> property.</summary>
        private string _sshPublicKey;

        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string SshPublicKey { get => this._sshPublicKey; set => this._sshPublicKey = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Specifies version of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="OSProfile" /> instance.</summary>
        public OSProfile()
        {

        }
    }
    /// Specifies the operating system settings for the Azure Large Instance.
    public partial interface IOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the host OS name of the Azure Large Instance.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get; set; }
        /// <summary>This property allows you to specify the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property allows you to specify the type of the OS.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the SSH public key used to access the operating system.",
        SerializedName = @"sshPublicKey",
        PossibleTypes = new [] { typeof(string) })]
        string SshPublicKey { get; set; }
        /// <summary>Specifies version of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies version of operating system.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Specifies the operating system settings for the Azure Large Instance.
    internal partial interface IOSProfileInternal

    {
        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        string ComputerName { get; set; }
        /// <summary>This property allows you to specify the type of the OS.</summary>
        string OSType { get; set; }
        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        string SshPublicKey { get; set; }
        /// <summary>Specifies version of operating system.</summary>
        string Version { get; set; }

    }
}