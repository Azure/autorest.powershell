// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>Create exadata Database Storage Details model</summary>
    public partial class ExascaleDbStorageInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IExascaleDbStorageInputDetails,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IExascaleDbStorageInputDetailsInternal
    {

        /// <summary>Backing field for <see cref="TotalSizeInGb" /> property.</summary>
        private int _totalSizeInGb;

        /// <summary>Total Capacity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public int TotalSizeInGb { get => this._totalSizeInGb; set => this._totalSizeInGb = value; }

        /// <summary>Creates an new <see cref="ExascaleDbStorageInputDetails" /> instance.</summary>
        public ExascaleDbStorageInputDetails()
        {

        }
    }
    /// Create exadata Database Storage Details model
    public partial interface IExascaleDbStorageInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Total Capacity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Total Capacity",
        SerializedName = @"totalSizeInGbs",
        PossibleTypes = new [] { typeof(int) })]
        int TotalSizeInGb { get; set; }

    }
    /// Create exadata Database Storage Details model
    internal partial interface IExascaleDbStorageInputDetailsInternal

    {
        /// <summary>Total Capacity</summary>
        int TotalSizeInGb { get; set; }

    }
}