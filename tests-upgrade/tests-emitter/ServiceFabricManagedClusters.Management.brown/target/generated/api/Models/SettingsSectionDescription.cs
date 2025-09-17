// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a section in the fabric settings of the cluster.</summary>
    public partial class SettingsSectionDescription :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescriptionInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The section name of the fabric settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescription> _parameter;

        /// <summary>The collection of parameters in the section.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescription> Parameter { get => this._parameter; set => this._parameter = value; }

        /// <summary>Creates an new <see cref="SettingsSectionDescription" /> instance.</summary>
        public SettingsSectionDescription()
        {

        }
    }
    /// Describes a section in the fabric settings of the cluster.
    public partial interface ISettingsSectionDescription :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The section name of the fabric settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The section name of the fabric settings.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The collection of parameters in the section.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The collection of parameters in the section.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescription) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescription> Parameter { get; set; }

    }
    /// Describes a section in the fabric settings of the cluster.
    internal partial interface ISettingsSectionDescriptionInternal

    {
        /// <summary>The section name of the fabric settings.</summary>
        string Name { get; set; }
        /// <summary>The collection of parameters in the section.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsParameterDescription> Parameter { get; set; }

    }
}