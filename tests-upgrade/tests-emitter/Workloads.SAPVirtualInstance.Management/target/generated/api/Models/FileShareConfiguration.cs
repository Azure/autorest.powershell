// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount
    /// option is selected in case of missing input.
    /// </summary>
    public partial class FileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationType" /> property.</summary>
        private string _configurationType;

        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ConfigurationType { get => this._configurationType; set => this._configurationType = value; }

        /// <summary>Creates an new <see cref="FileShareConfiguration" /> instance.</summary>
        public FileShareConfiguration()
        {

        }
    }
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount
    /// option is selected in case of missing input.
    public partial interface IFileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of file share config, eg: Mount/CreateAndMount/Skip.",
        SerializedName = @"configurationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Skip", "CreateAndMount", "Mount")]
        string ConfigurationType { get; set; }

    }
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount
    /// option is selected in case of missing input.
    internal partial interface IFileShareConfigurationInternal

    {
        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Skip", "CreateAndMount", "Mount")]
        string ConfigurationType { get; set; }

    }
}