// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    public partial class FileSystemsDeleteAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemsDeleteAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemsDeleteAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Creates an new <see cref="FileSystemsDeleteAcceptedResponseHeaders" /> instance.
        /// </summary>
        public FileSystemsDeleteAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemsDeleteAcceptedResponseHeadersInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Location", out var __locationHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemsDeleteAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader1) is string __headerLocationHeader1 ? __headerLocationHeader1 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader2))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemsDeleteAcceptedResponseHeadersInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader2) is string __headerRetryAfterHeader2 ? int.TryParse( __headerRetryAfterHeader2, out int __headerRetryAfterHeader2Value ) ? __headerRetryAfterHeader2Value : default(int?) : default(int?);
            }
        }
    }
    public partial interface IFileSystemsDeleteAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

    }
    internal partial interface IFileSystemsDeleteAcceptedResponseHeadersInternal

    {
        string AzureAsyncOperation { get; set; }

        string Location { get; set; }

        int? RetryAfter { get; set; }

    }
}