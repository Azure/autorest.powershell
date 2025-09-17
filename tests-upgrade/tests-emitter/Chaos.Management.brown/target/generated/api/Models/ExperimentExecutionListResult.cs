// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>
    /// Model that represents a list of Experiment executions and a link for pagination.
    /// </summary>
    public partial class ExperimentExecutionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecution> _value;

        /// <summary>The ExperimentExecution items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecution> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ExperimentExecutionListResult" /> instance.</summary>
        public ExperimentExecutionListResult()
        {

        }
    }
    /// Model that represents a list of Experiment executions and a link for pagination.
    public partial interface IExperimentExecutionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ExperimentExecution items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ExperimentExecution items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecution) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecution> Value { get; set; }

    }
    /// Model that represents a list of Experiment executions and a link for pagination.
    internal partial interface IExperimentExecutionListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ExperimentExecution items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecution> Value { get; set; }

    }
}