// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Nlp metadata.</summary>
    public partial class NlpSolutions :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutions,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal
    {

        /// <summary>Backing field for <see cref="ProblemClassificationId" /> property.</summary>
        private string _problemClassificationId;

        /// <summary>
        /// Id of the ProblemClassification (https://learn.microsoft.com/en-us/rest/api/support/problem-classifications?view=rest-support-2020-04-01)
        /// that may be used to create a support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ProblemClassificationId { get => this._problemClassificationId; set => this._problemClassificationId = value; }

        /// <summary>Backing field for <see cref="ProblemDescription" /> property.</summary>
        private string _problemDescription;

        /// <summary>Description of the problem classification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ProblemDescription { get => this._problemDescription; set => this._problemDescription = value; }

        /// <summary>Backing field for <see cref="ProblemTitle" /> property.</summary>
        private string _problemTitle;

        /// <summary>Title of the problem classification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ProblemTitle { get => this._problemTitle; set => this._problemTitle = value; }

        /// <summary>Backing field for <see cref="RelatedService" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IClassificationService> _relatedService;

        /// <summary>
        /// The set of services that are most likely related to the request. If relatedServices is included in the response then solutions
        /// may not be discovered until the client calls a second time specifying one of the service Ids in the relatedServices object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IClassificationService> RelatedService { get => this._relatedService; set => this._relatedService = value; }

        /// <summary>Backing field for <see cref="ServiceId" /> property.</summary>
        private string _serviceId;

        /// <summary>
        /// Id of the service (https://learn.microsoft.com/en-us/rest/api/support/services?view=rest-support-2020-04-01) that may
        /// be used to create a support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ServiceId { get => this._serviceId; set => this._serviceId = value; }

        /// <summary>Backing field for <see cref="Solution" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> _solution;

        /// <summary>The list of solution metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get => this._solution; set => this._solution = value; }

        /// <summary>Creates an new <see cref="NlpSolutions" /> instance.</summary>
        public NlpSolutions()
        {

        }
    }
    /// Nlp metadata.
    public partial interface INlpSolutions :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Id of the ProblemClassification (https://learn.microsoft.com/en-us/rest/api/support/problem-classifications?view=rest-support-2020-04-01)
        /// that may be used to create a support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Id of the ProblemClassification (https://learn.microsoft.com/en-us/rest/api/support/problem-classifications?view=rest-support-2020-04-01) that may be used to create a support ticket.",
        SerializedName = @"problemClassificationId",
        PossibleTypes = new [] { typeof(string) })]
        string ProblemClassificationId { get; set; }
        /// <summary>Description of the problem classification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the problem classification.",
        SerializedName = @"problemDescription",
        PossibleTypes = new [] { typeof(string) })]
        string ProblemDescription { get; set; }
        /// <summary>Title of the problem classification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Title of the problem classification.",
        SerializedName = @"problemTitle",
        PossibleTypes = new [] { typeof(string) })]
        string ProblemTitle { get; set; }
        /// <summary>
        /// The set of services that are most likely related to the request. If relatedServices is included in the response then solutions
        /// may not be discovered until the client calls a second time specifying one of the service Ids in the relatedServices object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The set of services that are most likely related to the request. If relatedServices is included in the response then solutions may not be discovered until the client calls a second time specifying one of the service Ids in the relatedServices object.",
        SerializedName = @"relatedServices",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IClassificationService) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IClassificationService> RelatedService { get; set; }
        /// <summary>
        /// Id of the service (https://learn.microsoft.com/en-us/rest/api/support/services?view=rest-support-2020-04-01) that may
        /// be used to create a support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Id of the service (https://learn.microsoft.com/en-us/rest/api/support/services?view=rest-support-2020-04-01) that may be used to create a support ticket.",
        SerializedName = @"serviceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceId { get; set; }
        /// <summary>The list of solution metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of solution metadata.",
        SerializedName = @"solutions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get; set; }

    }
    /// Nlp metadata.
    internal partial interface INlpSolutionsInternal

    {
        /// <summary>
        /// Id of the ProblemClassification (https://learn.microsoft.com/en-us/rest/api/support/problem-classifications?view=rest-support-2020-04-01)
        /// that may be used to create a support ticket.
        /// </summary>
        string ProblemClassificationId { get; set; }
        /// <summary>Description of the problem classification.</summary>
        string ProblemDescription { get; set; }
        /// <summary>Title of the problem classification.</summary>
        string ProblemTitle { get; set; }
        /// <summary>
        /// The set of services that are most likely related to the request. If relatedServices is included in the response then solutions
        /// may not be discovered until the client calls a second time specifying one of the service Ids in the relatedServices object.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IClassificationService> RelatedService { get; set; }
        /// <summary>
        /// Id of the service (https://learn.microsoft.com/en-us/rest/api/support/services?view=rest-support-2020-04-01) that may
        /// be used to create a support ticket.
        /// </summary>
        string ServiceId { get; set; }
        /// <summary>The list of solution metadata.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get; set; }

    }
}