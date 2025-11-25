// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The Mitigate Job captured from request body for Mitigate API</summary>
    public partial class MitigateJobRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequestInternal
    {

        /// <summary>Backing field for <see cref="CustomerResolutionCode" /> property.</summary>
        private string _customerResolutionCode;

        /// <summary>Resolution code for the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CustomerResolutionCode { get => this._customerResolutionCode; set => this._customerResolutionCode = value; }

        /// <summary>Backing field for <see cref="SerialNumberCustomerResolutionMap" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequestSerialNumberCustomerResolutionMap _serialNumberCustomerResolutionMap;

        /// <summary>
        /// Serial number and the customer resolution code corresponding to each serial number
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequestSerialNumberCustomerResolutionMap SerialNumberCustomerResolutionMap { get => (this._serialNumberCustomerResolutionMap = this._serialNumberCustomerResolutionMap ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.MitigateJobRequestSerialNumberCustomerResolutionMap()); set => this._serialNumberCustomerResolutionMap = value; }

        /// <summary>Creates an new <see cref="MitigateJobRequest" /> instance.</summary>
        public MitigateJobRequest()
        {

        }
    }
    /// The Mitigate Job captured from request body for Mitigate API
    public partial interface IMitigateJobRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Resolution code for the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resolution code for the job",
        SerializedName = @"customerResolutionCode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        string CustomerResolutionCode { get; set; }
        /// <summary>
        /// Serial number and the customer resolution code corresponding to each serial number
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serial number and the customer resolution code corresponding to each serial number",
        SerializedName = @"serialNumberCustomerResolutionMap",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequestSerialNumberCustomerResolutionMap) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequestSerialNumberCustomerResolutionMap SerialNumberCustomerResolutionMap { get; set; }

    }
    /// The Mitigate Job captured from request body for Mitigate API
    internal partial interface IMitigateJobRequestInternal

    {
        /// <summary>Resolution code for the job</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        string CustomerResolutionCode { get; set; }
        /// <summary>
        /// Serial number and the customer resolution code corresponding to each serial number
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IMitigateJobRequestSerialNumberCustomerResolutionMap SerialNumberCustomerResolutionMap { get; set; }

    }
}