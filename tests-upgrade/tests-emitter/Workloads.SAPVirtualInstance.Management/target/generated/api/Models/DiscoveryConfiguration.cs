// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Discovery Details.</summary>
    public partial class DiscoveryConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiscoveryConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiscoveryConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration __sapConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapConfiguration();

        /// <summary>Backing field for <see cref="AppLocation" /> property.</summary>
        private string _appLocation;

        /// <summary>The geo-location where the SAP system exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AppLocation { get => this._appLocation; }

        /// <summary>Backing field for <see cref="CentralServerVMId" /> property.</summary>
        private string _centralServerVMId;

        /// <summary>The virtual machine ID of the Central Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string CentralServerVMId { get => this._centralServerVMId; set => this._centralServerVMId = value; }

        /// <summary>The configuration type. Eg: Deployment/Discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string ConfigurationType { get => "Discovery"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal)__sapConfiguration).ConfigurationType = "Discovery"; }

        /// <summary>Backing field for <see cref="ManagedRgStorageAccountName" /> property.</summary>
        private string _managedRgStorageAccountName;

        /// <summary>
        /// The custom storage account name for the storage account created by the service in the managed resource group created as
        /// part of VIS deployment.<br><br>Refer to the storage account naming rules [here](https://learn.microsoft.com/azure/azure-resource-manager/management/resource-name-rules#microsoftstorage).<br><br>If
        /// not provided, the service will create the storage account with a random name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ManagedRgStorageAccountName { get => this._managedRgStorageAccountName; set => this._managedRgStorageAccountName = value; }

        /// <summary>Internal Acessors for AppLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiscoveryConfigurationInternal.AppLocation { get => this._appLocation; set { {_appLocation = value;} } }

        /// <summary>Creates an new <see cref="DiscoveryConfiguration" /> instance.</summary>
        public DiscoveryConfiguration()
        {
            this.__sapConfiguration.ConfigurationType = "Discovery";
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
    /// Discovery Details.
    public partial interface IDiscoveryConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfiguration
    {
        /// <summary>The geo-location where the SAP system exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The geo-location where the SAP system exists.",
        SerializedName = @"appLocation",
        PossibleTypes = new [] { typeof(string) })]
        string AppLocation { get;  }
        /// <summary>The virtual machine ID of the Central Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The virtual machine ID of the Central Server.",
        SerializedName = @"centralServerVmId",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVMId { get; set; }
        /// <summary>
        /// The custom storage account name for the storage account created by the service in the managed resource group created as
        /// part of VIS deployment.<br><br>Refer to the storage account naming rules [here](https://learn.microsoft.com/azure/azure-resource-manager/management/resource-name-rules#microsoftstorage).<br><br>If
        /// not provided, the service will create the storage account with a random name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The custom storage account name for the storage account created by the service in the managed resource group created as part of VIS deployment.<br><br>Refer to the storage account naming rules [here](https://learn.microsoft.com/azure/azure-resource-manager/management/resource-name-rules#microsoftstorage).<br><br>If not provided, the service will create the storage account with a random name.",
        SerializedName = @"managedRgStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedRgStorageAccountName { get; set; }

    }
    /// Discovery Details.
    internal partial interface IDiscoveryConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapConfigurationInternal
    {
        /// <summary>The geo-location where the SAP system exists.</summary>
        string AppLocation { get; set; }
        /// <summary>The virtual machine ID of the Central Server.</summary>
        string CentralServerVMId { get; set; }
        /// <summary>
        /// The custom storage account name for the storage account created by the service in the managed resource group created as
        /// part of VIS deployment.<br><br>Refer to the storage account naming rules [here](https://learn.microsoft.com/azure/azure-resource-manager/management/resource-name-rules#microsoftstorage).<br><br>If
        /// not provided, the service will create the storage account with a random name.
        /// </summary>
        string ManagedRgStorageAccountName { get; set; }

    }
}