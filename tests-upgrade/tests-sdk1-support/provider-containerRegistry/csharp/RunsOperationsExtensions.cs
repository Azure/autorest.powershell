// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RunsOperations.
    /// </summary>
    public static partial class RunsOperationsExtensions
    {
            /// <summary>
            /// Gets all the runs for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Run> List(this IRunsOperations operations, string resourceGroupName, string registryName, Microsoft.Rest.Azure.OData.ODataQuery<RunFilter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<RunFilter>))
            {
                return ((IRunsOperations)operations).ListAsync(resourceGroupName, registryName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the runs for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Run>> ListAsync(this IRunsOperations operations, string resourceGroupName, string registryName, Microsoft.Rest.Azure.OData.ODataQuery<RunFilter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<RunFilter>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the detailed information for a given run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            public static Run Get(this IRunsOperations operations, string resourceGroupName, string registryName, string runId)
            {
                return ((IRunsOperations)operations).GetAsync(resourceGroupName, registryName, runId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the detailed information for a given run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Run> GetAsync(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, runId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch the run properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='runUpdateParameters'>
            /// The run update properties.
            /// </param>
            public static Run Update(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, RunUpdateParameters runUpdateParameters)
            {
                return ((IRunsOperations)operations).UpdateAsync(resourceGroupName, registryName, runId, runUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch the run properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='runUpdateParameters'>
            /// The run update properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Run> UpdateAsync(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, RunUpdateParameters runUpdateParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, runId, runUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a link to download the run logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            public static RunGetLogResult GetLogSasUrl(this IRunsOperations operations, string resourceGroupName, string registryName, string runId)
            {
                return ((IRunsOperations)operations).GetLogSasUrlAsync(resourceGroupName, registryName, runId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a link to download the run logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<RunGetLogResult> GetLogSasUrlAsync(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetLogSasUrlWithHttpMessagesAsync(resourceGroupName, registryName, runId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel an existing run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            public static void Cancel(this IRunsOperations operations, string resourceGroupName, string registryName, string runId)
            {
                ((IRunsOperations)operations).CancelAsync(resourceGroupName, registryName, runId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel an existing run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CancelAsync(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(resourceGroupName, registryName, runId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patch the run properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='runUpdateParameters'>
            /// The run update properties.
            /// </param>
            public static Run BeginUpdate(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, RunUpdateParameters runUpdateParameters)
            {
                return ((IRunsOperations)operations).BeginUpdateAsync(resourceGroupName, registryName, runId, runUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch the run properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='runUpdateParameters'>
            /// The run update properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Run> BeginUpdateAsync(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, RunUpdateParameters runUpdateParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, runId, runUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel an existing run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            public static void BeginCancel(this IRunsOperations operations, string resourceGroupName, string registryName, string runId)
            {
                ((IRunsOperations)operations).BeginCancelAsync(resourceGroupName, registryName, runId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel an existing run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='runId'>
            /// The run ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginCancelAsync(this IRunsOperations operations, string resourceGroupName, string registryName, string runId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.BeginCancelWithHttpMessagesAsync(resourceGroupName, registryName, runId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the runs for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Run> ListNext(this IRunsOperations operations, string nextPageLink)
            {
                return ((IRunsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the runs for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Run>> ListNextAsync(this IRunsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
