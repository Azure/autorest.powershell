// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Last Mitigation Action Performed On Job</summary>
    public partial class LastMitigationActionOnJob :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal
    {

        /// <summary>Backing field for <see cref="ActionDateTimeInUtc" /> property.</summary>
        private global::System.DateTime? _actionDateTimeInUtc;

        /// <summary>Action performed date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public global::System.DateTime? ActionDateTimeInUtc { get => this._actionDateTimeInUtc; set => this._actionDateTimeInUtc = value; }

        /// <summary>Backing field for <see cref="CustomerResolution" /> property.</summary>
        private string _customerResolution;

        /// <summary>Resolution code provided by customer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CustomerResolution { get => this._customerResolution; set => this._customerResolution = value; }

        /// <summary>Backing field for <see cref="IsPerformedByCustomer" /> property.</summary>
        private bool? _isPerformedByCustomer;

        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? IsPerformedByCustomer { get => this._isPerformedByCustomer; set => this._isPerformedByCustomer = value; }

        /// <summary>Creates an new <see cref="LastMitigationActionOnJob" /> instance.</summary>
        public LastMitigationActionOnJob()
        {

        }
    }
    /// Last Mitigation Action Performed On Job
    public partial interface ILastMitigationActionOnJob :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Action performed date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Action performed date time",
        SerializedName = @"actionDateTimeInUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ActionDateTimeInUtc { get; set; }
        /// <summary>Resolution code provided by customer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resolution code provided by customer",
        SerializedName = @"customerResolution",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        string CustomerResolution { get; set; }
        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Action performed by customer,
        possibility is that mitigation might happen by customer or service or by ops",
        SerializedName = @"isPerformedByCustomer",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPerformedByCustomer { get; set; }

    }
    /// Last Mitigation Action Performed On Job
    internal partial interface ILastMitigationActionOnJobInternal

    {
        /// <summary>Action performed date time</summary>
        global::System.DateTime? ActionDateTimeInUtc { get; set; }
        /// <summary>Resolution code provided by customer</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        string CustomerResolution { get; set; }
        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        bool? IsPerformedByCustomer { get; set; }

    }
}