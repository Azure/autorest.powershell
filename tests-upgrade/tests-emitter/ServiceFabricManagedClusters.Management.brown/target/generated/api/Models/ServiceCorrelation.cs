// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Creates a particular correlation between services.</summary>
    public partial class ServiceCorrelation :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelationInternal
    {

        /// <summary>Backing field for <see cref="Scheme" /> property.</summary>
        private string _scheme;

        /// <summary>
        /// The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Scheme { get => this._scheme; set => this._scheme = value; }

        /// <summary>Backing field for <see cref="ServiceName" /> property.</summary>
        private string _serviceName;

        /// <summary>
        /// The Arm Resource ID of the service that the correlation relationship is established with.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServiceName { get => this._serviceName; set => this._serviceName = value; }

        /// <summary>Creates an new <see cref="ServiceCorrelation" /> instance.</summary>
        public ServiceCorrelation()
        {

        }
    }
    /// Creates a particular correlation between services.
    public partial interface IServiceCorrelation :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName.",
        SerializedName = @"scheme",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("AlignedAffinity", "NonAlignedAffinity")]
        string Scheme { get; set; }
        /// <summary>
        /// The Arm Resource ID of the service that the correlation relationship is established with.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Arm Resource ID of the service that the correlation relationship is established with.",
        SerializedName = @"serviceName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceName { get; set; }

    }
    /// Creates a particular correlation between services.
    internal partial interface IServiceCorrelationInternal

    {
        /// <summary>
        /// The ServiceCorrelationScheme which describes the relationship between this service and the service specified via ServiceName.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("AlignedAffinity", "NonAlignedAffinity")]
        string Scheme { get; set; }
        /// <summary>
        /// The Arm Resource ID of the service that the correlation relationship is established with.
        /// </summary>
        string ServiceName { get; set; }

    }
}