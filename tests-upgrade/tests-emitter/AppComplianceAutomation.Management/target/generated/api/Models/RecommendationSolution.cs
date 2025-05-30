// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the recommendation solution.</summary>
    public partial class RecommendationSolution :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolutionInternal
    {

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private string _content;

        /// <summary>The detail steps of the recommendation solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Content { get => this._content; }

        /// <summary>Backing field for <see cref="Index" /> property.</summary>
        private string _index;

        /// <summary>The index of the recommendation solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Index { get => this._index; }

        /// <summary>Backing field for <see cref="IsRecommendSolution" /> property.</summary>
        private string _isRecommendSolution;

        /// <summary>Indicates whether this solution is the recommended.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string IsRecommendSolution { get => this._isRecommendSolution; }

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolutionInternal.Content { get => this._content; set { {_content = value;} } }

        /// <summary>Internal Acessors for Index</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolutionInternal.Index { get => this._index; set { {_index = value;} } }

        /// <summary>Internal Acessors for IsRecommendSolution</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolutionInternal.IsRecommendSolution { get => this._isRecommendSolution; set { {_isRecommendSolution = value;} } }

        /// <summary>Creates an new <see cref="RecommendationSolution" /> instance.</summary>
        public RecommendationSolution()
        {

        }
    }
    /// A class represent the recommendation solution.
    public partial interface IRecommendationSolution :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The detail steps of the recommendation solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The detail steps of the recommendation solution.",
        SerializedName = @"recommendationSolutionContent",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get;  }
        /// <summary>The index of the recommendation solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The index of the recommendation solution.",
        SerializedName = @"recommendationSolutionIndex",
        PossibleTypes = new [] { typeof(string) })]
        string Index { get;  }
        /// <summary>Indicates whether this solution is the recommended.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates whether this solution is the recommended.",
        SerializedName = @"isRecommendSolution",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string IsRecommendSolution { get;  }

    }
    /// A class represent the recommendation solution.
    internal partial interface IRecommendationSolutionInternal

    {
        /// <summary>The detail steps of the recommendation solution.</summary>
        string Content { get; set; }
        /// <summary>The index of the recommendation solution.</summary>
        string Index { get; set; }
        /// <summary>Indicates whether this solution is the recommended.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("true", "false")]
        string IsRecommendSolution { get; set; }

    }
}