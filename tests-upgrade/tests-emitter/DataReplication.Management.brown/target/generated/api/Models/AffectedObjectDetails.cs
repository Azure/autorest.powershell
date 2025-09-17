// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Details of the affected object.</summary>
    public partial class AffectedObjectDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="AffectedObjectDetails" /> instance.</summary>
        public AffectedObjectDetails()
        {

        }
    }
    /// Details of the affected object.
    public partial interface IAffectedObjectDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the affected object details.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the affected object details.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("object")]
        string Type { get; set; }

    }
    /// Details of the affected object.
    internal partial interface IAffectedObjectDetailsInternal

    {
        /// <summary>Description of the affected object details.</summary>
        string Description { get; set; }
        /// <summary>Type of the affected object details.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("object")]
        string Type { get; set; }

    }
}