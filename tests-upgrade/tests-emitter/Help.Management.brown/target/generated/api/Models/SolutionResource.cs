// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Solution response.</summary>
    public partial class SolutionResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResource,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource __extensionResource = new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ExtensionResource();

        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Content; }

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

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Content = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ReplacementMap</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMaps Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMap; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMap = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReplacementMapDiagnostic</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMapDiagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapMetricsBasedChart</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMapMetricsBasedChart { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapTroubleshooter</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMapTroubleshooter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideoGroup</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapWebResult</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Section</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.Section { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Section; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Section = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for SolutionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).SolutionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).SolutionId = value ?? null; }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceInternal.Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Title = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Name; }

        /// <summary>Client input parameters to run Solution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesParameters Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Parameter = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties _property;

        /// <summary>Solution result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourceProperties()); set => this._property = value; }

        /// <summary>Status of solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Solution diagnostics results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic> ReplacementMapDiagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic; }

        /// <summary>Solution metrics based charts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart> ReplacementMapMetricsBasedChart { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart; }

        /// <summary>Solutions Troubleshooters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters> ReplacementMapTroubleshooter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter; }

        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo; }

        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup; }

        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>List of section object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection> Section { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Section; }

        /// <summary>Solution Id to identify single solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).SolutionId; }

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
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Title; }

        /// <summary>Solution request trigger criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion> TriggerCriterion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).TriggerCriterion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).TriggerCriterion = value ?? null /* arrayOf */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Type; }

        /// <summary>Creates an new <see cref="SolutionResource" /> instance.</summary>
        public SolutionResource()
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
    /// Solution response.
    public partial interface ISolutionResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource
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
        /// <summary>Client input parameters to run Solution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client input parameters to run Solution",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Status of solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of solution provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Help.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Solution diagnostics results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution diagnostics results.",
        SerializedName = @"diagnostics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic> ReplacementMapDiagnostic { get;  }
        /// <summary>Solution metrics based charts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution metrics based charts",
        SerializedName = @"metricsBasedCharts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart> ReplacementMapMetricsBasedChart { get;  }
        /// <summary>Solutions Troubleshooters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solutions Troubleshooters",
        SerializedName = @"troubleshooters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters> ReplacementMapTroubleshooter { get;  }
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection> Section { get;  }
        /// <summary>Solution Id to identify single solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution Id to identify single solution.",
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
        /// <summary>Solution request trigger criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution request trigger criteria",
        SerializedName = @"triggerCriteria",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion> TriggerCriterion { get; set; }

    }
    /// Solution response.
    internal partial interface ISolutionResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResourceInternal
    {
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        string Content { get; set; }
        /// <summary>Client input parameters to run Solution</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Solution result</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties Property { get; set; }
        /// <summary>Status of solution provisioning.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Help.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Solution replacement maps.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMaps ReplacementMap { get; set; }
        /// <summary>Solution diagnostics results.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic> ReplacementMapDiagnostic { get; set; }
        /// <summary>Solution metrics based charts</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart> ReplacementMapMetricsBasedChart { get; set; }
        /// <summary>Solutions Troubleshooters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters> ReplacementMapTroubleshooter { get; set; }
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> ReplacementMapVideo { get; set; }
        /// <summary>Group of Videos</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> ReplacementMapVideoGroup { get; set; }
        /// <summary>Solution AzureKB results</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> ReplacementMapWebResult { get; set; }
        /// <summary>List of section object.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection> Section { get; set; }
        /// <summary>Solution Id to identify single solution.</summary>
        string SolutionId { get; set; }
        /// <summary>The title.</summary>
        string Title { get; set; }
        /// <summary>Solution request trigger criteria</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion> TriggerCriterion { get; set; }

    }
}