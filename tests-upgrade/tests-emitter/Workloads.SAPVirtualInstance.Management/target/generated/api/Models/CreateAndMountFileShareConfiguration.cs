// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Gets or sets the file share configuration where the transport directory fileshare is created and mounted as a part of
    /// the create infra flow. Please pre-create the resource group you intend to place the transport directory in. The storage
    /// account and fileshare will be auto-created by the ACSS and doesn't need to be pre-created.
    /// </summary>
    public partial class CreateAndMountFileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICreateAndMountFileShareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICreateAndMountFileShareConfigurationInternal,
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
        public string ConfigurationType { get => "CreateAndMount"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal)__fileShareConfiguration).ConfigurationType = "CreateAndMount"; }

        /// <summary>Backing field for <see cref="ResourceGroup" /> property.</summary>
        private string _resourceGroup;

        /// <summary>
        /// The name of transport file share resource group. This should be pre created by the customer. The app rg is used in case
        /// of missing input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ResourceGroup { get => this._resourceGroup; set => this._resourceGroup = value; }

        /// <summary>Backing field for <see cref="StorageAccountName" /> property.</summary>
        private string _storageAccountName;

        /// <summary>
        /// The name of file share storage account name . A custom name is used in case of missing input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string StorageAccountName { get => this._storageAccountName; set => this._storageAccountName = value; }

        /// <summary>Creates an new <see cref="CreateAndMountFileShareConfiguration" /> instance.</summary>
        public CreateAndMountFileShareConfiguration()
        {
            this.__fileShareConfiguration.ConfigurationType = "CreateAndMount";
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
    /// Gets or sets the file share configuration where the transport directory fileshare is created and mounted as a part of
    /// the create infra flow. Please pre-create the resource group you intend to place the transport directory in. The storage
    /// account and fileshare will be auto-created by the ACSS and doesn't need to be pre-created.
    public partial interface ICreateAndMountFileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration
    {
        /// <summary>
        /// The name of transport file share resource group. This should be pre created by the customer. The app rg is used in case
        /// of missing input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of transport file share resource group. This should be pre created by the customer. The app rg is used in case of missing input.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroup { get; set; }
        /// <summary>
        /// The name of file share storage account name . A custom name is used in case of missing input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of file share storage account name . A custom name is used in case of missing input.",
        SerializedName = @"storageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountName { get; set; }

    }
    /// Gets or sets the file share configuration where the transport directory fileshare is created and mounted as a part of
    /// the create infra flow. Please pre-create the resource group you intend to place the transport directory in. The storage
    /// account and fileshare will be auto-created by the ACSS and doesn't need to be pre-created.
    internal partial interface ICreateAndMountFileShareConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfigurationInternal
    {
        /// <summary>
        /// The name of transport file share resource group. This should be pre created by the customer. The app rg is used in case
        /// of missing input.
        /// </summary>
        string ResourceGroup { get; set; }
        /// <summary>
        /// The name of file share storage account name . A custom name is used in case of missing input.
        /// </summary>
        string StorageAccountName { get; set; }

    }
}