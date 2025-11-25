// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>
    /// This class represents additional info which Resource Providers pass when an error occurs.
    /// </summary>
    public partial class AdditionalErrorInfo1 :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1Internal
    {

        /// <summary>Backing field for <see cref="Info" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo _info;

        /// <summary>Additional information of the type of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo Info { get => (this._info = this._info ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo()); set => this._info = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of error (e.g. CustomerIntervention, PolicyViolation, SecurityViolation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="AdditionalErrorInfo1" /> instance.</summary>
        public AdditionalErrorInfo1()
        {

        }
    }
    /// This class represents additional info which Resource Providers pass when an error occurs.
    public partial interface IAdditionalErrorInfo1 :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Additional information of the type of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional information of the type of error.",
        SerializedName = @"info",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo Info { get; set; }
        /// <summary>Type of error (e.g. CustomerIntervention, PolicyViolation, SecurityViolation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of error (e.g. CustomerIntervention, PolicyViolation, SecurityViolation).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// This class represents additional info which Resource Providers pass when an error occurs.
    internal partial interface IAdditionalErrorInfo1Internal

    {
        /// <summary>Additional information of the type of error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo Info { get; set; }
        /// <summary>Type of error (e.g. CustomerIntervention, PolicyViolation, SecurityViolation).</summary>
        string Type { get; set; }

    }
}