// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the customer responsibility.</summary>
    public partial class Responsibility :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="Environment" /> property.</summary>
        private string _environment;

        /// <summary>The supported cloud environment of this customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Environment { get => this._environment; }

        /// <summary>Backing field for <see cref="EvidenceFile" /> property.</summary>
        private System.Collections.Generic.List<string> _evidenceFile;

        /// <summary>List of evidence file url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> EvidenceFile { get => this._evidenceFile; set => this._evidenceFile = value; }

        /// <summary>Backing field for <see cref="FailedResourceCount" /> property.</summary>
        private int? _failedResourceCount;

        /// <summary>The count of all failed resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? FailedResourceCount { get => this._failedResourceCount; set => this._failedResourceCount = value; }

        /// <summary>Backing field for <see cref="Guidance" /> property.</summary>
        private string _guidance;

        /// <summary>The evidence upload guidance description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Guidance { get => this._guidance; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Justification" /> property.</summary>
        private string _justification;

        /// <summary>The justification given by the user to clarify the reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Justification { get => this._justification; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for Environment</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Environment { get => this._environment; set { {_environment = value;} } }

        /// <summary>Internal Acessors for Guidance</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Guidance { get => this._guidance; set { {_guidance = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Justification</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Justification { get => this._justification; set { {_justification = value;} } }

        /// <summary>Internal Acessors for RecommendationList</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.RecommendationList { get => this._recommendationList; set { {_recommendationList = value;} } }

        /// <summary>Internal Acessors for ResourceList</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.ResourceList { get => this._resourceList; set { {_resourceList = value;} } }

        /// <summary>Internal Acessors for Severity</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Severity { get => this._severity; set { {_severity = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Title { get => this._title; set { {_title = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="RecommendationList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation> _recommendationList;

        /// <summary>List of recommendation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation> RecommendationList { get => this._recommendationList; }

        /// <summary>Backing field for <see cref="ResourceList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource> _resourceList;

        /// <summary>List of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource> ResourceList { get => this._resourceList; }

        /// <summary>Backing field for <see cref="Severity" /> property.</summary>
        private string _severity;

        /// <summary>The severity level of this customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Severity { get => this._severity; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of this customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>The title of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Title { get => this._title; }

        /// <summary>Backing field for <see cref="TotalResourceCount" /> property.</summary>
        private int? _totalResourceCount;

        /// <summary>The count of all resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? TotalResourceCount { get => this._totalResourceCount; set => this._totalResourceCount = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Responsibility" /> instance.</summary>
        public Responsibility()
        {

        }
    }
    /// A class represent the customer responsibility.
    public partial interface IResponsibility :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The description of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The description of the customer responsibility.",
        SerializedName = @"responsibilityDescription",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The supported cloud environment of this customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The supported cloud environment of this customer responsibility.",
        SerializedName = @"responsibilityEnvironment",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Azure", "AWS", "GCP", "General")]
        string Environment { get;  }
        /// <summary>List of evidence file url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of evidence file url.",
        SerializedName = @"evidenceFiles",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> EvidenceFile { get; set; }
        /// <summary>The count of all failed resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of all failed resources.",
        SerializedName = @"failedResourceCount",
        PossibleTypes = new [] { typeof(int) })]
        int? FailedResourceCount { get; set; }
        /// <summary>The evidence upload guidance description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The evidence upload guidance description.",
        SerializedName = @"guidance",
        PossibleTypes = new [] { typeof(string) })]
        string Guidance { get;  }
        /// <summary>The id of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The id of the customer responsibility.",
        SerializedName = @"responsibilityId",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The justification given by the user to clarify the reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The justification given by the user to clarify the reason.",
        SerializedName = @"justification",
        PossibleTypes = new [] { typeof(string) })]
        string Justification { get;  }
        /// <summary>List of recommendation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of recommendation.",
        SerializedName = @"recommendationList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation> RecommendationList { get;  }
        /// <summary>List of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of resource.",
        SerializedName = @"resourceList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource> ResourceList { get;  }
        /// <summary>The severity level of this customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The severity level of this customer responsibility.",
        SerializedName = @"responsibilitySeverity",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("High", "Medium", "Low")]
        string Severity { get;  }
        /// <summary>The status of this customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of this customer responsibility.",
        SerializedName = @"responsibilityStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get;  }
        /// <summary>The title of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The title of the customer responsibility.",
        SerializedName = @"responsibilityTitle",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get;  }
        /// <summary>The count of all resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of all resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalResourceCount { get; set; }
        /// <summary>The type of customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of customer responsibility.",
        SerializedName = @"responsibilityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Automated", "ScopedManual", "Manual")]
        string Type { get;  }

    }
    /// A class represent the customer responsibility.
    internal partial interface IResponsibilityInternal

    {
        /// <summary>The description of the customer responsibility.</summary>
        string Description { get; set; }
        /// <summary>The supported cloud environment of this customer responsibility.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Azure", "AWS", "GCP", "General")]
        string Environment { get; set; }
        /// <summary>List of evidence file url.</summary>
        System.Collections.Generic.List<string> EvidenceFile { get; set; }
        /// <summary>The count of all failed resources.</summary>
        int? FailedResourceCount { get; set; }
        /// <summary>The evidence upload guidance description.</summary>
        string Guidance { get; set; }
        /// <summary>The id of the customer responsibility.</summary>
        string Id { get; set; }
        /// <summary>The justification given by the user to clarify the reason.</summary>
        string Justification { get; set; }
        /// <summary>List of recommendation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation> RecommendationList { get; set; }
        /// <summary>List of resource.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource> ResourceList { get; set; }
        /// <summary>The severity level of this customer responsibility.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("High", "Medium", "Low")]
        string Severity { get; set; }
        /// <summary>The status of this customer responsibility.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get; set; }
        /// <summary>The title of the customer responsibility.</summary>
        string Title { get; set; }
        /// <summary>The count of all resources.</summary>
        int? TotalResourceCount { get; set; }
        /// <summary>The type of customer responsibility.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Automated", "ScopedManual", "Manual")]
        string Type { get; set; }

    }
}