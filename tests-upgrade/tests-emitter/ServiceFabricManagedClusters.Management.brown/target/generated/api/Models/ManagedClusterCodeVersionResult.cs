// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The result of the Service Fabric runtime versions</summary>
    public partial class ManagedClusterCodeVersionResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterCodeVersionResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterCodeVersionResultInternal
    {

        /// <summary>The Service Fabric runtime version of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ClusterCodeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal)Property).ClusterCodeVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal)Property).ClusterCodeVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The identification of the result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetails Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterCodeVersionResultInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterVersionDetails()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Cluster operating system, the default will be Windows</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string OSType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal)Property).OSType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal)Property).OSType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetails _property;

        /// <summary>The detail of the Service Fabric runtime version result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetails Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterVersionDetails()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The date of expiry of support of the version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public global::System.DateTime? SupportExpiryUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal)Property).SupportExpiryUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetailsInternal)Property).SupportExpiryUtc = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The result resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ManagedClusterCodeVersionResult" /> instance.</summary>
        public ManagedClusterCodeVersionResult()
        {

        }
    }
    /// The result of the Service Fabric runtime versions
    public partial interface IManagedClusterCodeVersionResult :
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
        /// <summary>The identification of the result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identification of the result",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the result",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
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
        /// <summary>The result resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The result resource type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// The result of the Service Fabric runtime versions
    internal partial interface IManagedClusterCodeVersionResultInternal

    {
        /// <summary>The Service Fabric runtime version of the cluster.</summary>
        string ClusterCodeVersion { get; set; }
        /// <summary>The identification of the result</summary>
        string Id { get; set; }
        /// <summary>The name of the result</summary>
        string Name { get; set; }
        /// <summary>Cluster operating system, the default will be Windows</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Windows")]
        string OSType { get; set; }
        /// <summary>The detail of the Service Fabric runtime version result</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterVersionDetails Property { get; set; }
        /// <summary>The date of expiry of support of the version.</summary>
        global::System.DateTime? SupportExpiryUtc { get; set; }
        /// <summary>The result resource type</summary>
        string Type { get; set; }

    }
}