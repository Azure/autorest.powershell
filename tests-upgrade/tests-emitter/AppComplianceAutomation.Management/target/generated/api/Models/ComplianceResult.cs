// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the compliance result.</summary>
    public partial class ComplianceResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResultInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory> _category;

        /// <summary>List of categories.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory> Category { get => this._category; }

        /// <summary>Backing field for <see cref="ComplianceName" /> property.</summary>
        private string _complianceName;

        /// <summary>The name of the compliance. e.g. "M365"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ComplianceName { get => this._complianceName; }

        /// <summary>Internal Acessors for Category</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResultInternal.Category { get => this._category; set { {_category = value;} } }

        /// <summary>Internal Acessors for ComplianceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResultInternal.ComplianceName { get => this._complianceName; set { {_complianceName = value;} } }

        /// <summary>Creates an new <see cref="ComplianceResult" /> instance.</summary>
        public ComplianceResult()
        {

        }
    }
    /// A class represent the compliance result.
    public partial interface IComplianceResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of categories.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of categories.",
        SerializedName = @"categories",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory> Category { get;  }
        /// <summary>The name of the compliance. e.g. "M365"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the compliance. e.g. ""M365""",
        SerializedName = @"complianceName",
        PossibleTypes = new [] { typeof(string) })]
        string ComplianceName { get;  }

    }
    /// A class represent the compliance result.
    internal partial interface IComplianceResultInternal

    {
        /// <summary>List of categories.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICategory> Category { get; set; }
        /// <summary>The name of the compliance. e.g. "M365"</summary>
        string ComplianceName { get; set; }

    }
}