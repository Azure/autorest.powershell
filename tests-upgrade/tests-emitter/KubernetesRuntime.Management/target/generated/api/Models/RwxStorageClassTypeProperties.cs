// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The properties of RWX StorageClass</summary>
    public partial class RwxStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IRwxStorageClassTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IRwxStorageClassTypePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties __storageClassTypeProperties = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties();

        /// <summary>Backing field for <see cref="BackingStorageClassName" /> property.</summary>
        private string _backingStorageClassName;

        /// <summary>The backing storageclass used to create new storageclass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string BackingStorageClassName { get => this._backingStorageClassName; set => this._backingStorageClassName = value; }

        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inherited)]
        public string Type { get => "RWX"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)__storageClassTypeProperties).Type = "RWX"; }

        /// <summary>Creates an new <see cref="RwxStorageClassTypeProperties" /> instance.</summary>
        public RwxStorageClassTypeProperties()
        {
            this.__storageClassTypeProperties.Type = "RWX";
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
    /// The properties of RWX StorageClass
    public partial interface IRwxStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties
    {
        /// <summary>The backing storageclass used to create new storageclass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The backing storageclass used to create new storageclass",
        SerializedName = @"backingStorageClassName",
        PossibleTypes = new [] { typeof(string) })]
        string BackingStorageClassName { get; set; }

    }
    /// The properties of RWX StorageClass
    internal partial interface IRwxStorageClassTypePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal
    {
        /// <summary>The backing storageclass used to create new storageclass</summary>
        string BackingStorageClassName { get; set; }

    }
}