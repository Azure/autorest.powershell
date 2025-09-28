// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    public partial class HelpIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IHelpIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IHelpIdentityInternal
    {

        /// <summary>Backing field for <see cref="DiagnosticsResourceName" /> property.</summary>
        private string _diagnosticsResourceName;

        /// <summary>Unique resource name for insight resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string DiagnosticsResourceName { get => this._diagnosticsResourceName; set => this._diagnosticsResourceName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Backing field for <see cref="SimplifiedSolutionsResourceName" /> property.</summary>
        private string _simplifiedSolutionsResourceName;

        /// <summary>Simplified Solutions Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string SimplifiedSolutionsResourceName { get => this._simplifiedSolutionsResourceName; set => this._simplifiedSolutionsResourceName = value; }

        /// <summary>Backing field for <see cref="SolutionId" /> property.</summary>
        private string _solutionId;

        /// <summary>
        /// SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string SolutionId { get => this._solutionId; set => this._solutionId = value; }

        /// <summary>Backing field for <see cref="SolutionResourceName" /> property.</summary>
        private string _solutionResourceName;

        /// <summary>Solution resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string SolutionResourceName { get => this._solutionResourceName; set => this._solutionResourceName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TroubleshooterName" /> property.</summary>
        private string _troubleshooterName;

        /// <summary>Troubleshooter resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string TroubleshooterName { get => this._troubleshooterName; set => this._troubleshooterName = value; }

        /// <summary>Creates an new <see cref="HelpIdentity" /> instance.</summary>
        public HelpIdentity()
        {

        }
    }
    public partial interface IHelpIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>Unique resource name for insight resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique resource name for insight resources",
        SerializedName = @"diagnosticsResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DiagnosticsResourceName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified Azure Resource manager identifier of the resource.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
        /// <summary>Simplified Solutions Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Simplified Solutions Resource Name.",
        SerializedName = @"simplifiedSolutionsResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string SimplifiedSolutionsResourceName { get; set; }
        /// <summary>
        /// SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get; set; }
        /// <summary>Solution resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution resource Name.",
        SerializedName = @"solutionResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionResourceName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Troubleshooter resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Troubleshooter resource Name.",
        SerializedName = @"troubleshooterName",
        PossibleTypes = new [] { typeof(string) })]
        string TroubleshooterName { get; set; }

    }
    internal partial interface IHelpIdentityInternal

    {
        /// <summary>Unique resource name for insight resources</summary>
        string DiagnosticsResourceName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The fully qualified Azure Resource manager identifier of the resource.</summary>
        string Scope { get; set; }
        /// <summary>Simplified Solutions Resource Name.</summary>
        string SimplifiedSolutionsResourceName { get; set; }
        /// <summary>
        /// SolutionId is a unique id to identify a solution. You can retrieve the solution id using the Discovery api - https://learn.microsoft.com/en-us/rest/api/help/discovery-solution/list?view=rest-help-2023-09-01-preview&tabs=HTTP
        /// </summary>
        string SolutionId { get; set; }
        /// <summary>Solution resource Name.</summary>
        string SolutionResourceName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>Troubleshooter resource Name.</summary>
        string TroubleshooterName { get; set; }

    }
}