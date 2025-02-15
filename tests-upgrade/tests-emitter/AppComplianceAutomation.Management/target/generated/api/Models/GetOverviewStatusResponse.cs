// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The get overview status response.</summary>
    public partial class GetOverviewStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IGetOverviewStatusResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IGetOverviewStatusResponseInternal
    {

        /// <summary>Backing field for <see cref="StatusList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItem> _statusList;

        /// <summary>List of different status items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItem> StatusList { get => this._statusList; set => this._statusList = value; }

        /// <summary>Creates an new <see cref="GetOverviewStatusResponse" /> instance.</summary>
        public GetOverviewStatusResponse()
        {

        }
    }
    /// The get overview status response.
    public partial interface IGetOverviewStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of different status items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of different status items.",
        SerializedName = @"statusList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItem> StatusList { get; set; }

    }
    /// The get overview status response.
    internal partial interface IGetOverviewStatusResponseInternal

    {
        /// <summary>List of different status items.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItem> StatusList { get; set; }

    }
}