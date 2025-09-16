// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The common service resource properties.</summary>
    public partial class ServiceResourcePropertiesBase :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal
    {

        /// <summary>Backing field for <see cref="CorrelationScheme" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation> _correlationScheme;

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation> CorrelationScheme { get => this._correlationScheme; set => this._correlationScheme = value; }

        /// <summary>Backing field for <see cref="DefaultMoveCost" /> property.</summary>
        private string _defaultMoveCost;

        /// <summary>Specifies the move cost for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DefaultMoveCost { get => this._defaultMoveCost; set => this._defaultMoveCost = value; }

        /// <summary>Backing field for <see cref="PlacementConstraint" /> property.</summary>
        private string _placementConstraint;

        /// <summary>
        /// The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for
        /// restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes
        /// where NodeType is blue specify the following: "NodeColor == blue)".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PlacementConstraint { get => this._placementConstraint; set => this._placementConstraint = value; }

        /// <summary>Backing field for <see cref="ScalingPolicy" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy> _scalingPolicy;

        /// <summary>Scaling policies for this service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy> ScalingPolicy { get => this._scalingPolicy; set => this._scalingPolicy = value; }

        /// <summary>Backing field for <see cref="ServiceLoadMetric" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> _serviceLoadMetric;

        /// <summary>The service load metrics is given as an array of ServiceLoadMetric objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> ServiceLoadMetric { get => this._serviceLoadMetric; set => this._serviceLoadMetric = value; }

        /// <summary>Backing field for <see cref="ServicePlacementPolicy" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> _servicePlacementPolicy;

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> ServicePlacementPolicy { get => this._servicePlacementPolicy; set => this._servicePlacementPolicy = value; }

        /// <summary>Creates an new <see cref="ServiceResourcePropertiesBase" /> instance.</summary>
        public ServiceResourcePropertiesBase()
        {

        }
    }
    /// The common service resource properties.
    public partial interface IServiceResourcePropertiesBase :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list that describes the correlation of the service with other services.",
        SerializedName = @"correlationScheme",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation> CorrelationScheme { get; set; }
        /// <summary>Specifies the move cost for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the move cost for the service.",
        SerializedName = @"defaultMoveCost",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Zero", "Low", "Medium", "High")]
        string DefaultMoveCost { get; set; }
        /// <summary>
        /// The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for
        /// restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes
        /// where NodeType is blue specify the following: "NodeColor == blue)".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: ""NodeColor == blue)"".",
        SerializedName = @"placementConstraints",
        PossibleTypes = new [] { typeof(string) })]
        string PlacementConstraint { get; set; }
        /// <summary>Scaling policies for this service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Scaling policies for this service.",
        SerializedName = @"scalingPolicies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy> ScalingPolicy { get; set; }
        /// <summary>The service load metrics is given as an array of ServiceLoadMetric objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The service load metrics is given as an array of ServiceLoadMetric objects.",
        SerializedName = @"serviceLoadMetrics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> ServiceLoadMetric { get; set; }
        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list that describes the correlation of the service with other services.",
        SerializedName = @"servicePlacementPolicies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> ServicePlacementPolicy { get; set; }

    }
    /// The common service resource properties.
    internal partial interface IServiceResourcePropertiesBaseInternal

    {
        /// <summary>A list that describes the correlation of the service with other services.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation> CorrelationScheme { get; set; }
        /// <summary>Specifies the move cost for the service.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Zero", "Low", "Medium", "High")]
        string DefaultMoveCost { get; set; }
        /// <summary>
        /// The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for
        /// restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes
        /// where NodeType is blue specify the following: "NodeColor == blue)".
        /// </summary>
        string PlacementConstraint { get; set; }
        /// <summary>Scaling policies for this service.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy> ScalingPolicy { get; set; }
        /// <summary>The service load metrics is given as an array of ServiceLoadMetric objects.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> ServiceLoadMetric { get; set; }
        /// <summary>A list that describes the correlation of the service with other services.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> ServicePlacementPolicy { get; set; }

    }
}