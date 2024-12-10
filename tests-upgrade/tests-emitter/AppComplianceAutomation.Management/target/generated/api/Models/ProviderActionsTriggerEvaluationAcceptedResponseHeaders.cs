// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    public partial class ProviderActionsTriggerEvaluationAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProviderActionsTriggerEvaluationAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProviderActionsTriggerEvaluationAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProviderActionsTriggerEvaluationAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>
        /// Creates an new <see cref="ProviderActionsTriggerEvaluationAcceptedResponseHeaders" /> instance.
        /// </summary>
        public ProviderActionsTriggerEvaluationAcceptedResponseHeaders()
        {

        }
    }
    public partial interface IProviderActionsTriggerEvaluationAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface IProviderActionsTriggerEvaluationAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}