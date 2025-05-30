// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Single status.</summary>
    public partial class StatusItem :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItem,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStatusItemInternal
    {

        /// <summary>Backing field for <see cref="StatusName" /> property.</summary>
        private string _statusName;

        /// <summary>Status name - e.g. "Active", "Failed".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string StatusName { get => this._statusName; set => this._statusName = value; }

        /// <summary>Backing field for <see cref="StatusValue" /> property.</summary>
        private string _statusValue;

        /// <summary>Status value. e.g. "100", or "100%".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string StatusValue { get => this._statusValue; set => this._statusValue = value; }

        /// <summary>Creates an new <see cref="StatusItem" /> instance.</summary>
        public StatusItem()
        {

        }
    }
    /// Single status.
    public partial interface IStatusItem :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Status name - e.g. "Active", "Failed".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status name - e.g. ""Active"", ""Failed"".",
        SerializedName = @"statusName",
        PossibleTypes = new [] { typeof(string) })]
        string StatusName { get; set; }
        /// <summary>Status value. e.g. "100", or "100%".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status value. e.g. ""100"", or ""100%"".",
        SerializedName = @"statusValue",
        PossibleTypes = new [] { typeof(string) })]
        string StatusValue { get; set; }

    }
    /// Single status.
    internal partial interface IStatusItemInternal

    {
        /// <summary>Status name - e.g. "Active", "Failed".</summary>
        string StatusName { get; set; }
        /// <summary>Status value. e.g. "100", or "100%".</summary>
        string StatusValue { get; set; }

    }
}