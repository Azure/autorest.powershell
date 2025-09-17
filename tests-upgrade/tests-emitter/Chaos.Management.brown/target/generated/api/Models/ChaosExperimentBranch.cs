// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a branch in the step. 9 total per experiment.</summary>
    public partial class ChaosExperimentBranch :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentBranch,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentBranchInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction> _action;

        /// <summary>List of actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction> Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>String of the branch name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ChaosExperimentBranch" /> instance.</summary>
        public ChaosExperimentBranch()
        {

        }
    }
    /// Model that represents a branch in the step. 9 total per experiment.
    public partial interface IChaosExperimentBranch :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>List of actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of actions.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction> Action { get; set; }
        /// <summary>String of the branch name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String of the branch name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Model that represents a branch in the step. 9 total per experiment.
    internal partial interface IChaosExperimentBranchInternal

    {
        /// <summary>List of actions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction> Action { get; set; }
        /// <summary>String of the branch name.</summary>
        string Name { get; set; }

    }
}