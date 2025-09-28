// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Solution result</summary>
    public partial class SolutionsResourcePropertiesSelfHelp :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelp,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal
    {

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private string _content;

        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string Content { get => this._content; }

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.Content { get => this._content; set { {_content = value;} } }

        /// <summary>Internal Acessors for ReplacementMap</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelp Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.ReplacementMap { get => (this._replacementMap = this._replacementMap ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ReplacementMapsSelfHelp()); set { {_replacementMap = value;} } }

        /// <summary>Internal Acessors for ReplacementMapVideo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).Video; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).Video = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideoGroup</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).VideoGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).VideoGroup = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapWebResult</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).WebResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).WebResult = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Section</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISectionSelfHelp> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.Section { get => this._section; set { {_section = value;} } }

        /// <summary>Internal Acessors for SolutionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.SolutionId { get => this._solutionId; set { {_solutionId = value;} } }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsResourcePropertiesSelfHelpInternal.Title { get => this._title; set { {_title = value;} } }

        /// <summary>Backing field for <see cref="ReplacementMap" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelp _replacementMap;

        /// <summary>Solution replacement maps.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelp ReplacementMap { get => (this._replacementMap = this._replacementMap ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ReplacementMapsSelfHelp()); }

        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).Video; }

        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).VideoGroup; }

        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal)ReplacementMap).WebResult; }

        /// <summary>Backing field for <see cref="Section" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISectionSelfHelp> _section;

        /// <summary>List of section object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISectionSelfHelp> Section { get => this._section; }

        /// <summary>Backing field for <see cref="SolutionId" /> property.</summary>
        private string _solutionId;

        /// <summary>
        /// SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string SolutionId { get => this._solutionId; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string Title { get => this._title; }

        /// <summary>Creates an new <see cref="SolutionsResourcePropertiesSelfHelp" /> instance.</summary>
        public SolutionsResourcePropertiesSelfHelp()
        {

        }
    }
    /// Solution result
    public partial interface ISolutionsResourcePropertiesSelfHelp :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The HTML content that needs to be rendered and shown to customer.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get;  }
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Video solutions, which have the power to engage the customer by stimulating their senses",
        SerializedName = @"videos",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> ReplacementMapVideo { get;  }
        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Group of Videos",
        SerializedName = @"videoGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> ReplacementMapVideoGroup { get;  }
        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution AzureKB results",
        SerializedName = @"webResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> ReplacementMapWebResult { get;  }
        /// <summary>List of section object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of section object.",
        SerializedName = @"sections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISectionSelfHelp) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISectionSelfHelp> Section { get;  }
        /// <summary>
        /// SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get;  }
        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The title.",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get;  }

    }
    /// Solution result
    internal partial interface ISolutionsResourcePropertiesSelfHelpInternal

    {
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        string Content { get; set; }
        /// <summary>Solution replacement maps.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelp ReplacementMap { get; set; }
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> ReplacementMapVideo { get; set; }
        /// <summary>Group of Videos</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> ReplacementMapVideoGroup { get; set; }
        /// <summary>Solution AzureKB results</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> ReplacementMapWebResult { get; set; }
        /// <summary>List of section object.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISectionSelfHelp> Section { get; set; }
        /// <summary>
        /// SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP
        /// </summary>
        string SolutionId { get; set; }
        /// <summary>The title.</summary>
        string Title { get; set; }

    }
}