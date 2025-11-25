// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Account details of the data to be transferred</summary>
    public partial class DataAccountDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal
    {

        /// <summary>Backing field for <see cref="DataAccountType" /> property.</summary>
        private string _dataAccountType;

        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DataAccountType { get => this._dataAccountType; set => this._dataAccountType = value; }

        /// <summary>Backing field for <see cref="SharePassword" /> property.</summary>
        private System.Security.SecureString _sharePassword;

        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Security.SecureString SharePassword { get => this._sharePassword; set => this._sharePassword = value; }

        /// <summary>Creates an new <see cref="DataAccountDetails" /> instance.</summary>
        public DataAccountDetails()
        {

        }
    }
    /// Account details of the data to be transferred
    public partial interface IDataAccountDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Account Type of the data to be transferred.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+",
        SerializedName = @"sharePassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString SharePassword { get; set; }

    }
    /// Account details of the data to be transferred
    internal partial interface IDataAccountDetailsInternal

    {
        /// <summary>Account Type of the data to be transferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        System.Security.SecureString SharePassword { get; set; }

    }
}