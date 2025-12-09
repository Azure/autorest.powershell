// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>
    /// FullBackupStoreDetails is used for scenarios where backup data is streamed/copied over to a storage destination.
    /// </summary>
    public partial class FullBackupStoreDetails :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFullBackupStoreDetails,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFullBackupStoreDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails __backupStoreDetails = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.BackupStoreDetails();

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string ObjectType { get => "FullBackupStoreDetails"; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetailsInternal)__backupStoreDetails).ObjectType = "FullBackupStoreDetails"; }

        /// <summary>Backing field for <see cref="SasUriList" /> property.</summary>
        private System.Collections.Generic.List<string> _sasUriList;

        /// <summary>SASUriList of storage containers where backup data is to be streamed/copied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SasUriList { get => this._sasUriList; set => this._sasUriList = value; }

        /// <summary>Creates an new <see cref="FullBackupStoreDetails" /> instance.</summary>
        public FullBackupStoreDetails()
        {
            this.__backupStoreDetails.ObjectType = "FullBackupStoreDetails";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__backupStoreDetails), __backupStoreDetails);
            await eventListener.AssertObjectIsValid(nameof(__backupStoreDetails), __backupStoreDetails);
        }
    }
    /// FullBackupStoreDetails is used for scenarios where backup data is streamed/copied over to a storage destination.
    public partial interface IFullBackupStoreDetails :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetails
    {
        /// <summary>SASUriList of storage containers where backup data is to be streamed/copied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SASUriList of storage containers where backup data is to be streamed/copied.",
        SerializedName = @"sasUriList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SasUriList { get; set; }

    }
    /// FullBackupStoreDetails is used for scenarios where backup data is streamed/copied over to a storage destination.
    internal partial interface IFullBackupStoreDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupStoreDetailsInternal
    {
        /// <summary>SASUriList of storage containers where backup data is to be streamed/copied.</summary>
        System.Collections.Generic.List<string> SasUriList { get; set; }

    }
}