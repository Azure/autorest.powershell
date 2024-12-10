// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The Azure SKU of the machines in the pool.</summary>
    public partial class DevOpsAzureSku :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSkuInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DevOpsAzureSku" /> instance.</summary>
        public DevOpsAzureSku()
        {

        }
    }
    /// The Azure SKU of the machines in the pool.
    public partial interface IDevOpsAzureSku :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure SKU name of the machines in the pool.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// The Azure SKU of the machines in the pool.
    internal partial interface IDevOpsAzureSkuInternal

    {
        /// <summary>The Azure SKU name of the machines in the pool.</summary>
        string Name { get; set; }

    }
}