// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Credential details of the shares in account.</summary>
    public partial class ShareCredentialDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetailsInternal
    {

        /// <summary>Internal Acessors for Password</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetailsInternal.Password { get => this._password; set { {_password = value;} } }

        /// <summary>Internal Acessors for ShareName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetailsInternal.ShareName { get => this._shareName; set { {_shareName = value;} } }

        /// <summary>Internal Acessors for ShareType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetailsInternal.ShareType { get => this._shareType; set { {_shareType = value;} } }

        /// <summary>Internal Acessors for SupportedAccessProtocol</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetailsInternal.SupportedAccessProtocol { get => this._supportedAccessProtocol; set { {_supportedAccessProtocol = value;} } }

        /// <summary>Internal Acessors for UserName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetailsInternal.UserName { get => this._userName; set { {_userName = value;} } }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>Password for the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Password { get => this._password; }

        /// <summary>Backing field for <see cref="ShareName" /> property.</summary>
        private string _shareName;

        /// <summary>Name of the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ShareName { get => this._shareName; }

        /// <summary>Backing field for <see cref="ShareType" /> property.</summary>
        private string _shareType;

        /// <summary>Type of the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ShareType { get => this._shareType; }

        /// <summary>Backing field for <see cref="SupportedAccessProtocol" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedAccessProtocol;

        /// <summary>Access protocols supported on the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedAccessProtocol { get => this._supportedAccessProtocol; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>User name for the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; }

        /// <summary>Creates an new <see cref="ShareCredentialDetails" /> instance.</summary>
        public ShareCredentialDetails()
        {

        }
    }
    /// Credential details of the shares in account.
    public partial interface IShareCredentialDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Password for the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Password for the share.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get;  }
        /// <summary>Name of the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the share.",
        SerializedName = @"shareName",
        PossibleTypes = new [] { typeof(string) })]
        string ShareName { get;  }
        /// <summary>Type of the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of the share.",
        SerializedName = @"shareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("UnknownType", "HCS", "BlockBlob", "PageBlob", "AzureFile", "ManagedDisk")]
        string ShareType { get;  }
        /// <summary>Access protocols supported on the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Access protocols supported on the device.",
        SerializedName = @"supportedAccessProtocols",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("SMB", "NFS")]
        System.Collections.Generic.List<string> SupportedAccessProtocol { get;  }
        /// <summary>User name for the share.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"User name for the share.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get;  }

    }
    /// Credential details of the shares in account.
    internal partial interface IShareCredentialDetailsInternal

    {
        /// <summary>Password for the share.</summary>
        string Password { get; set; }
        /// <summary>Name of the share.</summary>
        string ShareName { get; set; }
        /// <summary>Type of the share.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("UnknownType", "HCS", "BlockBlob", "PageBlob", "AzureFile", "ManagedDisk")]
        string ShareType { get; set; }
        /// <summary>Access protocols supported on the device.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("SMB", "NFS")]
        System.Collections.Generic.List<string> SupportedAccessProtocol { get; set; }
        /// <summary>User name for the share.</summary>
        string UserName { get; set; }

    }
}