// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The parameters for a PATCH request to a Integration Fabric resource.</summary>
    public partial class IntegrationFabricUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IntegrationFabricPropertiesUpdateParameters()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParameters _property;

        /// <summary>The new properties of this Integration Fabric resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IntegrationFabricPropertiesUpdateParameters()); set => this._property = value; }

        /// <summary>The new integration scenarios covered by this integration fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Scenario { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParametersInternal)Property).Scenario; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParametersInternal)Property).Scenario = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersTags _tag;

        /// <summary>The new tags of the Integration Fabric resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IntegrationFabricUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="IntegrationFabricUpdateParameters" /> instance.</summary>
        public IntegrationFabricUpdateParameters()
        {

        }
    }
    /// The parameters for a PATCH request to a Integration Fabric resource.
    public partial interface IIntegrationFabricUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The new integration scenarios covered by this integration fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The new integration scenarios covered by this integration fabric.",
        SerializedName = @"scenarios",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Scenario { get; set; }
        /// <summary>The new tags of the Integration Fabric resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The new tags of the Integration Fabric resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersTags Tag { get; set; }

    }
    /// The parameters for a PATCH request to a Integration Fabric resource.
    internal partial interface IIntegrationFabricUpdateParametersInternal

    {
        /// <summary>The new properties of this Integration Fabric resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParameters Property { get; set; }
        /// <summary>The new integration scenarios covered by this integration fabric.</summary>
        System.Collections.Generic.List<string> Scenario { get; set; }
        /// <summary>The new tags of the Integration Fabric resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricUpdateParametersTags Tag { get; set; }

    }
}