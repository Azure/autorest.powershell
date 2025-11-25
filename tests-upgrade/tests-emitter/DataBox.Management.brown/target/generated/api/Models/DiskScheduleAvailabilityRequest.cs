// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request body to get the availability for scheduling disk orders.</summary>
    public partial class DiskScheduleAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDiskScheduleAvailabilityRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDiskScheduleAvailabilityRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest __scheduleAvailabilityRequest = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityRequest();

        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).Country = value ?? null; }

        /// <summary>Backing field for <see cref="ExpectedDataSizeInTeraByte" /> property.</summary>
        private int _expectedDataSizeInTeraByte;

        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public int ExpectedDataSizeInTeraByte { get => this._expectedDataSizeInTeraByte; set => this._expectedDataSizeInTeraByte = value; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Model { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).Model = value ?? null; }

        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string SkuName { get => "DataBoxDisk"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).SkuName = "DataBoxDisk"; }

        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StorageLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).StorageLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).StorageLocation = value ; }

        /// <summary>Creates an new <see cref="DiskScheduleAvailabilityRequest" /> instance.</summary>
        public DiskScheduleAvailabilityRequest()
        {
            this.__scheduleAvailabilityRequest.SkuName = "DataBoxDisk";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scheduleAvailabilityRequest), __scheduleAvailabilityRequest);
            await eventListener.AssertObjectIsValid(nameof(__scheduleAvailabilityRequest), __scheduleAvailabilityRequest);
        }
    }
    /// Request body to get the availability for scheduling disk orders.
    public partial interface IDiskScheduleAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest
    {
        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The expected size of the data, which needs to be transferred in this job, in terabytes.",
        SerializedName = @"expectedDataSizeInTeraBytes",
        PossibleTypes = new [] { typeof(int) })]
        int ExpectedDataSizeInTeraByte { get; set; }

    }
    /// Request body to get the availability for scheduling disk orders.
    internal partial interface IDiskScheduleAvailabilityRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal
    {
        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        int ExpectedDataSizeInTeraByte { get; set; }

    }
}