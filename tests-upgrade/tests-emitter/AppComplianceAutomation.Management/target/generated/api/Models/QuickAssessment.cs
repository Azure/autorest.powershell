// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the quick assessment.</summary>
    public partial class QuickAssessment :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Quick assessment display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Quick assessment display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for RemediationLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.RemediationLink { get => this._remediationLink; set { {_remediationLink = value;} } }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Internal Acessors for ResourceStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.ResourceStatus { get => this._resourceStatus; set { {_resourceStatus = value;} } }

        /// <summary>Internal Acessors for ResponsibilityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.ResponsibilityId { get => this._responsibilityId; set { {_responsibilityId = value;} } }

        /// <summary>Internal Acessors for Timestamp</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessmentInternal.Timestamp { get => this._timestamp; set { {_timestamp = value;} } }

        /// <summary>Backing field for <see cref="RemediationLink" /> property.</summary>
        private string _remediationLink;

        /// <summary>Link to remediation steps for this quick assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string RemediationLink { get => this._remediationLink; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Backing field for <see cref="ResourceStatus" /> property.</summary>
        private string _resourceStatus;

        /// <summary>Quick assessment status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceStatus { get => this._resourceStatus; }

        /// <summary>Backing field for <see cref="ResponsibilityId" /> property.</summary>
        private string _responsibilityId;

        /// <summary>Responsibility id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResponsibilityId { get => this._responsibilityId; }

        /// <summary>Backing field for <see cref="Timestamp" /> property.</summary>
        private global::System.DateTime? _timestamp;

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? Timestamp { get => this._timestamp; }

        /// <summary>Creates an new <see cref="QuickAssessment" /> instance.</summary>
        public QuickAssessment()
        {

        }
    }
    /// A class represent the quick assessment.
    public partial interface IQuickAssessment :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Quick assessment display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Quick assessment display name.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Quick assessment display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Quick assessment display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Link to remediation steps for this quick assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Link to remediation steps for this quick assessment.",
        SerializedName = @"remediationLink",
        PossibleTypes = new [] { typeof(string) })]
        string RemediationLink { get;  }
        /// <summary>Resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource id.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }
        /// <summary>Quick assessment status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Quick assessment status.",
        SerializedName = @"resourceStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Healthy", "Unhealthy")]
        string ResourceStatus { get;  }
        /// <summary>Responsibility id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Responsibility id.",
        SerializedName = @"responsibilityId",
        PossibleTypes = new [] { typeof(string) })]
        string ResponsibilityId { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"timestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Timestamp { get;  }

    }
    /// A class represent the quick assessment.
    internal partial interface IQuickAssessmentInternal

    {
        /// <summary>Quick assessment display name.</summary>
        string Description { get; set; }
        /// <summary>Quick assessment display name.</summary>
        string DisplayName { get; set; }
        /// <summary>Link to remediation steps for this quick assessment.</summary>
        string RemediationLink { get; set; }
        /// <summary>Resource id.</summary>
        string ResourceId { get; set; }
        /// <summary>Quick assessment status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Healthy", "Unhealthy")]
        string ResourceStatus { get; set; }
        /// <summary>Responsibility id.</summary>
        string ResponsibilityId { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? Timestamp { get; set; }

    }
}