// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Nlp Metadata resource</summary>
    public partial class SolutionNlpMetadataResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResource,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutions Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionNlpMetadataResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.NlpSolutions()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>
        /// Id of the ProblemClassification (https://learn.microsoft.com/en-us/rest/api/support/problem-classifications?view=rest-support-2020-04-01)
        /// that may be used to create a support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ProblemClassificationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ProblemClassificationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ProblemClassificationId = value ?? null; }

        /// <summary>Description of the problem classification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ProblemDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ProblemDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ProblemDescription = value ?? null; }

        /// <summary>Title of the problem classification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ProblemTitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ProblemTitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ProblemTitle = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutions _property;

        /// <summary>Solution metadata Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutions Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.NlpSolutions()); set => this._property = value; }

        /// <summary>
        /// The set of services that are most likely related to the request. If relatedServices is included in the response then solutions
        /// may not be discovered until the client calls a second time specifying one of the service Ids in the relatedServices object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IClassificationService> RelatedService { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).RelatedService; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).RelatedService = value ?? null /* arrayOf */; }

        /// <summary>
        /// Id of the service (https://learn.microsoft.com/en-us/rest/api/support/services?view=rest-support-2020-04-01) that may
        /// be used to create a support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ServiceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ServiceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).ServiceId = value ?? null; }

        /// <summary>The list of solution metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).Solution; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutionsInternal)Property).Solution = value ?? null /* arrayOf */; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="SolutionNlpMetadataResource" /> instance.</summary>
        public SolutionNlpMetadataResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Nlp Metadata resource
    public partial interface ISolutionNlpMetadataResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IProxyResource
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
    /// Nlp Metadata resource
    internal partial interface ISolutionNlpMetadataResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IProxyResourceInternal
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
        /// <summary>Solution metadata Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.INlpSolutions Property { get; set; }
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