// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Deploy SAP Infrastructure Details.</summary>
    public partial class InfrastructureConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal
    {

        /// <summary>Backing field for <see cref="AppResourceGroup" /> property.</summary>
        private string _appResourceGroup;

        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AppResourceGroup { get => this._appResourceGroup; set => this._appResourceGroup = value; }

        /// <summary>Backing field for <see cref="DeploymentType" /> property.</summary>
        private string _deploymentType;

        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DeploymentType { get => this._deploymentType; set => this._deploymentType = value; }

        /// <summary>Creates an new <see cref="InfrastructureConfiguration" /> instance.</summary>
        public InfrastructureConfiguration()
        {

        }
    }
    /// Deploy SAP Infrastructure Details.
    public partial interface IInfrastructureConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The application resource group where SAP system resources will be deployed.",
        SerializedName = @"appResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string AppResourceGroup { get; set; }
        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAP deployment type. Eg: SingleServer/ThreeTier.",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string DeploymentType { get; set; }

    }
    /// Deploy SAP Infrastructure Details.
    internal partial interface IInfrastructureConfigurationInternal

    {
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        string AppResourceGroup { get; set; }
        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string DeploymentType { get; set; }

    }
}