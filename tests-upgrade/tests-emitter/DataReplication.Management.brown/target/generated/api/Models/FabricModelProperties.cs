// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Fabric model properties.</summary>
    public partial class FabricModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CustomProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties _customProperty;

        /// <summary>Fabric model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelCustomProperties()); set => this._customProperty = value; }

        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)CustomProperty).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)CustomProperty).InstanceType = value ; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        /// <summary>Gets or sets the fabric health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Health { get => this._health; }

        /// <summary>Backing field for <see cref="HealthError" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> _healthError;

        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get => this._healthError; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal.CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelCustomProperties()); set { {_customProperty = value;} } }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for HealthError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal.HealthError { get => this._healthError; set { {_healthError = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServiceEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal.ServiceEndpoint { get => this._serviceEndpoint; set { {_serviceEndpoint = value;} } }

        /// <summary>Internal Acessors for ServiceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal.ServiceResourceId { get => this._serviceResourceId; set { {_serviceResourceId = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets or sets the provisioning state of the fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ServiceEndpoint" /> property.</summary>
        private string _serviceEndpoint;

        /// <summary>Gets or sets the service endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ServiceEndpoint { get => this._serviceEndpoint; }

        /// <summary>Backing field for <see cref="ServiceResourceId" /> property.</summary>
        private string _serviceResourceId;

        /// <summary>Gets or sets the service resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ServiceResourceId { get => this._serviceResourceId; }

        /// <summary>Creates an new <see cref="FabricModelProperties" /> instance.</summary>
        public FabricModelProperties()
        {

        }
    }
    /// Fabric model properties.
    public partial interface IFabricModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for FabricModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the fabric health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric health.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Normal", "Warning", "Critical")]
        string Health { get;  }
        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of health errors.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get;  }
        /// <summary>Gets or sets the provisioning state of the fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the fabric.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>Gets or sets the service endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the service endpoint.",
        SerializedName = @"serviceEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceEndpoint { get;  }
        /// <summary>Gets or sets the service resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the service resource Id.",
        SerializedName = @"serviceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceResourceId { get;  }

    }
    /// Fabric model properties.
    internal partial interface IFabricModelPropertiesInternal

    {
        /// <summary>Fabric model custom properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties CustomProperty { get; set; }
        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the fabric health.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Normal", "Warning", "Critical")]
        string Health { get; set; }
        /// <summary>Gets or sets the list of health errors.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get; set; }
        /// <summary>Gets or sets the provisioning state of the fabric.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets the service endpoint.</summary>
        string ServiceEndpoint { get; set; }
        /// <summary>Gets or sets the service resource Id.</summary>
        string ServiceResourceId { get; set; }

    }
}