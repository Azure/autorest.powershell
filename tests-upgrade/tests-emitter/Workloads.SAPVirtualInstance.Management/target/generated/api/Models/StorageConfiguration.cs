// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Gets or sets the storage configuration.</summary>
    public partial class StorageConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal
    {

        /// <summary>Internal Acessors for TransportFileShareConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal.TransportFileShareConfiguration { get => (this._transportFileShareConfiguration = this._transportFileShareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.FileShareConfiguration()); set { {_transportFileShareConfiguration = value;} } }

        /// <summary>Backing field for <see cref="TransportFileShareConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration _transportFileShareConfiguration;

        /// <summary>
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the
        /// createAndMount flow if storage configuration is missing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration TransportFileShareConfiguration { get => (this._transportFileShareConfiguration = this._transportFileShareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.FileShareConfiguration()); set => this._transportFileShareConfiguration = value; }

        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string TransportFileShareConfigurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal)TransportFileShareConfiguration).ConfigurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal)TransportFileShareConfiguration).ConfigurationType = value ?? null; }

        /// <summary>Creates an new <see cref="StorageConfiguration" /> instance.</summary>
        public StorageConfiguration()
        {

        }
    }
    /// Gets or sets the storage configuration.
    public partial interface IStorageConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of file share config, eg: Mount/CreateAndMount/Skip.",
        SerializedName = @"configurationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Skip", "CreateAndMount", "Mount")]
        string TransportFileShareConfigurationType { get; set; }

    }
    /// Gets or sets the storage configuration.
    internal partial interface IStorageConfigurationInternal

    {
        /// <summary>
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the
        /// createAndMount flow if storage configuration is missing.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration TransportFileShareConfiguration { get; set; }
        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Skip", "CreateAndMount", "Mount")]
        string TransportFileShareConfigurationType { get; set; }

    }
}