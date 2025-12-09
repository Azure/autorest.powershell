// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>ValidateBackup Response Properties</summary>
    public partial class ValidateBackupResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="NumberOfContainer" /> property.</summary>
        private int? _numberOfContainer;

        /// <summary>Estimated no of storage containers required for resource data to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? NumberOfContainer { get => this._numberOfContainer; set => this._numberOfContainer = value; }

        /// <summary>Creates an new <see cref="ValidateBackupResponseProperties" /> instance.</summary>
        public ValidateBackupResponseProperties()
        {

        }
    }
    /// ValidateBackup Response Properties
    public partial interface IValidateBackupResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Estimated no of storage containers required for resource data to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Estimated no of storage containers required for resource data to be backed up.",
        SerializedName = @"numberOfContainers",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfContainer { get; set; }

    }
    /// ValidateBackup Response Properties
    internal partial interface IValidateBackupResponsePropertiesInternal

    {
        /// <summary>Estimated no of storage containers required for resource data to be backed up.</summary>
        int? NumberOfContainer { get; set; }

    }
}