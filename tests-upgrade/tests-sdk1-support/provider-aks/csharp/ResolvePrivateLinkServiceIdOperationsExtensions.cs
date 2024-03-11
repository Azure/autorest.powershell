// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ResolvePrivateLinkServiceIdOperations.
    /// </summary>
    public static partial class ResolvePrivateLinkServiceIdOperationsExtensions
    {
            /// <summary>
            /// Gets the private link service ID for the specified managed cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters required in order to resolve a private link service ID.
            /// </param>
            public static PrivateLinkResource Post(this IResolvePrivateLinkServiceIdOperations operations, string resourceGroupName, string resourceName, PrivateLinkResource parameters)
            {
                return ((IResolvePrivateLinkServiceIdOperations)operations).PostAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link service ID for the specified managed cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters required in order to resolve a private link service ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PrivateLinkResource> PostAsync(this IResolvePrivateLinkServiceIdOperations operations, string resourceGroupName, string resourceName, PrivateLinkResource parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}