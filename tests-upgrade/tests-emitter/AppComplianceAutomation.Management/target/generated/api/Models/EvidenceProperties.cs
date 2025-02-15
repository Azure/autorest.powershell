// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Evidence's properties.</summary>
    public partial class EvidenceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidencePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ControlId" /> property.</summary>
        private string _controlId;

        /// <summary>Control id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlId { get => this._controlId; set => this._controlId = value; }

        /// <summary>Backing field for <see cref="EvidenceType" /> property.</summary>
        private string _evidenceType;

        /// <summary>Evidence type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string EvidenceType { get => this._evidenceType; set => this._evidenceType = value; }

        /// <summary>Backing field for <see cref="ExtraData" /> property.</summary>
        private string _extraData;

        /// <summary>Extra data considered as evidence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ExtraData { get => this._extraData; set => this._extraData = value; }

        /// <summary>Backing field for <see cref="FilePath" /> property.</summary>
        private string _filePath;

        /// <summary>The path of the file in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string FilePath { get => this._filePath; set => this._filePath = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidencePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResponsibilityId" /> property.</summary>
        private string _responsibilityId;

        /// <summary>Responsibility id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResponsibilityId { get => this._responsibilityId; set => this._responsibilityId = value; }

        /// <summary>Creates an new <see cref="EvidenceProperties" /> instance.</summary>
        public EvidenceProperties()
        {

        }
    }
    /// Evidence's properties.
    public partial interface IEvidenceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Control id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Control id.",
        SerializedName = @"controlId",
        PossibleTypes = new [] { typeof(string) })]
        string ControlId { get; set; }
        /// <summary>Evidence type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Evidence type.",
        SerializedName = @"evidenceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("File", "AutoCollectedEvidence", "Data")]
        string EvidenceType { get; set; }
        /// <summary>Extra data considered as evidence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Extra data considered as evidence.",
        SerializedName = @"extraData",
        PossibleTypes = new [] { typeof(string) })]
        string ExtraData { get; set; }
        /// <summary>The path of the file in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The path of the file in storage.",
        SerializedName = @"filePath",
        PossibleTypes = new [] { typeof(string) })]
        string FilePath { get; set; }
        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure lifecycle management",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>Responsibility id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Responsibility id.",
        SerializedName = @"responsibilityId",
        PossibleTypes = new [] { typeof(string) })]
        string ResponsibilityId { get; set; }

    }
    /// Evidence's properties.
    internal partial interface IEvidencePropertiesInternal

    {
        /// <summary>Control id.</summary>
        string ControlId { get; set; }
        /// <summary>Evidence type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("File", "AutoCollectedEvidence", "Data")]
        string EvidenceType { get; set; }
        /// <summary>Extra data considered as evidence.</summary>
        string ExtraData { get; set; }
        /// <summary>The path of the file in storage.</summary>
        string FilePath { get; set; }
        /// <summary>Azure lifecycle management</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Responsibility id.</summary>
        string ResponsibilityId { get; set; }

    }
}