// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents ValidateBackup API Response</summary>
    public partial class ValidateBackupResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponse,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseProperties Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ValidateBackupResponseProperties()); set { {_property = value;} } }

        /// <summary>Estimated no of storage containers required for resource data to be backed up.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? NumberOfContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponsePropertiesInternal)Property).NumberOfContainer; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponsePropertiesInternal)Property).NumberOfContainer = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseProperties _property;

        /// <summary>The response properties of a pre backup operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ValidateBackupResponseProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="ValidateBackupResponse" /> instance.</summary>
        public ValidateBackupResponse()
        {

        }
    }
    /// Represents ValidateBackup API Response
    public partial interface IValidateBackupResponse :
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
    /// Represents ValidateBackup API Response
    internal partial interface IValidateBackupResponseInternal

    {
        /// <summary>Estimated no of storage containers required for resource data to be backed up.</summary>
        int? NumberOfContainer { get; set; }
        /// <summary>The response properties of a pre backup operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IValidateBackupResponseProperties Property { get; set; }

    }
}