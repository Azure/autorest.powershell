// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The detail of the Service Fabric runtime version result</summary>
    public partial class ManagedClusterVersionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetails,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal
    {

        /// <summary>Backing field for <see cref="ClusterCodeVersion" /> property.</summary>
        private string _clusterCodeVersion;

        /// <summary>The Service Fabric runtime version of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterCodeVersion { get => this._clusterCodeVersion; set => this._clusterCodeVersion = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>Cluster operating system, the default will be Windows</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="SupportExpiryUtc" /> property.</summary>
        private global::System.DateTime? _supportExpiryUtc;

        /// <summary>The date of expiry of support of the version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? SupportExpiryUtc { get => this._supportExpiryUtc; set => this._supportExpiryUtc = value; }

        /// <summary>Creates an new <see cref="ManagedClusterVersionDetails" /> instance.</summary>
        public ManagedClusterVersionDetails()
        {

        }
    }
    /// The detail of the Service Fabric runtime version result
    public partial interface IManagedClusterVersionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The Service Fabric runtime version of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Service Fabric runtime version of the cluster.",
        SerializedName = @"clusterCodeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterCodeVersion { get; set; }
        /// <summary>Cluster operating system, the default will be Windows</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Cluster operating system, the default will be Windows",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Windows")]
        string OSType { get; set; }
        /// <summary>The date of expiry of support of the version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The date of expiry of support of the version.",
        SerializedName = @"supportExpiryUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SupportExpiryUtc { get; set; }

    }
    /// The detail of the Service Fabric runtime version result
    internal partial interface IManagedClusterVersionDetailsInternal

    {
        /// <summary>The Service Fabric runtime version of the cluster.</summary>
        string ClusterCodeVersion { get; set; }
        /// <summary>Cluster operating system, the default will be Windows</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Windows")]
        string OSType { get; set; }
        /// <summary>The date of expiry of support of the version.</summary>
        global::System.DateTime? SupportExpiryUtc { get; set; }

    }
}