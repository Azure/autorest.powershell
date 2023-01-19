// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FileSharesOperations operations.
    /// </summary>
    public partial interface IFileSharesOperations
    {
        /// <summary>
        /// Lists all shares.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='maxpagesize'>
        /// Optional. Specified maximum number of shares that can be included
        /// in the list.
        /// </param>
        /// <param name='filter'>
        /// Optional. When specified, only share names starting with the filter
        /// will be listed.
        /// </param>
        /// <param name='expand'>
        /// Optional, used to expand the properties within share's properties.
        /// Valid values are: deleted, snapshots. Should be passed as a string
        /// with delimiter ','
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<FileShareItem>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, string maxpagesize = default(string), string filter = default(string), string expand = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates a new share under the specified account as described by
        /// request body. The share resource includes metadata and properties
        /// for that share. It does not include a list of the files contained
        /// by the share.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='fileShare'>
        /// Properties of the file share to create.
        /// </param>
        /// <param name='expand'>
        /// Optional, used to expand the properties within share's properties.
        /// Valid values are: snapshots. Should be passed as a string with
        /// delimiter ','
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileShare>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, FileShare fileShare, string expand = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates share properties as specified in request body. Properties
        /// not mentioned in the request will not be changed. Update fails if
        /// the specified share does not already exist.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='fileShare'>
        /// Properties to update for the file share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileShare>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, FileShare fileShare, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets properties of a specified share.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='expand'>
        /// Optional, used to expand the properties within share's properties.
        /// Valid values are: stats. Should be passed as a string with
        /// delimiter ','.
        /// </param>
        /// <param name='xMsSnapshot'>
        /// Optional, used to retrieve properties of a snapshot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FileShare>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string expand = default(string), string xMsSnapshot = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes specified share under its account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='xMsSnapshot'>
        /// Optional, used to delete a snapshot.
        /// </param>
        /// <param name='include'>
        /// Optional. Valid values are: snapshots, leased-snapshots, none. The
        /// default value is snapshots. For 'snapshots', the file share is
        /// deleted including all of its file share snapshots. If the file
        /// share contains leased-snapshots, the deletion fails. For
        /// 'leased-snapshots', the file share is deleted included all of its
        /// file share snapshots (leased/unleased). For 'none', the file share
        /// is deleted if it has no share snapshots. If the file share contains
        /// any snapshots (leased or unleased), the deletion fails.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string xMsSnapshot = default(string), string include = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Restore a file share within a valid retention days if share soft
        /// delete is enabled
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='deletedShare'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> RestoreWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, DeletedShare deletedShare, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// The Lease Share operation establishes and manages a lock on a share
        /// for delete operations. The lock duration can be 15 to 60 seconds,
        /// or can be infinite.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='parameters'>
        /// Lease Share request body.
        /// </param>
        /// <param name='xMsSnapshot'>
        /// Optional. Specify the snapshot time to lease a snapshot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<LeaseShareResponse,FileSharesLeaseHeaders>> LeaseWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string xMsSnapshot = default(string), LeaseShareRequest parameters = default(LeaseShareRequest), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all shares.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<FileShareItem>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
