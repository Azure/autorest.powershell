// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The properties of SMB StorageClass</summary>
    public partial class SmbStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ISmbStorageClassTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ISmbStorageClassTypePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties __storageClassTypeProperties = new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypeProperties();

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Server domain</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private System.Security.SecureString _password;

        /// <summary>Server password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Security.SecureString Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>SMB Source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

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
        public string Type { get => "SMB"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal)__storageClassTypeProperties).Type = "SMB"; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>Server username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="SmbStorageClassTypeProperties" /> instance.</summary>
        public SmbStorageClassTypeProperties()
        {
            this.__storageClassTypeProperties.Type = "SMB";
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
    /// The properties of SMB StorageClass
    public partial interface ISmbStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties
    {
        /// <summary>Server domain</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server domain",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get; set; }
        /// <summary>Server password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server password",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString Password { get; set; }
        /// <summary>SMB Source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SMB Source",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
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
        /// <summary>Server username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server username",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// The properties of SMB StorageClass
    internal partial interface ISmbStorageClassTypePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal
    {
        /// <summary>Server domain</summary>
        string Domain { get; set; }
        /// <summary>Server password</summary>
        System.Security.SecureString Password { get; set; }
        /// <summary>SMB Source</summary>
        string Source { get; set; }
        /// <summary>
        /// Sub directory under share. If the sub directory doesn't exist, driver will create it
        /// </summary>
        string SubDir { get; set; }
        /// <summary>Server username</summary>
        string Username { get; set; }

    }
}