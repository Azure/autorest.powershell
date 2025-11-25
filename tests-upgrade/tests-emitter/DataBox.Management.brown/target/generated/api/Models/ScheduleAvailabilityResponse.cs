// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Schedule availability for given sku in a region.</summary>
    public partial class ScheduleAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponseInternal
    {

        /// <summary>Backing field for <see cref="AvailableDate" /> property.</summary>
        private System.Collections.Generic.List<global::System.DateTime> _availableDate;

        /// <summary>List of dates available to schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<global::System.DateTime> AvailableDate { get => this._availableDate; }

        /// <summary>Internal Acessors for AvailableDate</summary>
        System.Collections.Generic.List<global::System.DateTime> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponseInternal.AvailableDate { get => this._availableDate; set { {_availableDate = value;} } }

        /// <summary>Creates an new <see cref="ScheduleAvailabilityResponse" /> instance.</summary>
        public ScheduleAvailabilityResponse()
        {

        }
    }
    /// Schedule availability for given sku in a region.
    public partial interface IScheduleAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>List of dates available to schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of dates available to schedule",
        SerializedName = @"availableDates",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        System.Collections.Generic.List<global::System.DateTime> AvailableDate { get;  }

    }
    /// Schedule availability for given sku in a region.
    internal partial interface IScheduleAvailabilityResponseInternal

    {
        /// <summary>List of dates available to schedule</summary>
        System.Collections.Generic.List<global::System.DateTime> AvailableDate { get; set; }

    }
}