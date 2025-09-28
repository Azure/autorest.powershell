// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Discover NLP request.</summary>
    public partial class DiscoveryNlpRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiscoveryNlpRequestInternal
    {

        /// <summary>Backing field for <see cref="AdditionalContext" /> property.</summary>
        private string _additionalContext;

        /// <summary>Additional information in the form of a string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string AdditionalContext { get => this._additionalContext; set => this._additionalContext = value; }

        /// <summary>Backing field for <see cref="IssueSummary" /> property.</summary>
        private string _issueSummary;

        /// <summary>Natural language description of the issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string IssueSummary { get => this._issueSummary; set => this._issueSummary = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// ARM resource Id of the resource that is having the issue. Only applicable for Discovery Solution NLP Subscription Scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="ServiceId" /> property.</summary>
        private string _serviceId;

        /// <summary>
        /// ARM service Id of the service that is having the issue. For more information on service Id see https://learn.microsoft.com/rest/api/support/services/list?tabs=HTTP.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ServiceId { get => this._serviceId; set => this._serviceId = value; }

        /// <summary>Creates an new <see cref="DiscoveryNlpRequest" /> instance.</summary>
        public DiscoveryNlpRequest()
        {

        }
    }
    /// Discover NLP request.
    public partial interface IDiscoveryNlpRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>Additional information in the form of a string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional information in the form of a string.",
        SerializedName = @"additionalContext",
        PossibleTypes = new [] { typeof(string) })]
        string AdditionalContext { get; set; }
        /// <summary>Natural language description of the issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Natural language description of the issue.",
        SerializedName = @"issueSummary",
        PossibleTypes = new [] { typeof(string) })]
        string IssueSummary { get; set; }
        /// <summary>
        /// ARM resource Id of the resource that is having the issue. Only applicable for Discovery Solution NLP Subscription Scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM resource Id of the resource that is having the issue. Only applicable for Discovery Solution NLP Subscription Scope.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>
        /// ARM service Id of the service that is having the issue. For more information on service Id see https://learn.microsoft.com/rest/api/support/services/list?tabs=HTTP.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM service Id of the service that is having the issue. For more information on service Id see https://learn.microsoft.com/rest/api/support/services/list?tabs=HTTP.",
        SerializedName = @"serviceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceId { get; set; }

    }
    /// Discover NLP request.
    internal partial interface IDiscoveryNlpRequestInternal

    {
        /// <summary>Additional information in the form of a string.</summary>
        string AdditionalContext { get; set; }
        /// <summary>Natural language description of the issue.</summary>
        string IssueSummary { get; set; }
        /// <summary>
        /// ARM resource Id of the resource that is having the issue. Only applicable for Discovery Solution NLP Subscription Scope.
        /// </summary>
        string ResourceId { get; set; }
        /// <summary>
        /// ARM service Id of the service that is having the issue. For more information on service Id see https://learn.microsoft.com/rest/api/support/services/list?tabs=HTTP.
        /// </summary>
        string ServiceId { get; set; }

    }
}