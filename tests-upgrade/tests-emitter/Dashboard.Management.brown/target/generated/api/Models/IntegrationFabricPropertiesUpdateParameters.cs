// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The new properties of this Integration Fabric resource</summary>
    public partial class IntegrationFabricPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricPropertiesUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Scenario" /> property.</summary>
        private System.Collections.Generic.List<string> _scenario;

        /// <summary>The new integration scenarios covered by this integration fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Scenario { get => this._scenario; set => this._scenario = value; }

        /// <summary>
        /// Creates an new <see cref="IntegrationFabricPropertiesUpdateParameters" /> instance.
        /// </summary>
        public IntegrationFabricPropertiesUpdateParameters()
        {

        }
    }
    /// The new properties of this Integration Fabric resource
    public partial interface IIntegrationFabricPropertiesUpdateParameters :
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

    }
    /// The new properties of this Integration Fabric resource
    internal partial interface IIntegrationFabricPropertiesUpdateParametersInternal

    {
        /// <summary>The new integration scenarios covered by this integration fabric.</summary>
        System.Collections.Generic.List<string> Scenario { get; set; }

    }
}