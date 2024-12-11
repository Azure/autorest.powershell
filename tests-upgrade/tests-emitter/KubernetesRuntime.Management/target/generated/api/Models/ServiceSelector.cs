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
    public partial class ServiceSelector :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelector,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelectorInternal
    {

        /// <summary>Creates an new <see cref="ServiceSelector" /> instance.</summary>
        public ServiceSelector()
        {

        }
    }
    /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
    /// with label "a=b", then please specify {"a": "b"} in the field.
    public partial interface IServiceSelector :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IAssociativeArray<string>
    {

    }
    /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
    /// with label "a=b", then please specify {"a": "b"} in the field.
    internal partial interface IServiceSelectorInternal

    {

    }
}