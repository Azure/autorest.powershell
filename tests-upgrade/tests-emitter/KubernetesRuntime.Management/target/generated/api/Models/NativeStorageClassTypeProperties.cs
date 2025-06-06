// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The properties of Native StorageClass</summary>
    public partial class NativeStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.INativeStorageClassTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.INativeStorageClassTypePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties __storageClassTypeProperties = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties();

        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inherited)]
        public string Type { get => "Native"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)__storageClassTypeProperties).Type = "Native"; }

        /// <summary>Creates an new <see cref="NativeStorageClassTypeProperties" /> instance.</summary>
        public NativeStorageClassTypeProperties()
        {
            this.__storageClassTypeProperties.Type = "Native";
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
    /// The properties of Native StorageClass
    public partial interface INativeStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties
    {

    }
    /// The properties of Native StorageClass
    internal partial interface INativeStorageClassTypePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal
    {

    }
}