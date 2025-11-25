// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Granular Details for log generated during copy.</summary>
    public partial class GranularCopyLogDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyLogDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyLogDetailsInternal
    {

        /// <summary>Backing field for <see cref="CopyLogDetailsType" /> property.</summary>
        private string _copyLogDetailsType;

        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CopyLogDetailsType { get => this._copyLogDetailsType; set => this._copyLogDetailsType = value; }

        /// <summary>Creates an new <see cref="GranularCopyLogDetails" /> instance.</summary>
        public GranularCopyLogDetails()
        {

        }
    }
    /// Granular Details for log generated during copy.
    public partial interface IGranularCopyLogDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the type of job details.",
        SerializedName = @"copyLogDetailsType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string CopyLogDetailsType { get; set; }

    }
    /// Granular Details for log generated during copy.
    internal partial interface IGranularCopyLogDetailsInternal

    {
        /// <summary>Indicates the type of job details.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string CopyLogDetailsType { get; set; }

    }
}