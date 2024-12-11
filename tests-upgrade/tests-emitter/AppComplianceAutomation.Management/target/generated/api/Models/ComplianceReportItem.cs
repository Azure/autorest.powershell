// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Object that includes all the content for single compliance result.</summary>
    public partial class ComplianceReportItem :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal
    {

        /// <summary>Backing field for <see cref="CategoryName" /> property.</summary>
        private string _categoryName;

        /// <summary>The category name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string CategoryName { get => this._categoryName; }

        /// <summary>Backing field for <see cref="ControlFamilyName" /> property.</summary>
        private string _controlFamilyName;

        /// <summary>The control family name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlFamilyName { get => this._controlFamilyName; }

        /// <summary>Backing field for <see cref="ControlId" /> property.</summary>
        private string _controlId;

        /// <summary>The control Id - e.g. "1".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlId { get => this._controlId; }

        /// <summary>Backing field for <see cref="ControlName" /> property.</summary>
        private string _controlName;

        /// <summary>The control name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlName { get => this._controlName; }

        /// <summary>Backing field for <see cref="ControlStatus" /> property.</summary>
        private string _controlStatus;

        /// <summary>Control status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlStatus { get => this._controlStatus; }

        /// <summary>Internal Acessors for CategoryName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.CategoryName { get => this._categoryName; set { {_categoryName = value;} } }

        /// <summary>Internal Acessors for ControlFamilyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ControlFamilyName { get => this._controlFamilyName; set { {_controlFamilyName = value;} } }

        /// <summary>Internal Acessors for ControlId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ControlId { get => this._controlId; set { {_controlId = value;} } }

        /// <summary>Internal Acessors for ControlName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ControlName { get => this._controlName; set { {_controlName = value;} } }

        /// <summary>Internal Acessors for ControlStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ControlStatus { get => this._controlStatus; set { {_controlStatus = value;} } }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Internal Acessors for ResourceOrigin</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResourceOrigin { get => this._resourceOrigin; set { {_resourceOrigin = value;} } }

        /// <summary>Internal Acessors for ResourceStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResourceStatus { get => this._resourceStatus; set { {_resourceStatus = value;} } }

        /// <summary>Internal Acessors for ResourceStatusChangeDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResourceStatusChangeDate { get => this._resourceStatusChangeDate; set { {_resourceStatusChangeDate = value;} } }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Internal Acessors for ResponsibilityDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResponsibilityDescription { get => this._responsibilityDescription; set { {_responsibilityDescription = value;} } }

        /// <summary>Internal Acessors for ResponsibilityTitle</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal.ResponsibilityTitle { get => this._responsibilityTitle; set { {_responsibilityTitle = value;} } }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The Id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Backing field for <see cref="ResourceOrigin" /> property.</summary>
        private string _resourceOrigin;

        /// <summary>Resource origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceOrigin { get => this._resourceOrigin; }

        /// <summary>Backing field for <see cref="ResourceStatus" /> property.</summary>
        private string _resourceStatus;

        /// <summary>Resource status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceStatus { get => this._resourceStatus; }

        /// <summary>Backing field for <see cref="ResourceStatusChangeDate" /> property.</summary>
        private global::System.DateTime? _resourceStatusChangeDate;

        /// <summary>The status change date for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? ResourceStatusChangeDate { get => this._resourceStatusChangeDate; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The type of the resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Backing field for <see cref="ResponsibilityDescription" /> property.</summary>
        private string _responsibilityDescription;

        /// <summary>The description of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResponsibilityDescription { get => this._responsibilityDescription; }

        /// <summary>Backing field for <see cref="ResponsibilityTitle" /> property.</summary>
        private string _responsibilityTitle;

        /// <summary>The title of the customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResponsibilityTitle { get => this._responsibilityTitle; }

        /// <summary>Creates an new <see cref="ComplianceReportItem" /> instance.</summary>
        public ComplianceReportItem()
        {

        }
    }
    /// Object that includes all the content for single compliance result.
    public partial interface IComplianceReportItem :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The category name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The category name.",
        SerializedName = @"categoryName",
        PossibleTypes = new [] { typeof(string) })]
        string CategoryName { get;  }
        /// <summary>The control family name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The control family name.",
        SerializedName = @"controlFamilyName",
        PossibleTypes = new [] { typeof(string) })]
        string ControlFamilyName { get;  }
        /// <summary>The control Id - e.g. "1".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The control Id - e.g. ""1"".",
        SerializedName = @"controlId",
        PossibleTypes = new [] { typeof(string) })]
        string ControlId { get;  }
        /// <summary>The control name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The control name.",
        SerializedName = @"controlName",
        PossibleTypes = new [] { typeof(string) })]
        string ControlName { get;  }
        /// <summary>Control status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Control status.",
        SerializedName = @"controlStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string ControlStatus { get;  }
        /// <summary>The Id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Id of the resource.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }
        /// <summary>Resource origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource origin.",
        SerializedName = @"resourceOrigin",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Azure", "AWS", "GCP")]
        string ResourceOrigin { get;  }
        /// <summary>Resource status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource status.",
        SerializedName = @"resourceStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Healthy", "Unhealthy")]
        string ResourceStatus { get;  }
        /// <summary>The status change date for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status change date for the resource.",
        SerializedName = @"resourceStatusChangeDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResourceStatusChangeDate { get;  }
        /// <summary>The type of the resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of the resource.  e.g. ""Microsoft.SignalRService/SignalR""",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }
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
        string ResponsibilityDescription { get;  }
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
        string ResponsibilityTitle { get;  }

    }
    /// Object that includes all the content for single compliance result.
    internal partial interface IComplianceReportItemInternal

    {
        /// <summary>The category name.</summary>
        string CategoryName { get; set; }
        /// <summary>The control family name.</summary>
        string ControlFamilyName { get; set; }
        /// <summary>The control Id - e.g. "1".</summary>
        string ControlId { get; set; }
        /// <summary>The control name.</summary>
        string ControlName { get; set; }
        /// <summary>Control status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string ControlStatus { get; set; }
        /// <summary>The Id of the resource.</summary>
        string ResourceId { get; set; }
        /// <summary>Resource origin.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Azure", "AWS", "GCP")]
        string ResourceOrigin { get; set; }
        /// <summary>Resource status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Healthy", "Unhealthy")]
        string ResourceStatus { get; set; }
        /// <summary>The status change date for the resource.</summary>
        global::System.DateTime? ResourceStatusChangeDate { get; set; }
        /// <summary>The type of the resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        string ResourceType { get; set; }
        /// <summary>The description of the customer responsibility.</summary>
        string ResponsibilityDescription { get; set; }
        /// <summary>The title of the customer responsibility.</summary>
        string ResponsibilityTitle { get; set; }

    }
}