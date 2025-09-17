// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Extensions;

    public partial class ArcAgentryConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurations,
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsInternal
    {

        /// <summary>Backing field for <see cref="Feature" /> property.</summary>
        private string _feature;

        /// <summary>Specifies the name of the feature for the configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public string Feature { get => this._feature; set => this._feature = value; }

        /// <summary>Backing field for <see cref="ProtectedSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsProtectedSettings _protectedSetting;

        /// <summary>
        /// The configuration settings for the feature that contain any sensitive or secret information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsProtectedSettings ProtectedSetting { get => (this._protectedSetting = this._protectedSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ArcAgentryConfigurationsProtectedSettings()); set => this._protectedSetting = value; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsSettings _setting;

        /// <summary>
        /// The configuration settings for the feature that do not contain any sensitive or secret information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsSettings Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.ArcAgentryConfigurationsSettings()); set => this._setting = value; }

        /// <summary>Creates an new <see cref="ArcAgentryConfigurations" /> instance.</summary>
        public ArcAgentryConfigurations()
        {

        }
    }
    public partial interface IArcAgentryConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the name of the feature for the configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the feature for the configuration setting.",
        SerializedName = @"feature",
        PossibleTypes = new [] { typeof(string) })]
        string Feature { get; set; }
        /// <summary>
        /// The configuration settings for the feature that contain any sensitive or secret information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The configuration settings for the feature that contain any sensitive or secret information.",
        SerializedName = @"protectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsProtectedSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsProtectedSettings ProtectedSetting { get; set; }
        /// <summary>
        /// The configuration settings for the feature that do not contain any sensitive or secret information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The configuration settings for the feature that do not contain any sensitive or secret information.",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsSettings Setting { get; set; }

    }
    internal partial interface IArcAgentryConfigurationsInternal

    {
        /// <summary>Specifies the name of the feature for the configuration setting.</summary>
        string Feature { get; set; }
        /// <summary>
        /// The configuration settings for the feature that contain any sensitive or secret information.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsProtectedSettings ProtectedSetting { get; set; }
        /// <summary>
        /// The configuration settings for the feature that do not contain any sensitive or secret information.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridKubernetes.Models.IArcAgentryConfigurationsSettings Setting { get; set; }

    }
}