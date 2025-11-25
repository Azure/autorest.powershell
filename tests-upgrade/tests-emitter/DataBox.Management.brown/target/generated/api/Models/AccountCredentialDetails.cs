// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Credential details of the account.</summary>
    public partial class AccountCredentialDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetailsInternal
    {

        /// <summary>Backing field for <see cref="AccountConnectionString" /> property.</summary>
        private string _accountConnectionString;

        /// <summary>
        /// Connection string of the account endpoint to use the account as a storage endpoint on the device.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string AccountConnectionString { get => this._accountConnectionString; }

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>Name of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; }

        /// <summary>Backing field for <see cref="DataAccountType" /> property.</summary>
        private string _dataAccountType;

        /// <summary>Type of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DataAccountType { get => this._dataAccountType; }

        /// <summary>Internal Acessors for AccountConnectionString</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetailsInternal.AccountConnectionString { get => this._accountConnectionString; set { {_accountConnectionString = value;} } }

        /// <summary>Internal Acessors for AccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetailsInternal.AccountName { get => this._accountName; set { {_accountName = value;} } }

        /// <summary>Internal Acessors for DataAccountType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetailsInternal.DataAccountType { get => this._dataAccountType; set { {_dataAccountType = value;} } }

        /// <summary>Internal Acessors for ShareCredentialDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAccountCredentialDetailsInternal.ShareCredentialDetail { get => this._shareCredentialDetail; set { {_shareCredentialDetail = value;} } }

        /// <summary>Backing field for <see cref="ShareCredentialDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails> _shareCredentialDetail;

        /// <summary>Per share level unencrypted access credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails> ShareCredentialDetail { get => this._shareCredentialDetail; }

        /// <summary>Creates an new <see cref="AccountCredentialDetails" /> instance.</summary>
        public AccountCredentialDetails()
        {

        }
    }
    /// Credential details of the account.
    public partial interface IAccountCredentialDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Connection string of the account endpoint to use the account as a storage endpoint on the device.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Connection string of the account endpoint to use the account as a storage endpoint on the device.",
        SerializedName = @"accountConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string AccountConnectionString { get;  }
        /// <summary>Name of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the account.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get;  }
        /// <summary>Type of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of the account.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get;  }
        /// <summary>Per share level unencrypted access credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Per share level unencrypted access credentials.",
        SerializedName = @"shareCredentialDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails> ShareCredentialDetail { get;  }

    }
    /// Credential details of the account.
    internal partial interface IAccountCredentialDetailsInternal

    {
        /// <summary>
        /// Connection string of the account endpoint to use the account as a storage endpoint on the device.
        /// </summary>
        string AccountConnectionString { get; set; }
        /// <summary>Name of the account.</summary>
        string AccountName { get; set; }
        /// <summary>Type of the account.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
        /// <summary>Per share level unencrypted access credentials.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShareCredentialDetails> ShareCredentialDetail { get; set; }

    }
}