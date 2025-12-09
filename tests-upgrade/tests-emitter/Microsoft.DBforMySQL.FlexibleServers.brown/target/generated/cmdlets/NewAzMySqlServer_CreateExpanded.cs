// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Cmdlets;
    using System;

    /// <summary>
    /// create a new server or create an existing server. The create action will overwrite the existing server.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzMySqlServer_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Description(@"create a new server or create an existing server. The create action will overwrite the existing server.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.HttpPath(Path = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}", ApiVersion = "2025-06-01-preview")]
    public partial class NewAzMySqlServer_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IContext
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>A dictionary to carry over additional data for pipeline.</summary>
        private global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object> _extensibleParameters = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>Represents a server.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer _parametersBody = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Server();

        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).",
        SerializedName = @"administratorLogin",
        PossibleTypes = new [] { typeof(string) })]
        public string AdministratorLogin { get => _parametersBody.AdministratorLogin ?? null; set => _parametersBody.AdministratorLogin = value; }

        /// <summary>The password of the administrator login (required for server creation).</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The password of the administrator login (required for server creation).")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password of the administrator login (required for server creation).",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString AdministratorLoginPassword { get => _parametersBody.AdministratorLoginPassword ?? null; set => _parametersBody.AdministratorLoginPassword = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>availability Zone information of the server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "availability Zone information of the server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"availability Zone information of the server.",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        public string AvailabilityZone { get => _parametersBody.AvailabilityZone ?? null; set => _parametersBody.AvailabilityZone = value; }

        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether or not geo redundant backup is enabled.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not geo redundant backup is enabled.",
        SerializedName = @"geoRedundantBackup",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string BackupGeoRedundantBackup { get => _parametersBody.BackupGeoRedundantBackup ?? null; set => _parametersBody.BackupGeoRedundantBackup = value; }

        /// <summary>Backup interval hours for the server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Backup interval hours for the server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup interval hours for the server.",
        SerializedName = @"backupIntervalHours",
        PossibleTypes = new [] { typeof(int) })]
        public int BackupIntervalHour { get => _parametersBody.BackupIntervalHour ?? default(int); set => _parametersBody.BackupIntervalHour = value; }

        /// <summary>Backup retention days for the server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Backup retention days for the server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        public int BackupRetentionDay { get => _parametersBody.BackupRetentionDay ?? default(int); set => _parametersBody.BackupRetentionDay = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.MySqlManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.ClientAPI;

        /// <summary>The mode to create a new MySQL server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The mode to create a new MySQL server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mode to create a new MySQL server.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "PointInTimeRestore", "Replica", "GeoRestore")]
        public string CreateMode { get => _parametersBody.CreateMode ?? null; set => _parametersBody.CreateMode = value; }

        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup",
        SerializedName = @"geoBackupKeyURI",
        PossibleTypes = new [] { typeof(string) })]
        public string DataEncryptionGeoBackupKeyUri { get => _parametersBody.DataEncryptionGeoBackupKeyUri ?? null; set => _parametersBody.DataEncryptionGeoBackupKeyUri = value; }

        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup",
        SerializedName = @"geoBackupUserAssignedIdentityId",
        PossibleTypes = new [] { typeof(string) })]
        public string DataEncryptionGeoBackupUserAssignedIdentityId { get => _parametersBody.DataEncryptionGeoBackupUserAssignedIdentityId ?? null; set => _parametersBody.DataEncryptionGeoBackupUserAssignedIdentityId = value; }

        /// <summary>Primary key uri</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Primary key uri")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary key uri",
        SerializedName = @"primaryKeyURI",
        PossibleTypes = new [] { typeof(string) })]
        public string DataEncryptionPrimaryKeyUri { get => _parametersBody.DataEncryptionPrimaryKeyUri ?? null; set => _parametersBody.DataEncryptionPrimaryKeyUri = value; }

        /// <summary>Primary user identity resource id</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Primary user identity resource id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary user identity resource id",
        SerializedName = @"primaryUserAssignedIdentityId",
        PossibleTypes = new [] { typeof(string) })]
        public string DataEncryptionPrimaryUserAssignedIdentityId { get => _parametersBody.DataEncryptionPrimaryUserAssignedIdentityId ?? null; set => _parametersBody.DataEncryptionPrimaryUserAssignedIdentityId = value; }

        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureKeyVault", "SystemManaged")]
        public string DataEncryptionType { get => _parametersBody.DataEncryptionType ?? null; set => _parametersBody.DataEncryptionType = value; }

        /// <summary>
        /// The server database port. Can only be specified when the server is being created.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The server database port. Can only be specified when the server is being created.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The server database port. Can only be specified when the server is being created.",
        SerializedName = @"databasePort",
        PossibleTypes = new [] { typeof(int) })]
        public int DatabasePort { get => _parametersBody.DatabasePort ?? default(int); set => _parametersBody.DatabasePort = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Determines whether to enable a system-assigned identity for the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines whether to enable a system-assigned identity for the resource.")]
        public global::System.Management.Automation.SwitchParameter EnableSystemAssignedIdentity { set => _parametersBody.IdentityType = value.IsPresent ? "SystemAssigned": null ; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>High availability mode for a server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "High availability mode for a server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"High availability mode for a server.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Disabled", "ZoneRedundant", "SameZone")]
        public string HighAvailabilityMode { get => _parametersBody.HighAvailabilityMode ?? null; set => _parametersBody.HighAvailabilityMode = value; }

        /// <summary>HA Replication mode for a server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HA Replication mode for a server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HA Replication mode for a server.",
        SerializedName = @"replicationMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("BinaryLog", "RedoLog")]
        public string HighAvailabilityReplicationMode { get => _parametersBody.HighAvailabilityReplicationMode ?? null; set => _parametersBody.HighAvailabilityReplicationMode = value; }

        /// <summary>Availability zone of the standby server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Availability zone of the standby server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Availability zone of the standby server.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        public string HighAvailabilityStandbyAvailabilityZone { get => _parametersBody.HighAvailabilityStandbyAvailabilityZone ?? null; set => _parametersBody.HighAvailabilityStandbyAvailabilityZone = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Relative path of data directory in storage.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Relative path of data directory in storage.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Relative path of data directory in storage.",
        SerializedName = @"dataDirPath",
        PossibleTypes = new [] { typeof(string) })]
        public string ImportSourcePropertyDataDirPath { get => _parametersBody.ImportSourcePropertyDataDirPath ?? null; set => _parametersBody.ImportSourcePropertyDataDirPath = value; }

        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Sas token for accessing source storage. Read and list permissions are required for sas token.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sas token for accessing source storage. Read and list permissions are required for sas token.",
        SerializedName = @"sasToken",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        public System.Security.SecureString ImportSourcePropertySasToken { get => _parametersBody.ImportSourcePropertySasToken ?? null; set => _parametersBody.ImportSourcePropertySasToken = value; }

        /// <summary>Storage type of import source.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Storage type of import source.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Storage type of import source.",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureBlob")]
        public string ImportSourcePropertyStorageType { get => _parametersBody.ImportSourcePropertyStorageType ?? null; set => _parametersBody.ImportSourcePropertyStorageType = value; }

        /// <summary>Uri of the import source storage.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Uri of the import source storage.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uri of the import source storage.",
        SerializedName = @"storageUrl",
        PossibleTypes = new [] { typeof(string) })]
        public string ImportSourcePropertyStorageUrl { get => _parametersBody.ImportSourcePropertyStorageUrl ?? null; set => _parametersBody.ImportSourcePropertyStorageUrl = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The geo-location where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The geo-location where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => _parametersBody.Location ?? null; set => _parametersBody.Location = value; }

        /// <summary>
        /// The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or
        /// 2.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or 2.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or 2.",
        SerializedName = @"lowerCaseTableNames",
        PossibleTypes = new [] { typeof(int) })]
        public int LowerCaseTableName { get => _parametersBody.LowerCaseTableName ?? default(int); set => _parametersBody.LowerCaseTableName = value; }

        /// <summary>The patch strategy of this server</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The patch strategy of this server")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The patch strategy of this server",
        SerializedName = @"patchStrategy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Regular", "VirtualCanary")]
        public string MaintenancePolicyPatchStrategy { get => _parametersBody.MaintenancePolicyPatchStrategy ?? null; set => _parametersBody.MaintenancePolicyPatchStrategy = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the server.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the server.",
        SerializedName = @"serverName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("ServerName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Delegated subnet resource id used to setup vnet for a server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Delegated subnet resource id used to setup vnet for a server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Delegated subnet resource id used to setup vnet for a server.",
        SerializedName = @"delegatedSubnetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string NetworkDelegatedSubnetResourceId { get => _parametersBody.NetworkDelegatedSubnetResourceId ?? null; set => _parametersBody.NetworkDelegatedSubnetResourceId = value; }

        /// <summary>Private DNS zone resource id.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Private DNS zone resource id.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private DNS zone resource id.",
        SerializedName = @"privateDnsZoneResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string NetworkPrivateDnsZoneResourceId { get => _parametersBody.NetworkPrivateDnsZoneResourceId ?? null; set => _parametersBody.NetworkPrivateDnsZoneResourceId = value; }

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string NetworkPublicNetworkAccess { get => _parametersBody.NetworkPublicNetworkAccess ?? null; set => _parametersBody.NetworkPublicNetworkAccess = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>The replication role.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The replication role.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replication role.",
        SerializedName = @"replicationRole",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        public string ReplicationRole { get => _parametersBody.ReplicationRole ?? null; set => _parametersBody.ReplicationRole = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group. The name is case insensitive.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Restore point creation time (ISO8601 format), specifying the time to restore from.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Restore point creation time (ISO8601 format), specifying the time to restore from.",
        SerializedName = @"restorePointInTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime RestorePointInTime { get => _parametersBody.RestorePointInTime ?? default(global::System.DateTime); set => _parametersBody.RestorePointInTime = value; }

        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The name of the sku, e.g. Standard_D32s_v3.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the sku, e.g. Standard_D32s_v3.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string SkuName { get => _parametersBody.SkuName ?? null; set => _parametersBody.SkuName = value; }

        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The tier of the particular SKU, e.g. GeneralPurpose.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tier of the particular SKU, e.g. GeneralPurpose.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Burstable", "GeneralPurpose", "MemoryOptimized")]
        public string SkuTier { get => _parametersBody.SkuTier ?? null; set => _parametersBody.SkuTier = value; }

        /// <summary>The source MySQL server id.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The source MySQL server id.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source MySQL server id.",
        SerializedName = @"sourceServerResourceId",
        PossibleTypes = new [] { typeof(string) })]
        public string SourceServerResourceId { get => _parametersBody.SourceServerResourceId ?? null; set => _parametersBody.SourceServerResourceId = value; }

        /// <summary>Enable Storage Auto Grow or not.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enable Storage Auto Grow or not.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable Storage Auto Grow or not.",
        SerializedName = @"autoGrow",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string StorageAutoGrow { get => _parametersBody.StorageAutoGrow ?? null; set => _parametersBody.StorageAutoGrow = value; }

        /// <summary>Enable IO Auto Scaling or not.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enable IO Auto Scaling or not.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable IO Auto Scaling or not.",
        SerializedName = @"autoIoScaling",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string StorageAutoIoScaling { get => _parametersBody.StorageAutoIoScaling ?? null; set => _parametersBody.StorageAutoIoScaling = value; }

        /// <summary>Storage IOPS for a server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Storage IOPS for a server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Storage IOPS for a server.",
        SerializedName = @"iops",
        PossibleTypes = new [] { typeof(int) })]
        public int StorageIop { get => _parametersBody.StorageIop ?? default(int); set => _parametersBody.StorageIop = value; }

        /// <summary>Enable Log On Disk or not.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Enable Log On Disk or not.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable Log On Disk or not.",
        SerializedName = @"logOnDisk",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        public string StorageLogOnDisk { get => _parametersBody.StorageLogOnDisk ?? null; set => _parametersBody.StorageLogOnDisk = value; }

        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The redundant type of the server storage. The parameter is used for server creation.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The redundant type of the server storage. The parameter is used for server creation.",
        SerializedName = @"storageRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("LocalRedundancy", "ZoneRedundancy")]
        public string StorageRedundancy { get => _parametersBody.StorageRedundancy ?? null; set => _parametersBody.StorageRedundancy = value; }

        /// <summary>Max storage size allowed for a server.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Max storage size allowed for a server.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage size allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        public int StorageSizeGb { get => _parametersBody.StorageSizeGb ?? default(int); set => _parametersBody.StorageSizeGb = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription. The value must be an UUID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id",
        SetCondition = @"")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceTags Tag { get => _parametersBody.Tag ?? null /* object */; set => _parametersBody.Tag = value; }

        /// <summary>
        /// The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The array of user assigned identities associated with the resource. The elements in array will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.'")]
        [global::System.Management.Automation.AllowEmptyCollection]
        public string[] UserAssignedIdentity { get; set; }

        /// <summary>
        /// Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.Category(global::Microsoft.Azure.PowerShell.Cmdlets.MySql.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("5.7", "8.0.21", "8.4")]
        public string Version { get => _parametersBody.Version ?? null; set => _parametersBody.Version = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer">Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of NewAzMySqlServer_CreateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Cmdlets.NewAzMySqlServer_CreateExpanded Clone()
        {
            var clone = new NewAzMySqlServer_CreateExpanded();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone._parametersBody = this._parametersBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
            if (telemetryInfo != null)
            {
                telemetryInfo.TryGetValue("ShowSecretsWarning", out var showSecretsWarning);
                telemetryInfo.TryGetValue("SanitizedProperties", out var sanitizedProperties);
                telemetryInfo.TryGetValue("InvocationName", out var invocationName);
                if (showSecretsWarning == "true")
                {
                    if (string.IsNullOrEmpty(sanitizedProperties))
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing secrets. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                    else
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing the following secrets: {sanitizedProperties}. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                }
            }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.Progress:
                    {
                        var data = messageData();
                        int progress = (int)data.Value;
                        string activityMessage, statusDescription;
                        global::System.Management.Automation.ProgressRecordType recordType;
                        if (progress < 100)
                        {
                            activityMessage = "In progress";
                            statusDescription = "Checking operation status";
                            recordType = System.Management.Automation.ProgressRecordType.Processing;
                        }
                        else
                        {
                            activityMessage = "Completed";
                            statusDescription = "Completed";
                            recordType = System.Management.Automation.ProgressRecordType.Completed;
                        }
                        WriteProgress(new global::System.Management.Automation.ProgressRecord(1, activityMessage, statusDescription)
                        {
                            PercentComplete = progress,
                        RecordType = recordType
                        });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        else
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                int delay = (int)(response.Headers.RetryAfter?.Delta?.TotalSeconds ?? 30);
                                WriteDebug($"Delaying {delay} seconds before polling.");
                                for (var now = 0; now < delay; ++now)
                                {
                                    WriteProgress(new global::System.Management.Automation.ProgressRecord(1, "In progress", "Checking operation status")
                                    {
                                        PercentComplete = now * 100 / delay
                                    });
                                    await global::System.Threading.Tasks.Task.Delay(1000, token);
                                }
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAzMySqlServer_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewAzMySqlServer_CreateExpanded()
        {

        }

        private void PreProcessManagedIdentityParameters()
        {
            if (this.UserAssignedIdentity?.Length > 0)
            {
                // calculate UserAssignedIdentity
                _parametersBody.IdentityUserAssignedIdentity.Clear();
                foreach( var id in this.UserAssignedIdentity )
                {
                    _parametersBody.IdentityUserAssignedIdentity.Add(id, new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.UserAssignedIdentity());
                }
            }
            // calculate IdentityType
            if (this.UserAssignedIdentity?.Length > 0)
            {
                if ("SystemAssigned".Equals(_parametersBody.IdentityType, StringComparison.InvariantCultureIgnoreCase))
                {
                    _parametersBody.IdentityType = "SystemAssigned,UserAssigned";
                }
                else
                {
                    _parametersBody.IdentityType = "UserAssigned";
                }
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ServersCreate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    this.PreProcessManagedIdentityParameters();
                    await this.Client.ServersCreate(SubscriptionId, ResourceGroupName, Name, _parametersBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeCreate);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Name=Name})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.MySql.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer">Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer
                var result = (await response);
                WriteObject(result, false);
            }
        }
    }
}