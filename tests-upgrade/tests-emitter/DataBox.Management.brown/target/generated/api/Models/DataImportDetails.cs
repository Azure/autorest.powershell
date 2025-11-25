// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Details of the data to be used for importing data to azure.</summary>
    public partial class DataImportDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetailsInternal
    {

        /// <summary>Backing field for <see cref="AccountDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails _accountDetail;

        /// <summary>Account details of the data to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails AccountDetail { get => (this._accountDetail = this._accountDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataAccountDetails()); set => this._accountDetail = value; }

        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string AccountDetailDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).DataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).DataAccountType = value ; }

        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Security.SecureString AccountDetailSharePassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).SharePassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).SharePassword = value ?? null; }

        /// <summary>Backing field for <see cref="LogCollectionLevel" /> property.</summary>
        private string _logCollectionLevel;

        /// <summary>Level of the logs to be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string LogCollectionLevel { get => this._logCollectionLevel; set => this._logCollectionLevel = value; }

        /// <summary>Internal Acessors for AccountDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetailsInternal.AccountDetail { get => (this._accountDetail = this._accountDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataAccountDetails()); set { {_accountDetail = value;} } }

        /// <summary>Creates an new <see cref="DataImportDetails" /> instance.</summary>
        public DataImportDetails()
        {

        }
    }
    /// Details of the data to be used for importing data to azure.
    public partial interface IDataImportDetails :
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
        string AccountDetailDataAccountType { get; set; }
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
        System.Security.SecureString AccountDetailSharePassword { get; set; }
        /// <summary>Level of the logs to be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Level of the logs to be collected.",
        SerializedName = @"logCollectionLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Error", "Verbose")]
        string LogCollectionLevel { get; set; }

    }
    /// Details of the data to be used for importing data to azure.
    internal partial interface IDataImportDetailsInternal

    {
        /// <summary>Account details of the data to be transferred</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails AccountDetail { get; set; }
        /// <summary>Account Type of the data to be transferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string AccountDetailDataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        System.Security.SecureString AccountDetailSharePassword { get; set; }
        /// <summary>Level of the logs to be collected.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Error", "Verbose")]
        string LogCollectionLevel { get; set; }

    }
}