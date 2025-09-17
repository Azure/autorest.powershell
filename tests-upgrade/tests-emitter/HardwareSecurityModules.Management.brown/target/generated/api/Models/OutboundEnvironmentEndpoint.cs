// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Egress endpoints which dedicated hsm service connects to for common purpose.</summary>
    public partial class OutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IEndpointDependency> _endpoint;

        /// <summary>The endpoints that dedicated hsm service connects to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IEndpointDependency> Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>Creates an new <see cref="OutboundEnvironmentEndpoint" /> instance.</summary>
        public OutboundEnvironmentEndpoint()
        {

        }
    }
    /// Egress endpoints which dedicated hsm service connects to for common purpose.
    public partial interface IOutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>The endpoints that dedicated hsm service connects to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The endpoints that dedicated hsm service connects to",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IEndpointDependency) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IEndpointDependency> Endpoint { get; set; }

    }
    /// Egress endpoints which dedicated hsm service connects to for common purpose.
    internal partial interface IOutboundEnvironmentEndpointInternal

    {
        /// <summary>
        /// The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc.
        /// </summary>
        string Category { get; set; }
        /// <summary>The endpoints that dedicated hsm service connects to</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IEndpointDependency> Endpoint { get; set; }

    }
}