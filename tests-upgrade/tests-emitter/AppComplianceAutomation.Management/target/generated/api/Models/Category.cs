// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the compliance category.</summary>
    public partial class Category :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategoryInternal
    {

        /// <summary>Backing field for <see cref="ControlFamily" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily> _controlFamily;

        /// <summary>List of control families.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily> ControlFamily { get => this._controlFamily; }

        /// <summary>Internal Acessors for ControlFamily</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategoryInternal.ControlFamily { get => this._controlFamily; set { {_controlFamily = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategoryInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategoryInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the compliance category. e.g. "Operational Security"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Category status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="Category" /> instance.</summary>
        public Category()
        {

        }
    }
    /// A class represent the compliance category.
    public partial interface ICategory :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of control families.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of control families.",
        SerializedName = @"controlFamilies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily> ControlFamily { get;  }
        /// <summary>The name of the compliance category. e.g. "Operational Security"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the compliance category. e.g. ""Operational Security""",
        SerializedName = @"categoryName",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Category status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Category status.",
        SerializedName = @"categoryStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get;  }

    }
    /// A class represent the compliance category.
    internal partial interface ICategoryInternal

    {
        /// <summary>List of control families.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily> ControlFamily { get; set; }
        /// <summary>The name of the compliance category. e.g. "Operational Security"</summary>
        string Name { get; set; }
        /// <summary>Category status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get; set; }

    }
}