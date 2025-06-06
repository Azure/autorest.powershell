// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The properties of Blob StorageClass</summary>
    public partial class BlobStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IBlobStorageClassTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IBlobStorageClassTypePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties __storageClassTypeProperties = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties();

        /// <summary>Backing field for <see cref="AzureStorageAccountKey" /> property.</summary>
        private System.Security.SecureString _azureStorageAccountKey;

        /// <summary>Azure Storage Account Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Security.SecureString AzureStorageAccountKey { get => this._azureStorageAccountKey; set => this._azureStorageAccountKey = value; }

        /// <summary>Backing field for <see cref="AzureStorageAccountName" /> property.</summary>
        private string _azureStorageAccountName;

        /// <summary>Azure Storage Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string AzureStorageAccountName { get => this._azureStorageAccountName; set => this._azureStorageAccountName = value; }

        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inherited)]
        public string Type { get => "Blob"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)__storageClassTypeProperties).Type = "Blob"; }

        /// <summary>Creates an new <see cref="BlobStorageClassTypeProperties" /> instance.</summary>
        public BlobStorageClassTypeProperties()
        {
            this.__storageClassTypeProperties.Type = "Blob";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__storageClassTypeProperties), __storageClassTypeProperties);
            await eventListener.AssertObjectIsValid(nameof(__storageClassTypeProperties), __storageClassTypeProperties);
        }
    }
    /// The properties of Blob StorageClass
    public partial interface IBlobStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties
    {
        /// <summary>Azure Storage Account Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure Storage Account Key",
        SerializedName = @"azureStorageAccountKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AzureStorageAccountKey { get; set; }
        /// <summary>Azure Storage Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure Storage Account Name",
        SerializedName = @"azureStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string AzureStorageAccountName { get; set; }

    }
    /// The properties of Blob StorageClass
    internal partial interface IBlobStorageClassTypePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal
    {
        /// <summary>Azure Storage Account Key</summary>
        System.Security.SecureString AzureStorageAccountKey { get; set; }
        /// <summary>Azure Storage Account Name</summary>
        string AzureStorageAccountName { get; set; }

    }
}