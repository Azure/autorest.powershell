// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The properties of NFS StorageClass</summary>
    public partial class NfsStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.INfsStorageClassTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.INfsStorageClassTypePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties __storageClassTypeProperties = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties();

        /// <summary>Backing field for <see cref="MountPermission" /> property.</summary>
        private string _mountPermission;

        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string MountPermission { get => this._mountPermission; set => this._mountPermission = value; }

        /// <summary>Backing field for <see cref="OnDelete" /> property.</summary>
        private string _onDelete;

        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string OnDelete { get => this._onDelete; set => this._onDelete = value; }

        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private string _server;

        /// <summary>NFS Server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Server { get => this._server; set => this._server = value; }

        /// <summary>Backing field for <see cref="Share" /> property.</summary>
        private string _share;

        /// <summary>NFS share</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Share { get => this._share; set => this._share = value; }

        /// <summary>Backing field for <see cref="SubDir" /> property.</summary>
        private string _subDir;

        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string SubDir { get => this._subDir; set => this._subDir = value; }

        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Inherited)]
        public string Type { get => "NFS"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)__storageClassTypeProperties).Type = "NFS"; }

        /// <summary>Creates an new <see cref="NfsStorageClassTypeProperties" /> instance.</summary>
        public NfsStorageClassTypeProperties()
        {
            this.__storageClassTypeProperties.Type = "NFS";
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
    /// The properties of NFS StorageClass
    public partial interface INfsStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties
    {
        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount",
        SerializedName = @"mountPermissions",
        PossibleTypes = new [] { typeof(string) })]
        string MountPermission { get; set; }
        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The action to take when a NFS volume is deleted. Default is Delete",
        SerializedName = @"onDelete",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Delete", "Retain")]
        string OnDelete { get; set; }
        /// <summary>NFS Server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"NFS Server",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        string Server { get; set; }
        /// <summary>NFS share</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"NFS share",
        SerializedName = @"share",
        PossibleTypes = new [] { typeof(string) })]
        string Share { get; set; }
        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sub directory under share. If the sub directory doesn't exist, driver will create it",
        SerializedName = @"subDir",
        PossibleTypes = new [] { typeof(string) })]
        string SubDir { get; set; }

    }
    /// The properties of NFS StorageClass
    internal partial interface INfsStorageClassTypePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal
    {
        /// <summary>
        /// Mounted folder permissions. Default is 0. If set as non-zero, driver will perform `chmod` after mount
        /// </summary>
        string MountPermission { get; set; }
        /// <summary>The action to take when a NFS volume is deleted. Default is Delete</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Delete", "Retain")]
        string OnDelete { get; set; }
        /// <summary>NFS Server</summary>
        string Server { get; set; }
        /// <summary>NFS share</summary>
        string Share { get; set; }
        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        string SubDir { get; set; }

    }
}