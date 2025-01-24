// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Gets or sets the high availability configuration.</summary>
    public partial class HighAvailabilityConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfigurationInternal
    {

        /// <summary>Backing field for <see cref="HighAvailabilityType" /> property.</summary>
        private string _highAvailabilityType;

        /// <summary>The high availability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string HighAvailabilityType { get => this._highAvailabilityType; set => this._highAvailabilityType = value; }

        /// <summary>Creates an new <see cref="HighAvailabilityConfiguration" /> instance.</summary>
        public HighAvailabilityConfiguration()
        {

        }
    }
    /// Gets or sets the high availability configuration.
    public partial interface IHighAvailabilityConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The high availability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The high availability type.",
        SerializedName = @"highAvailabilityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("AvailabilitySet", "AvailabilityZone")]
        string HighAvailabilityType { get; set; }

    }
    /// Gets or sets the high availability configuration.
    internal partial interface IHighAvailabilityConfigurationInternal

    {
        /// <summary>The high availability type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("AvailabilitySet", "AvailabilityZone")]
        string HighAvailabilityType { get; set; }

    }
}