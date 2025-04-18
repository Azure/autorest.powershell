// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the SAP Enqueue Replication Server (ERS) properties.</summary>
    public partial class EnqueueReplicationServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ErsVersion" /> property.</summary>
        private string _ersVersion;

        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ErsVersion { get => this._ersVersion; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Health { get => this._health; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>ERS SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>ERS SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="InstanceNo" /> property.</summary>
        private string _instanceNo;

        /// <summary>ERS Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string InstanceNo { get => this._instanceNo; }

        /// <summary>Backing field for <see cref="KernelPatch" /> property.</summary>
        private string _kernelPatch;

        /// <summary>ERS SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KernelPatch { get => this._kernelPatch; }

        /// <summary>Backing field for <see cref="KernelVersion" /> property.</summary>
        private string _kernelVersion;

        /// <summary>ERS SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KernelVersion { get => this._kernelVersion; }

        /// <summary>Internal Acessors for ErsVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.ErsVersion { get => this._ersVersion; set { {_ersVersion = value;} } }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for Hostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.Hostname { get => this._hostname; set { {_hostname = value;} } }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for InstanceNo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.InstanceNo { get => this._instanceNo; set { {_instanceNo = value;} } }

        /// <summary>Internal Acessors for KernelPatch</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.KernelPatch { get => this._kernelPatch; set { {_kernelPatch = value;} } }

        /// <summary>Internal Acessors for KernelVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IEnqueueReplicationServerPropertiesInternal.KernelVersion { get => this._kernelVersion; set { {_kernelVersion = value;} } }

        /// <summary>Creates an new <see cref="EnqueueReplicationServerProperties" /> instance.</summary>
        public EnqueueReplicationServerProperties()
        {

        }
    }
    /// Defines the SAP Enqueue Replication Server (ERS) properties.
    public partial interface IEnqueueReplicationServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the type of Enqueue Replication Server.",
        SerializedName = @"ersVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("EnqueueReplicator1", "EnqueueReplicator2")]
        string ErsVersion { get;  }
        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the health of SAP Instances.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get;  }
        /// <summary>ERS SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP Hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get;  }
        /// <summary>ERS SAP IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get;  }
        /// <summary>ERS Instance Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS Instance Number.",
        SerializedName = @"instanceNo",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceNo { get;  }
        /// <summary>ERS SAP Kernel Patch level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP Kernel Patch level.",
        SerializedName = @"kernelPatch",
        PossibleTypes = new [] { typeof(string) })]
        string KernelPatch { get;  }
        /// <summary>ERS SAP Kernel Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ERS SAP Kernel Version.",
        SerializedName = @"kernelVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KernelVersion { get;  }

    }
    /// Defines the SAP Enqueue Replication Server (ERS) properties.
    internal partial interface IEnqueueReplicationServerPropertiesInternal

    {
        /// <summary>Defines the type of Enqueue Replication Server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("EnqueueReplicator1", "EnqueueReplicator2")]
        string ErsVersion { get; set; }
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get; set; }
        /// <summary>ERS SAP Hostname.</summary>
        string Hostname { get; set; }
        /// <summary>ERS SAP IP Address.</summary>
        string IPAddress { get; set; }
        /// <summary>ERS Instance Number.</summary>
        string InstanceNo { get; set; }
        /// <summary>ERS SAP Kernel Patch level.</summary>
        string KernelPatch { get; set; }
        /// <summary>ERS SAP Kernel Version.</summary>
        string KernelVersion { get; set; }

    }
}