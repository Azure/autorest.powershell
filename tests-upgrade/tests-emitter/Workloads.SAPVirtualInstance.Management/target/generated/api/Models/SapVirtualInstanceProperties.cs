// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the Virtual Instance for SAP solutions resource properties.</summary>
    public partial class SapVirtualInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration _configuration;

        /// <summary>
        /// Defines if the SAP system is being created using Azure Center for SAP solutions (ACSS) or if an existing SAP system is
        /// being registered with ACSS
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapConfiguration()); set => this._configuration = value; }

        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ConfigurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)Configuration).ConfigurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)Configuration).ConfigurationType = value ; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Environment" /> property.</summary>
        private string _environment;

        /// <summary>Defines the environment type - Production/Non Production.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Environment { get => this._environment; set => this._environment = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError _error;

        /// <summary>Indicates any errors on the Virtual Instance for SAP solutions resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Health { get => this._health; }

        /// <summary>Backing field for <see cref="ManagedResourceGroupConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfiguration _managedResourceGroupConfiguration;

        /// <summary>Managed resource group configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfiguration ManagedResourceGroupConfiguration { get => (this._managedResourceGroupConfiguration = this._managedResourceGroupConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ManagedRgConfiguration()); set => this._managedResourceGroupConfiguration = value; }

        /// <summary>Managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfigurationInternal)ManagedResourceGroupConfiguration).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfigurationInternal)ManagedResourceGroupConfiguration).Name = value ?? null; }

        /// <summary>Backing field for <see cref="ManagedResourcesNetworkAccessType" /> property.</summary>
        private string _managedResourcesNetworkAccessType;

        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ManagedResourcesNetworkAccessType { get => this._managedResourcesNetworkAccessType; set => this._managedResourcesNetworkAccessType = value; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapConfiguration()); set { {_configuration = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapVirtualInstanceError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.ErrorProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Property = value; }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for ManagedResourceGroupConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.ManagedResourceGroupConfiguration { get => (this._managedResourceGroupConfiguration = this._managedResourceGroupConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ManagedRgConfiguration()); set { {_managedResourceGroupConfiguration = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceErrorInternal)Error).Message = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstancePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Defines the provisioning states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SapProduct" /> property.</summary>
        private string _sapProduct;

        /// <summary>Defines the SAP Product type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SapProduct { get => this._sapProduct; set => this._sapProduct = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Defines the Virtual Instance for SAP state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string State { get => this._state; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Defines the SAP Instance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="SapVirtualInstanceProperties" /> instance.</summary>
        public SapVirtualInstanceProperties()
        {

        }
    }
    /// Defines the Virtual Instance for SAP solutions resource properties.
    public partial interface ISapVirtualInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
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
        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get;  }
        /// <summary>Defines the environment type - Production/Non Production.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Defines the environment type - Production/Non Production.",
        SerializedName = @"environment",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("NonProd", "Prod")]
        string Environment { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the health of SAP Instances.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get;  }
        /// <summary>Managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed resource group name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupConfigurationName { get; set; }
        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here https://go.microsoft.com/fwlink/?linkid=2247228",
        SerializedName = @"managedResourcesNetworkAccessType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Public", "Private")]
        string ManagedResourcesNetworkAccessType { get; set; }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Defines the provisioning states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the provisioning states.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Defines the SAP Product type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Defines the SAP Product type.",
        SerializedName = @"sapProduct",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ECC", "S4HANA", "Other")]
        string SapProduct { get; set; }
        /// <summary>Defines the Virtual Instance for SAP state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the Virtual Instance for SAP state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("InfrastructureDeploymentPending", "InfrastructureDeploymentInProgress", "InfrastructureDeploymentFailed", "SoftwareInstallationPending", "SoftwareInstallationInProgress", "SoftwareInstallationFailed", "SoftwareDetectionInProgress", "SoftwareDetectionFailed", "DiscoveryPending", "DiscoveryInProgress", "DiscoveryFailed", "RegistrationComplete", "ACSSInstallationBlocked")]
        string State { get;  }
        /// <summary>Defines the SAP Instance status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the SAP Instance status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get;  }

    }
    /// Defines the Virtual Instance for SAP solutions resource properties.
    internal partial interface ISapVirtualInstancePropertiesInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>
        /// Defines if the SAP system is being created using Azure Center for SAP solutions (ACSS) or if an existing SAP system is
        /// being registered with ACSS
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration Configuration { get; set; }
        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Deployment", "Discovery", "DeploymentWithOSConfig")]
        string ConfigurationType { get; set; }
        /// <summary>Internal error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition> Detail { get; set; }
        /// <summary>Defines the environment type - Production/Non Production.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("NonProd", "Prod")]
        string Environment { get; set; }
        /// <summary>Indicates any errors on the Virtual Instance for SAP solutions resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceError Error { get; set; }
        /// <summary>The Virtual Instance for SAP error body.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IErrorDefinition ErrorProperty { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get; set; }
        /// <summary>Managed resource group configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IManagedRgConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary>Managed resource group name</summary>
        string ManagedResourceGroupConfigurationName { get; set; }
        /// <summary>
        /// Specifies the network access configuration for the resources that will be deployed in the Managed Resource Group. The
        /// options to choose from are Public and Private. If 'Private' is chosen, the Storage Account service tag should be enabled
        /// on the subnets in which the SAP VMs exist. This is required for establishing connectivity between VM extensions and the
        /// managed resource group storage account. This setting is currently applicable only to Storage Account. Learn more here
        /// https://go.microsoft.com/fwlink/?linkid=2247228
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Public", "Private")]
        string ManagedResourcesNetworkAccessType { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }
        /// <summary>Defines the provisioning states.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Succeeded", "Updating", "Creating", "Failed", "Deleting", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Defines the SAP Product type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ECC", "S4HANA", "Other")]
        string SapProduct { get; set; }
        /// <summary>Defines the Virtual Instance for SAP state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("InfrastructureDeploymentPending", "InfrastructureDeploymentInProgress", "InfrastructureDeploymentFailed", "SoftwareInstallationPending", "SoftwareInstallationInProgress", "SoftwareInstallationFailed", "SoftwareDetectionInProgress", "SoftwareDetectionFailed", "DiscoveryPending", "DiscoveryInProgress", "DiscoveryFailed", "RegistrationComplete", "ACSSInstallationBlocked")]
        string State { get; set; }
        /// <summary>Defines the SAP Instance status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Starting", "Running", "Stopping", "Offline", "PartiallyRunning", "Unavailable", "SoftShutdown")]
        string Status { get; set; }

    }
}