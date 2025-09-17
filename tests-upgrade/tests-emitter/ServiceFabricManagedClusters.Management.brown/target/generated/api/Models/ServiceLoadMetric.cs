// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Specifies a metric to load balance a service during runtime.</summary>
    public partial class ServiceLoadMetric :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetricInternal
    {

        /// <summary>Backing field for <see cref="DefaultLoad" /> property.</summary>
        private int? _defaultLoad;

        /// <summary>
        /// Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? DefaultLoad { get => this._defaultLoad; set => this._defaultLoad = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name
        /// that is specified in Name exactly. Note that metric names are case sensitive.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PrimaryDefaultLoad" /> property.</summary>
        private int? _primaryDefaultLoad;

        /// <summary>
        /// Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when
        /// it is a Primary replica.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? PrimaryDefaultLoad { get => this._primaryDefaultLoad; set => this._primaryDefaultLoad = value; }

        /// <summary>Backing field for <see cref="SecondaryDefaultLoad" /> property.</summary>
        private int? _secondaryDefaultLoad;

        /// <summary>
        /// Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when
        /// it is a Secondary replica.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? SecondaryDefaultLoad { get => this._secondaryDefaultLoad; set => this._secondaryDefaultLoad = value; }

        /// <summary>Backing field for <see cref="Weight" /> property.</summary>
        private string _weight;

        /// <summary>
        /// The service load metric relative weight, compared to other metrics configured for this service, as a number.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Weight { get => this._weight; set => this._weight = value; }

        /// <summary>Creates an new <see cref="ServiceLoadMetric" /> instance.</summary>
        public ServiceLoadMetric()
        {

        }
    }
    /// Specifies a metric to load balance a service during runtime.
    public partial interface IServiceLoadMetric :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric.",
        SerializedName = @"defaultLoad",
        PossibleTypes = new [] { typeof(int) })]
        int? DefaultLoad { get; set; }
        /// <summary>
        /// The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name
        /// that is specified in Name exactly. Note that metric names are case sensitive.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name that is specified in Name exactly. Note that metric names are case sensitive.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when
        /// it is a Primary replica.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Primary replica.",
        SerializedName = @"primaryDefaultLoad",
        PossibleTypes = new [] { typeof(int) })]
        int? PrimaryDefaultLoad { get; set; }
        /// <summary>
        /// Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when
        /// it is a Secondary replica.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Secondary replica.",
        SerializedName = @"secondaryDefaultLoad",
        PossibleTypes = new [] { typeof(int) })]
        int? SecondaryDefaultLoad { get; set; }
        /// <summary>
        /// The service load metric relative weight, compared to other metrics configured for this service, as a number.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The service load metric relative weight, compared to other metrics configured for this service, as a number.",
        SerializedName = @"weight",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Zero", "Low", "Medium", "High")]
        string Weight { get; set; }

    }
    /// Specifies a metric to load balance a service during runtime.
    internal partial interface IServiceLoadMetricInternal

    {
        /// <summary>
        /// Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric.
        /// </summary>
        int? DefaultLoad { get; set; }
        /// <summary>
        /// The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name
        /// that is specified in Name exactly. Note that metric names are case sensitive.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when
        /// it is a Primary replica.
        /// </summary>
        int? PrimaryDefaultLoad { get; set; }
        /// <summary>
        /// Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when
        /// it is a Secondary replica.
        /// </summary>
        int? SecondaryDefaultLoad { get; set; }
        /// <summary>
        /// The service load metric relative weight, compared to other metrics configured for this service, as a number.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Zero", "Low", "Medium", "High")]
        string Weight { get; set; }

    }
}