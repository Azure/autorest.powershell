// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a parameter in fabric settings of the cluster.</summary>
    public partial class SettingsParameterDescription :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescription,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescriptionInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The parameter name of fabric setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The parameter value of fabric setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SettingsParameterDescription" /> instance.</summary>
        public SettingsParameterDescription()
        {

        }
    }
    /// Describes a parameter in fabric settings of the cluster.
    public partial interface ISettingsParameterDescription :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The parameter name of fabric setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The parameter name of fabric setting.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The parameter value of fabric setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The parameter value of fabric setting.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Describes a parameter in fabric settings of the cluster.
    internal partial interface ISettingsParameterDescriptionInternal

    {
        /// <summary>The parameter name of fabric setting.</summary>
        string Name { get; set; }
        /// <summary>The parameter value of fabric setting.</summary>
        string Value { get; set; }

    }
}