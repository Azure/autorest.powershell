// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Extensions;

    /// <summary>The workload identity feature webhook.</summary>
    public partial class SecurityProfileWorkloadIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentityInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="SecurityProfileWorkloadIdentity" /> instance.</summary>
        public SecurityProfileWorkloadIdentity()
        {

        }
    }
    /// The workload identity feature webhook.
    public partial interface ISecurityProfileWorkloadIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to enable or disable the workload identity Webhook",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// The workload identity feature webhook.
    internal partial interface ISecurityProfileWorkloadIdentityInternal

    {
        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        bool? Enabled { get; set; }

    }
}