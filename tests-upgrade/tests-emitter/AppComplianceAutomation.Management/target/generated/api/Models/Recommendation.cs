// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the recommendation.</summary>
    public partial class Recommendation :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The Id of the recommendation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for ShortName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationInternal.ShortName { get => this._shortName; set { {_shortName = value;} } }

        /// <summary>Internal Acessors for Solution</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationInternal.Solution { get => this._solution; set { {_solution = value;} } }

        /// <summary>Backing field for <see cref="ShortName" /> property.</summary>
        private string _shortName;

        /// <summary>The short name of the recommendation. e.g. "Invalid TLS config"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ShortName { get => this._shortName; }

        /// <summary>Backing field for <see cref="Solution" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution> _solution;

        /// <summary>List of recommendation solutions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution> Solution { get => this._solution; }

        /// <summary>Creates an new <see cref="Recommendation" /> instance.</summary>
        public Recommendation()
        {

        }
    }
    /// A class represent the recommendation.
    public partial interface IRecommendation :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The Id of the recommendation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Id of the recommendation.",
        SerializedName = @"recommendationId",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The short name of the recommendation. e.g. "Invalid TLS config"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The short name of the recommendation. e.g. ""Invalid TLS config""",
        SerializedName = @"recommendationShortName",
        PossibleTypes = new [] { typeof(string) })]
        string ShortName { get;  }
        /// <summary>List of recommendation solutions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of recommendation solutions.",
        SerializedName = @"recommendationSolutions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution> Solution { get;  }

    }
    /// A class represent the recommendation.
    internal partial interface IRecommendationInternal

    {
        /// <summary>The Id of the recommendation.</summary>
        string Id { get; set; }
        /// <summary>The short name of the recommendation. e.g. "Invalid TLS config"</summary>
        string ShortName { get; set; }
        /// <summary>List of recommendation solutions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendationSolution> Solution { get; set; }

    }
}