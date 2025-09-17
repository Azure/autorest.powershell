// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the named partition scheme of the service.</summary>
    public partial class NamedPartitionScheme :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INamedPartitionScheme,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INamedPartitionSchemeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition __partition = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Partition();

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private System.Collections.Generic.List<string> _name;

        /// <summary>Array for the names of the partitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Name { get => this._name; set => this._name = value; }

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Scheme { get => "Named"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal)__partition).Scheme = "Named"; }

        /// <summary>Creates an new <see cref="NamedPartitionScheme" /> instance.</summary>
        public NamedPartitionScheme()
        {
            this.__partition.Scheme = "Named";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__partition), __partition);
            await eventListener.AssertObjectIsValid(nameof(__partition), __partition);
        }
    }
    /// Describes the named partition scheme of the service.
    public partial interface INamedPartitionScheme :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition
    {
        /// <summary>Array for the names of the partitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array for the names of the partitions.",
        SerializedName = @"names",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Name { get; set; }

    }
    /// Describes the named partition scheme of the service.
    internal partial interface INamedPartitionSchemeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal
    {
        /// <summary>Array for the names of the partitions.</summary>
        System.Collections.Generic.List<string> Name { get; set; }

    }
}