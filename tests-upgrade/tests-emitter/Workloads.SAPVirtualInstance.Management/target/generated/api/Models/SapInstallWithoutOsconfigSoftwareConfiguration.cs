// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The SAP Software configuration Input when the software is to be installed by service without OS Configurations
    /// </summary>
    public partial class SapInstallWithoutOsconfigSoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapInstallWithoutOsconfigSoftwareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapInstallWithoutOsconfigSoftwareConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration __softwareConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfiguration();

        /// <summary>Backing field for <see cref="BomUrl" /> property.</summary>
        private string _bomUrl;

        /// <summary>The URL to the SAP Build of Materials(BOM) file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string BomUrl { get => this._bomUrl; set => this._bomUrl = value; }

        /// <summary>
        /// Backing field for <see cref="HighAvailabilitySoftwareConfiguration" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfiguration _highAvailabilitySoftwareConfiguration;

        /// <summary>Gets or sets the HA software configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfiguration HighAvailabilitySoftwareConfiguration { get => (this._highAvailabilitySoftwareConfiguration = this._highAvailabilitySoftwareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilitySoftwareConfiguration()); set => this._highAvailabilitySoftwareConfiguration = value; }

        /// <summary>The fencing client id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string HighAvailabilitySoftwareConfigurationFencingClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfigurationInternal)HighAvailabilitySoftwareConfiguration).FencingClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfigurationInternal)HighAvailabilitySoftwareConfiguration).FencingClientId = value ?? null; }

        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster
        /// VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Security.SecureString HighAvailabilitySoftwareConfigurationFencingClientPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfigurationInternal)HighAvailabilitySoftwareConfiguration).FencingClientPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfigurationInternal)HighAvailabilitySoftwareConfiguration).FencingClientPassword = value ?? null; }

        /// <summary>Internal Acessors for HighAvailabilitySoftwareConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapInstallWithoutOsconfigSoftwareConfigurationInternal.HighAvailabilitySoftwareConfiguration { get => (this._highAvailabilitySoftwareConfiguration = this._highAvailabilitySoftwareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilitySoftwareConfiguration()); set { {_highAvailabilitySoftwareConfiguration = value;} } }

        /// <summary>Backing field for <see cref="SapBitsStorageAccountId" /> property.</summary>
        private string _sapBitsStorageAccountId;

        /// <summary>The SAP bits storage account id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SapBitsStorageAccountId { get => this._sapBitsStorageAccountId; set => this._sapBitsStorageAccountId = value; }

        /// <summary>The SAP software installation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string SoftwareInstallationType { get => "SAPInstallWithoutOSConfig"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal)__softwareConfiguration).SoftwareInstallationType = "SAPInstallWithoutOSConfig"; }

        /// <summary>Backing field for <see cref="SoftwareVersion" /> property.</summary>
        private string _softwareVersion;

        /// <summary>The software version to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SoftwareVersion { get => this._softwareVersion; set => this._softwareVersion = value; }

        /// <summary>
        /// Creates an new <see cref="SapInstallWithoutOsconfigSoftwareConfiguration" /> instance.
        /// </summary>
        public SapInstallWithoutOsconfigSoftwareConfiguration()
        {
            this.__softwareConfiguration.SoftwareInstallationType = "SAPInstallWithoutOSConfig";
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
    /// The SAP Software configuration Input when the software is to be installed by service without OS Configurations
    public partial interface ISapInstallWithoutOsconfigSoftwareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfiguration
    {
        /// <summary>The URL to the SAP Build of Materials(BOM) file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to the SAP Build of Materials(BOM) file.",
        SerializedName = @"bomUrl",
        PossibleTypes = new [] { typeof(string) })]
        string BomUrl { get; set; }
        /// <summary>The fencing client id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fencing client id.",
        SerializedName = @"fencingClientId",
        PossibleTypes = new [] { typeof(string) })]
        string HighAvailabilitySoftwareConfigurationFencingClientId { get; set; }
        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster
        /// VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster VMs.",
        SerializedName = @"fencingClientPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString HighAvailabilitySoftwareConfigurationFencingClientPassword { get; set; }
        /// <summary>The SAP bits storage account id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAP bits storage account id.",
        SerializedName = @"sapBitsStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string SapBitsStorageAccountId { get; set; }
        /// <summary>The software version to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The software version to install.",
        SerializedName = @"softwareVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SoftwareVersion { get; set; }

    }
    /// The SAP Software configuration Input when the software is to be installed by service without OS Configurations
    internal partial interface ISapInstallWithoutOsconfigSoftwareConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISoftwareConfigurationInternal
    {
        /// <summary>The URL to the SAP Build of Materials(BOM) file.</summary>
        string BomUrl { get; set; }
        /// <summary>Gets or sets the HA software configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilitySoftwareConfiguration HighAvailabilitySoftwareConfiguration { get; set; }
        /// <summary>The fencing client id.</summary>
        string HighAvailabilitySoftwareConfigurationFencingClientId { get; set; }
        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster
        /// VMs.
        /// </summary>
        System.Security.SecureString HighAvailabilitySoftwareConfigurationFencingClientPassword { get; set; }
        /// <summary>The SAP bits storage account id.</summary>
        string SapBitsStorageAccountId { get; set; }
        /// <summary>The software version to install.</summary>
        string SoftwareVersion { get; set; }

    }
}