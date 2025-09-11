// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Gets or sets the three tier SAP configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    /// </summary>
    public partial class ThreeTierConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration __infrastructureConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.InfrastructureConfiguration();

        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string AppResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)__infrastructureConfiguration).AppResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)__infrastructureConfiguration).AppResourceGroup = value ; }

        /// <summary>Backing field for <see cref="ApplicationServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfiguration _applicationServer;

        /// <summary>The application server configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfiguration ApplicationServer { get => (this._applicationServer = this._applicationServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerConfiguration()); set => this._applicationServer = value; }

        /// <summary>The number of app server instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long ApplicationServerInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).InstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).InstanceCount = value ; }

        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).SubnetId = value ; }

        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationImageReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceId = value ?? null; }

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationImageReferenceOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceOffer = value ?? null; }

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationImageReferencePublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferencePublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferencePublisher = value ?? null; }

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationImageReferenceSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceSku = value ?? null; }

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationImageReferenceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).ImageReferenceVersion = value ?? null; }

        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Security.SecureString ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileAdminPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileAdminPassword = value ?? null; }

        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileAdminUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileAdminUsername = value ?? null; }

        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSConfigurationOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSConfigurationOstype = value ?? null; }

        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerVirtualMachineConfigurationVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfigurationVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfigurationVMSize = value ; }

        /// <summary>Backing field for <see cref="CentralServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration _centralServer;

        /// <summary>The central server configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration CentralServer { get => (this._centralServer = this._centralServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfiguration()); set => this._centralServer = value; }

        /// <summary>The number of central server VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long CentralServerInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).InstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).InstanceCount = value ; }

        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).SubnetId = value ; }

        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationImageReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceId = value ?? null; }

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationImageReferenceOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceOffer = value ?? null; }

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationImageReferencePublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferencePublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferencePublisher = value ?? null; }

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationImageReferenceSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceSku = value ?? null; }

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationImageReferenceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).ImageReferenceVersion = value ?? null; }

        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Security.SecureString CentralServerVirtualMachineConfigurationOSProfileAdminPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileAdminPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileAdminPassword = value ?? null; }

        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationOSProfileAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileAdminUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileAdminUsername = value ?? null; }

        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration CentralServerVirtualMachineConfigurationOSProfileOSConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSConfigurationOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSConfigurationOstype = value ?? null; }

        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerVirtualMachineConfigurationVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfigurationVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfigurationVMSize = value ; }

        /// <summary>Backing field for <see cref="CustomResourceName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames _customResourceName;

        /// <summary>
        /// The set of custom names to be used for underlying azure resources that are part of the SAP system.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames CustomResourceName { get => (this._customResourceName = this._customResourceName ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierCustomResourceNames()); set => this._customResourceName = value; }

        /// <summary>The pattern type to be used for resource naming.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CustomResourceNameNamingPatternType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)CustomResourceName).NamingPatternType; }

        /// <summary>Backing field for <see cref="DatabaseServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration _databaseServer;

        /// <summary>The database configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration DatabaseServer { get => (this._databaseServer = this._databaseServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfiguration()); set => this._databaseServer = value; }

        /// <summary>The database type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerDatabaseType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).DatabaseType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).DatabaseType = value ?? null; }

        /// <summary>The number of database VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long DatabaseServerInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).InstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).InstanceCount = value ; }

        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).SubnetId = value ; }

        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationImageReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceId = value ?? null; }

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationImageReferenceOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceOffer = value ?? null; }

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationImageReferencePublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferencePublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferencePublisher = value ?? null; }

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationImageReferenceSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceSku = value ?? null; }

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationImageReferenceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).ImageReferenceVersion = value ?? null; }

        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Security.SecureString DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileAdminPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileAdminPassword = value ?? null; }

        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileAdminUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileAdminUsername = value ?? null; }

        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSConfigurationOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSConfigurationOstype = value ?? null; }

        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerVirtualMachineConfigurationVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfigurationVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfigurationVMSize = value ; }

        /// <summary>The SAP deployment type. Eg: SingleServer/ThreeTier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string DeploymentType { get => "ThreeTier"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal)__infrastructureConfiguration).DeploymentType = "ThreeTier"; }

        /// <summary>
        /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
        /// 'os'], Optional volume : ['backup'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfigurationDiskVolumeConfigurations DiskConfigurationDiskVolumeConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).DiskConfigurationDiskVolumeConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).DiskConfigurationDiskVolumeConfiguration = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="HighAvailabilityConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration _highAvailabilityConfig;

        /// <summary>The high availability configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration HighAvailabilityConfig { get => (this._highAvailabilityConfig = this._highAvailabilityConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilityConfiguration()); set => this._highAvailabilityConfig = value; }

        /// <summary>The high availability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string HighAvailabilityConfigHighAvailabilityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfigurationInternal)HighAvailabilityConfig).HighAvailabilityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfigurationInternal)HighAvailabilityConfig).HighAvailabilityType = value ?? null; }

        /// <summary>Internal Acessors for ApplicationServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.ApplicationServer { get => (this._applicationServer = this._applicationServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerConfiguration()); set { {_applicationServer = value;} } }

        /// <summary>Internal Acessors for ApplicationServerVirtualMachineConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.ApplicationServerVirtualMachineConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfiguration = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for ApplicationServerVirtualMachineConfigurationImageReference
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.ApplicationServerVirtualMachineConfigurationImageReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfigurationImageReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfigurationImageReference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ApplicationServerVirtualMachineConfigurationOSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.ApplicationServerVirtualMachineConfigurationOSProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfigurationOSProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).VirtualMachineConfigurationOSProfile = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfigurationInternal)ApplicationServer).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CentralServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CentralServer { get => (this._centralServer = this._centralServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerConfiguration()); set { {_centralServer = value;} } }

        /// <summary>Internal Acessors for CentralServerVirtualMachineConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CentralServerVirtualMachineConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CentralServerVirtualMachineConfigurationImageReference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CentralServerVirtualMachineConfigurationImageReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfigurationImageReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfigurationImageReference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CentralServerVirtualMachineConfigurationOSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CentralServerVirtualMachineConfigurationOSProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfigurationOSProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).VirtualMachineConfigurationOSProfile = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for CentralServerVirtualMachineConfigurationOSProfileOSConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CentralServerVirtualMachineConfigurationOSProfileOSConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal)CentralServer).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CustomResourceName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CustomResourceName { get => (this._customResourceName = this._customResourceName ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierCustomResourceNames()); set { {_customResourceName = value;} } }

        /// <summary>Internal Acessors for CustomResourceNameNamingPatternType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.CustomResourceNameNamingPatternType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)CustomResourceName).NamingPatternType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)CustomResourceName).NamingPatternType = value ?? null; }

        /// <summary>Internal Acessors for DatabaseServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.DatabaseServer { get => (this._databaseServer = this._databaseServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseConfiguration()); set { {_databaseServer = value;} } }

        /// <summary>Internal Acessors for DatabaseServerDiskConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.DatabaseServerDiskConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).DiskConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).DiskConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatabaseServerVirtualMachineConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.DatabaseServerVirtualMachineConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatabaseServerVirtualMachineConfigurationImageReference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.DatabaseServerVirtualMachineConfigurationImageReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfigurationImageReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfigurationImageReference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatabaseServerVirtualMachineConfigurationOSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.DatabaseServerVirtualMachineConfigurationOSProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfigurationOSProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).VirtualMachineConfigurationOSProfile = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfigurationInternal)DatabaseServer).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HighAvailabilityConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.HighAvailabilityConfig { get => (this._highAvailabilityConfig = this._highAvailabilityConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilityConfiguration()); set { {_highAvailabilityConfig = value;} } }

        /// <summary>Internal Acessors for NetworkConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.NetworkConfiguration { get => (this._networkConfiguration = this._networkConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkConfiguration()); set { {_networkConfiguration = value;} } }

        /// <summary>Internal Acessors for StorageConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.StorageConfiguration { get => (this._storageConfiguration = this._storageConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.StorageConfiguration()); set { {_storageConfiguration = value;} } }

        /// <summary>Internal Acessors for StorageConfigurationTransportFileShareConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierConfigurationInternal.StorageConfigurationTransportFileShareConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal)StorageConfiguration).TransportFileShareConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal)StorageConfiguration).TransportFileShareConfiguration = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="NetworkConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration _networkConfiguration;

        /// <summary>Network configuration common to all servers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration NetworkConfiguration { get => (this._networkConfiguration = this._networkConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.NetworkConfiguration()); set => this._networkConfiguration = value; }

        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public bool? NetworkConfigurationIsSecondaryIPEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfigurationInternal)NetworkConfiguration).IsSecondaryIPEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfigurationInternal)NetworkConfiguration).IsSecondaryIPEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="StorageConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration _storageConfiguration;

        /// <summary>The storage configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration StorageConfiguration { get => (this._storageConfiguration = this._storageConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.StorageConfiguration()); set => this._storageConfiguration = value; }

        /// <summary>
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the
        /// createAndMount flow if storage configuration is missing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration StorageConfigurationTransportFileShareConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal)StorageConfiguration).TransportFileShareConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal)StorageConfiguration).TransportFileShareConfiguration = value ?? null /* model class */; }

        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string TransportFileShareConfigurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal)StorageConfiguration).TransportFileShareConfigurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfigurationInternal)StorageConfiguration).TransportFileShareConfigurationType = value ?? null; }

        /// <summary>Creates an new <see cref="ThreeTierConfiguration" /> instance.</summary>
        public ThreeTierConfiguration()
        {
            this.__infrastructureConfiguration.DeploymentType = "ThreeTier";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__infrastructureConfiguration), __infrastructureConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__infrastructureConfiguration), __infrastructureConfiguration);
        }
    }
    /// Gets or sets the three tier SAP configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    public partial interface IThreeTierConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfiguration
    {
        /// <summary>The number of app server instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of app server instances.",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long ApplicationServerInstanceCount { get; set; }
        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subnet id.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerSubnetId { get; set; }
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the offer of the platform image or marketplace image used to create the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationImageReferenceVersion { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** ""abc@123"", ""P@$$w0rd"", ""P@ssw0rd"", ""P@ssword123"", ""Pa$$word"", ""pass@word1"", ""Password!"", ""Password1"", ""Password22"", ""iloveyou!"" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br> **Windows-only restriction:** Cannot end in ""."" <br><br> **Disallowed values:** ""administrator"", ""admin"", ""user"", ""user1"", ""test"", ""user2"", ""test1"", ""user3"", ""admin1"", ""1"", ""123"", ""a"", ""actuser"", ""adm"", ""admin2"", ""aspnet"", ""backup"", ""console"", ""david"", ""guest"", ""john"", ""owner"", ""root"", ""server"", ""sql"", ""support"", ""support_388945a0"", ""sys"", ""test2"", ""test3"", ""user4"", ""user5"". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters.",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername { get; set; }
        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OS Type",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get; set; }
        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The virtual machine size.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVirtualMachineConfigurationVMSize { get; set; }
        /// <summary>The number of central server VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of central server VMs.",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long CentralServerInstanceCount { get; set; }
        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subnet id.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerSubnetId { get; set; }
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the offer of the platform image or marketplace image used to create the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationImageReferenceVersion { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** ""abc@123"", ""P@$$w0rd"", ""P@ssw0rd"", ""P@ssword123"", ""Pa$$word"", ""pass@word1"", ""Password!"", ""Password1"", ""Password22"", ""iloveyou!"" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString CentralServerVirtualMachineConfigurationOSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br> **Windows-only restriction:** Cannot end in ""."" <br><br> **Disallowed values:** ""administrator"", ""admin"", ""user"", ""user1"", ""test"", ""user2"", ""test1"", ""user3"", ""admin1"", ""1"", ""123"", ""a"", ""actuser"", ""adm"", ""admin2"", ""aspnet"", ""backup"", ""console"", ""david"", ""guest"", ""john"", ""owner"", ""root"", ""server"", ""sql"", ""support"", ""support_388945a0"", ""sys"", ""test2"", ""test3"", ""user4"", ""user5"". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters.",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationOSProfileAdminUsername { get; set; }
        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OS Type",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get; set; }
        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The virtual machine size.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVirtualMachineConfigurationVMSize { get; set; }
        /// <summary>The pattern type to be used for resource naming.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The pattern type to be used for resource naming.",
        SerializedName = @"namingPatternType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomResourceNameNamingPatternType { get;  }
        /// <summary>The database type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The database type.",
        SerializedName = @"databaseType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("HANA", "DB2")]
        string DatabaseServerDatabaseType { get; set; }
        /// <summary>The number of database VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of database VMs.",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long DatabaseServerInstanceCount { get; set; }
        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subnet id.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerSubnetId { get; set; }
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the offer of the platform image or marketplace image used to create the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationImageReferenceVersion { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** ""abc@123"", ""P@$$w0rd"", ""P@ssw0rd"", ""P@ssword123"", ""Pa$$word"", ""pass@word1"", ""Password!"", ""Password1"", ""Password22"", ""iloveyou!"" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br> **Windows-only restriction:** Cannot end in ""."" <br><br> **Disallowed values:** ""administrator"", ""admin"", ""user"", ""user1"", ""test"", ""user2"", ""test1"", ""user3"", ""admin1"", ""1"", ""123"", ""a"", ""actuser"", ""adm"", ""admin2"", ""aspnet"", ""backup"", ""console"", ""david"", ""guest"", ""john"", ""owner"", ""root"", ""server"", ""sql"", ""support"", ""support_388945a0"", ""sys"", ""test2"", ""test3"", ""user4"", ""user5"". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters.",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername { get; set; }
        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OS Type",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get; set; }
        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The virtual machine size.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseServerVirtualMachineConfigurationVMSize { get; set; }
        /// <summary>
        /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
        /// 'os'], Optional volume : ['backup'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os'], Optional volume : ['backup'].",
        SerializedName = @"diskVolumeConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfigurationDiskVolumeConfigurations) })]
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfigurationDiskVolumeConfigurations DiskConfigurationDiskVolumeConfiguration { get; set; }
        /// <summary>The high availability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The high availability type.",
        SerializedName = @"highAvailabilityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("AvailabilitySet", "AvailabilityZone")]
        string HighAvailabilityConfigHighAvailabilityType { get; set; }
        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed",
        SerializedName = @"isSecondaryIpEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NetworkConfigurationIsSecondaryIPEnabled { get; set; }
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
    /// Gets or sets the three tier SAP configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409)
    internal partial interface IThreeTierConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IInfrastructureConfigurationInternal
    {
        /// <summary>The application server configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerConfiguration ApplicationServer { get; set; }
        /// <summary>The number of app server instances.</summary>
        long ApplicationServerInstanceCount { get; set; }
        /// <summary>The subnet id.</summary>
        string ApplicationServerSubnetId { get; set; }
        /// <summary>Gets or sets the virtual machine configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration ApplicationServerVirtualMachineConfiguration { get; set; }
        /// <summary>The image reference.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference ApplicationServerVirtualMachineConfigurationImageReference { get; set; }
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        string ApplicationServerVirtualMachineConfigurationImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        string ApplicationServerVirtualMachineConfigurationImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        string ApplicationServerVirtualMachineConfigurationImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        string ApplicationServerVirtualMachineConfigurationImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        string ApplicationServerVirtualMachineConfigurationImageReferenceVersion { get; set; }
        /// <summary>The OS profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile ApplicationServerVirtualMachineConfigurationOSProfile { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        System.Security.SecureString ApplicationServerVirtualMachineConfigurationOSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        string ApplicationServerVirtualMachineConfigurationOSProfileAdminUsername { get; set; }
        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration ApplicationServerVirtualMachineConfigurationOSProfileOSConfiguration { get; set; }
        /// <summary>The OS Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string ApplicationServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get; set; }
        /// <summary>The virtual machine size.</summary>
        string ApplicationServerVirtualMachineConfigurationVMSize { get; set; }
        /// <summary>The central server configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration CentralServer { get; set; }
        /// <summary>The number of central server VMs.</summary>
        long CentralServerInstanceCount { get; set; }
        /// <summary>The subnet id.</summary>
        string CentralServerSubnetId { get; set; }
        /// <summary>Gets or sets the virtual machine configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration CentralServerVirtualMachineConfiguration { get; set; }
        /// <summary>The image reference.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference CentralServerVirtualMachineConfigurationImageReference { get; set; }
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        string CentralServerVirtualMachineConfigurationImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        string CentralServerVirtualMachineConfigurationImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        string CentralServerVirtualMachineConfigurationImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        string CentralServerVirtualMachineConfigurationImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        string CentralServerVirtualMachineConfigurationImageReferenceVersion { get; set; }
        /// <summary>The OS profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile CentralServerVirtualMachineConfigurationOSProfile { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        System.Security.SecureString CentralServerVirtualMachineConfigurationOSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        string CentralServerVirtualMachineConfigurationOSProfileAdminUsername { get; set; }
        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration CentralServerVirtualMachineConfigurationOSProfileOSConfiguration { get; set; }
        /// <summary>The OS Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string CentralServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get; set; }
        /// <summary>The virtual machine size.</summary>
        string CentralServerVirtualMachineConfigurationVMSize { get; set; }
        /// <summary>
        /// The set of custom names to be used for underlying azure resources that are part of the SAP system.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames CustomResourceName { get; set; }
        /// <summary>The pattern type to be used for resource naming.</summary>
        string CustomResourceNameNamingPatternType { get; set; }
        /// <summary>The database configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseConfiguration DatabaseServer { get; set; }
        /// <summary>The database type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("HANA", "DB2")]
        string DatabaseServerDatabaseType { get; set; }
        /// <summary>Gets or sets the disk configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfiguration DatabaseServerDiskConfiguration { get; set; }
        /// <summary>The number of database VMs.</summary>
        long DatabaseServerInstanceCount { get; set; }
        /// <summary>The subnet id.</summary>
        string DatabaseServerSubnetId { get; set; }
        /// <summary>Gets or sets the virtual machine configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration DatabaseServerVirtualMachineConfiguration { get; set; }
        /// <summary>The image reference.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference DatabaseServerVirtualMachineConfigurationImageReference { get; set; }
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        string DatabaseServerVirtualMachineConfigurationImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        string DatabaseServerVirtualMachineConfigurationImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        string DatabaseServerVirtualMachineConfigurationImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        string DatabaseServerVirtualMachineConfigurationImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        string DatabaseServerVirtualMachineConfigurationImageReferenceVersion { get; set; }
        /// <summary>The OS profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile DatabaseServerVirtualMachineConfigurationOSProfile { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        System.Security.SecureString DatabaseServerVirtualMachineConfigurationOSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        string DatabaseServerVirtualMachineConfigurationOSProfileAdminUsername { get; set; }
        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration DatabaseServerVirtualMachineConfigurationOSProfileOSConfiguration { get; set; }
        /// <summary>The OS Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string DatabaseServerVirtualMachineConfigurationOSProfileOSConfigurationOSType { get; set; }
        /// <summary>The virtual machine size.</summary>
        string DatabaseServerVirtualMachineConfigurationVMSize { get; set; }
        /// <summary>
        /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
        /// 'os'], Optional volume : ['backup'].
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskConfigurationDiskVolumeConfigurations DiskConfigurationDiskVolumeConfiguration { get; set; }
        /// <summary>The high availability configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IHighAvailabilityConfiguration HighAvailabilityConfig { get; set; }
        /// <summary>The high availability type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("AvailabilitySet", "AvailabilityZone")]
        string HighAvailabilityConfigHighAvailabilityType { get; set; }
        /// <summary>Network configuration common to all servers</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed
        /// </summary>
        bool? NetworkConfigurationIsSecondaryIPEnabled { get; set; }
        /// <summary>The storage configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageConfiguration StorageConfiguration { get; set; }
        /// <summary>
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the
        /// createAndMount flow if storage configuration is missing.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IFileShareConfiguration StorageConfigurationTransportFileShareConfiguration { get; set; }
        /// <summary>The type of file share config, eg: Mount/CreateAndMount/Skip.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Skip", "CreateAndMount", "Mount")]
        string TransportFileShareConfigurationType { get; set; }

    }
}