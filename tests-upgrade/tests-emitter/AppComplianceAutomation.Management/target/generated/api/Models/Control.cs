// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the control.</summary>
    public partial class Control :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The control's description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="DescriptionHyperLink" /> property.</summary>
        private string _descriptionHyperLink;

        /// <summary>The hyper link to the control's description'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string DescriptionHyperLink { get => this._descriptionHyperLink; }

        /// <summary>Backing field for <see cref="FullName" /> property.</summary>
        private string _fullName;

        /// <summary>
        /// The full name of the control. e.g. "Validate that unsupported operating systems and software components are not in use."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string FullName { get => this._fullName; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The Id of the control. e.g. "Operational_Security_10"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for DescriptionHyperLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.DescriptionHyperLink { get => this._descriptionHyperLink; set { {_descriptionHyperLink = value;} } }

        /// <summary>Internal Acessors for FullName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.FullName { get => this._fullName; set { {_fullName = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Responsibility</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.Responsibility { get => this._responsibility; set { {_responsibility = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the control. e.g. "Unsupported OS and Software."</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Responsibility" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility> _responsibility;

        /// <summary>List of customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility> Responsibility { get => this._responsibility; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Control status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="Control" /> instance.</summary>
        public Control()
        {

        }
    }
    /// A class represent the control.
    public partial interface IControl :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The control's description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The control's description",
        SerializedName = @"controlDescription",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The hyper link to the control's description'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The hyper link to the control's description'.",
        SerializedName = @"controlDescriptionHyperLink",
        PossibleTypes = new [] { typeof(string) })]
        string DescriptionHyperLink { get;  }
        /// <summary>
        /// The full name of the control. e.g. "Validate that unsupported operating systems and software components are not in use."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The full name of the control. e.g. ""Validate that unsupported operating systems and software components are not in use.""",
        SerializedName = @"controlFullName",
        PossibleTypes = new [] { typeof(string) })]
        string FullName { get;  }
        /// <summary>The Id of the control. e.g. "Operational_Security_10"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Id of the control. e.g. ""Operational_Security_10""",
        SerializedName = @"controlId",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The name of the control. e.g. "Unsupported OS and Software."</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the control. e.g. ""Unsupported OS and Software.""",
        SerializedName = @"controlName",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>List of customer responsibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of customer responsibility.",
        SerializedName = @"responsibilities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility> Responsibility { get;  }
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
        string Status { get;  }

    }
    /// A class represent the control.
    internal partial interface IControlInternal

    {
        /// <summary>The control's description</summary>
        string Description { get; set; }
        /// <summary>The hyper link to the control's description'.</summary>
        string DescriptionHyperLink { get; set; }
        /// <summary>
        /// The full name of the control. e.g. "Validate that unsupported operating systems and software components are not in use."
        /// </summary>
        string FullName { get; set; }
        /// <summary>The Id of the control. e.g. "Operational_Security_10"</summary>
        string Id { get; set; }
        /// <summary>The name of the control. e.g. "Unsupported OS and Software."</summary>
        string Name { get; set; }
        /// <summary>List of customer responsibility.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility> Responsibility { get; set; }
        /// <summary>Control status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get; set; }

    }
}