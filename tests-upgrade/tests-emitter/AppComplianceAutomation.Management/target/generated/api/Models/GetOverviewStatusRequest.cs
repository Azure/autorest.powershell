// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Get overview status request object.</summary>
    public partial class GetOverviewStatusRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IGetOverviewStatusRequest,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IGetOverviewStatusRequestInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="GetOverviewStatusRequest" /> instance.</summary>
        public GetOverviewStatusRequest()
        {

        }
    }
    /// Get overview status request object.
    public partial interface IGetOverviewStatusRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Get overview status request object.
    internal partial interface IGetOverviewStatusRequestInternal

    {
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}