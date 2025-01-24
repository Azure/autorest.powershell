// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP Configuration.</summary>
    public partial class SapConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationType" /> property.</summary>
        private string _configurationType;

        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ConfigurationType { get => this._configurationType; set => this._configurationType = value; }

        /// <summary>Creates an new <see cref="SapConfiguration" /> instance.</summary>
        public SapConfiguration()
        {

        }
    }
    /// The SAP Configuration.
    public partial interface ISapConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The configuration type. Eg: Deployment/Discovery",
        SerializedName = @"configurationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Deployment", "Discovery", "DeploymentWithOSConfig")]
        string ConfigurationType { get; set; }

    }
    /// The SAP Configuration.
    internal partial interface ISapConfigurationInternal

    {
        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Deployment", "Discovery", "DeploymentWithOSConfig")]
        string ConfigurationType { get; set; }

    }
}