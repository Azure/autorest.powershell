// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    public partial class AutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="IfMatch" /> property.</summary>
        private string _ifMatch;

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string IfMatch { get => this._ifMatch; set => this._ifMatch = value; }

        /// <summary>
        /// Creates an new <see cref="AutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeaders" /> instance.
        /// </summary>
        public AutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("If-Match", out var __ifMatchHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeadersInternal)this).IfMatch = System.Linq.Enumerable.FirstOrDefault(__ifMatchHeader0) is string __headerIfMatchHeader0 ? __headerIfMatchHeader0 : (string)null;
            }
        }
    }
    public partial interface IAutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"If-Match",
        PossibleTypes = new [] { typeof(string) })]
        string IfMatch { get; set; }

    }
    internal partial interface IAutoUpgradeProfileOperationsGenerateUpdateRunAcceptedResponseHeadersInternal

    {
        string IfMatch { get; set; }

    }
}