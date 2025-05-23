// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The SAP Software configuration Input when the software is installed externally outside the service.
    /// </summary>
    public partial class ExternalInstallationSoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IExternalInstallationSoftwareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IExternalInstallationSoftwareConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration __softwareConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfiguration();

        /// <summary>Backing field for <see cref="CentralServerVMId" /> property.</summary>
        private string _centralServerVMId;

        /// <summary>The resource ID of the virtual machine containing the central server instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string CentralServerVMId { get => this._centralServerVMId; set => this._centralServerVMId = value; }

        /// <summary>The SAP software installation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string SoftwareInstallationType { get => "External"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal)__softwareConfiguration).SoftwareInstallationType = "External"; }

        /// <summary>
        /// Creates an new <see cref="ExternalInstallationSoftwareConfiguration" /> instance.
        /// </summary>
        public ExternalInstallationSoftwareConfiguration()
        {
            this.__softwareConfiguration.SoftwareInstallationType = "External";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__softwareConfiguration), __softwareConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__softwareConfiguration), __softwareConfiguration);
        }
    }
    /// The SAP Software configuration Input when the software is installed externally outside the service.
    public partial interface IExternalInstallationSoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration
    {
        /// <summary>The resource ID of the virtual machine containing the central server instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource ID of the virtual machine containing the central server instance.",
        SerializedName = @"centralServerVmId",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVMId { get; set; }

    }
    /// The SAP Software configuration Input when the software is installed externally outside the service.
    internal partial interface IExternalInstallationSoftwareConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal
    {
        /// <summary>The resource ID of the virtual machine containing the central server instance.</summary>
        string CentralServerVMId { get; set; }

    }
}