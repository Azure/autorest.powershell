// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Solution PatchRequest body</summary>
    public partial class SolutionPatchRequestBody :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal
    {

        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Content; }

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Content = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ReplacementMap</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMaps Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMap; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMap = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReplacementMapDiagnostic</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMapDiagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapMetricsBasedChart</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMapMetricsBasedChart { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapTroubleshooter</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMapTroubleshooter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideoGroup</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapWebResult</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Section</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection> Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.Section { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Section; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Section = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for SolutionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).SolutionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).SolutionId = value ?? null; }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal.Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Title = value ?? null; }

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

        /// <summary>List of section object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection> Section { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Section; }

        /// <summary>Solution Id to identify single solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).SolutionId; }

        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).Title; }

        /// <summary>Solution request trigger criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion> TriggerCriterion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).TriggerCriterion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesInternal)Property).TriggerCriterion = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="SolutionPatchRequestBody" /> instance.</summary>
        public SolutionPatchRequestBody()
        {

        }
    }
    /// Solution PatchRequest body
    public partial interface ISolutionPatchRequestBody :
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
    /// Solution PatchRequest body
    internal partial interface ISolutionPatchRequestBodyInternal

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