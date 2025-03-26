// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The CheckNameAvailability operation response.</summary>
    public partial class CheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ICheckNameAvailabilityResult,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ICheckNameAvailabilityResultInternal
    {

        /// <summary>Backing field for <see cref="Available" /> property.</summary>
        private string _available;

        /// <summary>Availability status of the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Available { get => this._available; set => this._available = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>
        /// A message explaining why the name is unavailable. Will be null if the name is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name whose availability was checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>
        /// The reason code explaining why the name is unavailable. Will be null if the name is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResult" /> instance.</summary>
        public CheckNameAvailabilityResult()
        {

        }
    }
    /// The CheckNameAvailability operation response.
    public partial interface ICheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>Availability status of the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Availability status of the name.",
        SerializedName = @"available",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Available", "Unavailable")]
        string Available { get; set; }
        /// <summary>
        /// A message explaining why the name is unavailable. Will be null if the name is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A message explaining why the name is unavailable. Will be null if the name is available.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The name whose availability was checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name whose availability was checked.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The reason code explaining why the name is unavailable. Will be null if the name is available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The reason code explaining why the name is unavailable. Will be null if the name is available.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
    /// The CheckNameAvailability operation response.
    internal partial interface ICheckNameAvailabilityResultInternal

    {
        /// <summary>Availability status of the name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Available", "Unavailable")]
        string Available { get; set; }
        /// <summary>
        /// A message explaining why the name is unavailable. Will be null if the name is available.
        /// </summary>
        string Message { get; set; }
        /// <summary>The name whose availability was checked.</summary>
        string Name { get; set; }
        /// <summary>
        /// The reason code explaining why the name is unavailable. Will be null if the name is available.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
}