// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Extensions;

    /// <summary>Security Profile specifies attributes for cluster security features.</summary>
    public partial class SecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileInternal
    {

        /// <summary>Internal Acessors for WorkloadIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileInternal.WorkloadIdentity { get => (this._workloadIdentity = this._workloadIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SecurityProfileWorkloadIdentity()); set { {_workloadIdentity = value;} } }

        /// <summary>Backing field for <see cref="WorkloadIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity _workloadIdentity;

        /// <summary>The workload identity feature webhook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity WorkloadIdentity { get => (this._workloadIdentity = this._workloadIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.SecurityProfileWorkloadIdentity()); set => this._workloadIdentity = value; }

        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Inlined)]
        public bool? WorkloadIdentityEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentityInternal)WorkloadIdentity).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentityInternal)WorkloadIdentity).Enabled = value ?? default(bool); }

        /// <summary>Creates an new <see cref="SecurityProfile" /> instance.</summary>
        public SecurityProfile()
        {

        }
    }
    /// Security Profile specifies attributes for cluster security features.
    public partial interface ISecurityProfile :
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
        bool? WorkloadIdentityEnabled { get; set; }

    }
    /// Security Profile specifies attributes for cluster security features.
    internal partial interface ISecurityProfileInternal

    {
        /// <summary>The workload identity feature webhook.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ISecurityProfileWorkloadIdentity WorkloadIdentity { get; set; }
        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        bool? WorkloadIdentityEnabled { get; set; }

    }
}