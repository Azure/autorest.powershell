// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Simplified Solutions response.</summary>
    public partial class SimplifiedSolutionsResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResource,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource __extensionResource = new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ExtensionResource();

        /// <summary>Additional parameter response for Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesAppendix Appendix { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Appendix; }

        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Content; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Appendix</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesAppendix Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceInternal.Appendix { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Appendix; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Appendix = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceInternal.Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Content = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SimplifiedSolutionsResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceInternal.Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Title = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Name; }

        /// <summary>Client input parameters to run Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesParameters Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Parameter = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceProperties _property;

        /// <summary>Simplified Solutions result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SimplifiedSolutionsResourceProperties()); set => this._property = value; }

        /// <summary>Status of Simplified Solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Solution Id to identify single Simplified Solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).SolutionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).SolutionId = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).SystemDataLastModifiedByType; }

        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesInternal)Property).Title; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Type; }

        /// <summary>Creates an new <see cref="SimplifiedSolutionsResource" /> instance.</summary>
        public SimplifiedSolutionsResource()
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
            await eventListener.AssertNotNull(nameof(__extensionResource), __extensionResource);
            await eventListener.AssertObjectIsValid(nameof(__extensionResource), __extensionResource);
        }
    }
    /// Simplified Solutions response.
    public partial interface ISimplifiedSolutionsResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource
    {
        /// <summary>Additional parameter response for Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Additional parameter response for Simplified Solutions",
        SerializedName = @"appendix",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesAppendix) })]
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesAppendix Appendix { get;  }
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
        /// <summary>Client input parameters to run Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client input parameters to run Simplified Solutions",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Status of Simplified Solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of Simplified Solution provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Help.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Solution Id to identify single Simplified Solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution Id to identify single Simplified Solution.",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get; set; }
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
    /// Simplified Solutions response.
    internal partial interface ISimplifiedSolutionsResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResourceInternal
    {
        /// <summary>Additional parameter response for Simplified Solutions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesAppendix Appendix { get; set; }
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        string Content { get; set; }
        /// <summary>Client input parameters to run Simplified Solutions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Simplified Solutions result</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISimplifiedSolutionsResourceProperties Property { get; set; }
        /// <summary>Status of Simplified Solution provisioning.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Help.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Solution Id to identify single Simplified Solution.</summary>
        string SolutionId { get; set; }
        /// <summary>The title.</summary>
        string Title { get; set; }

    }
}