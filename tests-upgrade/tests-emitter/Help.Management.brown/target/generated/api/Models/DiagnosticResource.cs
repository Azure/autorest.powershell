// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Diagnostic resource</summary>
    public partial class DiagnosticResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResource,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource __extensionResource = new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ExtensionResource();

        /// <summary>Diagnostic Request Accepted time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string AcceptedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).AcceptedAt; }

        /// <summary>Array of Diagnostics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnostic> Diagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).Diagnostic; }

        /// <summary>
        /// Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics
        /// results
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesGlobalParameters GlobalParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).GlobalParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).GlobalParameter = value ?? null /* model class */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Id; }

        /// <summary>SolutionIds that are needed to be invoked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticInvocation> Insight { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).Insight; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).Insight = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AcceptedAt</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceInternal.AcceptedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).AcceptedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).AcceptedAt = value ?? null; }

        /// <summary>Internal Acessors for Diagnostic</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnostic> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceInternal.Diagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).Diagnostic; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).Diagnostic = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiagnosticResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).ProvisioningState = value ?? null; }

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

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceProperties _property;

        /// <summary>Diagnostic Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.DiagnosticResourceProperties()); set => this._property = value; }

        /// <summary>Status of diagnostic provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

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

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IResourceInternal)__extensionResource).Type; }

        /// <summary>Creates an new <see cref="DiagnosticResource" /> instance.</summary>
        public DiagnosticResource()
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
    /// Diagnostic resource
    public partial interface IDiagnosticResource :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResource
    {
        /// <summary>Diagnostic Request Accepted time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Diagnostic Request Accepted time.",
        SerializedName = @"acceptedAt",
        PossibleTypes = new [] { typeof(string) })]
        string AcceptedAt { get;  }
        /// <summary>Array of Diagnostics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of Diagnostics.",
        SerializedName = @"diagnostics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnostic) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnostic> Diagnostic { get;  }
        /// <summary>
        /// Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics
        /// results
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Global parameters is an optional map which can be used to add key and  value to request body to improve the diagnostics results",
        SerializedName = @"globalParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesGlobalParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesGlobalParameters GlobalParameter { get; set; }
        /// <summary>SolutionIds that are needed to be invoked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SolutionIds that are needed to be invoked.",
        SerializedName = @"insights",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticInvocation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticInvocation> Insight { get; set; }
        /// <summary>Status of diagnostic provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of diagnostic provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Help.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get;  }

    }
    /// Diagnostic resource
    internal partial interface IDiagnosticResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IExtensionResourceInternal
    {
        /// <summary>Diagnostic Request Accepted time.</summary>
        string AcceptedAt { get; set; }
        /// <summary>Array of Diagnostics.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnostic> Diagnostic { get; set; }
        /// <summary>
        /// Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics
        /// results
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesGlobalParameters GlobalParameter { get; set; }
        /// <summary>SolutionIds that are needed to be invoked.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticInvocation> Insight { get; set; }
        /// <summary>Diagnostic Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourceProperties Property { get; set; }
        /// <summary>Status of diagnostic provisioning.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Help.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get; set; }

    }
}