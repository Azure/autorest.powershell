// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    public partial class CloudHsmClusterBackupStatusGetAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterBackupStatusGetAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterBackupStatusGetAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="XmsRequestId" /> property.</summary>
        private string _xmsRequestId;

        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string XmsRequestId { get => this._xmsRequestId; set => this._xmsRequestId = value; }

        /// <summary>
        /// Creates an new <see cref="CloudHsmClusterBackupStatusGetAcceptedResponseHeaders" /> instance.
        /// </summary>
        public CloudHsmClusterBackupStatusGetAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("x-ms-request-id", out var __xMSRequestIdHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ICloudHsmClusterBackupStatusGetAcceptedResponseHeadersInternal)this).XmsRequestId = System.Linq.Enumerable.FirstOrDefault(__xMSRequestIdHeader0) is string __headerXMSRequestIdHeader0 ? __headerXMSRequestIdHeader0 : (string)null;
            }
        }
    }
    public partial interface ICloudHsmClusterBackupStatusGetAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"x-ms-request-id",
        PossibleTypes = new [] { typeof(string) })]
        string XmsRequestId { get; set; }

    }
    internal partial interface ICloudHsmClusterBackupStatusGetAcceptedResponseHeadersInternal

    {
        string XmsRequestId { get; set; }

    }
}