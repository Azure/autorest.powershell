// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Copy log details for a storage account for Databox heavy</summary>
    public partial class DataBoxHeavyAccountCopyLogDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyAccountCopyLogDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyAccountCopyLogDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails __copyLogDetails = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyLogDetails();

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>Account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; }

        /// <summary>Backing field for <see cref="CopyLogLink" /> property.</summary>
        private System.Collections.Generic.List<string> _copyLogLink;

        /// <summary>Link for copy logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> CopyLogLink { get => this._copyLogLink; }

        /// <summary>Backing field for <see cref="CopyVerboseLogLink" /> property.</summary>
        private System.Collections.Generic.List<string> _copyVerboseLogLink;

        /// <summary>
        /// Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> CopyVerboseLogLink { get => this._copyVerboseLogLink; }

        /// <summary>Internal Acessors for AccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyAccountCopyLogDetailsInternal.AccountName { get => this._accountName; set { {_accountName = value;} } }

        /// <summary>Internal Acessors for CopyLogLink</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyAccountCopyLogDetailsInternal.CopyLogLink { get => this._copyLogLink; set { {_copyLogLink = value;} } }

        /// <summary>Internal Acessors for CopyVerboseLogLink</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxHeavyAccountCopyLogDetailsInternal.CopyVerboseLogLink { get => this._copyVerboseLogLink; set { {_copyVerboseLogLink = value;} } }

        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Type { get => "DataBoxHeavy"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetailsInternal)__copyLogDetails).Type = "DataBoxHeavy"; }

        /// <summary>Creates an new <see cref="DataBoxHeavyAccountCopyLogDetails" /> instance.</summary>
        public DataBoxHeavyAccountCopyLogDetails()
        {
            this.__copyLogDetails.Type = "DataBoxHeavy";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__copyLogDetails), __copyLogDetails);
            await eventListener.AssertObjectIsValid(nameof(__copyLogDetails), __copyLogDetails);
        }
    }
    /// Copy log details for a storage account for Databox heavy
    public partial interface IDataBoxHeavyAccountCopyLogDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails
    {
        /// <summary>Account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Account name.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get;  }
        /// <summary>Link for copy logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Link for copy logs.",
        SerializedName = @"copyLogLink",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> CopyLogLink { get;  }
        /// <summary>
        /// Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose.",
        SerializedName = @"copyVerboseLogLink",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> CopyVerboseLogLink { get;  }

    }
    /// Copy log details for a storage account for Databox heavy
    internal partial interface IDataBoxHeavyAccountCopyLogDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetailsInternal
    {
        /// <summary>Account name.</summary>
        string AccountName { get; set; }
        /// <summary>Link for copy logs.</summary>
        System.Collections.Generic.List<string> CopyLogLink { get; set; }
        /// <summary>
        /// Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose.
        /// </summary>
        System.Collections.Generic.List<string> CopyVerboseLogLink { get; set; }

    }
}