// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Deployment along with OS Configuration.</summary>
    public partial class DeploymentWithOSConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentWithOSConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentWithOSConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration __sapConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapConfiguration();

        /// <summary>Backing field for <see cref="AppLocation" /> property.</summary>
        private string _appLocation;

        /// <summary>The geo-location where the SAP system is to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AppLocation { get => this._appLocation; set => this._appLocation = value; }

        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string ConfigurationType { get => "DeploymentWithOSConfig"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)__sapConfiguration).ConfigurationType = "DeploymentWithOSConfig"; }

        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DeployerVMPackageStorageAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageStorageAccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageStorageAccountId = value ?? null; }

        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DeployerVMPackageUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageUrl = value ?? null; }

        /// <summary>Backing field for <see cref="InfrastructureConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration _infrastructureConfiguration;

        /// <summary>The infrastructure configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration InfrastructureConfiguration { get => (this._infrastructureConfiguration = this._infrastructureConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.InfrastructureConfiguration()); set => this._infrastructureConfiguration = value; }

        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string InfrastructureConfigurationAppResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)InfrastructureConfiguration).AppResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)InfrastructureConfiguration).AppResourceGroup = value ?? null; }

        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string InfrastructureConfigurationDeploymentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)InfrastructureConfiguration).DeploymentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)InfrastructureConfiguration).DeploymentType = value ?? null; }

        /// <summary>Internal Acessors for InfrastructureConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentWithOSConfigurationInternal.InfrastructureConfiguration { get => (this._infrastructureConfiguration = this._infrastructureConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.InfrastructureConfiguration()); set { {_infrastructureConfiguration = value;} } }

        /// <summary>Internal Acessors for OSSapConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentWithOSConfigurationInternal.OSSapConfiguration { get => (this._oSSapConfiguration = this._oSSapConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSSapConfiguration()); set { {_oSSapConfiguration = value;} } }

        /// <summary>Internal Acessors for OSSapConfigurationDeployerVmpackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentWithOSConfigurationInternal.OSSapConfigurationDeployerVmpackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackage = value; }

        /// <summary>Internal Acessors for SoftwareConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeploymentWithOSConfigurationInternal.SoftwareConfiguration { get => (this._softwareConfiguration = this._softwareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfiguration()); set { {_softwareConfiguration = value;} } }

        /// <summary>Backing field for <see cref="OSSapConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfiguration _oSSapConfiguration;

        /// <summary>The OS and SAP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfiguration OSSapConfiguration { get => (this._oSSapConfiguration = this._oSSapConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSSapConfiguration()); set => this._oSSapConfiguration = value; }

        /// <summary>The FQDN to set for the SAP system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string OSSapConfigurationSapFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).SapFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal)OSSapConfiguration).SapFqdn = value ?? null; }

        /// <summary>Backing field for <see cref="SoftwareConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration _softwareConfiguration;

        /// <summary>The software configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration SoftwareConfiguration { get => (this._softwareConfiguration = this._softwareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfiguration()); set => this._softwareConfiguration = value; }

        /// <summary>The SAP software installation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SoftwareConfigurationSoftwareInstallationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal)SoftwareConfiguration).SoftwareInstallationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal)SoftwareConfiguration).SoftwareInstallationType = value ?? null; }

        /// <summary>Creates an new <see cref="DeploymentWithOSConfiguration" /> instance.</summary>
        public DeploymentWithOSConfiguration()
        {
            this.__sapConfiguration.ConfigurationType = "DeploymentWithOSConfig";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__sapConfiguration), __sapConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__sapConfiguration), __sapConfiguration);
        }
    }
    /// Deployment along with OS Configuration.
    public partial interface IDeploymentWithOSConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration
    {
        /// <summary>The geo-location where the SAP system is to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The geo-location where the SAP system is to be created.",
        SerializedName = @"appLocation",
        PossibleTypes = new [] { typeof(string) })]
        string AppLocation { get; set; }
        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deployer VM packages storage account id",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string DeployerVMPackageStorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to the deployer VM packages file.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string DeployerVMPackageUrl { get; set; }
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The application resource group where SAP system resources will be deployed.",
        SerializedName = @"appResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string InfrastructureConfigurationAppResourceGroup { get; set; }
        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAP deployment type. Eg: SingleServer/ThreeTier.",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string InfrastructureConfigurationDeploymentType { get; set; }
        /// <summary>The FQDN to set for the SAP system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The FQDN to set for the SAP system",
        SerializedName = @"sapFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string OSSapConfigurationSapFqdn { get; set; }
        /// <summary>The SAP software installation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAP software installation type.",
        SerializedName = @"softwareInstallationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ServiceInitiated", "SAPInstallWithoutOSConfig", "External")]
        string SoftwareConfigurationSoftwareInstallationType { get; set; }

    }
    /// Deployment along with OS Configuration.
    internal partial interface IDeploymentWithOSConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal
    {
        /// <summary>The geo-location where the SAP system is to be created.</summary>
        string AppLocation { get; set; }
        /// <summary>The deployer VM packages storage account id</summary>
        string DeployerVMPackageStorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        string DeployerVMPackageUrl { get; set; }
        /// <summary>The infrastructure configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration InfrastructureConfiguration { get; set; }
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        string InfrastructureConfigurationAppResourceGroup { get; set; }
        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string InfrastructureConfigurationDeploymentType { get; set; }
        /// <summary>The OS and SAP configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfiguration OSSapConfiguration { get; set; }
        /// <summary>The url and storage account ID where deployer VM packages are uploaded</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages OSSapConfigurationDeployerVmpackage { get; set; }
        /// <summary>The FQDN to set for the SAP system</summary>
        string OSSapConfigurationSapFqdn { get; set; }
        /// <summary>The software configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration SoftwareConfiguration { get; set; }
        /// <summary>The SAP software installation type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ServiceInitiated", "SAPInstallWithoutOSConfig", "External")]
        string SoftwareConfigurationSoftwareInstallationType { get; set; }

    }
}