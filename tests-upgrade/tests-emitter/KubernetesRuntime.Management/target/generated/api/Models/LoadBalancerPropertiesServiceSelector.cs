// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>
    /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
    /// with label "a=b", then please specify {"a": "b"} in the field.
    /// </summary>
    public partial class LoadBalancerPropertiesServiceSelector :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ILoadBalancerPropertiesServiceSelector,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ILoadBalancerPropertiesServiceSelectorInternal
    {

        /// <summary>Creates an new <see cref="LoadBalancerPropertiesServiceSelector" /> instance.</summary>
        public LoadBalancerPropertiesServiceSelector()
        {

        }
    }
    /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
    /// with label "a=b", then please specify {"a": "b"} in the field.
    public partial interface ILoadBalancerPropertiesServiceSelector :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IAssociativeArray<string>
    {

    }
    /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
    /// with label "a=b", then please specify {"a": "b"} in the field.
    internal partial interface ILoadBalancerPropertiesServiceSelectorInternal

    {

    }
}