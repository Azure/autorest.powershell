// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Specifies the hardware settings for the Azure Large Instance.</summary>
    public partial class HardwareProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfileInternal
    {

        /// <summary>Backing field for <see cref="AzureLargeInstanceSize" /> property.</summary>
        private string _azureLargeInstanceSize;

        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string AzureLargeInstanceSize { get => this._azureLargeInstanceSize; set => this._azureLargeInstanceSize = value; }

        /// <summary>Backing field for <see cref="HardwareType" /> property.</summary>
        private string _hardwareType;

        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string HardwareType { get => this._hardwareType; set => this._hardwareType = value; }

        /// <summary>Creates an new <see cref="HardwareProfile" /> instance.</summary>
        public HardwareProfile()
        {

        }
    }
    /// Specifies the hardware settings for the Azure Large Instance.
    public partial interface IHardwareProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Azure Large Instance SKU.",
        SerializedName = @"azureLargeInstanceSize",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        string AzureLargeInstanceSize { get; set; }
        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the hardware type (vendor and/or their product name)",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareType { get; set; }

    }
    /// Specifies the hardware settings for the Azure Large Instance.
    internal partial interface IHardwareProfileInternal

    {
        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        string AzureLargeInstanceSize { get; set; }
        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareType { get; set; }

    }
}