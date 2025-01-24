// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Gets or sets the file share configuration for scenarios where transport directory fileshare is not created or required.
    /// </summary>
    public partial class SkipFileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISkipFileShareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISkipFileShareConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration __fileShareConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.FileShareConfiguration();

        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string ConfigurationType { get => "Skip"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal)__fileShareConfiguration).ConfigurationType = "Skip"; }

        /// <summary>Creates an new <see cref="SkipFileShareConfiguration" /> instance.</summary>
        public SkipFileShareConfiguration()
        {
            this.__fileShareConfiguration.ConfigurationType = "Skip";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fileShareConfiguration), __fileShareConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__fileShareConfiguration), __fileShareConfiguration);
        }
    }
    /// Gets or sets the file share configuration for scenarios where transport directory fileshare is not created or required.
    public partial interface ISkipFileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration
    {

    }
    /// Gets or sets the file share configuration for scenarios where transport directory fileshare is not created or required.
    internal partial interface ISkipFileShareConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal
    {

    }
}